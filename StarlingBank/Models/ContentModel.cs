using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Class ContentModel.
    /// </summary>
    public class ContentModel
    {
        /// <summary>
        /// The webhook type
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("type", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Type? Type { get; set; }

        /// <summary>
        /// The transaction amount
        /// </summary>
        /// <value>The amount.</value>
        [JsonProperty("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// The unique identifier of the merchant
        /// </summary>
        /// <value>The merchant uid.</value>
        [JsonProperty("merchantUid")]
        public Guid? MerchantUid { get; set; }

        /// <summary>
        /// The currency charged at the point of sale
        /// </summary>
        /// <value>The source currency.</value>
        [JsonProperty("sourceCurrency")]
        public string SourceCurrency { get; set; }

        /// <summary>
        /// A basic textual description of the event
        /// </summary>
        /// <value>For customer.</value>
        [JsonProperty("forCustomer")]
        public string ForCustomer { get; set; }

        /// <summary>
        /// The counterparty name
        /// </summary>
        /// <value>The counter party.</value>
        [JsonProperty("counterParty")]
        public string CounterParty { get; set; }

        /// <summary>
        /// The unique identifier of the transaction
        /// </summary>
        /// <value>The transaction uid.</value>
        [JsonProperty("transactionUid")]
        public Guid? TransactionUid { get; set; }

        /// <summary>
        /// The unique identifier of the merchant location
        /// </summary>
        /// <value>The merchant location uid.</value>
        [JsonProperty("merchantLocationUid")]
        public Guid? MerchantLocationUid { get; set; }
    }
}
