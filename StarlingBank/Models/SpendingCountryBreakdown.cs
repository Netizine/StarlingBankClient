using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class SpendingCountryBreakdown
    {
        /// <summary>
        /// The country code for this spending insights entry (ISO 3166-1 alpha-2)
        /// </summary>
        [JsonProperty("countryCode", ItemConverterType = typeof(StringValuedEnumConverter))]
        public CountryCode? CountryCode { get; set; }

        /// <summary>
        /// Amount spent in/sent to this country
        /// </summary>
        [JsonProperty("totalSpent")]
        public double? TotalSpent { get; set; }

        /// <summary>
        /// Amount received from this country
        /// </summary>
        [JsonProperty("totalReceived")]
        public double? TotalReceived { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("netSpend")]
        public double? NetSpend { get; set; }

        /// <summary>
        /// IN if totalReceived > totalSpent else OUT
        /// </summary>
        [JsonProperty("netDirection", ItemConverterType = typeof(StringValuedEnumConverter))]
        public NetDirection? NetDirection { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("currency", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Currency? Currency { get; set; }

        /// <summary>
        /// Percentage that the netSpend makes up of the sum of the netSpends of breakdowns in the same period with the same netDirection
        /// </summary>
        [JsonProperty("percentage")]
        public double? Percentage { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("transactionCount")]
        public long? TransactionCount { get; set; }
    }
}
