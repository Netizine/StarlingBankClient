using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class DefaultWebhookPayloadModel
    {
        /// <summary>
        /// The content of the webhook (This example is for a mastercard transaction)
        /// </summary>
        [JsonProperty("content")]
        public ContentModel Content { get; set; }

        /// <summary>
        /// Timestamp of the event
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Unique identifier of the account holder
        /// </summary>
        [JsonProperty("accountHolderUid")]
        public Guid? AccountHolderUid { get; set; }

        /// <summary>
        /// Unique identifier of the webhook event
        /// </summary>
        [JsonProperty("webhookNotificationUid")]
        public Guid? WebhookNotificationUid { get; set; }

        /// <summary>
        /// The type of the event
        /// </summary>
        [JsonProperty("webhookType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public WebhookType? WebhookType { get; set; }
    }
}
