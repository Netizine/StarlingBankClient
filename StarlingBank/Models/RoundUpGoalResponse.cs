using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class RoundUpGoalResponse
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("roundUpGoal")]
        public RoundUpGoalDetails RoundUpGoal { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("roundUpGoalDetails")]
        public RoundUpGoalDetails RoundUpGoalDetails { get; set; }
    }
}
