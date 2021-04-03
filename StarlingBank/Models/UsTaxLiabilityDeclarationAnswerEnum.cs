using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// UsTaxLiabilityDeclarationAnswerEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum UsTaxLiabilityDeclarationAnswer
    {
        /// <summary>
        /// Yes
        /// </summary>
        YES,

        /// <summary>
        /// No
        /// </summary>
        NO
    }

    /// <summary>
    /// Helper for the enum type UsTaxLiabilityDeclarationAnswer
    /// </summary>
    public static class UsTaxLiabilityDeclarationAnswerHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string> {"YES", "NO"};

        /// <summary>
        /// Converts a UsTaxLiabilityDeclarationAnswer value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The UsTaxLiabilityDeclarationAnswer value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(UsTaxLiabilityDeclarationAnswer enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case UsTaxLiabilityDeclarationAnswer.YES:
                case UsTaxLiabilityDeclarationAnswer.NO:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of UsTaxLiabilityDeclarationAnswer values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of UsTaxLiabilityDeclarationAnswer values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<UsTaxLiabilityDeclarationAnswer> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into UsTaxLiabilityDeclarationAnswer value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed UsTaxLiabilityDeclarationAnswer value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type UsTaxLiabilityDeclarationAnswer</exception>
        public static UsTaxLiabilityDeclarationAnswer ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type UsTaxLiabilityDeclarationAnswer");
            return (UsTaxLiabilityDeclarationAnswer)index;
        }
    }
}
