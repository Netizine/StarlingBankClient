using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// TaxLiabilityDeclarationAnswerEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum TaxLiabilityDeclarationAnswer
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
    /// Helper for the enum type TaxLiabilityDeclarationAnswer
    /// </summary>
    public static class TaxLiabilityDeclarationAnswerHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string> {"YES", "NO"};

        /// <summary>
        /// Converts a TaxLiabilityDeclarationAnswer value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The TaxLiabilityDeclarationAnswer value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(TaxLiabilityDeclarationAnswer enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case TaxLiabilityDeclarationAnswer.YES:
                case TaxLiabilityDeclarationAnswer.NO:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of TaxLiabilityDeclarationAnswer values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of TaxLiabilityDeclarationAnswer values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<TaxLiabilityDeclarationAnswer> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into TaxLiabilityDeclarationAnswer value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed TaxLiabilityDeclarationAnswer value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type TaxLiabilityDeclarationAnswer</exception>
        public static TaxLiabilityDeclarationAnswer ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type TaxLiabilityDeclarationAnswer");
            return (TaxLiabilityDeclarationAnswer)index;
        }
    }
}
