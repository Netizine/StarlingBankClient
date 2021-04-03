using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    /// <summary>
    /// Class AccountStatementPeriod.
    /// </summary>
    public class AccountStatementPeriod
    {
        /// <summary>
        /// The period for which the statement is available
        /// </summary>
        /// <value>The period.</value>
        [JsonProperty("period")]
        public string Period { get; set; }

        /// <summary>
        /// Is the statement for this period partial
        /// </summary>
        /// <value><c>true</c> if partial; otherwise, <c>false</c>.</value>
        [JsonProperty("partial")]
        public bool Partial { get; set; }

        /// <summary>
        /// End timestamp for the period
        /// </summary>
        /// <value>The ends at.</value>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("endsAt")]
        public DateTime? EndsAt { get; set; }
    }
}
