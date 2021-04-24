using IssTracker.App.Messages.Response;
using IssTracker.App.Services.Interfaces;
using IssTracker.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace IssTracker.Application.Services
{
    public class TrackerAppService : ITrackerAppService
    {
        private readonly ILogger<TrackerAppService> _logger;
        private readonly ITrackerService _trackerService;
        private readonly IMapService _mapService;

        public TrackerAppService(ILogger<TrackerAppService> logger, ITrackerService trackerService, IMapService mapService)
        {
            _logger = logger;
            _trackerService = trackerService;
            _mapService = mapService;
        }

        public async Task<TrackerAppResponse> GetLocationAsync()
        {
            var result = await _trackerService.GetLocationAsync();

            result.MapAppResponse = await _mapService.GetLocationAsync(result.IssPosition.Latitude, result.IssPosition.Longitude);

            return result;
        }
    }
}
