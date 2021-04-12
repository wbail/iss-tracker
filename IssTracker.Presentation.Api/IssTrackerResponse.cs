﻿using Newtonsoft.Json;
using System;

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

        [JsonProperty("executed_at")]
        public DateTime ExecutedAt { get; set; }
    }
}
