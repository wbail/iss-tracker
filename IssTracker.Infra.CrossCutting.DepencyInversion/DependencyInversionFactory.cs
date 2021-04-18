using IssTracker.Infra.ServiceProvider.AppSettingsConfiguration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IssTracker.Infra.CrossCutting.DepencyInversion
{
    public static class DependencyInversionFactory
    {
        public static void ConfigureDependencyInversion(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MapApiConfiguration>(options => configuration.GetSection("MapApiConfiguration").Bind(options));
        }
    }
}
