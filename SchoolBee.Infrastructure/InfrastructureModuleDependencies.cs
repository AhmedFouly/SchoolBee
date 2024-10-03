using Microsoft.Extensions.DependencyInjection;
using SchoolBee.Infrastructure.Contracts;
using SchoolBee.Infrastructure.Repositories;

namespace SchoolBee.Infrastructure
{
    public static class InfrastructureModuleDependencies
    {
        public static IServiceCollection AddInfrastructureModuleDependencies(this IServiceCollection services) 
        {
            services.AddTransient<IStudentRepository, StudentRepository>();

            return services;
        }
    }
}
