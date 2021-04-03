using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Class AddressV2.
    /// </summary>
    public class AddressV2
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The line1.</value>
        [JsonProperty("line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The line2.</value>
        [JsonProperty("line2")]
        public string Line2 { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The line3.</value>
        [JsonProperty("line3")]
        public string Line3 { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The post town.</value>
        [JsonProperty("postTown")]
        public string PostTown { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The post code.</value>
        [JsonProperty("postCode")]
        public string PostCode { get; set; }

        /// <summary>
        /// Country code in ISO 3166-1 alpha-2. NB GB is the official country code for the UK. UK is not the officially assigned code, and so is not valid
        /// </summary>
        /// <value>The country code.</value>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }
}
