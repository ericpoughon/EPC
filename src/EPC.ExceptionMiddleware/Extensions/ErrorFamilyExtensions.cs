using EPC.Exceptions;
using System.Net;

namespace EPC.ExceptionMiddleware.Extensions
{
    public static class ErrorFamilyExtensions
    {
        public static HttpStatusCode ToHttpStatusCode(this ErrorFamily errorFamily)
        {
            return errorFamily switch
            {
                ErrorFamily.Business => HttpStatusCode.UnprocessableEntity,
                ErrorFamily.NotFound => HttpStatusCode.NotFound,
                _ => HttpStatusCode.InternalServerError,
            };
        }
    }
}