using Microsoft.Extensions.DependencyInjection;
using SchoolBee.Service.Contracts;
using SchoolBee.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBee.Service
{
    public static class ServiceModuleDependencies
    {
        public static IServiceCollection AddServiceModuleDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            return services;
        }
    }
}
