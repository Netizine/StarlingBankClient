using System;
using Newtonsoft.Json;
using StarlingBank.Utilities;

namespace StarlingBank.Models
{
    public class ScheduledPayment
    {
        /// <summary>
        /// Unique identifier for account holder
        /// </summary>
        [JsonProperty("accountHolderUid")]
        public Guid? AccountHolderUid { get; set; }

        /// <summary>
        /// Unique identifier of the scheduled payment order
        /// </summary>
        [JsonProperty("paymentOrderUid")]
        public Guid? PaymentOrderUid { get; set; }

        /// <summary>
        /// Unique identifier of the category from which the payment will be taken
        /// </summary>
        [JsonProperty("categoryUid")]
        public Guid? CategoryUid { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("nextPaymentAmount")]
        public CurrencyAndAmount NextPaymentAmount { get; set; }

        /// <summary>
        /// Payment order reference
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Unique identifier of the payee
        /// </summary>
        [JsonProperty("payeeUid")]
        public Guid? PayeeUid { get; set; }

        /// <summary>
        /// Unique identifier of the payee account
        /// </summary>
        [JsonProperty("payeeAccountUid")]
        public Guid? PayeeAccountUid { get; set; }

        /// <summary>
        /// Recipient name
        /// </summary>
        [JsonProperty("recipientName")]
        public string RecipientName { get; set; }

        /// <summary>
        /// How often is the payment made
        /// </summary>
        [JsonProperty("recurrenceRule")]
        public RecurrenceRule RecurrenceRule { get; set; }

        /// <summary>
        /// Date when the payment order has been created
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Date of the next payment order
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("nextDate")]
        public DateTime? NextDate { get; set; }

        /// <summary>
        /// Date when payment order ends
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Payment type
        /// </summary>
        [JsonProperty("paymentType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public PaymentType? PaymentType { get; set; }

        /// <summary>
        /// Spending category
        /// </summary>
        [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SpendingCategory? SpendingCategory { get; set; }
    }
}
