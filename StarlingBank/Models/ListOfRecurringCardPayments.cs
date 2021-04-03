using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class ListOfRecurringCardPayments
    {
        /// <summary>
        /// List of recurring card payments
        /// </summary>
        [JsonProperty("recurringPayments")]
        public List<RecurringCardPayment> RecurringPayments { get; set; }
    }
}
