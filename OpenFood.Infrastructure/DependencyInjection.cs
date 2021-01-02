using Microsoft.Extensions.DependencyInjection;
using OpenFood.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFood.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {

            services.AddTransient<IOpenFoodService, OpenFoodService>();
      






            return services;
        }
    }
}
