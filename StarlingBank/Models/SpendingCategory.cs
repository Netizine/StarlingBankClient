using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// SpendingCategoryEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum SpendingCategory
    {
        /// <summary>
        /// Bills and services
        /// </summary>
        BILLS_AND_SERVICES,

        /// <summary>
        /// Charity
        /// </summary>
        CHARITY,

        /// <summary>
        /// Eating out
        /// </summary>
        EATING_OUT,

        /// <summary>
        /// Entertainment
        /// </summary>
        ENTERTAINMENT,

        /// <summary>
        /// Expenses
        /// </summary>
        EXPENSES,

        /// <summary>
        /// Family
        /// </summary>
        FAMILY,

        /// <summary>
        /// Gambling
        /// </summary>
        GAMBLING,

        /// <summary>
        /// General
        /// </summary>
        GENERAL,

        /// <summary>
        /// Gifts
        /// </summary>
        GIFTS,

        /// <summary>
        /// Groceries
        /// </summary>
        GROCERIES,

        /// <summary>
        /// Home
        /// </summary>
        HOME,

        /// <summary>
        /// Income
        /// </summary>
        INCOME,

        /// <summary>
        /// Saving
        /// </summary>
        SAVING,

        /// <summary>
        /// The shopping
        /// </summary>
        SHOPPING,

        /// <summary>
        /// Holidays
        /// </summary>
        HOLIDAYS,

        /// <summary>
        /// Payments
        /// </summary>
        PAYMENTS,

        /// <summary>
        /// Pets
        /// </summary>
        PETS,

        /// <summary>
        /// Transport
        /// </summary>
        TRANSPORT,

        /// <summary>
        /// Lifestyle
        /// </summary>
        LIFESTYLE,

        /// <summary>
        /// None
        /// </summary>
        NONE,

        /// <summary>
        /// Revenue
        /// </summary>
        REVENUE,

        /// <summary>
        /// Other income
        /// </summary>
        OTHER_INCOME,

        /// <summary>
        /// Client refunds
        /// </summary>
        CLIENT_REFUNDS,

        /// <summary>
        /// Inventory
        /// </summary>
        INVENTORY,

        /// <summary>
        /// Staff
        /// </summary>
        STAFF,

        /// <summary>
        /// Travel
        /// </summary>
        TRAVEL,

        /// <summary>
        /// Workplace
        /// </summary>
        WORKPLACE,

        /// <summary>
        /// Repairs and maintenance
        /// </summary>
        REPAIRS_AND_MAINTENANCE,

        /// <summary>
        /// Admin
        /// </summary>
        ADMIN,

        /// <summary>
        /// Marketing
        /// </summary>
        MARKETING,

        /// <summary>
        /// Business entertainment
        /// </summary>
        BUSINESS_ENTERTAINMENT,

        /// <summary>
        /// Interest payments
        /// </summary>
        INTEREST_PAYMENTS,

        /// <summary>
        /// Bank charges
        /// </summary>
        BANK_CHARGES,

        /// <summary>
        /// Other
        /// </summary>
        OTHER,

        /// <summary>
        /// Food and drink
        /// </summary>
        FOOD_AND_DRINK,

        /// <summary>
        /// Equipment
        /// </summary>
        EQUIPMENT,

        /// <summary>
        /// Professional services
        /// </summary>
        PROFESSIONAL_SERVICES,

        /// <summary>
        /// Phone and internet
        /// </summary>
        PHONE_AND_INTERNET,

        /// <summary>
        /// Vehicles
        /// </summary>
        VEHICLES,

        /// <summary>
        /// Directors wages
        /// </summary>
        DIRECTORS_WAGES,

        /// <summary>
        /// VAT
        /// </summary>
        VAT,

        /// <summary>
        /// Corporation tax
        /// </summary>
        CORPORATION_TAX,

        /// <summary>
        /// Self assessment tax
        /// </summary>
        SELF_ASSESSMENT_TAX,

        /// <summary>
        /// Investment capital
        /// </summary>
        INVESTMENT_CAPITAL,

        /// <summary>
        /// Transfers
        /// </summary>
        TRANSFERS,

        /// <summary>
        /// Loan principal
        /// </summary>
        LOAN_PRINCIPAL,

        /// <summary>
        /// Personal
        /// </summary>
        PERSONAL,

        /// <summary>
        /// Dividends
        /// </summary>
        DIVIDENDS
    }

    /// <summary>
    /// Helper for the enum type SpendingCategory
    /// </summary>
    public static class SpendingCategoryHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string>
        {
            "BILLS_AND_SERVICES",
            "CHARITY",
            "EATING_OUT",
            "ENTERTAINMENT",
            "EXPENSES",
            "FAMILY",
            "GAMBLING",
            "GENERAL",
            "GIFTS",
            "GROCERIES",
            "HOME",
            "INCOME",
            "SAVING",
            "SHOPPING",
            "HOLIDAYS",
            "PAYMENTS",
            "PETS",
            "TRANSPORT",
            "LIFESTYLE",
            "NONE",
            "REVENUE",
            "OTHER_INCOME",
            "CLIENT_REFUNDS",
            "INVENTORY",
            "STAFF",
            "TRAVEL",
            "WORKPLACE",
            "REPAIRS_AND_MAINTENANCE",
            "ADMIN",
            "MARKETING",
            "BUSINESS_ENTERTAINMENT",
            "INTEREST_PAYMENTS",
            "BANK_CHARGES",
            "OTHER",
            "FOOD_AND_DRINK",
            "EQUIPMENT",
            "PROFESSIONAL_SERVICES",
            "PHONE_AND_INTERNET",
            "VEHICLES",
            "DIRECTORS_WAGES",
            "VAT",
            "CORPORATION_TAX",
            "SELF_ASSESSMENT_TAX",
            "INVESTMENT_CAPITAL",
            "TRANSFERS",
            "LOAN_PRINCIPAL",
            "PERSONAL",
            "DIVIDENDS"
        };

        /// <summary>
        /// Converts a SpendingCategory value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The SpendingCategory value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(SpendingCategory enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case SpendingCategory.BILLS_AND_SERVICES:
                case SpendingCategory.CHARITY:
                case SpendingCategory.EATING_OUT:
                case SpendingCategory.ENTERTAINMENT:
                case SpendingCategory.EXPENSES:
                case SpendingCategory.FAMILY:
                case SpendingCategory.GAMBLING:
                case SpendingCategory.GENERAL:
                case SpendingCategory.GIFTS:
                case SpendingCategory.GROCERIES:
                case SpendingCategory.HOME:
                case SpendingCategory.INCOME:
                case SpendingCategory.SAVING:
                case SpendingCategory.SHOPPING:
                case SpendingCategory.HOLIDAYS:
                case SpendingCategory.PAYMENTS:
                case SpendingCategory.PETS:
                case SpendingCategory.TRANSPORT:
                case SpendingCategory.LIFESTYLE:
                case SpendingCategory.NONE:
                case SpendingCategory.REVENUE:
                case SpendingCategory.OTHER_INCOME:
                case SpendingCategory.CLIENT_REFUNDS:
                case SpendingCategory.INVENTORY:
                case SpendingCategory.STAFF:
                case SpendingCategory.TRAVEL:
                case SpendingCategory.WORKPLACE:
                case SpendingCategory.REPAIRS_AND_MAINTENANCE:
                case SpendingCategory.ADMIN:
                case SpendingCategory.MARKETING:
                case SpendingCategory.BUSINESS_ENTERTAINMENT:
                case SpendingCategory.INTEREST_PAYMENTS:
                case SpendingCategory.BANK_CHARGES:
                case SpendingCategory.OTHER:
                case SpendingCategory.FOOD_AND_DRINK:
                case SpendingCategory.EQUIPMENT:
                case SpendingCategory.PROFESSIONAL_SERVICES:
                case SpendingCategory.PHONE_AND_INTERNET:
                case SpendingCategory.VEHICLES:
                case SpendingCategory.DIRECTORS_WAGES:
                case SpendingCategory.VAT:
                case SpendingCategory.CORPORATION_TAX:
                case SpendingCategory.SELF_ASSESSMENT_TAX:
                case SpendingCategory.INVESTMENT_CAPITAL:
                case SpendingCategory.TRANSFERS:
                case SpendingCategory.LOAN_PRINCIPAL:
                case SpendingCategory.PERSONAL:
                case SpendingCategory.DIVIDENDS:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of SpendingCategory values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of SpendingCategory values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<SpendingCategory> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into SpendingCategory value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed SpendingCategory value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type SpendingCategory</exception>
        public static SpendingCategory ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type SpendingCategory");
            return (SpendingCategory)index;
        }
    }
}
