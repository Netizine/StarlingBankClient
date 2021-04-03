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
    /// AddressesService Class.
    /// Implements the <see cref="StarlingBank.Services.IAddressesService" />
    /// </summary>
    /// <seealso cref="StarlingBank.Services.IAddressesService" />
    public class AddressesService : IAddressesService
    {
        /// <summary>
        /// Client factory
        /// </summary>
        private readonly IHttpClientFactory _clientFactory;

        /// <summary>
        /// The base services
        /// </summary>
        private readonly IBaseServices _baseServices;


        /// <summary>
        /// Initializes a new instance of the <see cref="AddressesService"/> class.
        /// </summary>
        /// <param name="clientFactory">The client factory.</param>
        /// <param name="baseServices">The base services.</param>
        public AddressesService(IHttpClientFactory clientFactory, IBaseServices baseServices)
        {
            _clientFactory = clientFactory;
            _baseServices = baseServices;

        }

        /// <summary>
        /// Get the account holder's addresses
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.AddressesV2&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.AddressesV2 response from the API call</return>
        public async Task<Models.AddressesV2> GetAddressesAsync(StarlingClient starlingClient)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/addresses");
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
                return APIHelper.JsonDeserialize<Models.AddressesV2>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Update the account holder's current address
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="addressUpdateRequest">Required parameter: Update account holder's current address</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateCurrentAddressAsync(StarlingClient starlingClient, Models.AddressUpdateRequest addressUpdateRequest)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/addresses");
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient);
            var request = new HttpRequestMessage(HttpMethod.Post, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);

            //append body params
            var body = APIHelper.JsonSerialize(addressUpdateRequest);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
        }
    }
}
