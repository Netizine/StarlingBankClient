using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class MastercardFeedItem
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("merchantIdentifier")]
        public string MerchantIdentifier { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("mcc")]
        public int? Mcc { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("posTimestamp")]
        public LocalTime PosTimestamp { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("authorisationCode")]
        public string AuthorisationCode { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("cardLast4")]
        public string CardLast4 { get; set; }
    }
}
