using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class ReceiptNote
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("noteUid")]
        public Guid? NoteUid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
