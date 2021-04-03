using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class ScheduledPayments
    {
        /// <summary>
        /// List of scheduled payments for a payee account
        /// </summary>
        [JsonProperty("scheduledPayments")]
        public List<ScheduledPayment> ScheduledPaymentsValue { get; set; }
    }
}
