using IssTracker.App.Messages.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;

namespace IssTracker.Presentation.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MapController : ControllerBase
    {
        private readonly ILogger<MapController> _logger;

        public MapController(ILogger<MapController> logger)
        {
            _logger = logger;
        }

        [HttpGet("location")]
        public async Task<string> GetLocation(MapAppRequest mapRequest)
        {
            using(var httpClient = new HttpClient())
            {
                var lat = "32.0518";
                var lng = "117.3842";
                var apiKey = "";

                _logger.Log(LogLevel.Information, "Getting information from Map API");

                var url = $"https://api.opencagedata.com/geocode/v1/json?key={apiKey}&q={lat}%2C{lng}&pretty=1";

                var test = await httpClient.GetAsync(url);
                
                return test.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
