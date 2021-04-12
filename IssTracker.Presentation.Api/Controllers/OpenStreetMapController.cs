using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IssTracker.Presentation.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OpenStreetMapController : ControllerBase
    {
        private readonly ILogger<OpenStreetMapController> _logger;

        public OpenStreetMapController(ILogger<OpenStreetMapController> logger)
        {
            _logger = logger;
        }

        [HttpGet("user")]
        public async Task GetUser()
        {
            _logger.Log(LogLevel.Information, "Getting user");

            using(var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://master.apis.dev.openstreetmap.org");

                var request = new HttpRequestMessage(HttpMethod.Get, "/api/0.6/user/");

                var byteArray = new UTF8Encoding().GetBytes(":");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                var response = await httpClient.SendAsync(request);

            }
        }
    }
}
