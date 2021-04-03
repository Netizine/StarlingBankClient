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
    /// Class PayeesServices.
    /// Implements the <see cref="StarlingBank.Services.IPayeesServices" />
    /// </summary>
    /// <seealso cref="StarlingBank.Services.IPayeesServices" />
    public class PayeesServices : IPayeesServices
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
        /// The array deserialization format
        /// </summary>
        private readonly ArrayDeserialization _arrayDeserializationFormat = ArrayDeserialization.INDEXED;

        /// <summary>
        /// Initializes a new instance of the <see cref="PayeesServices"/> class.
        /// </summary>
        /// <param name="clientFactory">The client factory.</param>
        /// <param name="baseServices">The base services.</param>
        public PayeesServices(IHttpClientFactory clientFactory, IBaseServices baseServices)
        {
            _clientFactory = clientFactory;
            _baseServices = baseServices;

        }

        /// <summary>
        /// Get an account holder's payees
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.Payees&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.Payees response from the API call</return>
        public async Task<Models.Payees> GetPayeesAsync(StarlingClient starlingClient)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payees");
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
                return APIHelper.JsonDeserialize<Models.Payees>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Create a payee
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="payeeCreationRequest">Required parameter: Payee creation object</param>
        /// <returns>Task&lt;Models.PayeeCreationResponse&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.PayeeCreationResponse response from the API call</return>
        public async Task<Models.PayeeCreationResponse> CreatePayeeAsync(StarlingClient starlingClient, Models.PayeeCreationRequest payeeCreationRequest)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payees");
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetContentRequestHeaders(starlingClient, true);
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //append body params
            var body = APIHelper.JsonSerialize(payeeCreationRequest);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
            try
            {
                var content = await response.Content.ReadAsStringAsync();
                return APIHelper.JsonDeserialize<Models.PayeeCreationResponse>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Create a payee account
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="payeeAccountCreationRequest">Required parameter: Payee account creation object</param>
        /// <returns>Task&lt;Models.PayeeAccountCreationResponse&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.PayeeAccountCreationResponse response from the API call</return>
        public async Task<Models.PayeeAccountCreationResponse> CreatePayeeAccountAsync(StarlingClient starlingClient, Guid payeeUid,
            Models.PayeeAccountCreationRequest payeeAccountCreationRequest)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payees/{payeeUid}/account");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"payeeUid", payeeUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetContentRequestHeaders(starlingClient, true);
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //append body params
            var body = APIHelper.JsonSerialize(payeeAccountCreationRequest);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
            try
            {
                var content = await response.Content.ReadAsStringAsync();
                return APIHelper.JsonDeserialize<Models.PayeeAccountCreationResponse>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Deletes a payee
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task DeletePayeeAsync(StarlingClient starlingClient, Guid payeeUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payees/{payeeUid}");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"payeeUid", payeeUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient, true);
            var request = new HttpRequestMessage(HttpMethod.Delete, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
        }

        /// <summary>
        /// Delete a payee account
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task DeletePayeeAccountAsync(StarlingClient starlingClient, Guid payeeUid, Guid accountUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payees/{payeeUid}/account/{accountUid}");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"payeeUid", payeeUid}, {"accountUid", accountUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient, true);
            var request = new HttpRequestMessage(HttpMethod.Delete, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
        }

        /// <summary>
        /// Get scheduled payments
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <returns>Task&lt;Models.ScheduledPayments&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.ScheduledPayments response from the API call</return>
        public async Task<Models.ScheduledPayments> ListPaymentOrdersForAccountAsync(StarlingClient starlingClient, Guid payeeUid, Guid accountUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payees/{payeeUid}/account/{accountUid}/scheduled-payments");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"payeeUid", payeeUid}, {"accountUid", accountUid}});
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
                return APIHelper.JsonDeserialize<Models.ScheduledPayments>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// View a history of payments to your payee
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <param name="since">Required parameter: Start date for a transaction history</param>
        /// <returns>Task&lt;Models.Payments&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.Payments response from the API call</return>
        public async Task<Models.Payments> ListPaymentsForPayeeAccountAsync(StarlingClient starlingClient, Guid payeeUid, Guid accountUid, DateTime since)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payees/{payeeUid}/account/{accountUid}/payments");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"payeeUid", payeeUid}, {"accountUid", accountUid}});
            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder, new Dictionary<string, object>() {{"since", since.ToString("yyyy'-'MM'-'dd")}},
                _arrayDeserializationFormat);
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
                return APIHelper.JsonDeserialize<Models.Payments>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Serves the image for the payee
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <returns>dynamic.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> ServePayeeImageFileAsync(StarlingClient starlingClient, Guid payeeUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payees/{payeeUid}/image");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"payeeUid", payeeUid}});
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
                return APIHelper.JsonDeserialize<dynamic>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }
    }
}
