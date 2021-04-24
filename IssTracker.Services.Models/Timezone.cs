namespace IssTracker.Services.Models
{
    public class Timezone
    {
        public string Name { get; set; }
        public int Now_in_dst { get; set; }
        public int Offset_sec { get; set; }
        public string Offset_string { get; set; }
        public string Short_name { get; set; }
    }
}
