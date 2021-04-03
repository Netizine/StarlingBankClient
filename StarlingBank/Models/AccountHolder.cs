using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Class AccountHolder.
    /// </summary>
    public class AccountHolder
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The account holder uid.</value>
        [JsonProperty("accountHolderUid")]
        public Guid? AccountHolderUid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The type of the account holder.</value>
        [JsonProperty("accountHolderType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public AccountHolderType? AccountHolderType { get; set; }
    }
}
