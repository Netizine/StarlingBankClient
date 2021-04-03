using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class SavingsGoalsV2
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("savingsGoalList")]
        public List<SavingsGoalV2> SavingsGoalList { get; set; }
    }
}
