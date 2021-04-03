using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class ScheduledSavingsPaymentRequestV2
    {
        /// <summary>
        /// The schedule definition
        /// </summary>
        [JsonProperty("recurrenceRule")]
        public RecurrenceRuleV2 RecurrenceRule { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("amount")]
        public CurrencyAndAmount Amount { get; set; }
    }
}
