using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using AP.Oefenproject.BLL.Interfaces;
using AP.Oefenproject.BLL.Services;

namespace AP.Oefenproject.BLL.Extensions
{
    public static class ServiceRegistrator
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ICircuitService, CircuitService>();
            //for all services
            return services;
        }
    }
}
