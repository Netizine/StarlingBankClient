using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class UpdateSpendingCategory
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SpendingCategory SpendingCategory { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("permanentSpendingCategoryUpdate")]
        public bool? PermanentSpendingCategoryUpdate { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("previousSpendingCategoryReferencesUpdate")]
        public bool? PreviousSpendingCategoryReferencesUpdate { get; set; }
    }
}
