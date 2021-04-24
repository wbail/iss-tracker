using IssTracker.App.Messages.Response;
using System.Threading.Tasks;

namespace IssTracker.Services.Interfaces
{
    public interface IMapService
    {
        Task<MapAppResponse> GetLocationAsync(string latitude, string longitude);
    }
}
