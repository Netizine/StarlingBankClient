using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// PayeeChannelTypeEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum PayeeChannelType
    {
        /// <summary>
        /// Bank account
        /// </summary>
        BANK_ACCOUNT,

        /// <summary>
        /// Settle up
        /// </summary>
        SETTLE_UP,

        /// <summary>
        /// Nearby
        /// </summary>
        NEARBY
    }

    /// <summary>
    /// Helper for the enum type PayeeChannelType
    /// </summary>
    public static class PayeeChannelTypeHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string> {"BANK_ACCOUNT", "SETTLE_UP", "NEARBY"};

        /// <summary>
        /// Converts a PayeeChannelType value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The PayeeChannelType value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(PayeeChannelType enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case PayeeChannelType.BANK_ACCOUNT:
                case PayeeChannelType.SETTLE_UP:
                case PayeeChannelType.NEARBY:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of PayeeChannelType values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of PayeeChannelType values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<PayeeChannelType> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into PayeeChannelType value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed PayeeChannelType value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type PayeeChannelType</exception>
        public static PayeeChannelType ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type PayeeChannelType");
            return (PayeeChannelType)index;
        }
    }
}
