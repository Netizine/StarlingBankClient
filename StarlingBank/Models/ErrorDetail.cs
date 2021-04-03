using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class ErrorDetail
    {
        /// <summary>
        /// The error message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
