using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// FeedItemAttachmentTypeEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum FeedItemAttachmentType
    {
        /// <summary>
        /// Image
        /// </summary>
        IMAGE,

        /// <summary>
        /// PDF
        /// </summary>
        PDF,

        /// <summary>
        /// Either image or PDF
        /// </summary>
        ENUM_IMAGE_PDF
    }

    /// <summary>
    /// Helper for the enum type FeedItemAttachmentType
    /// </summary>
    public static class FeedItemAttachmentTypeHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string> {"IMAGE", "PDF", "IMAGE, PDF"};

        /// <summary>
        /// Converts a FeedItemAttachmentType value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The FeedItemAttachmentType value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(FeedItemAttachmentType enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case FeedItemAttachmentType.IMAGE:
                case FeedItemAttachmentType.PDF:
                case FeedItemAttachmentType.ENUM_IMAGE_PDF:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of FeedItemAttachmentType values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of FeedItemAttachmentType values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<FeedItemAttachmentType> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into FeedItemAttachmentType value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed FeedItemAttachmentType value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type FeedItemAttachmentType</exception>
        public static FeedItemAttachmentType ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type FeedItemAttachmentType");
            return (FeedItemAttachmentType)index;
        }
    }
}
