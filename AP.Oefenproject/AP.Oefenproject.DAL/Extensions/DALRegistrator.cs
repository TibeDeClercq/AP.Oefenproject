using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using AP.Oefenproject.DAL.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AP.Oefenproject.DAL.Extensions
{
    public static class DALRegistrator
    {
        public static IServiceCollection RegisterContexts(this IServiceCollection services)
        {
            services.AddDbContext<OefenprojectContext>(options => options.UseSqlServer("name=ConnectionStrings:Oefenproject"));

            return services;
        }
    }
}
