using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class SavingsGoalTransferResponseV2
    {
        /// <summary>
        /// Unique identifier for the transfer
        /// </summary>
        [JsonProperty("transferUid")]
        public Guid TransferUid { get; set; }

        /// <summary>
        /// True if the method completed successfully
        /// </summary>
        [JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("error")]
        public List<ErrorDetail> Error { get; set; }

        /// <summary>
        /// List of errors if the method request failed
        /// </summary>
        [JsonProperty("errors")]
        public List<ErrorDetail> Errors { get; set; }
    }
}
