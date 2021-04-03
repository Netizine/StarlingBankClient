using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Enum AccountHolderType
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum AccountHolderType
    {
        /// <summary>
        /// Individual Account
        /// </summary>
        INDIVIDUAL,

        /// <summary>
        /// Business Account
        /// </summary>
        BUSINESS,

        /// <summary>
        /// Sole Trader Account
        /// </summary>
        SOLE_TRADER,

        /// <summary>
        /// Joint Account
        /// </summary>
        JOINT,

        /// <summary>
        /// Banking As A Service Account
        /// </summary>
        BANKING_AS_A_SERVICE
    }

    /// <summary>
    /// Helper for the enum type AccountHolderType
    /// </summary>
    public static class AccountHolderTypeHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string>
        {
            "INDIVIDUAL",
            "BUSINESS",
            "SOLE_TRADER",
            "JOINT",
            "BANKING_AS_A_SERVICE"
        };

        /// <summary>
        /// Converts a AccountHolderType value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The AccountHolderType value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(AccountHolderType enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case AccountHolderType.INDIVIDUAL:
                case AccountHolderType.BUSINESS:
                case AccountHolderType.SOLE_TRADER:
                case AccountHolderType.JOINT:
                case AccountHolderType.BANKING_AS_A_SERVICE:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of AccountHolderType values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of AccountHolderType values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<AccountHolderType> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into AccountHolderType value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed AccountHolderType value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type AccountHolderType</exception>
        public static AccountHolderType ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type AccountHolderType");
            return (AccountHolderType)index;
        }
    }
}
