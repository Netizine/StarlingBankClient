using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class DirectDebitPayment
    {
        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("paymentAmount")]
        public CurrencyAndAmount PaymentAmount { get; set; }

        /// <summary>
        /// Date when direct debit payment was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }
    }
}
