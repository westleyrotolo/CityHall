using System;
using CityHall.Web.Services.Interfaces;

namespace CityHall.Web.Services.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {

            if (services is null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IOfficeService, OfficeService>();

            return services;
        }
    }
}

