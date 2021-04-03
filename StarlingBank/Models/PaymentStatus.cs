using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// PaymentStatusEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum PaymentStatus
    {
        /// <summary>
        /// Accepted
        /// </summary>
        ACCEPTED,

        /// <summary>
        /// Rejected
        /// </summary>
        REJECTED,

        /// <summary>
        /// Pending
        /// </summary>
        PENDING
    }

    /// <summary>
    /// Helper for the enum type PaymentStatus
    /// </summary>
    public static class PaymentStatusHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string> {"ACCEPTED", "REJECTED", "PENDING"};

        /// <summary>
        /// Converts a PaymentStatus value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The PaymentStatus value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(PaymentStatus enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case PaymentStatus.ACCEPTED:
                case PaymentStatus.REJECTED:
                case PaymentStatus.PENDING:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of PaymentStatus values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of PaymentStatus values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<PaymentStatus> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into PaymentStatus value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed PaymentStatus value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type PaymentStatus</exception>
        public static PaymentStatus ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type PaymentStatus");
            return (PaymentStatus)index;
        }
    }
}
