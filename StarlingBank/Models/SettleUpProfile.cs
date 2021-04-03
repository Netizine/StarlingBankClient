using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class SettleUpProfile
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Status Status { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("starlingPayLink")]
        public string StarlingPayLink { get; set; }

        /// <summary>
        /// Settle Up link
        /// </summary>
        [JsonProperty("settleUpLink")]
        public string SettleUpLink { get; set; }
    }
}
