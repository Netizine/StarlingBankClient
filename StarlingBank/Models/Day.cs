using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// DayEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Day
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
    /// Helper for the enum type Day
    /// </summary>
    public static class DayHelper
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
        /// Converts a Day value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Day value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Day enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Day.MONDAY:
                case Day.TUESDAY:
                case Day.WEDNESDAY:
                case Day.THURSDAY:
                case Day.FRIDAY:
                case Day.SATURDAY:
                case Day.SUNDAY:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Day values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Day values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Day> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into Day value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Day value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type Day</exception>
        public static Day ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Day");
            return (Day)index;
        }
    }
}
