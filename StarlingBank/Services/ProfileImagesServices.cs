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
    /// Class ProfileImagesServices.
    /// Implements the <see cref="StarlingBank.Services.IProfileImagesServices" />
    /// </summary>
    /// <seealso cref="StarlingBank.Services.IProfileImagesServices" />
    public class ProfileImagesServices : IProfileImagesServices
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
        /// Initializes a new instance of the <see cref="ProfileImagesServices"/> class.
        /// </summary>
        /// <param name="clientFactory">The client factory.</param>
        /// <param name="baseServices">The base services.</param>
        public ProfileImagesServices(IHttpClientFactory clientFactory, IBaseServices baseServices)
        {
            _clientFactory = clientFactory;
            _baseServices = baseServices;

        }

        /// <summary>
        /// Get a profile image if one exists
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <returns>dynamic.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> DownloadProfileImageAsync(StarlingClient starlingClient, Guid accountHolderUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/account-holder/{accountHolderUid}/profile-image");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"accountHolderUid", accountHolderUid}});
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

        /// <summary>
        /// Update a profile image if one already exists
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <param name="contentType">Required parameter: Example:</param>
        /// <param name="inputStream">Required parameter: Attachment input stream</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateProfileImageAsync(StarlingClient starlingClient, Guid accountHolderUid, string contentType, object inputStream)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/account-holder/{accountHolderUid}/profile-image");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"accountHolderUid", accountHolderUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>
            {
                {"user-agent", "Starling Bank C# Client"}, {"Content-Type", contentType}, {"Authorization", $"Bearer {starlingClient.OAuthAccessToken}"}
            };
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //append body params
            var body = APIHelper.JsonSerialize(inputStream);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
        }

        /// <summary>
        /// Delete a profile image if one exists
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task DeleteProfileImageAsync(StarlingClient starlingClient, Guid accountHolderUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/account-holder/{accountHolderUid}/profile-image");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"accountHolderUid", accountHolderUid}});
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
    }
}
