using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <exclude />
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum CurrencyCode
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
    /// Helper for the enum type CurrencyCode
    /// </summary>
    public static class CurrencyCodeHelper
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
        /// Converts a CurrencyCode value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The CurrencyCode value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(CurrencyCode enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case CurrencyCode.UNDEFINED:
                case CurrencyCode.AED:
                case CurrencyCode.AFN:
                case CurrencyCode.ALL:
                case CurrencyCode.AMD:
                case CurrencyCode.ANG:
                case CurrencyCode.AOA:
                case CurrencyCode.ARS:
                case CurrencyCode.AUD:
                case CurrencyCode.AWG:
                case CurrencyCode.AZN:
                case CurrencyCode.BAM:
                case CurrencyCode.BBD:
                case CurrencyCode.BDT:
                case CurrencyCode.BGN:
                case CurrencyCode.BHD:
                case CurrencyCode.BIF:
                case CurrencyCode.BMD:
                case CurrencyCode.BND:
                case CurrencyCode.BOB:
                case CurrencyCode.BOV:
                case CurrencyCode.BRL:
                case CurrencyCode.BSD:
                case CurrencyCode.BTN:
                case CurrencyCode.BWP:
                case CurrencyCode.BYN:
                case CurrencyCode.BYR:
                case CurrencyCode.BZD:
                case CurrencyCode.CAD:
                case CurrencyCode.CDF:
                case CurrencyCode.CHE:
                case CurrencyCode.CHF:
                case CurrencyCode.CHW:
                case CurrencyCode.CLF:
                case CurrencyCode.CLP:
                case CurrencyCode.CNY:
                case CurrencyCode.COP:
                case CurrencyCode.COU:
                case CurrencyCode.CRC:
                case CurrencyCode.CUC:
                case CurrencyCode.CUP:
                case CurrencyCode.CVE:
                case CurrencyCode.CZK:
                case CurrencyCode.DJF:
                case CurrencyCode.DKK:
                case CurrencyCode.DOP:
                case CurrencyCode.DZD:
                case CurrencyCode.EGP:
                case CurrencyCode.ERN:
                case CurrencyCode.ETB:
                case CurrencyCode.EUR:
                case CurrencyCode.FJD:
                case CurrencyCode.FKP:
                case CurrencyCode.GBP:
                case CurrencyCode.GEL:
                case CurrencyCode.GHS:
                case CurrencyCode.GIP:
                case CurrencyCode.GMD:
                case CurrencyCode.GNF:
                case CurrencyCode.GTQ:
                case CurrencyCode.GYD:
                case CurrencyCode.HKD:
                case CurrencyCode.HNL:
                case CurrencyCode.HRK:
                case CurrencyCode.HTG:
                case CurrencyCode.HUF:
                case CurrencyCode.IDR:
                case CurrencyCode.ILS:
                case CurrencyCode.INR:
                case CurrencyCode.IQD:
                case CurrencyCode.IRR:
                case CurrencyCode.ISK:
                case CurrencyCode.JMD:
                case CurrencyCode.JOD:
                case CurrencyCode.JPY:
                case CurrencyCode.KES:
                case CurrencyCode.KGS:
                case CurrencyCode.KHR:
                case CurrencyCode.KMF:
                case CurrencyCode.KPW:
                case CurrencyCode.KRW:
                case CurrencyCode.KWD:
                case CurrencyCode.KYD:
                case CurrencyCode.KZT:
                case CurrencyCode.LAK:
                case CurrencyCode.LBP:
                case CurrencyCode.LKR:
                case CurrencyCode.LRD:
                case CurrencyCode.LSL:
                case CurrencyCode.LTL:
                case CurrencyCode.LYD:
                case CurrencyCode.MAD:
                case CurrencyCode.MDL:
                case CurrencyCode.MGA:
                case CurrencyCode.MKD:
                case CurrencyCode.MMK:
                case CurrencyCode.MNT:
                case CurrencyCode.MOP:
                case CurrencyCode.MRO:
                case CurrencyCode.MRU:
                case CurrencyCode.MUR:
                case CurrencyCode.MVR:
                case CurrencyCode.MWK:
                case CurrencyCode.MXN:
                case CurrencyCode.MXV:
                case CurrencyCode.MYR:
                case CurrencyCode.MZN:
                case CurrencyCode.NAD:
                case CurrencyCode.NGN:
                case CurrencyCode.NIO:
                case CurrencyCode.NOK:
                case CurrencyCode.NPR:
                case CurrencyCode.NZD:
                case CurrencyCode.OMR:
                case CurrencyCode.PAB:
                case CurrencyCode.PEN:
                case CurrencyCode.PGK:
                case CurrencyCode.PHP:
                case CurrencyCode.PKR:
                case CurrencyCode.PLN:
                case CurrencyCode.PYG:
                case CurrencyCode.QAR:
                case CurrencyCode.RON:
                case CurrencyCode.RSD:
                case CurrencyCode.RUB:
                case CurrencyCode.RUR:
                case CurrencyCode.RWF:
                case CurrencyCode.SAR:
                case CurrencyCode.SBD:
                case CurrencyCode.SCR:
                case CurrencyCode.SDG:
                case CurrencyCode.SEK:
                case CurrencyCode.SGD:
                case CurrencyCode.SHP:
                case CurrencyCode.SLL:
                case CurrencyCode.SOS:
                case CurrencyCode.SRD:
                case CurrencyCode.SSP:
                case CurrencyCode.STD:
                case CurrencyCode.STN:
                case CurrencyCode.SVC:
                case CurrencyCode.SYP:
                case CurrencyCode.SZL:
                case CurrencyCode.THB:
                case CurrencyCode.TJS:
                case CurrencyCode.TMT:
                case CurrencyCode.TND:
                case CurrencyCode.TOP:
                case CurrencyCode.TRY:
                case CurrencyCode.TTD:
                case CurrencyCode.TWD:
                case CurrencyCode.TZS:
                case CurrencyCode.UAH:
                case CurrencyCode.UGX:
                case CurrencyCode.USD:
                case CurrencyCode.USN:
                case CurrencyCode.USS:
                case CurrencyCode.UYI:
                case CurrencyCode.UYU:
                case CurrencyCode.UZS:
                case CurrencyCode.VEF:
                case CurrencyCode.VES:
                case CurrencyCode.VND:
                case CurrencyCode.VUV:
                case CurrencyCode.WST:
                case CurrencyCode.XAF:
                case CurrencyCode.XAG:
                case CurrencyCode.XAU:
                case CurrencyCode.XBA:
                case CurrencyCode.XBB:
                case CurrencyCode.XBC:
                case CurrencyCode.XBD:
                case CurrencyCode.XCD:
                case CurrencyCode.XDR:
                case CurrencyCode.XOF:
                case CurrencyCode.XPD:
                case CurrencyCode.XPF:
                case CurrencyCode.XPT:
                case CurrencyCode.XSU:
                case CurrencyCode.XTS:
                case CurrencyCode.XUA:
                case CurrencyCode.XXX:
                case CurrencyCode.YER:
                case CurrencyCode.ZAR:
                case CurrencyCode.ZMW:
                case CurrencyCode.ZWL:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of CurrencyCode values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of CurrencyCode values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<CurrencyCode> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into CurrencyCode value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed CurrencyCode value</returns>
        public static CurrencyCode ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type CurrencyCode");
            return (CurrencyCode)index;
        }
    }
}
