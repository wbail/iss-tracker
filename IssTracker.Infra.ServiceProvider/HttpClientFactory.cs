using IssTracker.Infra.ServiceProvider.Interfaces;
using System.Net.Http;

namespace IssTracker.Infra.ServiceProvider
{
    public class HttpClientFactory : IHttpClientFactory
    {
        public HttpClient HttpClient()
        {
            return new HttpClient();
        }
    }
}
