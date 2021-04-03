using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class IdentityV2
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("accountHolderUid")]
        public Guid? AccountHolderUid { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expiresAt")]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("expiresInSeconds")]
        public long? ExpiresInSeconds { get; set; }

        /// <summary>
        /// The scopes which this token has permission to use e.g. balance:read
        /// </summary>
        [JsonProperty("scopes")]
        public List<string> Scopes { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("authenticated")]
        public bool? Authenticated { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("applicationUserUid")]
        public Guid? ApplicationUserUid { get; set; }

        /// <summary>
        /// Deprecated, use accountHolderUid instead
        /// </summary>
        [JsonProperty("customerUid")]
        public Guid? CustomerUid { get; set; }
    }
}
