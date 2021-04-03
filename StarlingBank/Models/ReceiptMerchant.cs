using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class ReceiptMerchant
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("receiptMerchantUid")]
        public Guid? ReceiptMerchantUid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("orderCollectionNumber")]
        public string OrderCollectionNumber { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("taxNumber")]
        public string TaxNumber { get; set; }
    }
}
