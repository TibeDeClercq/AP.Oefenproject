using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using AP.Oefenproject.DAL.Contexts;
using AP.Oefenproject.DAL.Repositories;
using AP.Oefenproject.DAL.UOW;

namespace AP.Oefenproject.DAL.Extensions
{
    public static class DALRegistrator
    {
        public static IServiceCollection RegisterDataAccessServices(this IServiceCollection services)
        {
            services.RegisterContexts();
            services.RegisterRepositories();
            services.RegisterUnitsOfWork();

            return services;
        }

        private static IServiceCollection RegisterContexts(this IServiceCollection services)
        {
            services.AddDbContext<OefenprojectContext>(options => options.UseSqlServer("name=ConnectionStrings:Oefenproject"));

            return services;
        }

        private static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICircuitRepository, CircuitRepository>();
            //...

            return services;
        }

        private static IServiceCollection RegisterUnitsOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
