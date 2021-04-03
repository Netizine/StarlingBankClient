using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Enum AccountType
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum AccountType
    {
        /// <summary>
        /// Primary Account
        /// </summary>
        PRIMARY,

        /// <summary>
        /// Additional Account
        /// </summary>
        ADDITIONAL,

        /// <summary>
        /// Fixed Term Deposit Account
        /// </summary>
        FIXED_TERM_DEPOSIT
    }

    /// <summary>
    /// Helper for the enum type AccountType
    /// </summary>
    public static class AccountTypeHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string> {"PRIMARY", "ADDITIONAL", "FIXED_TERM_DEPOSIT"};

        /// <summary>
        /// Converts a AccountType value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The AccountType value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(AccountType enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case AccountType.PRIMARY:
                case AccountType.ADDITIONAL:
                case AccountType.FIXED_TERM_DEPOSIT:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of AccountType values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of AccountType values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<AccountType> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into AccountType value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed AccountType value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type AccountType</exception>
        public static AccountType ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type AccountType");
            return (AccountType)index;
        }
    }
}
