using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <exclude />
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum CountryCode
    {
        UNDEFINED,
        AC,
        AD,
        AE,
        AF,
        AG,
        AI,
        AL,
        AM,
        AN,
        AO,
        AQ,
        AR,
        AS,
        AT,
        AU,
        AW,
        AX,
        AZ,
        BA,
        BB,
        BD,
        BE,
        BF,
        BG,
        BH,
        BI,
        BJ,
        BL,
        BM,
        BN,
        BO,
        BQ,
        BR,
        BS,
        BT,
        BU,
        BV,
        BW,
        BY,
        BZ,
        CA,
        CC,
        CD,
        CF,
        CG,
        CH,
        CI,
        CK,
        CL,
        CM,
        CN,
        CO,
        CP,
        CR,
        CS,
        CU,
        CV,
        CW,
        CX,
        CY,
        CZ,
        DE,
        DG,
        DJ,
        DK,
        DM,
        DO,
        DZ,
        EA,
        EC,
        EE,
        EG,
        EH,
        ER,
        ES,
        ET,
        EU,
        EZ,
        FI,
        FJ,
        FK,
        FM,
        FO,
        FR,
        FX,
        GA,
        GB,
        GD,
        GE,
        GF,
        GG,
        GH,
        GI,
        GL,
        GM,
        GN,
        GP,
        GQ,
        GR,
        GS,
        GT,
        GU,
        GW,
        GY,
        HK,
        HM,
        HN,
        HR,
        HT,
        HU,
        IC,
        ID,
        IE,
        IL,
        IM,
        IN,
        IO,
        IQ,
        IR,
        IS,
        IT,
        JE,
        JM,
        JO,
        JP,
        KE,
        KG,
        KH,
        KI,
        KM,
        KN,
        KP,
        KR,
        KW,
        KY,
        KZ,
        LA,
        LB,
        LC,
        LI,
        LK,
        LR,
        LS,
        LT,
        LU,
        LV,
        LY,
        MA,
        MC,
        MD,
        ME,
        MF,
        MG,
        MH,
        MK,
        ML,
        MM,
        MN,
        MO,
        MP,
        MQ,
        MR,
        MS,
        MT,
        MU,
        MV,
        MW,
        MX,
        MY,
        MZ,
        NA,
        NC,
        NE,
        NF,
        NG,
        NI,
        NL,
        NO,
        NP,
        NR,
        NT,
        NU,
        NZ,
        OM,
        PA,
        PE,
        PF,
        PG,
        PH,
        PK,
        PL,
        PM,
        PN,
        PR,
        PS,
        PT,
        PW,
        PY,
        QA,
        RE,
        RO,
        RS,
        RU,
        RW,
        SA,
        SB,
        SC,
        SD,
        SE,
        SF,
        SG,
        SH,
        SI,
        SJ,
        SK,
        SL,
        SM,
        SN,
        SO,
        SR,
        SS,
        ST,
        SU,
        SV,
        SX,
        SY,
        SZ,
        TA,
        TC,
        TD,
        TF,
        TG,
        TH,
        TJ,
        TK,
        TL,
        TM,
        TN,
        TO,
        TP,
        TR,
        TT,
        TV,
        TW,
        TZ,
        UA,
        UG,
        UK,
        UM,
        US,
        UY,
        UZ,
        VA,
        VC,
        VE,
        VG,
        VI,
        VN,
        VU,
        WF,
        WS,
        XK,
        YE,
        YT,

        /// <summary>
        /// The yu
        /// </summary>
        YU,

        /// <summary>
        /// The za
        /// </summary>
        ZA,

        /// <summary>
        /// The zm
        /// </summary>
        ZM,

        /// <summary>
        /// The zr
        /// </summary>
        ZR,

        /// <summary>
        /// The zw
        /// </summary>
        ZW
    }

    /// <summary>
    /// Helper for the enum type CountryCode
    /// </summary>
    public static class CountryCodeHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// The string values
        /// </summary>
        private static readonly List<string> StringValues = new List<string>
        {
            "UNDEFINED",
            "AC",
            "AD",
            "AE",
            "AF",
            "AG",
            "AI",
            "AL",
            "AM",
            "AN",
            "AO",
            "AQ",
            "AR",
            "AS",
            "AT",
            "AU",
            "AW",
            "AX",
            "AZ",
            "BA",
            "BB",
            "BD",
            "BE",
            "BF",
            "BG",
            "BH",
            "BI",
            "BJ",
            "BL",
            "BM",
            "BN",
            "BO",
            "BQ",
            "BR",
            "BS",
            "BT",
            "BU",
            "BV",
            "BW",
            "BY",
            "BZ",
            "CA",
            "CC",
            "CD",
            "CF",
            "CG",
            "CH",
            "CI",
            "CK",
            "CL",
            "CM",
            "CN",
            "CO",
            "CP",
            "CR",
            "CS",
            "CU",
            "CV",
            "CW",
            "CX",
            "CY",
            "CZ",
            "DE",
            "DG",
            "DJ",
            "DK",
            "DM",
            "DO",
            "DZ",
            "EA",
            "EC",
            "EE",
            "EG",
            "EH",
            "ER",
            "ES",
            "ET",
            "EU",
            "EZ",
            "FI",
            "FJ",
            "FK",
            "FM",
            "FO",
            "FR",
            "FX",
            "GA",
            "GB",
            "GD",
            "GE",
            "GF",
            "GG",
            "GH",
            "GI",
            "GL",
            "GM",
            "GN",
            "GP",
            "GQ",
            "GR",
            "GS",
            "GT",
            "GU",
            "GW",
            "GY",
            "HK",
            "HM",
            "HN",
            "HR",
            "HT",
            "HU",
            "IC",
            "ID",
            "IE",
            "IL",
            "IM",
            "IN",
            "IO",
            "IQ",
            "IR",
            "IS",
            "IT",
            "JE",
            "JM",
            "JO",
            "JP",
            "KE",
            "KG",
            "KH",
            "KI",
            "KM",
            "KN",
            "KP",
            "KR",
            "KW",
            "KY",
            "KZ",
            "LA",
            "LB",
            "LC",
            "LI",
            "LK",
            "LR",
            "LS",
            "LT",
            "LU",
            "LV",
            "LY",
            "MA",
            "MC",
            "MD",
            "ME",
            "MF",
            "MG",
            "MH",
            "MK",
            "ML",
            "MM",
            "MN",
            "MO",
            "MP",
            "MQ",
            "MR",
            "MS",
            "MT",
            "MU",
            "MV",
            "MW",
            "MX",
            "MY",
            "MZ",
            "NA",
            "NC",
            "NE",
            "NF",
            "NG",
            "NI",
            "NL",
            "NO",
            "NP",
            "NR",
            "NT",
            "NU",
            "NZ",
            "OM",
            "PA",
            "PE",
            "PF",
            "PG",
            "PH",
            "PK",
            "PL",
            "PM",
            "PN",
            "PR",
            "PS",
            "PT",
            "PW",
            "PY",
            "QA",
            "RE",
            "RO",
            "RS",
            "RU",
            "RW",
            "SA",
            "SB",
            "SC",
            "SD",
            "SE",
            "SF",
            "SG",
            "SH",
            "SI",
            "SJ",
            "SK",
            "SL",
            "SM",
            "SN",
            "SO",
            "SR",
            "SS",
            "ST",
            "SU",
            "SV",
            "SX",
            "SY",
            "SZ",
            "TA",
            "TC",
            "TD",
            "TF",
            "TG",
            "TH",
            "TJ",
            "TK",
            "TL",
            "TM",
            "TN",
            "TO",
            "TP",
            "TR",
            "TT",
            "TV",
            "TW",
            "TZ",
            "UA",
            "UG",
            "UK",
            "UM",
            "US",
            "UY",
            "UZ",
            "VA",
            "VC",
            "VE",
            "VG",
            "VI",
            "VN",
            "VU",
            "WF",
            "WS",
            "XK",
            "YE",
            "YT",
            "YU",
            "ZA",
            "ZM",
            "ZR",
            "ZW"
        };

        /// <summary>
        /// Converts a CountryCode value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The CountryCode value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(CountryCode enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case CountryCode.UNDEFINED:
                case CountryCode.AC:
                case CountryCode.AD:
                case CountryCode.AE:
                case CountryCode.AF:
                case CountryCode.AG:
                case CountryCode.AI:
                case CountryCode.AL:
                case CountryCode.AM:
                case CountryCode.AN:
                case CountryCode.AO:
                case CountryCode.AQ:
                case CountryCode.AR:
                case CountryCode.AS:
                case CountryCode.AT:
                case CountryCode.AU:
                case CountryCode.AW:
                case CountryCode.AX:
                case CountryCode.AZ:
                case CountryCode.BA:
                case CountryCode.BB:
                case CountryCode.BD:
                case CountryCode.BE:
                case CountryCode.BF:
                case CountryCode.BG:
                case CountryCode.BH:
                case CountryCode.BI:
                case CountryCode.BJ:
                case CountryCode.BL:
                case CountryCode.BM:
                case CountryCode.BN:
                case CountryCode.BO:
                case CountryCode.BQ:
                case CountryCode.BR:
                case CountryCode.BS:
                case CountryCode.BT:
                case CountryCode.BU:
                case CountryCode.BV:
                case CountryCode.BW:
                case CountryCode.BY:
                case CountryCode.BZ:
                case CountryCode.CA:
                case CountryCode.CC:
                case CountryCode.CD:
                case CountryCode.CF:
                case CountryCode.CG:
                case CountryCode.CH:
                case CountryCode.CI:
                case CountryCode.CK:
                case CountryCode.CL:
                case CountryCode.CM:
                case CountryCode.CN:
                case CountryCode.CO:
                case CountryCode.CP:
                case CountryCode.CR:
                case CountryCode.CS:
                case CountryCode.CU:
                case CountryCode.CV:
                case CountryCode.CW:
                case CountryCode.CX:
                case CountryCode.CY:
                case CountryCode.CZ:
                case CountryCode.DE:
                case CountryCode.DG:
                case CountryCode.DJ:
                case CountryCode.DK:
                case CountryCode.DM:
                case CountryCode.DO:
                case CountryCode.DZ:
                case CountryCode.EA:
                case CountryCode.EC:
                case CountryCode.EE:
                case CountryCode.EG:
                case CountryCode.EH:
                case CountryCode.ER:
                case CountryCode.ES:
                case CountryCode.ET:
                case CountryCode.EU:
                case CountryCode.EZ:
                case CountryCode.FI:
                case CountryCode.FJ:
                case CountryCode.FK:
                case CountryCode.FM:
                case CountryCode.FO:
                case CountryCode.FR:
                case CountryCode.FX:
                case CountryCode.GA:
                case CountryCode.GB:
                case CountryCode.GD:
                case CountryCode.GE:
                case CountryCode.GF:
                case CountryCode.GG:
                case CountryCode.GH:
                case CountryCode.GI:
                case CountryCode.GL:
                case CountryCode.GM:
                case CountryCode.GN:
                case CountryCode.GP:
                case CountryCode.GQ:
                case CountryCode.GR:
                case CountryCode.GS:
                case CountryCode.GT:
                case CountryCode.GU:
                case CountryCode.GW:
                case CountryCode.GY:
                case CountryCode.HK:
                case CountryCode.HM:
                case CountryCode.HN:
                case CountryCode.HR:
                case CountryCode.HT:
                case CountryCode.HU:
                case CountryCode.IC:
                case CountryCode.ID:
                case CountryCode.IE:
                case CountryCode.IL:
                case CountryCode.IM:
                case CountryCode.IN:
                case CountryCode.IO:
                case CountryCode.IQ:
                case CountryCode.IR:
                case CountryCode.IS:
                case CountryCode.IT:
                case CountryCode.JE:
                case CountryCode.JM:
                case CountryCode.JO:
                case CountryCode.JP:
                case CountryCode.KE:
                case CountryCode.KG:
                case CountryCode.KH:
                case CountryCode.KI:
                case CountryCode.KM:
                case CountryCode.KN:
                case CountryCode.KP:
                case CountryCode.KR:
                case CountryCode.KW:
                case CountryCode.KY:
                case CountryCode.KZ:
                case CountryCode.LA:
                case CountryCode.LB:
                case CountryCode.LC:
                case CountryCode.LI:
                case CountryCode.LK:
                case CountryCode.LR:
                case CountryCode.LS:
                case CountryCode.LT:
                case CountryCode.LU:
                case CountryCode.LV:
                case CountryCode.LY:
                case CountryCode.MA:
                case CountryCode.MC:
                case CountryCode.MD:
                case CountryCode.ME:
                case CountryCode.MF:
                case CountryCode.MG:
                case CountryCode.MH:
                case CountryCode.MK:
                case CountryCode.ML:
                case CountryCode.MM:
                case CountryCode.MN:
                case CountryCode.MO:
                case CountryCode.MP:
                case CountryCode.MQ:
                case CountryCode.MR:
                case CountryCode.MS:
                case CountryCode.MT:
                case CountryCode.MU:
                case CountryCode.MV:
                case CountryCode.MW:
                case CountryCode.MX:
                case CountryCode.MY:
                case CountryCode.MZ:
                case CountryCode.NA:
                case CountryCode.NC:
                case CountryCode.NE:
                case CountryCode.NF:
                case CountryCode.NG:
                case CountryCode.NI:
                case CountryCode.NL:
                case CountryCode.NO:
                case CountryCode.NP:
                case CountryCode.NR:
                case CountryCode.NT:
                case CountryCode.NU:
                case CountryCode.NZ:
                case CountryCode.OM:
                case CountryCode.PA:
                case CountryCode.PE:
                case CountryCode.PF:
                case CountryCode.PG:
                case CountryCode.PH:
                case CountryCode.PK:
                case CountryCode.PL:
                case CountryCode.PM:
                case CountryCode.PN:
                case CountryCode.PR:
                case CountryCode.PS:
                case CountryCode.PT:
                case CountryCode.PW:
                case CountryCode.PY:
                case CountryCode.QA:
                case CountryCode.RE:
                case CountryCode.RO:
                case CountryCode.RS:
                case CountryCode.RU:
                case CountryCode.RW:
                case CountryCode.SA:
                case CountryCode.SB:
                case CountryCode.SC:
                case CountryCode.SD:
                case CountryCode.SE:
                case CountryCode.SF:
                case CountryCode.SG:
                case CountryCode.SH:
                case CountryCode.SI:
                case CountryCode.SJ:
                case CountryCode.SK:
                case CountryCode.SL:
                case CountryCode.SM:
                case CountryCode.SN:
                case CountryCode.SO:
                case CountryCode.SR:
                case CountryCode.SS:
                case CountryCode.ST:
                case CountryCode.SU:
                case CountryCode.SV:
                case CountryCode.SX:
                case CountryCode.SY:
                case CountryCode.SZ:
                case CountryCode.TA:
                case CountryCode.TC:
                case CountryCode.TD:
                case CountryCode.TF:
                case CountryCode.TG:
                case CountryCode.TH:
                case CountryCode.TJ:
                case CountryCode.TK:
                case CountryCode.TL:
                case CountryCode.TM:
                case CountryCode.TN:
                case CountryCode.TO:
                case CountryCode.TP:
                case CountryCode.TR:
                case CountryCode.TT:
                case CountryCode.TV:
                case CountryCode.TW:
                case CountryCode.TZ:
                case CountryCode.UA:
                case CountryCode.UG:
                case CountryCode.UK:
                case CountryCode.UM:
                case CountryCode.US:
                case CountryCode.UY:
                case CountryCode.UZ:
                case CountryCode.VA:
                case CountryCode.VC:
                case CountryCode.VE:
                case CountryCode.VG:
                case CountryCode.VI:
                case CountryCode.VN:
                case CountryCode.VU:
                case CountryCode.WF:
                case CountryCode.WS:
                case CountryCode.XK:
                case CountryCode.YE:
                case CountryCode.YT:
                case CountryCode.YU:
                case CountryCode.ZA:
                case CountryCode.ZM:
                case CountryCode.ZR:
                case CountryCode.ZW:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of CountryCode values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of CountryCode values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<CountryCode> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into CountryCode value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed CountryCode value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type CountryCode</exception>
        public static CountryCode ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type CountryCode");
            return (CountryCode)index;
        }
    }
}
