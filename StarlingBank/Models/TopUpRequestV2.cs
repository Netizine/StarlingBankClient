using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class TopUpRequestV2
    {
        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("amount")]
        public CurrencyAndAmount Amount { get; set; }
    }
}
