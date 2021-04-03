using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using StarlingBank.Utilities;

namespace StarlingBank.Models
{
    public class OnboardingRequest
    {
        /// <summary>
        /// Account holder's mobile phone number
        /// </summary>
        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }

        /// <summary>
        /// Account holder's title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; } = "MRS, MISS, MS, LADY, MR, SIR";

        /// <summary>
        /// Account holder's first name
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Account holder's last name
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Account holder's date of birth
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("dateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The email address for the account holder
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Address submitted when onboarding
        /// </summary>
        [JsonProperty("currentAddress")]
        public OnboardingAddress CurrentAddress { get; set; }

        /// <summary>
        /// Account holder's previous address history, 6 month minimum
        /// </summary>
        [JsonProperty("previousAddresses")]
        public List<OnboardingAddress> PreviousAddresses { get; set; }

        /// <summary>
        /// Details of the account holder's income
        /// </summary>
        [JsonProperty("incomeDetails")]
        public IncomeDetails IncomeDetails { get; set; }

        /// <summary>
        /// Declaration of tax liabilities
        /// </summary>
        [JsonProperty("taxLiabilityDeclaration")]
        public TaxLiabilityDeclaration TaxLiabilityDeclaration { get; set; }

        /// <summary>
        /// Account holder's terms acceptance details
        /// </summary>
        [JsonProperty("termsAcceptance")]
        public List<TermsAcceptance> TermsAcceptance { get; set; }
    }
}
