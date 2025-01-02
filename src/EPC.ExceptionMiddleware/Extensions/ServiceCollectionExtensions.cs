using Hellang.Middleware.ProblemDetails;

namespace EPC.ExceptionMiddleware.Extensions
{
    public static class ServiceCollectionExtensions
    {
        // Only here to avoid namespace conflict for AddProblemDetails extension method
        /// <summary>
        /// Adds the required services for <see cref="ProblemDetailsExtensions.UseProblemDetails"/> to work correctly,
        /// using the specified <paramref name="configure"/> callback for configuration.
        /// </summary>
        /// <param name="services">The service collection to add the services to.</param>
        /// <param name="configure"></param>
        public static IServiceCollection AddProblemDetailsWithHellang(this IServiceCollection services, Action<Hellang.Middleware.ProblemDetails.ProblemDetailsOptions>? configure = null)
        {
            ProblemDetailsExtensions.AddProblemDetails(services, configure);

            return services;
        }
    }
}
