using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// SourceOfFundEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum SourceOfFund
    {
        /// <summary>
        /// Benefits
        /// </summary>
        BENEFITS,

        /// <summary>
        /// Friends and family
        /// </summary>
        FRIENDS_AND_FAMILY,

        /// <summary>
        /// Investment
        /// </summary>
        INVESTMENT,

        /// <summary>
        /// Loans
        /// </summary>
        LOANS,

        /// <summary>
        /// Monthly salary
        /// </summary>
        MONTHLY_SALARY,

        /// <summary>
        /// Pension
        /// </summary>
        PENSION,

        /// <summary>
        /// Property
        /// </summary>
        PROPERTY,

        /// <summary>
        /// Weekly wages
        /// </summary>
        WEEKLY_WAGES
    }

    /// <summary>
    /// Helper for the enum type SourceOfFund
    /// </summary>
    public static class SourceOfFundHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string>
        {
            "BENEFITS",
            "FRIENDS_AND_FAMILY",
            "INVESTMENT",
            "LOANS",
            "MONTHLY_SALARY",
            "PENSION",
            "PROPERTY",
            "WEEKLY_WAGES"
        };

        /// <summary>
        /// Converts a SourceOfFund value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The SourceOfFund value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(SourceOfFund enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case SourceOfFund.BENEFITS:
                case SourceOfFund.FRIENDS_AND_FAMILY:
                case SourceOfFund.INVESTMENT:
                case SourceOfFund.LOANS:
                case SourceOfFund.MONTHLY_SALARY:
                case SourceOfFund.PENSION:
                case SourceOfFund.PROPERTY:
                case SourceOfFund.WEEKLY_WAGES:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of SourceOfFund values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of SourceOfFund values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<SourceOfFund> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into SourceOfFund value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed SourceOfFund value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type SourceOfFund</exception>
        public static SourceOfFund ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type SourceOfFund");
            return (SourceOfFund)index;
        }
    }
}
