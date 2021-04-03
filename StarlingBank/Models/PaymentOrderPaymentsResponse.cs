using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class PaymentOrderPaymentsResponse
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payments")]
        public List<PaymentOrderPayment> Payments { get; set; }
    }
}
