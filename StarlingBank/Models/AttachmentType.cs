using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Enum AttachmentType
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum AttachmentType
    {
        /// <summary>
        /// Image
        /// </summary>
        IMAGE,

        /// <summary>
        /// PDF
        /// </summary>
        PDF
    }

    /// <summary>
    /// Helper for the enum type AttachmentType
    /// </summary>
    public static class AttachmentTypeHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string> {"image, pdf"};

        /// <summary>
        /// Converts a AttachmentType value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The AttachmentType value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(AttachmentType enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case AttachmentType.IMAGE:
                case AttachmentType.PDF:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of AttachmentType values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of AttachmentType values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<AttachmentType> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into AttachmentType value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed AttachmentType value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type AttachmentType</exception>
        public static AttachmentType ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type AttachmentType");
            return (AttachmentType)index;
        }
    }
}
