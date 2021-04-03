using System;
using Newtonsoft.Json;
using StarlingBank.Utilities;

namespace StarlingBank.Models
{
    public class TermsAcceptance
    {
        /// <summary>
        /// The policy document which has been accepted
        /// </summary>
        [JsonProperty("policyDocument", ItemConverterType = typeof(StringValuedEnumConverter))]
        public PolicyDocument PolicyDocument { get; set; }

        /// <summary>
        /// The version of the policy document which has been accepted
        /// </summary>
        [JsonProperty("version")]
        public int Version { get; set; }

        /// <summary>
        /// Was policy document accepted
        /// </summary>
        [JsonProperty("termsAccepted")]
        public bool TermsAccepted { get; set; }

        /// <summary>
        /// Date on which the policy document was accepted
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("acceptanceDate")]
        public DateTime AcceptanceDate { get; set; }
    }
}
