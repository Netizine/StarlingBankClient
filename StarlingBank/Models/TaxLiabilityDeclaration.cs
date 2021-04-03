using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class TaxLiabilityDeclaration
    {
        /// <summary>
        /// Is the account holder liable for tax
        /// </summary>
        [JsonProperty("taxLiabilityDeclarationAnswer", ItemConverterType = typeof(StringValuedEnumConverter))]
        public TaxLiabilityDeclarationAnswer TaxLiabilityDeclarationAnswer { get; set; }

        /// <summary>
        /// Is the account holder liable for tax in the US
        /// </summary>
        [JsonProperty("usTaxLiabilityDeclarationAnswer", ItemConverterType = typeof(StringValuedEnumConverter))]
        public UsTaxLiabilityDeclarationAnswer UsTaxLiabilityDeclarationAnswer { get; set; }

        /// <summary>
        /// Countries in which account holder has tax liabilities
        /// </summary>
        [JsonProperty("taxLiabilityDeclarationCountries")]
        public List<TaxLiabilityDeclarationCountry> TaxLiabilityDeclarationCountries { get; set; }
    }
}
