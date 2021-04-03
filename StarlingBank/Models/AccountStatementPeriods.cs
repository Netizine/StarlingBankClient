using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Class AccountStatementPeriods.
    /// </summary>
    public class AccountStatementPeriods
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The periods.</value>
        [JsonProperty("periods")]
        public List<AccountStatementPeriod> Periods { get; set; }
    }
}
