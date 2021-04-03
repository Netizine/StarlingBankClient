using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class SpendingCountrySummary
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("period")]
        public string Period { get; set; }

        /// <summary>
        /// Amount spent from the account in the month
        /// </summary>
        [JsonProperty("totalSpent")]
        public double? TotalSpent { get; set; }

        /// <summary>
        /// Amount received to the account in the month
        /// </summary>
        [JsonProperty("totalReceived")]
        public double? TotalReceived { get; set; }

        /// <summary>
        /// |totalReceived - totalSpent|, i.e. how much the balance has changed in the month
        /// </summary>
        [JsonProperty("netSpend")]
        public double? NetSpend { get; set; }

        /// <summary>
        /// Sum of netSpend for countries whose net direction for the month is OUT
        /// </summary>
        [JsonProperty("totalSpendNetOut")]
        public double? TotalSpendNetOut { get; set; }

        /// <summary>
        /// Sum of netSpend for countries whose net direction for the month is IN
        /// </summary>
        [JsonProperty("totalReceivedNetIn")]
        public double? TotalReceivedNetIn { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("currency", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Currency? Currency { get; set; }

        /// <summary>
        /// IN if totalReceived > totalSpent else OUT
        /// </summary>
        [JsonProperty("direction", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Direction? Direction { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("breakdown")]
        public List<SpendingCountryBreakdown> Breakdown { get; set; }
    }
}
