using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class WithdrawalRequestV2
    {
        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("amount")]
        public CurrencyAndAmount Amount { get; set; }
    }
}
