using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class CurrencyAndAmount
    {
        /// <summary>
        /// ISO-4217 3 character currency code
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Amount in the minor units of the given currency; eg pence in GBP, cents in EUR
        /// </summary>
        [JsonProperty("minorUnits")]
        public long MinorUnits { get; set; }
    }
}
