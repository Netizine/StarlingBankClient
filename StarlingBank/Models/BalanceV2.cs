using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Class BalanceV2.
    /// </summary>
    public class BalanceV2
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The cleared balance.</value>
        [JsonProperty("clearedBalance")]
        public SignedCurrencyAndAmount ClearedBalance { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The effective balance.</value>
        [JsonProperty("effectiveBalance")]
        public SignedCurrencyAndAmount EffectiveBalance { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The pending transactions.</value>
        [JsonProperty("pendingTransactions")]
        public SignedCurrencyAndAmount PendingTransactions { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The accepted overdraft.</value>
        [JsonProperty("acceptedOverdraft")]
        public SignedCurrencyAndAmount AcceptedOverdraft { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The amount.</value>
        [JsonProperty("amount")]
        public SignedCurrencyAndAmount Amount { get; set; }
    }
}
