using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class RecurringCardPayment
    {
        /// <summary>
        /// Unique identifier for the recurring card payment
        /// </summary>
        [JsonProperty("recurringPaymentUid")]
        public Guid? RecurringPaymentUid { get; set; }

        /// <summary>
        /// Unique identifier for the account
        /// </summary>
        [JsonProperty("accountUid")]
        public Guid? AccountUid { get; set; }

        /// <summary>
        /// Unique identifier for the counterparty
        /// </summary>
        [JsonProperty("counterPartyUid")]
        public Guid? CounterPartyUid { get; set; }

        /// <summary>
        /// Counterparty name
        /// </summary>
        [JsonProperty("counterPartyName")]
        public string CounterPartyName { get; set; }

        /// <summary>
        /// Recurring payment status
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Status? Status { get; set; }

        /// <summary>
        /// Unique identifier for the latest feed item
        /// </summary>
        [JsonProperty("latestFeedItemUid")]
        public Guid? LatestFeedItemUid { get; set; }

        /// <summary>
        /// Latest payment date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("latestPaymentDate")]
        public DateTime? LatestPaymentDate { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("latestPaymentAmount")]
        public CurrencyAndAmount LatestPaymentAmount { get; set; }

        /// <summary>
        /// Unique identifier for the feed item
        /// </summary>
        [JsonProperty("mostRecentFeedItem")]
        public Guid? MostRecentFeedItem { get; set; }

        /// <summary>
        /// Most recent payment date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("mostRecentPaymentDate")]
        public DateTime? MostRecentPaymentDate { get; set; }

        /// <summary>
        /// Most recent payment amount
        /// </summary>
        [JsonProperty("mostRecentPaymentAmount")]
        public Money MostRecentPaymentAmount { get; set; }
    }
}
