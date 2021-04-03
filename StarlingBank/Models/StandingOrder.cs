using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using StarlingBank.Utilities;

namespace StarlingBank.Models
{
    public class StandingOrder
    {
        /// <summary>
        /// UID of this payment order
        /// </summary>
        [JsonProperty("paymentOrderUid")]
        public Guid? PaymentOrderUid { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("amount")]
        public CurrencyAndAmount Amount { get; set; }

        /// <summary>
        /// The reference set by the payer
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The ID of the payee receiving the payments
        /// </summary>
        [JsonProperty("payeeUid")]
        public Guid? PayeeUid { get; set; }

        /// <summary>
        /// The account ID of the payee account receiving the payments
        /// </summary>
        [JsonProperty("payeeAccountUid")]
        public Guid? PayeeAccountUid { get; set; }

        /// <summary>
        /// Recurrence rules of a standing order
        /// </summary>
        [JsonProperty("standingOrderRecurrence")]
        public StandingOrderRecurrence StandingOrderRecurrence { get; set; }

        /// <summary>
        /// Date on which the next standing order payment will be made
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("nextDate")]
        public DateTime? NextDate { get; set; }

        /// <summary>
        /// The time the standing order is cancelled at
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("cancelledAt")]
        public DateTime? CancelledAt { get; set; }

        /// <summary>
        /// The time the standing order is updated at
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Optional spending category for the standing order
        /// </summary>
        [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SpendingCategory? SpendingCategory { get; set; }
    }
}
