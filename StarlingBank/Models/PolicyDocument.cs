using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// PolicyDocumentEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum PolicyDocument
    {
        /// <summary>
        /// Account terms
        /// </summary>
        ACCOUNT_TERMS,

        /// <summary>
        /// Starling privacy policy
        /// </summary>
        STARLING_PRIVACY_POLICY,

        /// <summary>
        /// FSCS information
        /// </summary>
        FSCS_INFORMATION
    }

    /// <summary>
    /// Helper for the enum type PolicyDocument
    /// </summary>
    public static class PolicyDocumentHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string> {"ACCOUNT_TERMS", "STARLING_PRIVACY_POLICY", "FSCS_INFORMATION"};

        /// <summary>
        /// Converts a PolicyDocument value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The PolicyDocument value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(PolicyDocument enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case PolicyDocument.ACCOUNT_TERMS:
                case PolicyDocument.STARLING_PRIVACY_POLICY:
                case PolicyDocument.FSCS_INFORMATION:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of PolicyDocument values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of PolicyDocument values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<PolicyDocument> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into PolicyDocument value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed PolicyDocument value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type PolicyDocument</exception>
        public static PolicyDocument ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type PolicyDocument");
            return (PolicyDocument)index;
        }
    }
}
