using IssTracker.App.Messages.Response;
using System.Threading.Tasks;

namespace IssTracker.App.Services.Interfaces
{
    public interface ITrackerAppService
    {
        Task<TrackerAppResponse> GetLocationAsync();
    }
}
