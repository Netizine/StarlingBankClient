using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class InstructLocalPaymentResponse
    {
        /// <summary>
        /// The uid of the payment order created by the instruction. N.B. this will not be the uid of any payment which is created by the payment order
        /// </summary>
        [JsonProperty("paymentOrderUid")]
        public Guid? PaymentOrderUid { get; set; }
    }
}
