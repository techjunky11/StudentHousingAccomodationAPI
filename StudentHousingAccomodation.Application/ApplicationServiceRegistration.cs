﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace StudentHousingAccomodation.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}