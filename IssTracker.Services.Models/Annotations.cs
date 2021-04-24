namespace IssTracker.Services.Models
{
    public class Annotations
    {
        public Dms Dms { get; set; }
        public string Mgrs { get; set; }
        public string Maidenhead { get; set; }
        public Mercator Mercator { get; set; }
        public Osm Osm { get; set; }
        public UnM49 Un_m49 { get; set; }
        public int Callingcode { get; set; }
        public Currency Currency { get; set; }
        public string Flag { get; set; }
        public string Geohash { get; set; }
        public double Qibla { get; set; }
        public RoadInfo Roadinfo { get; set; }
        public Sun Sun { get; set; }
        public Timezone Timezone { get; set; }
        public What3Words What3words { get; set; }
    }
}
