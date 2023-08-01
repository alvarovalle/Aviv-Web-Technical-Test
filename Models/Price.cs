using System;
using Newtonsoft.Json;

namespace listingapi.Models
{
    public partial class Price
    {
        /// <summary>A price, expressed in euros.</summary>
        [JsonProperty("price_eur")]
        public double PriceEur { get; set; }
        [JsonProperty("date_created")]
        public DateTime DateCreated { get; set; }
  
    }
}
