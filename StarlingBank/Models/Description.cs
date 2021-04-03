using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// DescriptionEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Description
    {
        /// <summary>
        /// Accepted
        /// </summary>
        ACCEPTED,

        /// <summary>
        /// Qualified accept within two hours
        /// </summary>
        QUALIFIED_ACCEPT_WITHIN_TWO_HOURS,

        /// <summary>
        /// Qualified accept unspecified day
        /// </summary>
        QUALIFIED_ACCEPT_UNSPECIFIED_DAY,

        /// <summary>
        /// Qualified accept same day
        /// </summary>
        QUALIFIED_ACCEPT_SAME_DAY,

        /// <summary>
        /// Qualified accept next calendar day
        /// </summary>
        QUALIFIED_ACCEPT_NEXT_CALENDAR_DAY,

        /// <summary>
        /// Qualified accept next working day
        /// </summary>
        QUALIFIED_ACCEPT_NEXT_WORKING_DAY,

        /// <summary>
        /// Qualified accept after next working day
        /// </summary>
        QUALIFIED_ACCEPT_AFTER_NEXT_WORKING_DAY,

        /// <summary>
        /// Destination account invalid
        /// </summary>
        DESTINATION_ACCOUNT_INVALID,

        /// <summary>
        /// Destination account name mismatch
        /// </summary>
        DESTINATION_ACCOUNT_NAME_MISMATCH,

        /// <summary>
        /// Reference information incorrect
        /// </summary>
        REFERENCE_INFORMATION_INCORRECT,

        /// <summary>
        /// Destination account unavailable
        /// </summary>
        DESTINATION_ACCOUNT_UNAVAILABLE,

        /// <summary>
        /// Pending
        /// </summary>
        PENDING
    }

    /// <summary>
    /// Helper for the enum type Description
    /// </summary>
    public static class DescriptionHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string>
        {
            "ACCEPTED",
            "QUALIFIED_ACCEPT_WITHIN_TWO_HOURS",
            "QUALIFIED_ACCEPT_UNSPECIFIED_DAY",
            "QUALIFIED_ACCEPT_SAME_DAY",
            "QUALIFIED_ACCEPT_NEXT_CALENDAR_DAY",
            "QUALIFIED_ACCEPT_NEXT_WORKING_DAY",
            "QUALIFIED_ACCEPT_AFTER_NEXT_WORKING_DAY",
            "DESTINATION_ACCOUNT_INVALID",
            "DESTINATION_ACCOUNT_NAME_MISMATCH",
            "REFERENCE_INFORMATION_INCORRECT",
            "DESTINATION_ACCOUNT_UNAVAILABLE",
            "PENDING"
        };

        /// <summary>
        /// Converts a Description value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Description value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Description enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Description.ACCEPTED:
                case Description.QUALIFIED_ACCEPT_WITHIN_TWO_HOURS:
                case Description.QUALIFIED_ACCEPT_UNSPECIFIED_DAY:
                case Description.QUALIFIED_ACCEPT_SAME_DAY:
                case Description.QUALIFIED_ACCEPT_NEXT_CALENDAR_DAY:
                case Description.QUALIFIED_ACCEPT_NEXT_WORKING_DAY:
                case Description.QUALIFIED_ACCEPT_AFTER_NEXT_WORKING_DAY:
                case Description.DESTINATION_ACCOUNT_INVALID:
                case Description.DESTINATION_ACCOUNT_NAME_MISMATCH:
                case Description.REFERENCE_INFORMATION_INCORRECT:
                case Description.DESTINATION_ACCOUNT_UNAVAILABLE:
                case Description.PENDING:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Description values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Description values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Description> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into Description value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Description value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type Description</exception>
        public static Description ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Description");
            return (Description)index;
        }
    }
}
