using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class TaxLiabilityDeclarationCountry
    {
        /// <summary>
        /// Country code in ISO 3166-1 alpha-2. NB GB is the official country code for the UK. UK is not the officially assigned code, and so is not valid
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Tax identification number
        /// </summary>
        [JsonProperty("taxIdentificationNumber")]
        public string TaxIdentificationNumber { get; set; }
    }
}
