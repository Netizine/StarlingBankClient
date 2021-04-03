using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// BusinessCategoryEnum
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum BusinessCategory
    {
        /// <summary>
        /// Not provided
        /// </summary>
        NOT_PROVIDED,

        /// <summary>
        /// Arts crafts and collectibles
        /// </summary>
        ARTS_CRAFTS_AND_COLLECTIBLES,

        /// <summary>
        /// Baby
        /// </summary>
        BABY,

        /// <summary>
        /// Beauty and fragrances
        /// </summary>
        BEAUTY_AND_FRAGRANCES,

        /// <summary>
        /// Books and magazines
        /// </summary>
        BOOKS_AND_MAGAZINES,

        /// <summary>
        /// Business to business
        /// </summary>
        BUSINESS_TO_BUSINESS,

        /// <summary>
        /// Clothing accessories and shoes
        /// </summary>
        CLOTHING_ACCESSORIES_AND_SHOES,

        /// <summary>
        /// Computers accessories and services
        /// </summary>
        COMPUTERS_ACCESSORIES_AND_SERVICES,

        /// <summary>
        /// Education
        /// </summary>
        EDUCATION,

        /// <summary>
        /// Electronics and telecom
        /// </summary>
        ELECTRONICS_AND_TELECOM,

        /// <summary>
        /// Entertainment and media
        /// </summary>
        ENTERTAINMENT_AND_MEDIA,

        /// <summary>
        /// Financial services and products
        /// </summary>
        FINANCIAL_SERVICES_AND_PRODUCTS,

        /// <summary>
        /// Food retail and service
        /// </summary>
        FOOD_RETAIL_AND_SERVICE,

        /// <summary>
        /// Gifts and flowers
        /// </summary>
        GIFTS_AND_FLOWERS,

        /// <summary>
        /// Health and personal care
        /// </summary>
        HEALTH_AND_PERSONAL_CARE,

        /// <summary>
        /// Home and garden
        /// </summary>
        HOME_AND_GARDEN,

        /// <summary>
        /// Nonprofit
        /// </summary>
        NONPROFIT,

        /// <summary>
        /// Pets and animals
        /// </summary>
        PETS_AND_ANIMALS,

        /// <summary>
        /// Religion and spirituality for profit
        /// </summary>
        RELIGION_AND_SPIRITUALITY_FOR_PROFIT,

        /// <summary>
        /// Retail not elsewhere classified
        /// </summary>
        RETAIL_NOT_ELSEWHERE_CLASSIFIED,

        /// <summary>
        /// Services other
        /// </summary>
        SERVICES_OTHER,

        /// <summary>
        /// Sports and outdoors
        /// </summary>
        SPORTS_AND_OUTDOORS,

        /// <summary>
        /// Toys and hobbies
        /// </summary>
        TOYS_AND_HOBBIES,

        /// <summary>
        /// Travel
        /// </summary>
        TRAVEL,

        /// <summary>
        /// Vehicle service and accessories
        /// </summary>
        VEHICLE_SERVICE_AND_ACCESSORIES,

        /// <summary>
        /// Professional services
        /// </summary>
        PROFESSIONAL_SERVICES,

        /// <summary>
        /// Retail bars and restaurants
        /// </summary>
        RETAIL_BARS_AND_RESTAURANTS,

        /// <summary>
        /// Entertainment and travel
        /// </summary>
        ENTERTAINMENT_AND_TRAVEL,

        /// <summary>
        /// Health and social care
        /// </summary>
        HEALTH_AND_SOCIAL_CARE,

        /// <summary>
        /// Transport and vehicles
        /// </summary>
        TRANSPORT_AND_VEHICLES,

        /// <summary>
        /// Construction trades and cleaning
        /// </summary>
        CONSTRUCTION_TRADES_AND_CLEANING,

        /// <summary>
        /// Property
        /// </summary>
        PROPERTY,

        /// <summary>
        /// Exercise and fitness
        /// </summary>
        EXERCISE_AND_FITNESS,

        /// <summary>
        /// Education and skills
        /// </summary>
        EDUCATION_AND_SKILLS,

        /// <summary>
        /// Non profit
        /// </summary>
        NON_PROFIT1,

        /// <summary>
        /// The manufacturing random and agriculture
        /// </summary>
        MANUFACTURING_RND_AND_AGRICULTURE
    }

    /// <summary>
    /// Helper for the enum type BusinessCategory
    /// </summary>
    public static class BusinessCategoryHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// String values
        /// </summary>
        private static readonly List<string> StringValues = new List<string>
        {
            "NOT_PROVIDED",
            "ARTS_CRAFTS_AND_COLLECTIBLES",
            "BABY",
            "BEAUTY_AND_FRAGRANCES",
            "BOOKS_AND_MAGAZINES",
            "BUSINESS_TO_BUSINESS",
            "CLOTHING_ACCESSORIES_AND_SHOES",
            "COMPUTERS_ACCESSORIES_AND_SERVICES",
            "EDUCATION",
            "ELECTRONICS_AND_TELECOM",
            "ENTERTAINMENT_AND_MEDIA",
            "FINANCIAL_SERVICES_AND_PRODUCTS",
            "FOOD_RETAIL_AND_SERVICE",
            "GIFTS_AND_FLOWERS",
            "HEALTH_AND_PERSONAL_CARE",
            "HOME_AND_GARDEN",
            "NONPROFIT",
            "PETS_AND_ANIMALS",
            "RELIGION_AND_SPIRITUALITY_FOR_PROFIT",
            "RETAIL_NOT_ELSEWHERE_CLASSIFIED",
            "SERVICES_OTHER",
            "SPORTS_AND_OUTDOORS",
            "TOYS_AND_HOBBIES",
            "TRAVEL",
            "VEHICLE_SERVICE_AND_ACCESSORIES",
            "PROFESSIONAL_SERVICES",
            "RETAIL_BARS_AND_RESTAURANTS",
            "ENTERTAINMENT_AND_TRAVEL",
            "HEALTH_AND_SOCIAL_CARE",
            "TRANSPORT_AND_VEHICLES",
            "CONSTRUCTION_TRADES_AND_CLEANING",
            "PROPERTY",
            "EXERCISE_AND_FITNESS",
            "EDUCATION_AND_SKILLS",
            "NON_PROFIT",
            "MANUFACTURING_RND_AND_AGRICULTURE"
        };

        /// <summary>
        /// Converts a BusinessCategory value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The BusinessCategory value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(BusinessCategory enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case BusinessCategory.NOT_PROVIDED:
                case BusinessCategory.ARTS_CRAFTS_AND_COLLECTIBLES:
                case BusinessCategory.BABY:
                case BusinessCategory.BEAUTY_AND_FRAGRANCES:
                case BusinessCategory.BOOKS_AND_MAGAZINES:
                case BusinessCategory.BUSINESS_TO_BUSINESS:
                case BusinessCategory.CLOTHING_ACCESSORIES_AND_SHOES:
                case BusinessCategory.COMPUTERS_ACCESSORIES_AND_SERVICES:
                case BusinessCategory.EDUCATION:
                case BusinessCategory.ELECTRONICS_AND_TELECOM:
                case BusinessCategory.ENTERTAINMENT_AND_MEDIA:
                case BusinessCategory.FINANCIAL_SERVICES_AND_PRODUCTS:
                case BusinessCategory.FOOD_RETAIL_AND_SERVICE:
                case BusinessCategory.GIFTS_AND_FLOWERS:
                case BusinessCategory.HEALTH_AND_PERSONAL_CARE:
                case BusinessCategory.HOME_AND_GARDEN:
                case BusinessCategory.NONPROFIT:
                case BusinessCategory.PETS_AND_ANIMALS:
                case BusinessCategory.RELIGION_AND_SPIRITUALITY_FOR_PROFIT:
                case BusinessCategory.RETAIL_NOT_ELSEWHERE_CLASSIFIED:
                case BusinessCategory.SERVICES_OTHER:
                case BusinessCategory.SPORTS_AND_OUTDOORS:
                case BusinessCategory.TOYS_AND_HOBBIES:
                case BusinessCategory.TRAVEL:
                case BusinessCategory.VEHICLE_SERVICE_AND_ACCESSORIES:
                case BusinessCategory.PROFESSIONAL_SERVICES:
                case BusinessCategory.RETAIL_BARS_AND_RESTAURANTS:
                case BusinessCategory.ENTERTAINMENT_AND_TRAVEL:
                case BusinessCategory.HEALTH_AND_SOCIAL_CARE:
                case BusinessCategory.TRANSPORT_AND_VEHICLES:
                case BusinessCategory.CONSTRUCTION_TRADES_AND_CLEANING:
                case BusinessCategory.PROPERTY:
                case BusinessCategory.EXERCISE_AND_FITNESS:
                case BusinessCategory.EDUCATION_AND_SKILLS:
                case BusinessCategory.NON_PROFIT1:
                case BusinessCategory.MANUFACTURING_RND_AND_AGRICULTURE:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of BusinessCategory values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of BusinessCategory values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<BusinessCategory> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into BusinessCategory value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed BusinessCategory value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type BusinessCategory</exception>
        public static BusinessCategory ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type BusinessCategory");
            return (BusinessCategory)index;
        }
    }
}
