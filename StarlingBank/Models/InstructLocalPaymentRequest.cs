using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class InstructLocalPaymentRequest
    {
        /// <summary>
        /// External identifier for the payment request
        /// </summary>
        [JsonProperty("externalIdentifier")]
        public string ExternalIdentifier { get; set; }

        /// <summary>
        /// Desired payment recipient. Either paymentRecipient or destinationPayeeAccountUid must be present
        /// </summary>
        [JsonProperty("destinationPayeeAccountUid")]
        public Guid? DestinationPayeeAccountUid { get; set; }

        /// <summary>
        /// Desired payment recipient. Either paymentRecipient or destinationPayeeAccountUid must be present
        /// </summary>
        [JsonProperty("paymentRecipient")]
        public PaymentRecipient PaymentRecipient { get; set; }

        /// <summary>
        /// The payment reference. The 35 character limit applies to SEPA payments (Euro accounts). For FPS payments (GBP accounts), the limit is 18 characters
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("amount")]
        public CurrencyAndAmount Amount { get; set; }

        /// <summary>
        /// Optional spending category to associate with this payment
        /// </summary>
        [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SpendingCategory? SpendingCategory { get; set; }
    }
}
