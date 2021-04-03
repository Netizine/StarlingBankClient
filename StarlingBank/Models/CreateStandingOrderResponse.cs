using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class CreateStandingOrderResponse
    {
        /// <summary>
        /// The uid of the payment order created by the standing order. N.B. this will not be the uid of any payment which is created by the standing order
        /// </summary>
        [JsonProperty("paymentOrderUid")]
        public Guid? PaymentOrderUid { get; set; }
    }
}
