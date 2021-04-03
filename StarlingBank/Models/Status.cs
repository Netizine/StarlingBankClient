using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// StatusEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Status
    {
        /// <summary>
        /// Inactive
        /// </summary>
        INACTIVE,

        /// <summary>
        /// Closed
        /// </summary>
        CLOSED,

        /// <summary>
        /// Upcoming
        /// </summary>
        UPCOMING,

        /// <summary>
        /// Pending
        /// </summary>
        PENDING,

        /// <summary>
        /// Reversed
        /// </summary>
        REVERSED,

        /// <summary>
        /// Settled
        /// </summary>
        SETTLED,

        /// <summary>
        /// Declined
        /// </summary>
        DECLINED,

        /// <summary>
        /// Refunded
        /// </summary>
        REFUNDED,

        /// <summary>
        /// Retrying
        /// </summary>
        RETRYING,

        /// <summary>
        /// Account check
        /// </summary>
        ACCOUNT_CHECK,

        /// <summary>
        /// Active
        /// </summary>
        ACTIVE,

        /// <summary>
        /// Cancelled
        /// </summary>
        CANCELLED,

        /// <summary>
        /// Live
        /// </summary>
        LIVE,

        /// <summary>
        /// Pending cas
        /// </summary>
        PENDING_CAS
    }

    /// <summary>
    /// Helper for the enum type Status
    /// </summary>
    public static class StatusHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string>
        {
            "INACTIVE",
            "CLOSED",
            "UPCOMING",
            "PENDING",
            "REVERSED",
            "SETTLED",
            "DECLINED",
            "REFUNDED",
            "RETRYING",
            "ACCOUNT_CHECK",
            "ACTIVE",
            "CANCELLED",
            "LIVE",
            "PENDING_CAS"
        };

        /// <summary>
        /// Converts a Status value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Status value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Status enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Status.INACTIVE:
                case Status.CLOSED:
                case Status.UPCOMING:
                case Status.PENDING:
                case Status.REVERSED:
                case Status.SETTLED:
                case Status.DECLINED:
                case Status.REFUNDED:
                case Status.RETRYING:
                case Status.ACCOUNT_CHECK:
                case Status.ACTIVE:
                case Status.CANCELLED:
                case Status.LIVE:
                case Status.PENDING_CAS:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Status values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Status values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Status> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into Status value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Status value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type Status</exception>
        public static Status ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Status");
            return (Status)index;
        }
    }
}
