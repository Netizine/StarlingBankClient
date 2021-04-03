using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class RoundUpGoalPayload
    {
        /// <summary>
        /// UID of the account category to send round-ups to
        /// </summary>
        [JsonProperty("roundUpGoalUid")]
        public Guid RoundUpGoalUid { get; set; }

        /// <summary>
        /// How much to multiply the rounded-up amount by before transfer. Must be an integer between 1 and 10 (inclusive)
        /// </summary>
        [JsonProperty("roundUpMultiplier")]
        public int RoundUpMultiplier { get; set; }
    }
}
