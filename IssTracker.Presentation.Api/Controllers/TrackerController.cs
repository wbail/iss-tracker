using IssTracker.App.Messages.Response;
using IssTracker.App.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IssTracker.Presentation.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrackerController : ControllerBase
    {
        private readonly ITrackerAppService _trackerAppService;

        public TrackerController(ITrackerAppService trackerAppService)
        {
            _trackerAppService = trackerAppService;
        }

        [HttpGet]
        public async Task<TrackerAppResponse> Get()
        {
            return await _trackerAppService.GetLocationAsync();
        }
    }
}
