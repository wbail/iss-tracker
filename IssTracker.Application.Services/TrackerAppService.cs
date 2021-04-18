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

        public TrackerAppService(ILogger<TrackerAppService> logger, ITrackerService trackerService)
        {
            _logger = logger;
            _trackerService = trackerService;
        }

        public async Task<TrackerAppResponse> GetLocationAsync()
        {
            return await _trackerService.GetLocationAsync();
        }
    }
}
