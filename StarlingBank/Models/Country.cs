using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <exclude />
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Country
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
        YU,
        ZA,
        ZM,
        ZR,
        ZW
    }

    /// <summary>
    /// Helper for the enum type Country
    /// </summary>
    public static class CountryHelper
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
        /// Converts a Country value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Country value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Country enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Country.UNDEFINED:
                case Country.AC:
                case Country.AD:
                case Country.AE:
                case Country.AF:
                case Country.AG:
                case Country.AI:
                case Country.AL:
                case Country.AM:
                case Country.AN:
                case Country.AO:
                case Country.AQ:
                case Country.AR:
                case Country.AS:
                case Country.AT:
                case Country.AU:
                case Country.AW:
                case Country.AX:
                case Country.AZ:
                case Country.BA:
                case Country.BB:
                case Country.BD:
                case Country.BE:
                case Country.BF:
                case Country.BG:
                case Country.BH:
                case Country.BI:
                case Country.BJ:
                case Country.BL:
                case Country.BM:
                case Country.BN:
                case Country.BO:
                case Country.BQ:
                case Country.BR:
                case Country.BS:
                case Country.BT:
                case Country.BU:
                case Country.BV:
                case Country.BW:
                case Country.BY:
                case Country.BZ:
                case Country.CA:
                case Country.CC:
                case Country.CD:
                case Country.CF:
                case Country.CG:
                case Country.CH:
                case Country.CI:
                case Country.CK:
                case Country.CL:
                case Country.CM:
                case Country.CN:
                case Country.CO:
                case Country.CP:
                case Country.CR:
                case Country.CS:
                case Country.CU:
                case Country.CV:
                case Country.CW:
                case Country.CX:
                case Country.CY:
                case Country.CZ:
                case Country.DE:
                case Country.DG:
                case Country.DJ:
                case Country.DK:
                case Country.DM:
                case Country.DO:
                case Country.DZ:
                case Country.EA:
                case Country.EC:
                case Country.EE:
                case Country.EG:
                case Country.EH:
                case Country.ER:
                case Country.ES:
                case Country.ET:
                case Country.EU:
                case Country.EZ:
                case Country.FI:
                case Country.FJ:
                case Country.FK:
                case Country.FM:
                case Country.FO:
                case Country.FR:
                case Country.FX:
                case Country.GA:
                case Country.GB:
                case Country.GD:
                case Country.GE:
                case Country.GF:
                case Country.GG:
                case Country.GH:
                case Country.GI:
                case Country.GL:
                case Country.GM:
                case Country.GN:
                case Country.GP:
                case Country.GQ:
                case Country.GR:
                case Country.GS:
                case Country.GT:
                case Country.GU:
                case Country.GW:
                case Country.GY:
                case Country.HK:
                case Country.HM:
                case Country.HN:
                case Country.HR:
                case Country.HT:
                case Country.HU:
                case Country.IC:
                case Country.ID:
                case Country.IE:
                case Country.IL:
                case Country.IM:
                case Country.IN:
                case Country.IO:
                case Country.IQ:
                case Country.IR:
                case Country.IS:
                case Country.IT:
                case Country.JE:
                case Country.JM:
                case Country.JO:
                case Country.JP:
                case Country.KE:
                case Country.KG:
                case Country.KH:
                case Country.KI:
                case Country.KM:
                case Country.KN:
                case Country.KP:
                case Country.KR:
                case Country.KW:
                case Country.KY:
                case Country.KZ:
                case Country.LA:
                case Country.LB:
                case Country.LC:
                case Country.LI:
                case Country.LK:
                case Country.LR:
                case Country.LS:
                case Country.LT:
                case Country.LU:
                case Country.LV:
                case Country.LY:
                case Country.MA:
                case Country.MC:
                case Country.MD:
                case Country.ME:
                case Country.MF:
                case Country.MG:
                case Country.MH:
                case Country.MK:
                case Country.ML:
                case Country.MM:
                case Country.MN:
                case Country.MO:
                case Country.MP:
                case Country.MQ:
                case Country.MR:
                case Country.MS:
                case Country.MT:
                case Country.MU:
                case Country.MV:
                case Country.MW:
                case Country.MX:
                case Country.MY:
                case Country.MZ:
                case Country.NA:
                case Country.NC:
                case Country.NE:
                case Country.NF:
                case Country.NG:
                case Country.NI:
                case Country.NL:
                case Country.NO:
                case Country.NP:
                case Country.NR:
                case Country.NT:
                case Country.NU:
                case Country.NZ:
                case Country.OM:
                case Country.PA:
                case Country.PE:
                case Country.PF:
                case Country.PG:
                case Country.PH:
                case Country.PK:
                case Country.PL:
                case Country.PM:
                case Country.PN:
                case Country.PR:
                case Country.PS:
                case Country.PT:
                case Country.PW:
                case Country.PY:
                case Country.QA:
                case Country.RE:
                case Country.RO:
                case Country.RS:
                case Country.RU:
                case Country.RW:
                case Country.SA:
                case Country.SB:
                case Country.SC:
                case Country.SD:
                case Country.SE:
                case Country.SF:
                case Country.SG:
                case Country.SH:
                case Country.SI:
                case Country.SJ:
                case Country.SK:
                case Country.SL:
                case Country.SM:
                case Country.SN:
                case Country.SO:
                case Country.SR:
                case Country.SS:
                case Country.ST:
                case Country.SU:
                case Country.SV:
                case Country.SX:
                case Country.SY:
                case Country.SZ:
                case Country.TA:
                case Country.TC:
                case Country.TD:
                case Country.TF:
                case Country.TG:
                case Country.TH:
                case Country.TJ:
                case Country.TK:
                case Country.TL:
                case Country.TM:
                case Country.TN:
                case Country.TO:
                case Country.TP:
                case Country.TR:
                case Country.TT:
                case Country.TV:
                case Country.TW:
                case Country.TZ:
                case Country.UA:
                case Country.UG:
                case Country.UK:
                case Country.UM:
                case Country.US:
                case Country.UY:
                case Country.UZ:
                case Country.VA:
                case Country.VC:
                case Country.VE:
                case Country.VG:
                case Country.VI:
                case Country.VN:
                case Country.VU:
                case Country.WF:
                case Country.WS:
                case Country.XK:
                case Country.YE:
                case Country.YT:
                case Country.YU:
                case Country.ZA:
                case Country.ZM:
                case Country.ZR:
                case Country.ZW:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Country values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Country values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Country> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into Country value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Country value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type Country</exception>
        public static Country ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Country");
            return (Country)index;
        }
    }
}
