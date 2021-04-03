using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// MetadataSourceEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum MetadataSource
    {
        /// <summary>
        /// Customer
        /// </summary>
        CUSTOMER,

        /// <summary>
        /// Starling
        /// </summary>
        STARLING,

        /// <summary>
        /// Partner
        /// </summary>
        PARTNER
    }

    /// <summary>
    /// Helper for the enum type MetadataSource
    /// </summary>
    public static class MetadataSourceHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string> {"CUSTOMER", "STARLING", "PARTNER"};

        /// <summary>
        /// Converts a MetadataSource value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The MetadataSource value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(MetadataSource enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case MetadataSource.CUSTOMER:
                case MetadataSource.STARLING:
                case MetadataSource.PARTNER:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of MetadataSource values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of MetadataSource values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<MetadataSource> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into MetadataSource value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed MetadataSource value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type MetadataSource</exception>
        public static MetadataSource ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type MetadataSource");
            return (MetadataSource)index;
        }
    }
}
