using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class PaymentOrderPayment
    {
        /// <summary>
        /// UID of this payment
        /// </summary>
        [JsonProperty("paymentUid")]
        public Guid PaymentUid { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("amount")]
        public CurrencyAndAmount Amount { get; set; }

        /// <summary>
        /// Reference of this payment
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
        /// When this payment was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// When this payment was completed, if it completed
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("completedAt")]
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// When this payment was rejected, if it was rejected
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("rejectedAt")]
        public DateTime? RejectedAt { get; set; }

        /// <summary>
        /// Status details of a payment
        /// </summary>
        [JsonProperty("paymentStatusDetails")]
        public PaymentStatusDetails PaymentStatusDetails { get; set; }
    }
}
