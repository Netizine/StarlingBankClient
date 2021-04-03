using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using StarlingBank.Exceptions;
using StarlingBank.Utilities;

namespace StarlingBank.Services
{
    /// <summary>
    /// CardsServices Class.
    /// Implements the <see cref="StarlingBank.Services.ICardsServices" />
    /// </summary>
    /// <seealso cref="StarlingBank.Services.ICardsServices" />
    public class CardsServices : ICardsServices
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
        /// Initializes a new instance of the <see cref="CardsServices"/> class.
        /// </summary>
        /// <param name="clientFactory">The client factory.</param>
        /// <param name="baseServices">The base services.</param>
        public CardsServices(IHttpClientFactory clientFactory, IBaseServices baseServices)
        {
            _clientFactory = clientFactory;
            _baseServices = baseServices;

        }

        /// <summary>
        /// Update ATM withdrawal control
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="enabling">Required parameter: Whether ATM withdrawals should be allowed. Set to false to block, true to allow.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task EnableAtmAsync(StarlingClient starlingClient, Guid cardUid, Models.Enabling enabling)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/cards/{cardUid}/controls/atm-enabled");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"cardUid", cardUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient);
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //append body params
            var body = APIHelper.JsonSerialize(enabling);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
        }

        /// <summary>
        /// Update card lock
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="enabling">Required parameter: Whether the card should be locked. Set to false to lock, true to unlock.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task EnableCardAsync(StarlingClient starlingClient, Guid cardUid, Models.Enabling enabling)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/cards/{cardUid}/controls/enabled");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"cardUid", cardUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient);
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //append body params
            var body = APIHelper.JsonSerialize(enabling);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
        }

        /// <summary>
        /// Update currency switch payments control
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="currencyFlag">Required parameter: Whether currency switch payments should be allowed for a given currency. Set to false to block, true to allow.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task EnableCurrencySwitchAsync(StarlingClient starlingClient, Guid cardUid, Models.CurrencyFlag currencyFlag)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/cards/{cardUid}/controls/currency-switch");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"cardUid", cardUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient);
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //append body params
            var body = APIHelper.JsonSerialize(currencyFlag);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
        }

        /// <summary>
        /// Update gambling payments control
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="enabling">Required parameter: Whether gambling payments should be allowed. Set to false to block, true to allow.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task EnableGamblingPaymentsAsync(StarlingClient starlingClient, Guid cardUid, Models.Enabling enabling)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/cards/{cardUid}/controls/gambling-enabled");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"cardUid", cardUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient);
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //append body params
            var body = APIHelper.JsonSerialize(enabling);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
        }

        /// <summary>
        /// Update magstripe payments control
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="enabling">Required parameter: Whether magstripe payments should be allowed. Set to false to block, true to allow.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task EnableMagStripePaymentAsync(StarlingClient starlingClient, Guid cardUid, Models.Enabling enabling)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/cards/{cardUid}/controls/mag-stripe-enabled");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"cardUid", cardUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient);
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //append body params
            var body = APIHelper.JsonSerialize(enabling);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
        }

        /// <summary>
        /// Update mobile wallet payments control
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="enabling">Required parameter: Whether mobile wallet payments should be allowed. Set to false to block, true to allow.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task EnableMobileWalletAsync(StarlingClient starlingClient, Guid cardUid, Models.Enabling enabling)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/cards/{cardUid}/controls/mobile-wallet-enabled");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"cardUid", cardUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient);
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //append body params
            var body = APIHelper.JsonSerialize(enabling);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
        }

        /// <summary>
        /// Update online payments control
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="enabling">Required parameter: Whether online payments should be allowed. Set to false to block, true to allow.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task EnableOnlinePaymentsAsync(StarlingClient starlingClient, Guid cardUid, Models.Enabling enabling)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/cards/{cardUid}/controls/online-enabled");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"cardUid", cardUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient);
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //append body params
            var body = APIHelper.JsonSerialize(enabling);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
        }

        /// <summary>
        /// Update card present payments (contactless and chip and pin) control
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="enabling">Required parameter: Whether card present payments (contactless and chip and pin) should be allowed. Set to false to block, true to allow.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task EnablePosAsync(StarlingClient starlingClient, Guid cardUid, Models.Enabling enabling)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/cards/{cardUid}/controls/pos-enabled");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"cardUid", cardUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient);
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //append body params
            var body = APIHelper.JsonSerialize(enabling);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
        }

        /// <summary>
        /// Get all the cards for an account holder
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.Cards&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.Cards response from the API call</return>
        public async Task<Models.Cards> ListCardsAsync(StarlingClient starlingClient)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/cards");
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient);
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            //invoke request and get response
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
            try
            {
                var content = await response.Content.ReadAsStringAsync();
                return APIHelper.JsonDeserialize<Models.Cards>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }
    }
}
