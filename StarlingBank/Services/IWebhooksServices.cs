using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface IWebhooksServices
    {
        /// <summary>
        /// Deliver webhook payload for a Starling account event
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="defaultWebhookPayloadModel">Optional parameter: The webhook payload for the account event</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task DispatchWebhookAsync(StarlingClient starlingClient, Models.DefaultWebhookPayloadModel defaultWebhookPayloadModel = null);
    }
}
