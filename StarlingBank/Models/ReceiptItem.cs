using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class ReceiptItem
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("receiptItemUid")]
        public Guid? ReceiptItemUid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("tax")]
        public double Tax { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// The time the receipt item was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("creationTime")]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Type of receipt item. It can be PURCHASE, SERVICE_FEE, GRATUITY or null
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Type? Type { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("notes")]
        public List<string> Notes { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("subItems")]
        public List<ReceiptSubItem> SubItems { get; set; }
    }
}
