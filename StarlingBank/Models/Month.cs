using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// MonthEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Month
    {
        /// <summary>
        /// January
        /// </summary>
        JANUARY,

        /// <summary>
        /// February
        /// </summary>
        FEBRUARY,

        /// <summary>
        /// March
        /// </summary>
        MARCH,

        /// <summary>
        /// April
        /// </summary>
        APRIL,

        /// <summary>
        /// May
        /// </summary>
        MAY,

        /// <summary>
        /// June
        /// </summary>
        JUNE,

        /// <summary>
        /// July
        /// </summary>
        JULY,

        /// <summary>
        /// August
        /// </summary>
        AUGUST,

        /// <summary>
        /// September
        /// </summary>
        SEPTEMBER,

        /// <summary>
        /// October
        /// </summary>
        OCTOBER,

        /// <summary>
        /// November
        /// </summary>
        NOVEMBER,

        /// <summary>
        /// December
        /// </summary>
        DECEMBER
    }

    /// <summary>
    /// Helper for the enum type Month
    /// </summary>
    public static class MonthHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string>
        {
            "JANUARY",
            "FEBRUARY",
            "MARCH",
            "APRIL",
            "MAY",
            "JUNE",
            "JULY",
            "AUGUST",
            "SEPTEMBER",
            "OCTOBER",
            "NOVEMBER",
            "DECEMBER"
        };

        /// <summary>
        /// Converts a Month value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Month value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Month enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Month.JANUARY:
                case Month.FEBRUARY:
                case Month.MARCH:
                case Month.APRIL:
                case Month.MAY:
                case Month.JUNE:
                case Month.JULY:
                case Month.AUGUST:
                case Month.SEPTEMBER:
                case Month.OCTOBER:
                case Month.NOVEMBER:
                case Month.DECEMBER:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Month values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Month values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Month> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into Month value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Month value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type Month</exception>
        public static Month ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Month");
            return (Month)index;
        }
    }
}
