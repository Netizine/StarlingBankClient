using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class SavingsGoalV2
    {
        /// <summary>
        /// Unique identifier of the savings goal
        /// </summary>
        [JsonProperty("savingsGoalUid")]
        public Guid? SavingsGoalUid { get; set; }

        /// <summary>
        /// Name of the savings goal
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("target")]
        public CurrencyAndAmount Target { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("totalSaved")]
        public CurrencyAndAmount TotalSaved { get; set; }

        /// <summary>
        /// Percentage of target currently deposited in the savings goal
        /// </summary>
        [JsonProperty("savedPercentage")]
        public int? SavedPercentage { get; set; }
    }
}
