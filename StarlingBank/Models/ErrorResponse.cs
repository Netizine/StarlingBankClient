using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class ErrorResponse
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("errors")]
        public List<ErrorDetail> Errors { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("success")]
        public bool? Success { get; set; }
    }
}
