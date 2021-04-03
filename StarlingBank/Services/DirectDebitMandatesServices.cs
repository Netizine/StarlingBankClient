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
    /// DirectDebitMandatesServices Class.
    /// Implements the <see cref="StarlingBank.Services.IDirectDebitMandatesServices" />
    /// </summary>
    /// <seealso cref="StarlingBank.Services.IDirectDebitMandatesServices" />
    public class DirectDebitMandatesServices : IDirectDebitMandatesServices
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
        /// Initializes a new instance of the <see cref="DirectDebitMandatesServices"/> class.
        /// </summary>
        /// <param name="clientFactory">The client factory.</param>
        /// <param name="baseServices">The base services.</param>
        public DirectDebitMandatesServices(IHttpClientFactory clientFactory, IBaseServices baseServices)
        {
            _clientFactory = clientFactory;
            _baseServices = baseServices;

        }

        /// <summary>
        /// Get the direct debit mandate with the specified identifier
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <returns>Task&lt;Models.DirectDebitMandateV2&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.DirectDebitMandateV2 response from the API call</return>
        public async Task<Models.DirectDebitMandateV2> GetMandateAsync(StarlingClient starlingClient, Guid mandateUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/direct-debit/mandates/{mandateUid}");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"mandateUid", mandateUid}});
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
                return APIHelper.JsonDeserialize<Models.DirectDebitMandateV2>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Cancel the direct debit mandate with the specified identifier
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task CancelMandateAsync(StarlingClient starlingClient, Guid mandateUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/direct-debit/mandates/{mandateUid}");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"mandateUid", mandateUid}});
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
        /// Get a list of direct debit mandates
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.DirectDebitMandatesV2&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.DirectDebitMandatesV2 response from the API call</return>
        public async Task<Models.DirectDebitMandatesV2> ListMandatesAsync(StarlingClient starlingClient)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/direct-debit/mandates");
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
                return APIHelper.JsonDeserialize<Models.DirectDebitMandatesV2>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Get a transaction history for a direct debit
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <param name="since">Required parameter: Start date for a transaction history</param>
        /// <returns>Task&lt;Models.DirectDebitPaymentsResponse&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.DirectDebitPaymentsResponse response from the API call</return>
        public async Task<Models.DirectDebitPaymentsResponse> ListPaymentsForMandateAsync(StarlingClient starlingClient, Guid mandateUid, DateTime since)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/direct-debit/mandates/{mandateUid}/payments");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"mandateUid", mandateUid}});
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
                return APIHelper.JsonDeserialize<Models.DirectDebitPaymentsResponse>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }
    }
}
