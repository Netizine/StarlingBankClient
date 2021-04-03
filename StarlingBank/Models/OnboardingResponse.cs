using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class OnboardingResponse
    {
        /// <summary>
        /// The unique identifier of the account holder which has been created
        /// </summary>
        [JsonProperty("accountHolderUid")]
        public Guid? AccountHolderUid { get; set; }

        /// <summary>
        /// Access token response
        /// </summary>
        [JsonProperty("accessToken")]
        public AccessToken AccessToken { get; set; }
    }
}
