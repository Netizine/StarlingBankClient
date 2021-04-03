using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class UpdateStandingOrderRequest
    {
        /// <summary>
        /// UID of this payment order
        /// </summary>
        [JsonProperty("paymentOrderUid")]
        public Guid PaymentOrderUid { get; set; }

        /// <summary>
        /// The payment reference
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("amount")]
        public CurrencyAndAmount Amount { get; set; }

        /// <summary>
        /// Recurrence rules of a standing order
        /// </summary>
        [JsonProperty("standingOrderRecurrence")]
        public StandingOrderRecurrence StandingOrderRecurrence { get; set; }

        /// <summary>
        /// Optional spending category to associate with this payment
        /// </summary>
        [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SpendingCategory? SpendingCategory { get; set; }
    }
}
