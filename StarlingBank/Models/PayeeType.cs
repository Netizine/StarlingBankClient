using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// PayeeTypeEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum PayeeType
    {
        /// <summary>
        /// Business
        /// </summary>
        BUSINESS,

        /// <summary>
        /// Individual
        /// </summary>
        INDIVIDUAL
    }

    /// <summary>
    /// Helper for the enum type PayeeType
    /// </summary>
    public static class PayeeTypeHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string> {"BUSINESS", "INDIVIDUAL"};

        /// <summary>
        /// Converts a PayeeType value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The PayeeType value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(PayeeType enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case PayeeType.BUSINESS:
                case PayeeType.INDIVIDUAL:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of PayeeType values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of PayeeType values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<PayeeType> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into PayeeType value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed PayeeType value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type PayeeType</exception>
        public static PayeeType ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type PayeeType");
            return (PayeeType)index;
        }
    }
}
