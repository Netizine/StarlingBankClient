using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class ReceiptPaymentMethod
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("paymentMethodUid")]
        public Guid? PaymentMethodUid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }
    }
}
