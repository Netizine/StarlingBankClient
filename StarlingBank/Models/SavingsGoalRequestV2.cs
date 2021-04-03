using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class SavingsGoalRequestV2
    {
        /// <summary>
        /// Name of the savings goal
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// ISO-4217 3 character currency code of the savings goal
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("target")]
        public CurrencyAndAmount Target { get; set; }

        /// <summary>
        /// A text (base 64) encoded picture to associate with the savings goal
        /// </summary>
        [JsonProperty("base64EncodedPhoto")]
        public string Base64EncodedPhoto { get; set; }
    }
}
