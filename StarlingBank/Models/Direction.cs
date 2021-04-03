using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// DirectionEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Direction
    {
        /// <summary>
        /// In
        /// </summary>
        IN,

        /// <summary>
        /// Out
        /// </summary>
        OUT
    }

    /// <summary>
    /// Helper for the enum type Direction
    /// </summary>
    public static class DirectionHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string> {"IN", "OUT"};

        /// <summary>
        /// Converts a Direction value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Direction value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Direction enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Direction.IN:
                case Direction.OUT:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Direction values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Direction values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Direction> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into Direction value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Direction value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type Direction</exception>
        public static Direction ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Direction");
            return (Direction)index;
        }
    }
}
