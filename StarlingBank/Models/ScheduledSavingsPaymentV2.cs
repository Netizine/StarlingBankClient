using System;
using Newtonsoft.Json;
using StarlingBank.Utilities;

namespace StarlingBank.Models
{
    public class ScheduledSavingsPaymentV2
    {
        /// <summary>
        /// Unique identifier of the transfer
        /// </summary>
        [JsonProperty("transferUid")]
        public Guid TransferUid { get; set; }

        /// <summary>
        /// The schedule definition
        /// </summary>
        [JsonProperty("recurrenceRule")]
        public RecurrenceRuleV2 RecurrenceRule { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("currencyAndAmount")]
        public CurrencyAndAmount CurrencyAndAmount { get; set; }

        /// <summary>
        /// The next date the payment will be made on
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("nextPaymentDate")]
        public DateTime NextPaymentDate { get; set; }
    }
}
