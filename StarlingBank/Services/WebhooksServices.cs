using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using StarlingBank.Exceptions;
using StarlingBank.Utilities;

namespace StarlingBank.Services
{
    /// <summary>
    /// Class WebhooksServices.
    /// Implements the <see cref="StarlingBank.Services.IWebhooksServices" />
    /// </summary>
    /// <seealso cref="StarlingBank.Services.IWebhooksServices" />
    public class WebhooksServices : IWebhooksServices
    {
        /// <summary>
        /// The client factory
        /// </summary>
        private readonly IHttpClientFactory _clientFactory;

        /// <summary>
        /// The base services
        /// </summary>
        private readonly IBaseServices _baseServices;


        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksServices"/> class.
        /// </summary>
        /// <param name="clientFactory">The client factory.</param>
        /// <param name="baseServices">The base services.</param>
        public WebhooksServices(IHttpClientFactory clientFactory, IBaseServices baseServices)
        {
            _clientFactory = clientFactory;
            _baseServices = baseServices;

        }

        /// <summary>
        /// Deliver webhook payload for a Starling account event
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="defaultWebhookPayloadModel">Optional parameter: The webhook payload for the account event</param>
        /// <returns>Task.</returns>
        /// <exception cref="IBaseServices baseServices)">This, and all other HTTP codes, will be treated as a failure of hook receipt and Starling will resend with exponential back-off</exception>
        /// <return>Returns the void response from the API call</return>
        public async Task DispatchWebhookAsync(StarlingClient starlingClient, Models.DefaultWebhookPayloadModel defaultWebhookPayloadModel = null)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("/yourdomain.com/your/registered/web-hook/address");
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient);
            var request = new HttpRequestMessage(HttpMethod.Post, queryUrl);
            foreach (KeyValuePair<string, string> header in headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }

            //append body params
            var body = APIHelper.JsonSerialize(defaultWebhookPayloadModel);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
            //Error handling using HTTP status codes
            if (response.StatusCode == HttpStatusCode.InternalServerError)
                throw new APIException(
                    "This, and all other HTTP codes, will be treated as a failure of hook receipt and Starling will resend with exponential back-off", request,
                    response);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
        }
    }
}
