using IssTracker.App.Messages.Response;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace IssTracker.Presentation.Api.Tests.Controllers
{
    public class TrackerControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _httpClient;

        public TrackerControllerTests(WebApplicationFactory<Startup> webApplicationFactory)
        {
            _httpClient = webApplicationFactory.CreateDefaultClient();
        }

        const string Endpoint = "/api/tracker";

        [Fact]
        public async Task GetResult_ReturnsSuccessStatusCode()
        {
            var response = await _httpClient.GetAsync(Endpoint);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetResult_ReturnsExpectedMediaType()
        {
            var response = await _httpClient.GetAsync(Endpoint);

            Assert.Equal("application/json", response.Content.Headers.ContentType.MediaType);
        }

        [Fact]
        public async Task GetResult_ReturnsContent()
        {
            var response = await _httpClient.GetAsync(Endpoint);

            Assert.NotNull(response.Content);
            Assert.True(response.Content.Headers.ContentLength > 0);
        }

        [Fact]
        public async Task GetResult_ReturnsExpectedJson()
        {
            var response = await _httpClient.GetFromJsonAsync<TrackerAppResponse>(Endpoint);

            Assert.NotNull(response?.MapAppResponse);
            Assert.True(response.MapAppResponse.Results.Count > 0);
        }
    }
}
