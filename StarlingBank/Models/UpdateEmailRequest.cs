using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class UpdateEmailRequest
    {
        /// <summary>
        /// The new email address for the account holder
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
