using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class StandingOrdersResponse
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("standingOrders")]
        public List<StandingOrder> StandingOrders { get; set; }
    }
}
