using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class Payees
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payees")]
        public List<Payee> PayeesValue { get; set; }
    }
}
