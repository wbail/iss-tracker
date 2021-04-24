using Newtonsoft.Json;

namespace IssTracker.Services.Models
{
    public class Components
    {
        [JsonProperty("ISO_3166-1_alpha-2")]
        public string Iso31661alpha2 { get; set; }

        [JsonProperty("ISO_3166-1_alpha-3")]
        public string Iso31661alpha3 { get; set; }
        public string _category { get; set; }
        public string _type { get; set; }
        public string City { get; set; }
        public string City_district { get; set; }
        public string Continent { get; set; }
        public string Country { get; set; }
        public string Country_code { get; set; }
        public string House_number { get; set; }
        public string Neighbourhood { get; set; }
        public string Political_union { get; set; }
        public string Postcode { get; set; }
        public string Road { get; set; }
        public string State { get; set; }
        public string State_code { get; set; }
        public string Suburb { get; set; }
    }
}
