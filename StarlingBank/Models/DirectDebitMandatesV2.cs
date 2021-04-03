using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class DirectDebitMandatesV2
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("mandates")]
        public List<DirectDebitMandateV2> Mandates { get; set; }
    }
}
