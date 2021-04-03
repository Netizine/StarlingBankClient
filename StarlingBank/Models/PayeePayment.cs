using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class PayeePayment
    {
        /// <summary>
        /// Unique identifier of the payment
        /// </summary>
        [JsonProperty("paymentUid")]
        public Guid? PaymentUid { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("amount")]
        public CurrencyAndAmount Amount { get; set; }

        /// <summary>
        /// Payment reference
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Date when payment was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Spending category
        /// </summary>
        [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SpendingCategory? SpendingCategory { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("paymentAmount")]
        public CurrencyAndAmount PaymentAmount { get; set; }
    }
}
