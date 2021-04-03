using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using StarlingBank.Utilities;

namespace StarlingBank.Models
{
    public class Payee
    {
        /// <summary>
        /// The uid of this payee
        /// </summary>
        [JsonProperty("payeeUid")]
        public Guid? PayeeUid { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("payeeName")]
        public string PayeeName { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// INDIVIDUAL
        /// </summary>
        [JsonProperty("payeeType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public PayeeType? PayeeType { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Middle name
        /// </summary>
        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Business name
        /// </summary>
        [JsonProperty("businessName")]
        public string BusinessName { get; set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("dateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Accounts for this payee
        /// </summary>
        [JsonProperty("accounts")]
        public List<PayeeAccount> Accounts { get; set; }
    }
}
