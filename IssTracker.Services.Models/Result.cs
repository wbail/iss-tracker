namespace IssTracker.Services.Models
{
    public class Result
    {
        public Annotations Annotations { get; set; }
        public Bounds Bounds { get; set; }
        public Components Components { get; set; }
        public int Confidence { get; set; }
        public string Formatted { get; set; }
        public Geometry Geometry { get; set; }
    }
}
