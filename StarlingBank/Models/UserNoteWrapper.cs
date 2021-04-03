using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class UserNoteWrapper
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("userNote")]
        public string UserNote { get; set; }
    }
}
