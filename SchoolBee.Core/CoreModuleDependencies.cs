using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SchoolBee.Core
{
    public static class CoreModuleDependencies
    {
        public static IServiceCollection AddCoreModuleDependencies(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            return services;
        }
    }
}
