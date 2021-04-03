using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class PaymentRecipient
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payeeName")]
        public string PayeeName { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payeeType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public PayeeType PayeeType { get; set; }

        /// <summary>
        /// The country code for the account (ISO 3166-1 alpha-2)
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("accountIdentifier")]
        public string AccountIdentifier { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("bankIdentifier")]
        public string BankIdentifier { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("bankIdentifierType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public BankIdentifierType BankIdentifierType { get; set; }
    }
}
