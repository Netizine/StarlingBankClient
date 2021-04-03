using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class ReceiptCreationResponse
    {
        /// <summary>
        /// The UUID of the created receipt. This UUID could be used for updating the receipt at a later point.
        /// </summary>
        [JsonProperty("receiptUid")]
        public Guid? ReceiptUid { get; set; }
    }
}
