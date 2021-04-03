using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class DirectDebitPaymentsResponse
    {
        /// <summary>
        /// List of processed direct debit mandate payments
        /// </summary>
        [JsonProperty("directDebitPayments")]
        public List<DirectDebitPayment> DirectDebitPayments { get; set; }
    }
}
