using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// NetDirectionEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum NetDirection
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
    /// Helper for the enum type NetDirection
    /// </summary>
    public static class NetDirectionHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string> {"IN", "OUT"};

        /// <summary>
        /// Converts a NetDirection value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The NetDirection value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(NetDirection enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case NetDirection.IN:
                case NetDirection.OUT:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of NetDirection values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of NetDirection values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<NetDirection> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into NetDirection value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed NetDirection value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type NetDirection</exception>
        public static NetDirection ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type NetDirection");
            return (NetDirection)index;
        }
    }
}
