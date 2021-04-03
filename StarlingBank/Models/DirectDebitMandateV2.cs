using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using StarlingBank.Utilities;

namespace StarlingBank.Models
{
    public class DirectDebitMandateV2
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("uid")]
        public Guid? Uid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Status? Status { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("source", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Source? Source { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("cancelled")]
        public DateTime? Cancelled { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("nextDate")]
        public DateTime? NextDate { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("lastDate")]
        public DateTime? LastDate { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("originatorName")]
        public string OriginatorName { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("originatorUid")]
        public Guid? OriginatorUid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("merchantUid")]
        public Guid? MerchantUid { get; set; }

        /// <summary>
        /// Last direct debit payment
        /// </summary>
        [JsonProperty("lastPayment")]
        public LastPayment LastPayment { get; set; }
    }
}
