using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class SpendingCounterPartyBreakdown
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("counterPartyUid")]
        public Guid? CounterPartyUid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("counterPartyType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public CounterPartyType? CounterPartyType { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("counterPartyName")]
        public string CounterPartyName { get; set; }

        /// <summary>
        /// Amount spent at/sent to this counter party
        /// </summary>
        [JsonProperty("totalSpent")]
        public double? TotalSpent { get; set; }

        /// <summary>
        /// Amount received from this counter party
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
