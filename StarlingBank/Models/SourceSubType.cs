using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// SourceSubTypeEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum SourceSubType
    {
        /// <summary>
        /// Contactless
        /// </summary>
        CONTACTLESS,

        /// <summary>
        /// Magnetic strip
        /// </summary>
        MAGNETIC_STRIP,

        /// <summary>
        /// Manual key entry
        /// </summary>
        MANUAL_KEY_ENTRY,

        /// <summary>
        /// Chip and pin
        /// </summary>
        CHIP_AND_PIN,

        /// <summary>
        /// Online
        /// </summary>
        ONLINE,

        /// <summary>
        /// ATM
        /// </summary>
        ATM,

        /// <summary>
        /// Credit authentication
        /// </summary>
        CREDIT_AUTH,

        /// <summary>
        /// Apple pay
        /// </summary>
        APPLE_PAY,

        /// <summary>
        /// Android pay
        /// </summary>
        ANDROID_PAY,

        /// <summary>
        /// Fitbit pay
        /// </summary>
        FITBIT_PAY,

        /// <summary>
        /// Garmin pay
        /// </summary>
        GARMIN_PAY,

        /// <summary>
        /// Samsung pay
        /// </summary>
        SAMSUNG_PAY,

        /// <summary>
        /// Other wallet
        /// </summary>
        OTHER_WALLET,

        /// <summary>
        /// Not applicable
        /// </summary>
        NOT_APPLICABLE,

        /// <summary>
        /// Unknown
        /// </summary>
        UNKNOWN,

        /// <summary>
        /// Deposit
        /// </summary>
        DEPOSIT,

        /// <summary>
        /// Overdraft
        /// </summary>
        OVERDRAFT,

        /// <summary>
        /// Settle up
        /// </summary>
        SETTLE_UP,

        /// <summary>
        /// Nearby
        /// </summary>
        NEARBY,

        /// <summary>
        /// Transfer same currency
        /// </summary>
        TRANSFER_SAME_CURRENCY
    }

    /// <summary>
    /// Helper for the enum type SourceSubType
    /// </summary>
    public static class SourceSubTypeHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string>
        {
            "CONTACTLESS",
            "MAGNETIC_STRIP",
            "MANUAL_KEY_ENTRY",
            "CHIP_AND_PIN",
            "ONLINE",
            "ATM",
            "CREDIT_AUTH",
            "APPLE_PAY",
            "ANDROID_PAY",
            "FITBIT_PAY",
            "GARMIN_PAY",
            "SAMSUNG_PAY",
            "OTHER_WALLET",
            "NOT_APPLICABLE",
            "UNKNOWN",
            "DEPOSIT",
            "OVERDRAFT",
            "SETTLE_UP",
            "NEARBY",
            "TRANSFER_SAME_CURRENCY"
        };

        /// <summary>
        /// Converts a SourceSubType value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The SourceSubType value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(SourceSubType enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case SourceSubType.CONTACTLESS:
                case SourceSubType.MAGNETIC_STRIP:
                case SourceSubType.MANUAL_KEY_ENTRY:
                case SourceSubType.CHIP_AND_PIN:
                case SourceSubType.ONLINE:
                case SourceSubType.ATM:
                case SourceSubType.CREDIT_AUTH:
                case SourceSubType.APPLE_PAY:
                case SourceSubType.ANDROID_PAY:
                case SourceSubType.FITBIT_PAY:
                case SourceSubType.GARMIN_PAY:
                case SourceSubType.SAMSUNG_PAY:
                case SourceSubType.OTHER_WALLET:
                case SourceSubType.NOT_APPLICABLE:
                case SourceSubType.UNKNOWN:
                case SourceSubType.DEPOSIT:
                case SourceSubType.OVERDRAFT:
                case SourceSubType.SETTLE_UP:
                case SourceSubType.NEARBY:
                case SourceSubType.TRANSFER_SAME_CURRENCY:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of SourceSubType values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of SourceSubType values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<SourceSubType> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into SourceSubType value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed SourceSubType value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type SourceSubType</exception>
        public static SourceSubType ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type SourceSubType");
            return (SourceSubType)index;
        }
    }
}
