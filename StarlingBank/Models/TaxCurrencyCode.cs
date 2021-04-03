using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <exclude />
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum TaxCurrencyCode
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
    /// Helper for the enum type TaxCurrencyCode
    /// </summary>
    public static class TaxCurrencyCodeHelper
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
        /// Converts a TaxCurrencyCode value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The TaxCurrencyCode value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(TaxCurrencyCode enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case TaxCurrencyCode.UNDEFINED:
                case TaxCurrencyCode.AED:
                case TaxCurrencyCode.AFN:
                case TaxCurrencyCode.ALL:
                case TaxCurrencyCode.AMD:
                case TaxCurrencyCode.ANG:
                case TaxCurrencyCode.AOA:
                case TaxCurrencyCode.ARS:
                case TaxCurrencyCode.AUD:
                case TaxCurrencyCode.AWG:
                case TaxCurrencyCode.AZN:
                case TaxCurrencyCode.BAM:
                case TaxCurrencyCode.BBD:
                case TaxCurrencyCode.BDT:
                case TaxCurrencyCode.BGN:
                case TaxCurrencyCode.BHD:
                case TaxCurrencyCode.BIF:
                case TaxCurrencyCode.BMD:
                case TaxCurrencyCode.BND:
                case TaxCurrencyCode.BOB:
                case TaxCurrencyCode.BOV:
                case TaxCurrencyCode.BRL:
                case TaxCurrencyCode.BSD:
                case TaxCurrencyCode.BTN:
                case TaxCurrencyCode.BWP:
                case TaxCurrencyCode.BYN:
                case TaxCurrencyCode.BYR:
                case TaxCurrencyCode.BZD:
                case TaxCurrencyCode.CAD:
                case TaxCurrencyCode.CDF:
                case TaxCurrencyCode.CHE:
                case TaxCurrencyCode.CHF:
                case TaxCurrencyCode.CHW:
                case TaxCurrencyCode.CLF:
                case TaxCurrencyCode.CLP:
                case TaxCurrencyCode.CNY:
                case TaxCurrencyCode.COP:
                case TaxCurrencyCode.COU:
                case TaxCurrencyCode.CRC:
                case TaxCurrencyCode.CUC:
                case TaxCurrencyCode.CUP:
                case TaxCurrencyCode.CVE:
                case TaxCurrencyCode.CZK:
                case TaxCurrencyCode.DJF:
                case TaxCurrencyCode.DKK:
                case TaxCurrencyCode.DOP:
                case TaxCurrencyCode.DZD:
                case TaxCurrencyCode.EGP:
                case TaxCurrencyCode.ERN:
                case TaxCurrencyCode.ETB:
                case TaxCurrencyCode.EUR:
                case TaxCurrencyCode.FJD:
                case TaxCurrencyCode.FKP:
                case TaxCurrencyCode.GBP:
                case TaxCurrencyCode.GEL:
                case TaxCurrencyCode.GHS:
                case TaxCurrencyCode.GIP:
                case TaxCurrencyCode.GMD:
                case TaxCurrencyCode.GNF:
                case TaxCurrencyCode.GTQ:
                case TaxCurrencyCode.GYD:
                case TaxCurrencyCode.HKD:
                case TaxCurrencyCode.HNL:
                case TaxCurrencyCode.HRK:
                case TaxCurrencyCode.HTG:
                case TaxCurrencyCode.HUF:
                case TaxCurrencyCode.IDR:
                case TaxCurrencyCode.ILS:
                case TaxCurrencyCode.INR:
                case TaxCurrencyCode.IQD:
                case TaxCurrencyCode.IRR:
                case TaxCurrencyCode.ISK:
                case TaxCurrencyCode.JMD:
                case TaxCurrencyCode.JOD:
                case TaxCurrencyCode.JPY:
                case TaxCurrencyCode.KES:
                case TaxCurrencyCode.KGS:
                case TaxCurrencyCode.KHR:
                case TaxCurrencyCode.KMF:
                case TaxCurrencyCode.KPW:
                case TaxCurrencyCode.KRW:
                case TaxCurrencyCode.KWD:
                case TaxCurrencyCode.KYD:
                case TaxCurrencyCode.KZT:
                case TaxCurrencyCode.LAK:
                case TaxCurrencyCode.LBP:
                case TaxCurrencyCode.LKR:
                case TaxCurrencyCode.LRD:
                case TaxCurrencyCode.LSL:
                case TaxCurrencyCode.LTL:
                case TaxCurrencyCode.LYD:
                case TaxCurrencyCode.MAD:
                case TaxCurrencyCode.MDL:
                case TaxCurrencyCode.MGA:
                case TaxCurrencyCode.MKD:
                case TaxCurrencyCode.MMK:
                case TaxCurrencyCode.MNT:
                case TaxCurrencyCode.MOP:
                case TaxCurrencyCode.MRO:
                case TaxCurrencyCode.MRU:
                case TaxCurrencyCode.MUR:
                case TaxCurrencyCode.MVR:
                case TaxCurrencyCode.MWK:
                case TaxCurrencyCode.MXN:
                case TaxCurrencyCode.MXV:
                case TaxCurrencyCode.MYR:
                case TaxCurrencyCode.MZN:
                case TaxCurrencyCode.NAD:
                case TaxCurrencyCode.NGN:
                case TaxCurrencyCode.NIO:
                case TaxCurrencyCode.NOK:
                case TaxCurrencyCode.NPR:
                case TaxCurrencyCode.NZD:
                case TaxCurrencyCode.OMR:
                case TaxCurrencyCode.PAB:
                case TaxCurrencyCode.PEN:
                case TaxCurrencyCode.PGK:
                case TaxCurrencyCode.PHP:
                case TaxCurrencyCode.PKR:
                case TaxCurrencyCode.PLN:
                case TaxCurrencyCode.PYG:
                case TaxCurrencyCode.QAR:
                case TaxCurrencyCode.RON:
                case TaxCurrencyCode.RSD:
                case TaxCurrencyCode.RUB:
                case TaxCurrencyCode.RUR:
                case TaxCurrencyCode.RWF:
                case TaxCurrencyCode.SAR:
                case TaxCurrencyCode.SBD:
                case TaxCurrencyCode.SCR:
                case TaxCurrencyCode.SDG:
                case TaxCurrencyCode.SEK:
                case TaxCurrencyCode.SGD:
                case TaxCurrencyCode.SHP:
                case TaxCurrencyCode.SLL:
                case TaxCurrencyCode.SOS:
                case TaxCurrencyCode.SRD:
                case TaxCurrencyCode.SSP:
                case TaxCurrencyCode.STD:
                case TaxCurrencyCode.STN:
                case TaxCurrencyCode.SVC:
                case TaxCurrencyCode.SYP:
                case TaxCurrencyCode.SZL:
                case TaxCurrencyCode.THB:
                case TaxCurrencyCode.TJS:
                case TaxCurrencyCode.TMT:
                case TaxCurrencyCode.TND:
                case TaxCurrencyCode.TOP:
                case TaxCurrencyCode.TRY:
                case TaxCurrencyCode.TTD:
                case TaxCurrencyCode.TWD:
                case TaxCurrencyCode.TZS:
                case TaxCurrencyCode.UAH:
                case TaxCurrencyCode.UGX:
                case TaxCurrencyCode.USD:
                case TaxCurrencyCode.USN:
                case TaxCurrencyCode.USS:
                case TaxCurrencyCode.UYI:
                case TaxCurrencyCode.UYU:
                case TaxCurrencyCode.UZS:
                case TaxCurrencyCode.VEF:
                case TaxCurrencyCode.VES:
                case TaxCurrencyCode.VND:
                case TaxCurrencyCode.VUV:
                case TaxCurrencyCode.WST:
                case TaxCurrencyCode.XAF:
                case TaxCurrencyCode.XAG:
                case TaxCurrencyCode.XAU:
                case TaxCurrencyCode.XBA:
                case TaxCurrencyCode.XBB:
                case TaxCurrencyCode.XBC:
                case TaxCurrencyCode.XBD:
                case TaxCurrencyCode.XCD:
                case TaxCurrencyCode.XDR:
                case TaxCurrencyCode.XOF:
                case TaxCurrencyCode.XPD:
                case TaxCurrencyCode.XPF:
                case TaxCurrencyCode.XPT:
                case TaxCurrencyCode.XSU:
                case TaxCurrencyCode.XTS:
                case TaxCurrencyCode.XUA:
                case TaxCurrencyCode.XXX:
                case TaxCurrencyCode.YER:
                case TaxCurrencyCode.ZAR:
                case TaxCurrencyCode.ZMW:
                case TaxCurrencyCode.ZWL:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of TaxCurrencyCode values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of TaxCurrencyCode values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<TaxCurrencyCode> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into TaxCurrencyCode value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed TaxCurrencyCode value</returns>
        public static TaxCurrencyCode ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type TaxCurrencyCode");
            return (TaxCurrencyCode)index;
        }
    }
}
