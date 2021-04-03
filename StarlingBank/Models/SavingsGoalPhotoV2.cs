using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class SavingsGoalPhotoV2
    {
        /// <summary>
        /// A text (base 64) encoded picture to associate with the savings goal
        /// </summary>
        [JsonProperty("base64EncodedPhoto")]
        public string Base64EncodedPhoto { get; set; }
    }
}
