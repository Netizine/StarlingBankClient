using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Class Business.
    /// </summary>
    public class Business
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The name of the company.</value>
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The type of the company.</value>
        [JsonProperty("companyType")]
        public string CompanyType { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The company category.</value>
        [JsonProperty("companyCategory")]
        public string CompanyCategory { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The company sub category.</value>
        [JsonProperty("companySubCategory")]
        public string CompanySubCategory { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The company registration number.</value>
        [JsonProperty("companyRegistrationNumber")]
        public string CompanyRegistrationNumber { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The email.</value>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The phone.</value>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
