using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// WebhookTypeEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum WebhookType
    {
        /// <summary>
        /// Interest charge
        /// </summary>
        INTEREST_CHARGE,

        /// <summary>
        /// Scheduled payment cancelled
        /// </summary>
        SCHEDULED_PAYMENT_CANCELLED,

        /// <summary>
        /// Scheduled payment insufficient funds
        /// </summary>
        SCHEDULED_PAYMENT_INSUFFICIENT_FUNDS,

        /// <summary>
        /// Transaction card
        /// </summary>
        TRANSACTION_CARD,

        /// <summary>
        /// Transaction cash withdrawal
        /// </summary>
        TRANSACTION_CASH_WITHDRAWAL,

        /// <summary>
        /// Transaction mobile wallet
        /// </summary>
        TRANSACTION_MOBILE_WALLET,

        /// <summary>
        /// Transaction direct credit
        /// </summary>
        TRANSACTION_DIRECT_CREDIT,

        /// <summary>
        /// Transaction direct debit
        /// </summary>
        TRANSACTION_DIRECT_DEBIT,

        /// <summary>
        /// Transaction direct debit insufficient funds
        /// </summary>
        TRANSACTION_DIRECT_DEBIT_INSUFFICIENT_FUNDS,

        /// <summary>
        /// Transaction direct debit dispute
        /// </summary>
        TRANSACTION_DIRECT_DEBIT_DISPUTE,

        /// <summary>
        /// Transaction faster payment in
        /// </summary>
        TRANSACTION_FASTER_PAYMENT_IN,

        /// <summary>
        /// Transaction faster payment out
        /// </summary>
        TRANSACTION_FASTER_PAYMENT_OUT,

        /// <summary>
        /// Transaction faster payment reversal
        /// </summary>
        TRANSACTION_FASTER_PAYMENT_REVERSAL,

        /// <summary>
        /// Transaction interest payment
        /// </summary>
        TRANSACTION_INTEREST_PAYMENT,

        /// <summary>
        /// Transaction internal transfer
        /// </summary>
        TRANSACTION_INTERNAL_TRANSFER,

        /// <summary>
        /// Transaction nostro deposit
        /// </summary>
        TRANSACTION_NOSTRO_DEPOSIT,

        /// <summary>
        /// Transaction on us payment in
        /// </summary>
        TRANSACTION_ON_US_PAYMENT_IN,

        /// <summary>
        /// Transaction on us payment out
        /// </summary>
        TRANSACTION_ON_US_PAYMENT_OUT,

        /// <summary>
        /// Transaction interest waived deposit
        /// </summary>
        TRANSACTION_INTEREST_WAIVED_DEPOSIT,

        /// <summary>
        /// Transaction stripe funding
        /// </summary>
        TRANSACTION_STRIPE_FUNDING,

        /// <summary>
        /// Transaction declined insufficient funds
        /// </summary>
        TRANSACTION_DECLINED_INSUFFICIENT_FUNDS,

        /// <summary>
        /// Transaction authentication declined
        /// </summary>
        TRANSACTION_AUTH_DECLINED,

        /// <summary>
        /// Transaction authentication partial reversal
        /// </summary>
        TRANSACTION_AUTH_PARTIAL_REVERSAL,

        /// <summary>
        /// Transaction authentication full reversal
        /// </summary>
        TRANSACTION_AUTH_FULL_REVERSAL
    }

    /// <summary>
    /// Helper for the enum type WebhookType
    /// </summary>
    public static class WebhookTypeHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string>
        {
            "INTEREST_CHARGE",
            "SCHEDULED_PAYMENT_CANCELLED",
            "SCHEDULED_PAYMENT_INSUFFICIENT_FUNDS",
            "TRANSACTION_CARD",
            "TRANSACTION_CASH_WITHDRAWAL",
            "TRANSACTION_MOBILE_WALLET",
            "TRANSACTION_DIRECT_CREDIT",
            "TRANSACTION_DIRECT_DEBIT",
            "TRANSACTION_DIRECT_DEBIT_INSUFFICIENT_FUNDS",
            "TRANSACTION_DIRECT_DEBIT_DISPUTE",
            "TRANSACTION_FASTER_PAYMENT_IN",
            "TRANSACTION_FASTER_PAYMENT_OUT",
            "TRANSACTION_FASTER_PAYMENT_REVERSAL",
            "TRANSACTION_INTEREST_PAYMENT",
            "TRANSACTION_INTERNAL_TRANSFER",
            "TRANSACTION_NOSTRO_DEPOSIT",
            "TRANSACTION_ON_US_PAYMENT_IN",
            "TRANSACTION_ON_US_PAYMENT_OUT",
            "TRANSACTION_INTEREST_WAIVED_DEPOSIT",
            "TRANSACTION_STRIPE_FUNDING",
            "TRANSACTION_DECLINED_INSUFFICIENT_FUNDS",
            "TRANSACTION_AUTH_DECLINED",
            "TRANSACTION_AUTH_PARTIAL_REVERSAL",
            "TRANSACTION_AUTH_FULL_REVERSAL"
        };

        /// <summary>
        /// Converts a WebhookType value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The WebhookType value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(WebhookType enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case WebhookType.INTEREST_CHARGE:
                case WebhookType.SCHEDULED_PAYMENT_CANCELLED:
                case WebhookType.SCHEDULED_PAYMENT_INSUFFICIENT_FUNDS:
                case WebhookType.TRANSACTION_CARD:
                case WebhookType.TRANSACTION_CASH_WITHDRAWAL:
                case WebhookType.TRANSACTION_MOBILE_WALLET:
                case WebhookType.TRANSACTION_DIRECT_CREDIT:
                case WebhookType.TRANSACTION_DIRECT_DEBIT:
                case WebhookType.TRANSACTION_DIRECT_DEBIT_INSUFFICIENT_FUNDS:
                case WebhookType.TRANSACTION_DIRECT_DEBIT_DISPUTE:
                case WebhookType.TRANSACTION_FASTER_PAYMENT_IN:
                case WebhookType.TRANSACTION_FASTER_PAYMENT_OUT:
                case WebhookType.TRANSACTION_FASTER_PAYMENT_REVERSAL:
                case WebhookType.TRANSACTION_INTEREST_PAYMENT:
                case WebhookType.TRANSACTION_INTERNAL_TRANSFER:
                case WebhookType.TRANSACTION_NOSTRO_DEPOSIT:
                case WebhookType.TRANSACTION_ON_US_PAYMENT_IN:
                case WebhookType.TRANSACTION_ON_US_PAYMENT_OUT:
                case WebhookType.TRANSACTION_INTEREST_WAIVED_DEPOSIT:
                case WebhookType.TRANSACTION_STRIPE_FUNDING:
                case WebhookType.TRANSACTION_DECLINED_INSUFFICIENT_FUNDS:
                case WebhookType.TRANSACTION_AUTH_DECLINED:
                case WebhookType.TRANSACTION_AUTH_PARTIAL_REVERSAL:
                case WebhookType.TRANSACTION_AUTH_FULL_REVERSAL:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of WebhookType values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of WebhookType values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<WebhookType> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into WebhookType value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed WebhookType value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type WebhookType</exception>
        public static WebhookType ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type WebhookType");
            return (WebhookType)index;
        }
    }
}
