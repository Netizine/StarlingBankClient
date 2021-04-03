using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Enum CounterPartyType
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum CounterPartyType
    {
        /// <summary>
        /// The category
        /// </summary>
        CATEGORY,

        /// <summary>
        /// The cheque
        /// </summary>
        CHEQUE,

        /// <summary>
        /// The customer
        /// </summary>
        CUSTOMER,

        /// <summary>
        /// The payee
        /// </summary>
        PAYEE,

        /// <summary>
        /// The merchant
        /// </summary>
        MERCHANT,

        /// <summary>
        /// The sender
        /// </summary>
        SENDER,

        /// <summary>
        /// The starling
        /// </summary>
        STARLING,

        /// <summary>
        /// The loan
        /// </summary>
        LOAN
    }

    /// <summary>
    /// Helper for the enum type CounterPartyType
    /// </summary>
    public static class CounterPartyTypeHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string>
        {
            "CATEGORY",
            "CHEQUE",
            "CUSTOMER",
            "PAYEE",
            "MERCHANT",
            "SENDER",
            "STARLING",
            "LOAN"
        };

        /// <summary>
        /// Converts a CounterPartyType value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The CounterPartyType value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(CounterPartyType enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case CounterPartyType.CATEGORY:
                case CounterPartyType.CHEQUE:
                case CounterPartyType.CUSTOMER:
                case CounterPartyType.PAYEE:
                case CounterPartyType.MERCHANT:
                case CounterPartyType.SENDER:
                case CounterPartyType.STARLING:
                case CounterPartyType.LOAN:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of CounterPartyType values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of CounterPartyType values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<CounterPartyType> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into CounterPartyType value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed CounterPartyType value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type CounterPartyType</exception>
        public static CounterPartyType ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type CounterPartyType");
            return (CounterPartyType)index;
        }
    }
}
