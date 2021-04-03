using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class ReceiptSubItem
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("receiptSubItemUid")]
        public Guid? ReceiptSubItemUid { get; set; }

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
        public double? Amount { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("notes")]
        public List<string> Notes { get; set; }
    }
}
