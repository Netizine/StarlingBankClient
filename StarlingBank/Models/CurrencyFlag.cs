using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class CurrencyFlag
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
