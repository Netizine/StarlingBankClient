using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class PaymentOrderV2
    {
        /// <summary>
        /// UID of this payment order
        /// </summary>
        [JsonProperty("paymentOrderUid")]
        public Guid PaymentOrderUid { get; set; }

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
        /// The ID of the payee receiving this payment
        /// </summary>
        [JsonProperty("payeeUid")]
        public Guid PayeeUid { get; set; }

        /// <summary>
        /// The account ID of the payee account receiving this payment
        /// </summary>
        [JsonProperty("payeeAccountUid")]
        public Guid PayeeAccountUid { get; set; }

        /// <summary>
        /// Spending category for the payment order
        /// </summary>
        [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SpendingCategory? SpendingCategory { get; set; }
    }
}
