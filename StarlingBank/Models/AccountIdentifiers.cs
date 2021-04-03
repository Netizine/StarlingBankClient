using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Class AccountIdentifiers.
    /// </summary>
    public class AccountIdentifiers
    {
        /// <summary>
        /// Identifier to uniquely identify the account at the bank
        /// </summary>
        /// <value>The account identifier.</value>
        [JsonProperty("accountIdentifier")]
        public string AccountIdentifier { get; set; }

        /// <summary>
        /// Identifier to uniquely identify the bank
        /// </summary>
        /// <value>The bank identifier.</value>
        [JsonProperty("bankIdentifier")]
        public string BankIdentifier { get; set; }

        /// <summary>
        /// International identifier to uniquely identify the account at the bank
        /// </summary>
        /// <value>The iban.</value>
        [JsonProperty("iban")]
        public string Iban { get; set; }

        /// <summary>
        /// International identifier to uniquely identify the bank
        /// </summary>
        /// <value>The bic.</value>
        [JsonProperty("bic")]
        public string Bic { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The account identifiers value.</value>
        [JsonProperty("accountIdentifiers")]
        public List<AccountIdentifier> AccountIdentifiersValue { get; set; }
    }
}
