using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// WeekStartEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum WeekStart
    {
        /// <summary>
        /// Monday
        /// </summary>
        MONDAY,

        /// <summary>
        /// Tuesday
        /// </summary>
        TUESDAY,

        /// <summary>
        /// Wednesday
        /// </summary>
        WEDNESDAY,

        /// <summary>
        /// Thursday
        /// </summary>
        THURSDAY,

        /// <summary>
        /// Friday
        /// </summary>
        FRIDAY,

        /// <summary>
        /// Saturday
        /// </summary>
        SATURDAY,

        /// <summary>
        /// Sunday
        /// </summary>
        SUNDAY
    }

    /// <summary>
    /// Helper for the enum type WeekStart
    /// </summary>
    public static class WeekStartHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string>
        {
            "MONDAY",
            "TUESDAY",
            "WEDNESDAY",
            "THURSDAY",
            "FRIDAY",
            "SATURDAY",
            "SUNDAY"
        };

        /// <summary>
        /// Converts a WeekStart value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The WeekStart value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(WeekStart enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case WeekStart.MONDAY:
                case WeekStart.TUESDAY:
                case WeekStart.WEDNESDAY:
                case WeekStart.THURSDAY:
                case WeekStart.FRIDAY:
                case WeekStart.SATURDAY:
                case WeekStart.SUNDAY:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of WeekStart values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of WeekStart values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<WeekStart> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into WeekStart value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed WeekStart value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type WeekStart</exception>
        public static WeekStart ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type WeekStart");
            return (WeekStart)index;
        }
    }
}
