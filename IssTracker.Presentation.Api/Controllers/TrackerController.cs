using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace IssTracker.Presentation.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrackerController : ControllerBase
    {
        private readonly ILogger<TrackerController> _logger;

        public TrackerController(ILogger<TrackerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IssTrackerResponse> GetAsync()
        {
            _logger.Log(LogLevel.Information, "Getting information from ISS");

            using(var httpClient = new HttpClient())
            {
                var issCurrentPositionRequest = await httpClient.GetAsync("http://api.open-notify.org/iss-now.json");

                var issCurrentPositionResult = issCurrentPositionRequest.Content.ReadAsStringAsync().Result;

                var response = JsonConvert.DeserializeObject<IssTrackerResponse>(issCurrentPositionResult);
                response.ExecutedAt = DateTimeOffset.FromUnixTimeSeconds(response.Timestamp).UtcDateTime;

                return response;
            }
        }
    }
}
