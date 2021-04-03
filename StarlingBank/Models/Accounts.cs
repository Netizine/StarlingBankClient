using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Class Accounts.
    /// </summary>
    public class Accounts
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The accounts value.</value>
        [JsonProperty("accounts")]
        public List<AccountV2> AccountsValue { get; set; }
    }
}
