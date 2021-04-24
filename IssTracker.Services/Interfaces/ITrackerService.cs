using IssTracker.App.Messages.Response;
using System.Threading.Tasks;

namespace IssTracker.Services.Interfaces
{
    public interface ITrackerService
    {
        Task<TrackerAppResponse> GetLocationAsync();
    }
}
