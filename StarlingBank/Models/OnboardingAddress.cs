using System;
using Newtonsoft.Json;
using StarlingBank.Utilities;

namespace StarlingBank.Models
{
    public class OnboardingAddress
    {
        /// <summary>
        /// First line
        /// </summary>
        [JsonProperty("line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// Second line
        /// </summary>
        [JsonProperty("line2")]
        public string Line2 { get; set; }

        /// <summary>
        /// Third line
        /// </summary>
        [JsonProperty("line3")]
        public string Line3 { get; set; }

        /// <summary>
        /// PAF field of same name
        /// </summary>
        [JsonProperty("subBuildingName")]
        public string SubBuildingName { get; set; }

        /// <summary>
        /// PAF field of same name
        /// </summary>
        [JsonProperty("buildingName")]
        public string BuildingName { get; set; }

        /// <summary>
        /// PAF field of same name
        /// </summary>
        [JsonProperty("buildingNumber")]
        public string BuildingNumber { get; set; }

        /// <summary>
        /// PAF field of same name
        /// </summary>
        [JsonProperty("thoroughfare")]
        public string Thoroughfare { get; set; }

        /// <summary>
        /// PAF field of same name
        /// </summary>
        [JsonProperty("dependantLocality")]
        public string DependantLocality { get; set; }

        /// <summary>
        /// Post town
        /// </summary>
        [JsonProperty("postTown")]
        public string PostTown { get; set; }

        /// <summary>
        /// Post code
        /// </summary>
        [JsonProperty("postCode")]
        public string PostCode { get; set; }

        /// <summary>
        /// Country code in ISO 3166-1 alpha-2. NB GB is the official country code for the UK. UK is not the officially assigned code, and so is not valid
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The udprn of the property.
        /// </summary>
        [JsonProperty("udprn")]
        public string Udprn { get; set; }

        /// <summary>
        /// The umprn of the property
        /// </summary>
        [JsonProperty("umprn")]
        public string Umprn { get; set; }

        /// <summary>
        /// Date the account holder's residency at this address started
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("from")]
        public DateTime From { get; set; }

        /// <summary>
        /// Date the account holder's residency at this address completed
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("to")]
        public DateTime? To { get; set; }
    }
}
