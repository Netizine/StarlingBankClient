using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class UpdateStandingOrderResponse
    {
        /// <summary>
        /// The uid of the updated payment order created by the standing order. N.B. this will not be the uid of any payment which is created by the standing order. If the recurrence rule is updated, this payment order uid will be different from the original one
        /// </summary>
        [JsonProperty("paymentOrderUid")]
        public Guid? PaymentOrderUid { get; set; }
    }
}
