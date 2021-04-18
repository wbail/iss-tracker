using Newtonsoft.Json;

namespace IssTracker.Services.Models
{
    public class IssPosition
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }
}
