using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssTracker.Presentation.Api
{
    public class IssTrackerResponse
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("iss_position")]
        public IssPosition IssPosition { get; set; }
    }
}
