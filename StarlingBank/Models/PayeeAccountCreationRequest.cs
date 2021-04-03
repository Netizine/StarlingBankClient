using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class PayeeAccountCreationRequest
    {
        /// <summary>
        /// Account description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Is this the default account for the owning payee
        /// </summary>
        [JsonProperty("defaultAccount")]
        public bool DefaultAccount { get; set; }

        /// <summary>
        /// The country code for the account (ISO 3166-1 alpha-2)
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The account identifier
        /// </summary>
        [JsonProperty("accountIdentifier")]
        public string AccountIdentifier { get; set; }

        /// <summary>
        /// The bank identifier
        /// </summary>
        [JsonProperty("bankIdentifier")]
        public string BankIdentifier { get; set; }

        /// <summary>
        /// The bank identifier type
        /// </summary>
        [JsonProperty("bankIdentifierType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public BankIdentifierType BankIdentifierType { get; set; }
    }
}
