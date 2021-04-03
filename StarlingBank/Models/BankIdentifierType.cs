using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Enum BankIdentifierType
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum BankIdentifierType
    {
        /// <summary>
        /// Sort Code Bank Identifier
        /// </summary>
        SORT_CODE,

        /// <summary>
        /// Swift Bank Identifier
        /// </summary>
        SWIFT,

        /// <summary>
        /// Iban Bank Identifier
        /// </summary>
        IBAN,

        /// <summary>
        /// Aba Bank Identifier
        /// </summary>
        ABA,

        /// <summary>
        /// Aba Wire Bank Identifier
        /// </summary>
        ABA_WIRE,

        /// <summary>
        /// Aba Ach  Bank Identifier
        /// </summary>
        ABA_ACH
    }

    /// <summary>
    /// Helper for the enum type BankIdentifierType
    /// </summary>
    public static class BankIdentifierTypeHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string>
        {
            "SORT_CODE",
            "SWIFT",
            "IBAN",
            "ABA",
            "ABA_WIRE",
            "ABA_ACH"
        };

        /// <summary>
        /// Converts a BankIdentifierType value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The BankIdentifierType value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(BankIdentifierType enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case BankIdentifierType.SORT_CODE:
                case BankIdentifierType.SWIFT:
                case BankIdentifierType.IBAN:
                case BankIdentifierType.ABA:
                case BankIdentifierType.ABA_WIRE:
                case BankIdentifierType.ABA_ACH:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of BankIdentifierType values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of BankIdentifierType values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<BankIdentifierType> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into BankIdentifierType value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed BankIdentifierType value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type BankIdentifierType</exception>
        public static BankIdentifierType ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type BankIdentifierType");
            return (BankIdentifierType)index;
        }
    }
}
