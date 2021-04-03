using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class LocalTime
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("minute")]
        public int? Minute { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("second")]
        public int? Second { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("nano")]
        public int? Nano { get; set; }
    }
}
