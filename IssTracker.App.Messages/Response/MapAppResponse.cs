using IssTracker.Services.Models;
using System.Collections.Generic;

namespace IssTracker.App.Messages.Response
{
    public class MapAppResponse
    {
        public List<Result> Results { get; set; }
        public Status Status { get; set; }
    }
}
