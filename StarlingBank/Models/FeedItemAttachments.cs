using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class FeedItemAttachments
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("feedItemAttachments")]
        public List<FeedItemAttachment> FeedItemAttachmentsValue { get; set; }
    }
}
