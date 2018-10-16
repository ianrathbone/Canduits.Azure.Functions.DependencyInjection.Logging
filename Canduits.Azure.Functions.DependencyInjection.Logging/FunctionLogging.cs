using Microsoft.Extensions.DependencyInjection;

namespace Canduits.Azure.Functions.DependencyInjection.Logging
{
    public static class FunctionLogging
    {
        public static IServiceCollection AddFunctionLogging(this IServiceCollection services)
        {
            services.AddSingleton<IFunctionLogger, FunctionLogger>();
            return services;
        }
    }
}