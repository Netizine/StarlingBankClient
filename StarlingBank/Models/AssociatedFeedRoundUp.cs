using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Class AssociatedFeedRoundUp.
    /// </summary>
    public class AssociatedFeedRoundUp
    {
        /// <summary>
        /// Unique identifier of associated category
        /// </summary>
        /// <value>The goal category uid.</value>
        [JsonProperty("goalCategoryUid")]
        public Guid? GoalCategoryUid { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        /// <value>The amount.</value>
        [JsonProperty("amount")]
        public CurrencyAndAmount Amount { get; set; }
    }
}
