using IssTracker.Infra.CrossCutting.DepencyInversion;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssTracker.Presentation.Api.Extensions
{
    internal static class DependencyInjectionConfiguration
    {
        public static IServiceCollection DependencyInjectionConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            DependencyInversionFactory.ConfigureDependencyInversion(services, configuration);
            return services;
        }
    }
}
