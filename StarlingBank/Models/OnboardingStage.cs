using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// OnboardingStageEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum OnboardingStage
    {
        /// <summary>
        /// Onboarding request submitted
        /// </summary>
        ONBOARDING_REQUEST_SUBMITTED,

        /// <summary>
        /// Onboarding complete
        /// </summary>
        ONBOARDING_COMPLETE,

        /// <summary>
        /// Onboarding rejected
        /// </summary>
        ONBOARDING_REJECTED
    }

    /// <summary>
    /// Helper for the enum type OnboardingStage
    /// </summary>
    public static class OnboardingStageHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string> {"ONBOARDING_REQUEST_SUBMITTED", "ONBOARDING_COMPLETE", "ONBOARDING_REJECTED"};

        /// <summary>
        /// Converts a OnboardingStage value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The OnboardingStage value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(OnboardingStage enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case OnboardingStage.ONBOARDING_REQUEST_SUBMITTED:
                case OnboardingStage.ONBOARDING_COMPLETE:
                case OnboardingStage.ONBOARDING_REJECTED:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of OnboardingStage values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of OnboardingStage values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<OnboardingStage> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into OnboardingStage value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed OnboardingStage value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type OnboardingStage</exception>
        public static OnboardingStage ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type OnboardingStage");
            return (OnboardingStage)index;
        }
    }
}
