using System.Net.Http;

namespace IssTracker.Infra.ServiceProvider.Interfaces
{
    public interface IHttpClientFactory
    {
        HttpClient HttpClient();
    }
}
