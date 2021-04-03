using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <exclude />
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Currency
    {
        UNDEFINED,
        AED,
        AFN,
        ALL,
        AMD,
        ANG,
        AOA,
        ARS,
        AUD,
        AWG,
        AZN,
        BAM,
        BBD,
        BDT,
        BGN,
        BHD,
        BIF,
        BMD,
        BND,
        BOB,
        BOV,
        BRL,
        BSD,
        BTN,
        BWP,
        BYN,
        BYR,
        BZD,
        CAD,
        CDF,
        CHE,
        CHF,
        CHW,
        CLF,
        CLP,
        CNY,
        COP,
        COU,
        CRC,
        CUC,
        CUP,
        CVE,
        CZK,
        DJF,
        DKK,
        DOP,
        DZD,
        EGP,
        ERN,
        ETB,
        EUR,
        FJD,
        FKP,
        GBP,
        GEL,
        GHS,
        GIP,
        GMD,
        GNF,
        GTQ,
        GYD,
        HKD,
        HNL,
        HRK,
        HTG,
        HUF,
        IDR,
        ILS,
        INR,
        IQD,
        IRR,
        ISK,
        JMD,
        JOD,
        JPY,
        KES,
        KGS,
        KHR,
        KMF,
        KPW,
        KRW,
        KWD,
        KYD,
        KZT,
        LAK,
        LBP,
        LKR,
        LRD,
        LSL,
        LTL,
        LYD,
        MAD,
        MDL,
        MGA,
        MKD,
        MMK,
        MNT,
        MOP,
        MRO,
        MRU,
        MUR,
        MVR,
        MWK,
        MXN,
        MXV,
        MYR,
        MZN,
        NAD,
        NGN,
        NIO,
        NOK,
        NPR,
        NZD,
        OMR,
        PAB,
        PEN,
        PGK,
        PHP,
        PKR,
        PLN,
        PYG,
        QAR,
        RON,
        RSD,
        RUB,
        RUR,
        RWF,
        SAR,
        SBD,
        SCR,
        SDG,
        SEK,
        SGD,
        SHP,
        SLL,
        SOS,
        SRD,
        SSP,
        STD,
        STN,
        SVC,
        SYP,
        SZL,
        THB,
        TJS,
        TMT,
        TND,
        TOP,
        TRY,
        TTD,
        TWD,
        TZS,
        UAH,
        UGX,
        USD,
        USN,
        USS,
        UYI,
        UYU,
        UZS,
        VEF,
        VES,
        VND,
        VUV,
        WST,
        XAF,
        XAG,
        XAU,
        XBA,
        XBB,
        XBC,
        XBD,
        XCD,
        XDR,
        XOF,
        XPD,
        XPF,
        XPT,
        XSU,
        XTS,
        XUA,
        XXX,
        YER,
        ZAR,
        ZMW,
        ZWL
    }

    /// <summary>
    /// Helper for the enum type Currency
    /// </summary>
    public static class CurrencyHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string>
        {
            "UNDEFINED",
            "AED",
            "AFN",
            "ALL",
            "AMD",
            "ANG",
            "AOA",
            "ARS",
            "AUD",
            "AWG",
            "AZN",
            "BAM",
            "BBD",
            "BDT",
            "BGN",
            "BHD",
            "BIF",
            "BMD",
            "BND",
            "BOB",
            "BOV",
            "BRL",
            "BSD",
            "BTN",
            "BWP",
            "BYN",
            "BYR",
            "BZD",
            "CAD",
            "CDF",
            "CHE",
            "CHF",
            "CHW",
            "CLF",
            "CLP",
            "CNY",
            "COP",
            "COU",
            "CRC",
            "CUC",
            "CUP",
            "CVE",
            "CZK",
            "DJF",
            "DKK",
            "DOP",
            "DZD",
            "EGP",
            "ERN",
            "ETB",
            "EUR",
            "FJD",
            "FKP",
            "GBP",
            "GEL",
            "GHS",
            "GIP",
            "GMD",
            "GNF",
            "GTQ",
            "GYD",
            "HKD",
            "HNL",
            "HRK",
            "HTG",
            "HUF",
            "IDR",
            "ILS",
            "INR",
            "IQD",
            "IRR",
            "ISK",
            "JMD",
            "JOD",
            "JPY",
            "KES",
            "KGS",
            "KHR",
            "KMF",
            "KPW",
            "KRW",
            "KWD",
            "KYD",
            "KZT",
            "LAK",
            "LBP",
            "LKR",
            "LRD",
            "LSL",
            "LTL",
            "LYD",
            "MAD",
            "MDL",
            "MGA",
            "MKD",
            "MMK",
            "MNT",
            "MOP",
            "MRO",
            "MRU",
            "MUR",
            "MVR",
            "MWK",
            "MXN",
            "MXV",
            "MYR",
            "MZN",
            "NAD",
            "NGN",
            "NIO",
            "NOK",
            "NPR",
            "NZD",
            "OMR",
            "PAB",
            "PEN",
            "PGK",
            "PHP",
            "PKR",
            "PLN",
            "PYG",
            "QAR",
            "RON",
            "RSD",
            "RUB",
            "RUR",
            "RWF",
            "SAR",
            "SBD",
            "SCR",
            "SDG",
            "SEK",
            "SGD",
            "SHP",
            "SLL",
            "SOS",
            "SRD",
            "SSP",
            "STD",
            "STN",
            "SVC",
            "SYP",
            "SZL",
            "THB",
            "TJS",
            "TMT",
            "TND",
            "TOP",
            "TRY",
            "TTD",
            "TWD",
            "TZS",
            "UAH",
            "UGX",
            "USD",
            "USN",
            "USS",
            "UYI",
            "UYU",
            "UZS",
            "VEF",
            "VES",
            "VND",
            "VUV",
            "WST",
            "XAF",
            "XAG",
            "XAU",
            "XBA",
            "XBB",
            "XBC",
            "XBD",
            "XCD",
            "XDR",
            "XOF",
            "XPD",
            "XPF",
            "XPT",
            "XSU",
            "XTS",
            "XUA",
            "XXX",
            "YER",
            "ZAR",
            "ZMW",
            "ZWL"
        };

        /// <summary>
        /// Converts a Currency value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Currency value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Currency enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Currency.UNDEFINED:
                case Currency.AED:
                case Currency.AFN:
                case Currency.ALL:
                case Currency.AMD:
                case Currency.ANG:
                case Currency.AOA:
                case Currency.ARS:
                case Currency.AUD:
                case Currency.AWG:
                case Currency.AZN:
                case Currency.BAM:
                case Currency.BBD:
                case Currency.BDT:
                case Currency.BGN:
                case Currency.BHD:
                case Currency.BIF:
                case Currency.BMD:
                case Currency.BND:
                case Currency.BOB:
                case Currency.BOV:
                case Currency.BRL:
                case Currency.BSD:
                case Currency.BTN:
                case Currency.BWP:
                case Currency.BYN:
                case Currency.BYR:
                case Currency.BZD:
                case Currency.CAD:
                case Currency.CDF:
                case Currency.CHE:
                case Currency.CHF:
                case Currency.CHW:
                case Currency.CLF:
                case Currency.CLP:
                case Currency.CNY:
                case Currency.COP:
                case Currency.COU:
                case Currency.CRC:
                case Currency.CUC:
                case Currency.CUP:
                case Currency.CVE:
                case Currency.CZK:
                case Currency.DJF:
                case Currency.DKK:
                case Currency.DOP:
                case Currency.DZD:
                case Currency.EGP:
                case Currency.ERN:
                case Currency.ETB:
                case Currency.EUR:
                case Currency.FJD:
                case Currency.FKP:
                case Currency.GBP:
                case Currency.GEL:
                case Currency.GHS:
                case Currency.GIP:
                case Currency.GMD:
                case Currency.GNF:
                case Currency.GTQ:
                case Currency.GYD:
                case Currency.HKD:
                case Currency.HNL:
                case Currency.HRK:
                case Currency.HTG:
                case Currency.HUF:
                case Currency.IDR:
                case Currency.ILS:
                case Currency.INR:
                case Currency.IQD:
                case Currency.IRR:
                case Currency.ISK:
                case Currency.JMD:
                case Currency.JOD:
                case Currency.JPY:
                case Currency.KES:
                case Currency.KGS:
                case Currency.KHR:
                case Currency.KMF:
                case Currency.KPW:
                case Currency.KRW:
                case Currency.KWD:
                case Currency.KYD:
                case Currency.KZT:
                case Currency.LAK:
                case Currency.LBP:
                case Currency.LKR:
                case Currency.LRD:
                case Currency.LSL:
                case Currency.LTL:
                case Currency.LYD:
                case Currency.MAD:
                case Currency.MDL:
                case Currency.MGA:
                case Currency.MKD:
                case Currency.MMK:
                case Currency.MNT:
                case Currency.MOP:
                case Currency.MRO:
                case Currency.MRU:
                case Currency.MUR:
                case Currency.MVR:
                case Currency.MWK:
                case Currency.MXN:
                case Currency.MXV:
                case Currency.MYR:
                case Currency.MZN:
                case Currency.NAD:
                case Currency.NGN:
                case Currency.NIO:
                case Currency.NOK:
                case Currency.NPR:
                case Currency.NZD:
                case Currency.OMR:
                case Currency.PAB:
                case Currency.PEN:
                case Currency.PGK:
                case Currency.PHP:
                case Currency.PKR:
                case Currency.PLN:
                case Currency.PYG:
                case Currency.QAR:
                case Currency.RON:
                case Currency.RSD:
                case Currency.RUB:
                case Currency.RUR:
                case Currency.RWF:
                case Currency.SAR:
                case Currency.SBD:
                case Currency.SCR:
                case Currency.SDG:
                case Currency.SEK:
                case Currency.SGD:
                case Currency.SHP:
                case Currency.SLL:
                case Currency.SOS:
                case Currency.SRD:
                case Currency.SSP:
                case Currency.STD:
                case Currency.STN:
                case Currency.SVC:
                case Currency.SYP:
                case Currency.SZL:
                case Currency.THB:
                case Currency.TJS:
                case Currency.TMT:
                case Currency.TND:
                case Currency.TOP:
                case Currency.TRY:
                case Currency.TTD:
                case Currency.TWD:
                case Currency.TZS:
                case Currency.UAH:
                case Currency.UGX:
                case Currency.USD:
                case Currency.USN:
                case Currency.USS:
                case Currency.UYI:
                case Currency.UYU:
                case Currency.UZS:
                case Currency.VEF:
                case Currency.VES:
                case Currency.VND:
                case Currency.VUV:
                case Currency.WST:
                case Currency.XAF:
                case Currency.XAG:
                case Currency.XAU:
                case Currency.XBA:
                case Currency.XBB:
                case Currency.XBC:
                case Currency.XBD:
                case Currency.XCD:
                case Currency.XDR:
                case Currency.XOF:
                case Currency.XPD:
                case Currency.XPF:
                case Currency.XPT:
                case Currency.XSU:
                case Currency.XTS:
                case Currency.XUA:
                case Currency.XXX:
                case Currency.YER:
                case Currency.ZAR:
                case Currency.ZMW:
                case Currency.ZWL:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Currency values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Currency values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Currency> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into Currency value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Currency value</returns>
        public static Currency ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Currency");
            return (Currency)index;
        }
    }
}
