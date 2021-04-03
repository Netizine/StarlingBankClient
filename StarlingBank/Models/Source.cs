using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// SourceEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Source
    {
        /// <summary>
        /// Electronic
        /// </summary>
        ELECTRONIC,

        /// <summary>
        /// Paper
        /// </summary>
        PAPER,

        /// <summary>
        /// British business bank fees
        /// </summary>
        BRITISH_BUSINESS_BANK_FEES,

        /// <summary>
        /// Cash deposit
        /// </summary>
        CASH_DEPOSIT,

        /// <summary>
        /// Cash deposit charge
        /// </summary>
        CASH_DEPOSIT_CHARGE,

        /// <summary>
        /// Cash withdrawal
        /// </summary>
        CASH_WITHDRAWAL,

        /// <summary>
        /// Cash withdrawal charge
        /// </summary>
        CASH_WITHDRAWAL_CHARGE,

        /// <summary>
        /// Chaps
        /// </summary>
        CHAPS,

        /// <summary>
        /// Cheque
        /// </summary>
        CHEQUE,

        /// <summary>
        /// CICS cheque
        /// </summary>
        CICS_CHEQUE,

        /// <summary>
        /// Currency cloud
        /// </summary>
        CURRENCY_CLOUD,

        /// <summary>
        /// Direct credit
        /// </summary>
        DIRECT_CREDIT,

        /// <summary>
        /// Direct debit
        /// </summary>
        DIRECT_DEBIT,

        /// <summary>
        /// Direct debit dispute
        /// </summary>
        DIRECT_DEBIT_DISPUTE,

        /// <summary>
        /// Internal transfer
        /// </summary>
        INTERNAL_TRANSFER,

        /// <summary>
        /// Master card
        /// </summary>
        MASTER_CARD,

        /// <summary>
        /// Mastercard moneysend
        /// </summary>
        MASTERCARD_MONEYSEND,

        /// <summary>
        /// Mastercard chargeback
        /// </summary>
        MASTERCARD_CHARGEBACK,

        /// <summary>
        /// Faster payments in
        /// </summary>
        FASTER_PAYMENTS_IN,

        /// <summary>
        /// Faster payments out
        /// </summary>
        FASTER_PAYMENTS_OUT,

        /// <summary>
        /// Faster payments reversal
        /// </summary>
        FASTER_PAYMENTS_REVERSAL,

        /// <summary>
        /// Stripe funding
        /// </summary>
        STRIPE_FUNDING,

        /// <summary>
        /// Interest payment
        /// </summary>
        INTEREST_PAYMENT,

        /// <summary>
        /// Nostro deposit
        /// </summary>
        NOSTRO_DEPOSIT,

        /// <summary>
        /// Overdraft
        /// </summary>
        OVERDRAFT,

        /// <summary>
        /// Overdraft interest waived
        /// </summary>
        OVERDRAFT_INTEREST_WAIVED,

        /// <summary>
        /// Faster payments refund
        /// </summary>
        FASTER_PAYMENTS_REFUND,

        /// <summary>
        /// Starling pay stripe
        /// </summary>
        STARLING_PAY_STRIPE,

        /// <summary>
        /// On us pay me
        /// </summary>
        ON_US_PAY_ME,

        /// <summary>
        /// Loan principal payment
        /// </summary>
        LOAN_PRINCIPAL_PAYMENT,

        /// <summary>
        /// Loan repayment
        /// </summary>
        LOAN_REPAYMENT,

        /// <summary>
        /// Loan overpayment
        /// </summary>
        LOAN_OVERPAYMENT,

        /// <summary>
        /// Loan late payment
        /// </summary>
        LOAN_LATE_PAYMENT,

        /// <summary>
        /// Loan fee payment
        /// </summary>
        LOAN_FEE_PAYMENT,

        /// <summary>
        /// SEPA credit transfer
        /// </summary>
        SEPA_CREDIT_TRANSFER,

        /// <summary>
        /// SEPA direct debit
        /// </summary>
        SEPA_DIRECT_DEBIT,

        /// <summary>
        /// Target customer payment
        /// </summary>
        TARGET2_CUSTOMER_PAYMENT,

        /// <summary>
        /// FX transfer
        /// </summary>
        FX_TRANSFER,

        /// <summary>
        /// ISS payment
        /// </summary>
        ISS_PAYMENT,

        /// <summary>
        /// Starling payment
        /// </summary>
        STARLING_PAYMENT,

        /// <summary>
        /// Subscription charge
        /// </summary>
        SUBSCRIPTION_CHARGE,

        /// <summary>
        /// Overdraft fee
        /// </summary>
        OVERDRAFT_FEE
    }

    /// <summary>
    /// Helper for the enum type Source
    /// </summary>
    public static class SourceHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string>
        {
            "ELECTRONIC",
            "PAPER",
            "BRITISH_BUSINESS_BANK_FEES",
            "CASH_DEPOSIT",
            "CASH_DEPOSIT_CHARGE",
            "CASH_WITHDRAWAL",
            "CASH_WITHDRAWAL_CHARGE",
            "CHAPS",
            "CHEQUE",
            "CICS_CHEQUE",
            "CURRENCY_CLOUD",
            "DIRECT_CREDIT",
            "DIRECT_DEBIT",
            "DIRECT_DEBIT_DISPUTE",
            "INTERNAL_TRANSFER",
            "MASTER_CARD",
            "MASTERCARD_MONEYSEND",
            "MASTERCARD_CHARGEBACK",
            "FASTER_PAYMENTS_IN",
            "FASTER_PAYMENTS_OUT",
            "FASTER_PAYMENTS_REVERSAL",
            "STRIPE_FUNDING",
            "INTEREST_PAYMENT",
            "NOSTRO_DEPOSIT",
            "OVERDRAFT",
            "OVERDRAFT_INTEREST_WAIVED",
            "FASTER_PAYMENTS_REFUND",
            "STARLING_PAY_STRIPE",
            "ON_US_PAY_ME",
            "LOAN_PRINCIPAL_PAYMENT",
            "LOAN_REPAYMENT",
            "LOAN_OVERPAYMENT",
            "LOAN_LATE_PAYMENT",
            "LOAN_FEE_PAYMENT",
            "SEPA_CREDIT_TRANSFER",
            "SEPA_DIRECT_DEBIT",
            "TARGET2_CUSTOMER_PAYMENT",
            "FX_TRANSFER",
            "ISS_PAYMENT",
            "STARLING_PAYMENT",
            "SUBSCRIPTION_CHARGE",
            "OVERDRAFT_FEE"
        };

        /// <summary>
        /// Converts a Source value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Source value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Source enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Source.ELECTRONIC:
                case Source.PAPER:
                case Source.BRITISH_BUSINESS_BANK_FEES:
                case Source.CASH_DEPOSIT:
                case Source.CASH_DEPOSIT_CHARGE:
                case Source.CASH_WITHDRAWAL:
                case Source.CASH_WITHDRAWAL_CHARGE:
                case Source.CHAPS:
                case Source.CHEQUE:
                case Source.CICS_CHEQUE:
                case Source.CURRENCY_CLOUD:
                case Source.DIRECT_CREDIT:
                case Source.DIRECT_DEBIT:
                case Source.DIRECT_DEBIT_DISPUTE:
                case Source.INTERNAL_TRANSFER:
                case Source.MASTER_CARD:
                case Source.MASTERCARD_MONEYSEND:
                case Source.MASTERCARD_CHARGEBACK:
                case Source.FASTER_PAYMENTS_IN:
                case Source.FASTER_PAYMENTS_OUT:
                case Source.FASTER_PAYMENTS_REVERSAL:
                case Source.STRIPE_FUNDING:
                case Source.INTEREST_PAYMENT:
                case Source.NOSTRO_DEPOSIT:
                case Source.OVERDRAFT:
                case Source.OVERDRAFT_INTEREST_WAIVED:
                case Source.FASTER_PAYMENTS_REFUND:
                case Source.STARLING_PAY_STRIPE:
                case Source.ON_US_PAY_ME:
                case Source.LOAN_PRINCIPAL_PAYMENT:
                case Source.LOAN_REPAYMENT:
                case Source.LOAN_OVERPAYMENT:
                case Source.LOAN_LATE_PAYMENT:
                case Source.LOAN_FEE_PAYMENT:
                case Source.SEPA_CREDIT_TRANSFER:
                case Source.SEPA_DIRECT_DEBIT:
                case Source.TARGET2_CUSTOMER_PAYMENT:
                case Source.FX_TRANSFER:
                case Source.ISS_PAYMENT:
                case Source.STARLING_PAYMENT:
                case Source.SUBSCRIPTION_CHARGE:
                case Source.OVERDRAFT_FEE:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Source values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Source values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Source> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into Source value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Source value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type Source</exception>
        public static Source ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Source");
            return (Source)index;
        }
    }
}
