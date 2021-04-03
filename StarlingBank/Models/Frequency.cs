using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// FrequencyEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Frequency
    {
        /// <summary>
        /// Secondly
        /// </summary>
        SECONDLY,

        /// <summary>
        /// Minutely
        /// </summary>
        MINUTELY,

        /// <summary>
        /// Hourly
        /// </summary>
        HOURLY,

        /// <summary>
        /// Daily
        /// </summary>
        DAILY,

        /// <summary>
        /// Weekly
        /// </summary>
        WEEKLY,

        /// <summary>
        /// Monthly
        /// </summary>
        MONTHLY,

        /// <summary>
        /// Yearly
        /// </summary>
        YEARLY,

        /// <summary>
        /// Millennialy
        /// </summary>
        MILLENNIALY,

        /// <summary>
        /// Working daily
        /// </summary>
        WORKING_DAILY,

        /// <summary>
        /// Scottish quarterly
        /// </summary>
        SCOTTISH_QUARTERLY,

        /// <summary>
        /// English quarterly
        /// </summary>
        ENGLISH_QUARTERLY,

        /// <summary>
        /// Received quarterly
        /// </summary>
        RECEIVED_QUARTERLY
    }

    /// <summary>
    /// Helper for the enum type Frequency
    /// </summary>
    public static class FrequencyHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string>
        {
            "SECONDLY",
            "MINUTELY",
            "HOURLY",
            "DAILY",
            "WEEKLY",
            "MONTHLY",
            "YEARLY",
            "MILLENNIALY",
            "WORKING_DAILY",
            "SCOTTISH_QUARTERLY",
            "ENGLISH_QUARTERLY",
            "RECEIVED_QUARTERLY"
        };

        /// <summary>
        /// Converts a Frequency value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Frequency value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Frequency enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Frequency.SECONDLY:
                case Frequency.MINUTELY:
                case Frequency.HOURLY:
                case Frequency.DAILY:
                case Frequency.WEEKLY:
                case Frequency.MONTHLY:
                case Frequency.YEARLY:
                case Frequency.MILLENNIALY:
                case Frequency.WORKING_DAILY:
                case Frequency.SCOTTISH_QUARTERLY:
                case Frequency.ENGLISH_QUARTERLY:
                case Frequency.RECEIVED_QUARTERLY:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Frequency values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Frequency values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Frequency> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into Frequency value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Frequency value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type Frequency</exception>
        public static Frequency ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Frequency");
            return (Frequency)index;
        }
    }
}
