using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class SoleTrader
    {
        /// <summary>
        /// Trading as name
        /// </summary>
        [JsonProperty("tradingAsName")]
        public string TradingAsName { get; set; }

        /// <summary>
        /// Business category
        /// </summary>
        [JsonProperty("businessCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public BusinessCategory? BusinessCategory { get; set; }

        /// <summary>
        /// Business subcategory
        /// </summary>
        [JsonProperty("businessSubCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public BusinessSubCategory? BusinessSubCategory { get; set; }
    }
}
