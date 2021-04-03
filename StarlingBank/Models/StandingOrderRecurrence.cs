using System;
using Newtonsoft.Json;
using StarlingBank.Utilities;

namespace StarlingBank.Models
{
    public class StandingOrderRecurrence
    {
        /// <summary>
        /// Date that the first standing order payment should be made
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Frequency of which payments should be made
        /// </summary>
        [JsonProperty("frequency", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Frequency Frequency { get; set; }

        /// <summary>
        /// Interval of specified frequency on which payments should be made
        /// </summary>
        [JsonProperty("interval")]
        public int? Interval { get; set; }

        /// <summary>
        /// Number of payments that should be made before standing order is stopped
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Date on which to stop standing order
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("untilDate")]
        public DateTime? UntilDate { get; set; }
    }
}
