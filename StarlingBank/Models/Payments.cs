using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class Payments
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payments")]
        public List<PayeePayment> PaymentsValue { get; set; }
    }
}
