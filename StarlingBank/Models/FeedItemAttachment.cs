using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class FeedItemAttachment
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("feedItemUid")]
        public Guid? FeedItemUid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("feedItemAttachmentUid")]
        public Guid? FeedItemAttachmentUid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("attachmentType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public AttachmentType? AttachmentType { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("feedItemAttachmentType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public FeedItemAttachmentType? FeedItemAttachmentType { get; set; }
    }
}
