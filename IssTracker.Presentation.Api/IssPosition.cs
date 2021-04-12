using Newtonsoft.Json;

namespace IssTracker.Presentation.Api
{
    public class IssPosition
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }
}
