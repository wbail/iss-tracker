using IssTracker.App.Services.Interfaces;
using IssTracker.Application.Services;
using IssTracker.Infra.ServiceProvider;
using IssTracker.Infra.ServiceProvider.AppSettingsConfiguration;
using IssTracker.Infra.ServiceProvider.Interfaces;
using IssTracker.Services;
using IssTracker.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IssTracker.Infra.CrossCutting.DepencyInversion
{
    public static class DependencyInversionFactory
    {
        public static void ConfigureDependencyInversion(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MapApiConfiguration>(options => configuration.GetSection("MapApiConfiguration").Bind(options));
            services.Configure<TrackApiConfiguration>(options => configuration.GetSection("TrackApiConfiguration").Bind(options));
            services.AddScoped<ITrackerAppService, TrackerAppService>();
            services.AddScoped<ITrackerService, TrackerService>();
            services.AddScoped<IHttpClientFactory, HttpClientFactory>();
        }
    }
}
