using System.Collections.Generic;

namespace IssTracker.Services.Models
{
    public class Currency
    {
        public List<object> Alternate_symbols { get; set; }
        public string Decimal_mark { get; set; }
        public string Html_entity { get; set; }
        public string Iso_code { get; set; }
        public string Iso_numeric { get; set; }
        public string Name { get; set; }
        public int Smallest_denomination { get; set; }
        public string Subunit { get; set; }
        public int Subunit_to_unit { get; set; }
        public string Symbol { get; set; }
        public int Symbol_first { get; set; }
        public string Thousands_separator { get; set; }
    }
}
