using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class RoundUpGoalDetails
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("primaryCategoryUid")]
        public Guid PrimaryCategoryUid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("roundUpGoalUid")]
        public Guid RoundUpGoalUid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("roundUpMultiplier")]
        public double RoundUpMultiplier { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("activatedAt")]
        public DateTime ActivatedAt { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("activatedBy")]
        public Guid ActivatedBy { get; set; }
    }
}
