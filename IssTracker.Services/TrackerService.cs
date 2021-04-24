using IssTracker.App.Messages.Response;
using IssTracker.Infra.ServiceProvider.AppSettingsConfiguration;
using IssTracker.Infra.ServiceProvider.Interfaces;
using IssTracker.Services.Interfaces;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace IssTracker.Services
{
    public class TrackerService : ITrackerService
    {
        private readonly HttpClient _httpClientFactory;
        private readonly IOptions<TrackApiConfiguration> _trackApiConfiguration;

        public TrackerService(IHttpClientFactory httpClientFactory, IOptions<TrackApiConfiguration> trackApiConfiguration)
        {
            _httpClientFactory = httpClientFactory.HttpClient();
            _trackApiConfiguration = trackApiConfiguration;
        }

        public async Task<TrackerAppResponse> GetLocationAsync()
        {
            _httpClientFactory.BaseAddress = new Uri(_trackApiConfiguration.Value.Url);

            var issCurrentPositionRequest = await _httpClientFactory.GetAsync(_trackApiConfiguration.Value.Uri);

            var issCurrentPositionResult = issCurrentPositionRequest.Content.ReadAsStringAsync().Result;

            var response = JsonConvert.DeserializeObject<TrackerAppResponse>(issCurrentPositionResult);
            response.ExecutedAt = DateTimeOffset.FromUnixTimeSeconds(response.Timestamp).UtcDateTime;

            return response;
        }
    }
}
