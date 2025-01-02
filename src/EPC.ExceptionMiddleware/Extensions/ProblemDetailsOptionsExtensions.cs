using EPC.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace EPC.ExceptionMiddleware.Extensions
{
    public static class ProblemDetailsOptionsExtensions
    {
        /// <summary>
        /// Maps the specified exception type <see cref="BaseException"/> to a <see cref="ProblemDetails"/> instance.
        /// </summary>
        /// <param name="options"></param>
        public static void MapBaseExceptions(this Hellang.Middleware.ProblemDetails.ProblemDetailsOptions options)
        {
            options.Map<BaseException>(baseException =>
            {
                var statusCode = (int)baseException.ErrorFamily.ToHttpStatusCode();

                var problemDetails = new ProblemDetails
                {
                    Status = statusCode,
                    Type = baseException.DocumentationUri?.AbsolutePath ?? baseException.GetType().Name,
                    Title = baseException.ErrorCode,
                    Detail = baseException.Message
                };

                foreach (DictionaryEntry entry in baseException.Data)
                {
                    var key = entry.Key?.ToString();

                    if (key is null)
                    {
                        continue;
                    }

                    problemDetails.Extensions[key] = entry.Value;
                }

                return problemDetails;
            });
        }

        /// <summary>
        /// In production, hide any information related to HTTP 500 errors, except for the trace ID.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="onBeforeWriteDetail">Gets or sets a callback used to transform a problem details instance right before it is written to the response.</param>
        public static void OnBeforeWriteDetailsObfuscateAnyHttp500ErrorDetailsInProduction(this Hellang.Middleware.ProblemDetails.ProblemDetailsOptions options, Action<HttpContext, ProblemDetails>? onBeforeWriteDetail = null)
        {
            const string TraceIdKey = "traceId";

            options.OnBeforeWriteDetails = (httpContext, problemDetails) =>
            {
                if (problemDetails.Status is StatusCodes.Status500InternalServerError)
                {
                    var environment = httpContext.RequestServices.GetService<IWebHostEnvironment>();

                    if (environment?.IsProduction() is true)
                    {
                        problemDetails.Type = null;
                        problemDetails.Title = "Internal Server Error";
                        problemDetails.Detail = null;

                        problemDetails.Extensions.TryGetValue(TraceIdKey, out object? traceId);
                        problemDetails.Extensions.Clear();

                        if (traceId is not null)
                        {
                            problemDetails.Extensions[TraceIdKey] = traceId;
                        }
                    }
                }

                onBeforeWriteDetail?.Invoke(httpContext, problemDetails);
            };
        }
    }
}