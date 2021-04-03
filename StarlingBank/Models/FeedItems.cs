using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class FeedItems
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("feedItems")]
        public List<FeedItem> FeedItemsValue { get; set; }
    }
}
