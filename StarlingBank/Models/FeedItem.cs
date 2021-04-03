using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class FeedItem
    {
        /// <summary>
        /// Unique identifier for this item
        /// </summary>
        [JsonProperty("feedItemUid")]
        public Guid? FeedItemUid { get; set; }

        /// <summary>
        /// The category on which the transaction happened
        /// </summary>
        [JsonProperty("categoryUid")]
        public Guid? CategoryUid { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("amount")]
        public CurrencyAndAmount Amount { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("sourceAmount")]
        public CurrencyAndAmount SourceAmount { get; set; }

        /// <summary>
        /// Was this an inbound or outbound transaction
        /// </summary>
        [JsonProperty("direction", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Direction? Direction { get; set; }

        /// <summary>
        /// The time the transaction was last updated at
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The time of the transaction
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transactionTime")]
        public DateTime? TransactionTime { get; set; }

        /// <summary>
        /// The time the transaction settled
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("settlementTime")]
        public DateTime? SettlementTime { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("retryAllocationUntilTime")]
        public DateTime? RetryAllocationUntilTime { get; set; }

        /// <summary>
        /// The source of the transaction
        /// </summary>
        [JsonProperty("source", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Source? Source { get; set; }

        /// <summary>
        /// The source subtype of the transaction
        /// </summary>
        [JsonProperty("sourceSubType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SourceSubType? SourceSubType { get; set; }

        /// <summary>
        /// The status of the transaction
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Status? Status { get; set; }

        /// <summary>
        /// The application user that made the transaction
        /// </summary>
        [JsonProperty("transactingApplicationUserUid")]
        public Guid? TransactingApplicationUserUid { get; set; }

        /// <summary>
        /// The type of counter party for this transaction
        /// </summary>
        [JsonProperty("counterPartyType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public CounterPartyType? CounterPartyType { get; set; }

        /// <summary>
        /// The unique identifier for the counter party. eg for MERCHANT this will be the merchant uid, for PAYEE this will be the payee uid
        /// </summary>
        [JsonProperty("counterPartyUid")]
        public Guid? CounterPartyUid { get; set; }

        /// <summary>
        /// The name of the counter party
        /// </summary>
        [JsonProperty("counterPartyName")]
        public string CounterPartyName { get; set; }

        /// <summary>
        /// An identifier for the counter party sub entity. eg for MERCHANT this will be the merchant location uid, for PAYEE this will be the payee account uid
        /// </summary>
        [JsonProperty("counterPartySubEntityUid")]
        public Guid? CounterPartySubEntityUid { get; set; }

        /// <summary>
        /// A name for the counter party sub entity, for PAYEE this will be the name set for the payee account
        /// </summary>
        [JsonProperty("counterPartySubEntityName")]
        public string CounterPartySubEntityName { get; set; }

        /// <summary>
        /// An external identifier for the sub entity, for PAYEE this will be the sort code of the account
        /// </summary>
        [JsonProperty("counterPartySubEntityIdentifier")]
        public string CounterPartySubEntityIdentifier { get; set; }

        /// <summary>
        /// An external sub identifier for the sub entity, for PAYEE this will be the account number of the account
        /// </summary>
        [JsonProperty("counterPartySubEntitySubIdentifier")]
        public string CounterPartySubEntitySubIdentifier { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("exchangeRate")]
        public double? ExchangeRate { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("totalFees")]
        public double? TotalFees { get; set; }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("totalFeeAmount")]
        public CurrencyAndAmount TotalFeeAmount { get; set; }

        /// <summary>
        /// The reference for the transaction
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The country in which the transaction took place. ISO 3166-1 alpha-2
        /// </summary>
        [JsonProperty("country", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Country? Country { get; set; }

        /// <summary>
        /// The category of the transaction
        /// </summary>
        [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SpendingCategory? SpendingCategory { get; set; }

        /// <summary>
        /// The user-provided transaction note
        /// </summary>
        [JsonProperty("userNote")]
        public string UserNote { get; set; }

        /// <summary>
        /// Round up details associated with a feed item
        /// </summary>
        [JsonProperty("roundUp")]
        public AssociatedFeedRoundUp RoundUp { get; set; }

        /// <summary>
        /// Attachment present
        /// </summary>
        [JsonProperty("hasAttachment")]
        public bool? HasAttachment { get; set; }

        /// <summary>
        /// Receipt present
        /// </summary>
        [JsonProperty("hasReceipt")]
        public bool? HasReceipt { get; set; }
    }
}
