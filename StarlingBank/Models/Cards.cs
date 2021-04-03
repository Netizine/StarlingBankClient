using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Class Cards.
    /// </summary>
    public class Cards
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        /// <value>The cards value.</value>
        [JsonProperty("cards")]
        public List<Card> CardsValue { get; set; }
    }
}
