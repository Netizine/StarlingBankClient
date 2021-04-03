using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class ReceiptTaxDetail
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("receiptTaxDetailUid")]
        public Guid? ReceiptTaxDetailUid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("taxName")]
        public string TaxName { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("taxValue")]
        public double TaxValue { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("taxCurrencyCode", ItemConverterType = typeof(StringValuedEnumConverter))]
        public TaxCurrencyCode TaxCurrencyCode { get; set; }

        /// <summary>
        /// The time the tax detail was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("creationTime")]
        public DateTime? CreationTime { get; set; }
    }
}
