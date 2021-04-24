using IssTracker.App.Messages.Response;
using IssTracker.Infra.ServiceProvider.AppSettingsConfiguration;
using IssTracker.Infra.ServiceProvider.Interfaces;
using IssTracker.Services.Interfaces;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace IssTracker.Services
{
    public class MapService : IMapService
    {
        private readonly HttpClient _httpClientFactory;
        private readonly IOptions<MapApiConfiguration> _mapApiConfiguration;

        public MapService(IHttpClientFactory httpClientFactory, IOptions<MapApiConfiguration> mapApiConfiguration)
        {
            _httpClientFactory = httpClientFactory.HttpClient();
            _mapApiConfiguration = mapApiConfiguration;
        }

        public async Task<MapAppResponse> GetLocationAsync(string latitude, string longitude)
        {
            _httpClientFactory.BaseAddress = new Uri(_mapApiConfiguration.Value.Url);
            _httpClientFactory.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var issCurrentPositionRequest = await _httpClientFactory.GetAsync(_mapApiConfiguration.Value.Uri + $"?key={ _mapApiConfiguration.Value.Key}&q={latitude}%2C{longitude}&pretty=1");

            var issCurrentPositionResult = issCurrentPositionRequest.Content.ReadAsStringAsync().Result;

            var response = JsonConvert.DeserializeObject<MapAppResponse>(issCurrentPositionResult);

            return response;
        }
    }
}
