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
    /// Class SpendingInsightsServices.
    /// Implements the <see cref="StarlingBank.Services.ISpendingInsightsServices" />
    /// </summary>
    /// <seealso cref="StarlingBank.Services.ISpendingInsightsServices" />
    public class SpendingInsightsServices : ISpendingInsightsServices
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
        /// Initializes a new instance of the <see cref="SpendingInsightsServices"/> class.
        /// </summary>
        /// <param name="clientFactory">The client factory.</param>
        /// <param name="baseServices">The base services.</param>
        public SpendingInsightsServices(IHttpClientFactory clientFactory, IBaseServices baseServices)
        {
            _clientFactory = clientFactory;
            _baseServices = baseServices;

        }

        /// <summary>
        /// Get the spending insights grouped by counter party
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <returns>Task&lt;Models.SpendingCounterPartySummary&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.SpendingCounterPartySummary response from the API call</return>
        public async Task<Models.SpendingCounterPartySummary> QuerySpendingInsightsByCounterpartyAsync(StarlingClient starlingClient, Guid accountUid,
            string year, Models.Month month)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/accounts/{accountUid}/spending-insights/counter-party");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"accountUid", accountUid}});
            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder,
                new Dictionary<string, object>() {{"year", year}, {"month", Models.MonthHelper.ToValue(month)}}, _arrayDeserializationFormat);
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient);
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
            foreach (KeyValuePair<string, string> header in headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }

            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            //invoke request and get response
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
            try
            {
                var content = await response.Content.ReadAsStringAsync();
                return APIHelper.JsonDeserialize<Models.SpendingCounterPartySummary>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Get the spending insights grouped by country
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <returns>Task&lt;Models.SpendingCountrySummary&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.SpendingCountrySummary response from the API call</return>
        public async Task<Models.SpendingCountrySummary> QuerySpendingInsightsByCountryAsync(StarlingClient starlingClient, Guid accountUid, string year,
            Models.Month month)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/accounts/{accountUid}/spending-insights/country");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"accountUid", accountUid}});
            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder,
                new Dictionary<string, object>() {{"year", year}, {"month", Models.MonthHelper.ToValue(month)}}, _arrayDeserializationFormat);
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient);
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
            foreach (KeyValuePair<string, string> header in headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }

            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            //invoke request and get response
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
            try
            {
                var content = await response.Content.ReadAsStringAsync();
                return APIHelper.JsonDeserialize<Models.SpendingCountrySummary>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Get the spending insights grouped by spending category
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <returns>Task&lt;Models.SpendingCategorySummary&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.SpendingCategorySummary response from the API call</return>
        public async Task<Models.SpendingCategorySummary> QuerySpendingInsightsBySpendingCategoryAsync(StarlingClient starlingClient, Guid accountUid,
            string year, Models.Month month)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/accounts/{accountUid}/spending-insights/spending-category");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"accountUid", accountUid}});
            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder,
                new Dictionary<string, object>() {{"year", year}, {"month", Models.MonthHelper.ToValue(month)}}, _arrayDeserializationFormat);
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient);
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
            foreach (KeyValuePair<string, string> header in headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }

            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            //invoke request and get response
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
            try
            {
                var content = await response.Content.ReadAsStringAsync();
                return APIHelper.JsonDeserialize<Models.SpendingCategorySummary>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }
    }
}
