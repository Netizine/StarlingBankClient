using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class Receipt
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("receiptUid")]
        public Guid? ReceiptUid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("feedItemUid")]
        public Guid? FeedItemUid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("metadataSource", ItemConverterType = typeof(StringValuedEnumConverter))]
        public MetadataSource MetadataSource { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("receiptIdentifier")]
        public string ReceiptIdentifier { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("totalAmount")]
        public double TotalAmount { get; set; }

        /// <summary>
        /// Receipt Merchant Information
        /// </summary>
        [JsonProperty("receiptMerchant")]
        public ReceiptMerchant ReceiptMerchant { get; set; }

        /// <summary>
        /// ISO-4217 3 character currency code
        /// </summary>
        [JsonProperty("currencyCode", ItemConverterType = typeof(StringValuedEnumConverter))]
        public CurrencyCode? CurrencyCode { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("items")]
        public List<ReceiptItem> Items { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("notes")]
        public List<ReceiptNote> Notes { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("taxDetails")]
        public List<ReceiptTaxDetail> TaxDetails { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("paymentMethods")]
        public List<ReceiptPaymentMethod> PaymentMethods { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("providerName")]
        public string ProviderName { get; set; }
    }
}
