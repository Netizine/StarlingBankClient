using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    /// <summary>
    /// Class AccountV2.
    /// </summary>
    public class AccountV2
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The account uid.</value>
        [JsonProperty("accountUid")]
        public Guid? AccountUid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The type of the account.</value>
        [JsonProperty("accountType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public AccountType? AccountType { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The default category.</value>
        [JsonProperty("defaultCategory")]
        public Guid? DefaultCategory { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The currency.</value>
        [JsonProperty("currency", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Currency? Currency { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The created at.</value>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
