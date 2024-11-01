using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AbbieGillespieA8.Data
{
    public class House
    {
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("zip_code")]
        public string ZipCode { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("time_on_market")]
        public int TimeOnMarket { get; set; }

        public override string ToString()
        {
            return $"House: {Address}, {City}, {State}, {ZipCode} - Listed at: ${Price} - On Market: {TimeOnMarket} Months";
        }
    }
}
