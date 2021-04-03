using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// PaymentTypeEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum PaymentType
    {
        /// <summary>
        /// Direct debit
        /// </summary>
        DIRECT_DEBIT,

        /// <summary>
        /// Standing order
        /// </summary>
        STANDING_ORDER,

        /// <summary>
        /// Internal transfer
        /// </summary>
        INTERNAL_TRANSFER
    }

    /// <summary>
    /// Helper for the enum type PaymentType
    /// </summary>
    public static class PaymentTypeHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string> {"DIRECT_DEBIT", "STANDING_ORDER", "INTERNAL_TRANSFER"};

        /// <summary>
        /// Converts a PaymentType value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The PaymentType value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(PaymentType enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case PaymentType.DIRECT_DEBIT:
                case PaymentType.STANDING_ORDER:
                case PaymentType.INTERNAL_TRANSFER:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of PaymentType values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of PaymentType values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<PaymentType> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into PaymentType value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed PaymentType value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type PaymentType</exception>
        public static PaymentType ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type PaymentType");
            return (PaymentType)index;
        }
    }
}
