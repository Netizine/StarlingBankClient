using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class Money
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("currency", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Currency Currency { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }
    }
}
