using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// IdentifierTypeEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum IdentifierType
    {
        /// <summary>
        /// Sort code
        /// </summary>
        SORT_CODE,

        /// <summary>
        /// Iban bic
        /// </summary>
        IBAN_BIC,

        /// <summary>
        /// Aba ach
        /// </summary>
        ABA_ACH
    }

    /// <summary>
    /// Helper for the enum type IdentifierType
    /// </summary>
    public static class IdentifierTypeHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string> {"SORT_CODE", "IBAN_BIC", "ABA_ACH"};

        /// <summary>
        /// Converts a IdentifierType value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The IdentifierType value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(IdentifierType enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case IdentifierType.SORT_CODE:
                case IdentifierType.IBAN_BIC:
                case IdentifierType.ABA_ACH:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of IdentifierType values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of IdentifierType values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<IdentifierType> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into IdentifierType value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed IdentifierType value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type IdentifierType</exception>
        public static IdentifierType ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type IdentifierType");
            return (IdentifierType)index;
        }
    }
}
