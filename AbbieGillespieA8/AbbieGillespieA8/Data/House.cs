using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AbbieGillespieA8.Data
{
    /// <summary>
    /// Creates a house object from the data from the json file.
    /// </summary>
    public class House
    {
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        [JsonPropertyName("address")]
        public required string Address { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        [JsonPropertyName("city")]
        public required string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        [JsonPropertyName("state")]
        public required string State { get; set; }

        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        [JsonPropertyName("zip_code")]
        public required string ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the time on market.
        /// </summary>
        [JsonPropertyName("time_on_market")]
        public int TimeOnMarket { get; set; }

        /// <summary>
        /// Converts the data into string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"House: {Address}, {City}, {State}, {ZipCode} - Listed at: ${Price} - On Market: {TimeOnMarket} Months";
        }
    }
}
