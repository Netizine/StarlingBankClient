using System;
using Newtonsoft.Json;
using StarlingBank.Utilities;

namespace StarlingBank.Models
{
    /// <summary>
    /// Class AddressUpdateRequest.
    /// </summary>
    public class AddressUpdateRequest
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

        /// <summary>
        /// The UDPRN of the property
        /// </summary>
        /// <value>The udprn.</value>
        [JsonProperty("udprn")]
        public string Udprn { get; set; }

        /// <summary>
        /// The UMPRN of the property
        /// </summary>
        /// <value>The umprn.</value>
        [JsonProperty("umprn")]
        public string Umprn { get; set; }

        /// <summary>
        /// Date the account holder's residency at this address started
        /// </summary>
        /// <value>From.</value>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("from")]
        public DateTime From { get; set; }
    }
}
