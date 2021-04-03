using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class OnboardingStatus
    {
        /// <summary>
        /// The current stage of onboarding
        /// </summary>
        [JsonProperty("onboardingStage", ItemConverterType = typeof(StringValuedEnumConverter))]
        public OnboardingStage? OnboardingStage { get; set; }

        /// <summary>
        /// The time that onboarding was completed, only present if onboarding has in fact completed
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("onboardingCompletedAt")]
        public DateTime? OnboardingCompletedAt { get; set; }
    }
}
