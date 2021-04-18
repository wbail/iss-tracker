namespace IssTracker.App.Messages.Request
{
    public class MapAppRequest
    {
        public MapAppRequest(string latitude, string longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
