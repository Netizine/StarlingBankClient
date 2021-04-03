using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class PaymentStatusDetails
    {
        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("paymentStatus", ItemConverterType = typeof(StringValuedEnumConverter))]
        public PaymentStatus? PaymentStatus { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("description", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Description? Description { get; set; }
    }
}
