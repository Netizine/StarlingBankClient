using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using StarlingBank.Exceptions;
using StarlingBank.Utilities;

namespace StarlingBank.Services
{
    /// <summary>
    /// Class TransactionFeedServices.
    /// Implements the <see cref="StarlingBank.Services.ITransactionFeedServices" />
    /// </summary>
    /// <seealso cref="StarlingBank.Services.ITransactionFeedServices" />
    public class TransactionFeedServices : ITransactionFeedServices
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
        /// Initializes a new instance of the <see cref="TransactionFeedServices"/> class.
        /// </summary>
        /// <param name="clientFactory">The client factory.</param>
        /// <param name="baseServices">The base services.</param>
        public TransactionFeedServices(IHttpClientFactory clientFactory, IBaseServices baseServices)
        {
            _clientFactory = clientFactory;
            _baseServices = baseServices;

        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="updateSpendingCategory">Required parameter: Spending category</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task ChangeTransactionCategoryAsync(StarlingClient starlingClient,
            Guid accountUid,
            Guid categoryUid,
            Guid feedItemUid,
            Models.UpdateSpendingCategory updateSpendingCategory)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/feed/account/{accountUid}/category/{categoryUid}/{feedItemUid}/spending-category");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>() {{"accountUid", accountUid}, {"categoryUid", categoryUid}, {"feedItemUid", feedItemUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient);
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }

            //append body params
            var body = APIHelper.JsonSerialize(updateSpendingCategory);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <returns>Task&lt;Models.Receipt&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.Receipt response from the API call</return>
        public async Task<Models.Receipt> GetReceiptAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid, Guid feedItemUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/feed/account/{accountUid}/category/{categoryUid}/{feedItemUid}/receipt");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>() {{"accountUid", accountUid}, {"categoryUid", categoryUid}, {"feedItemUid", feedItemUid}});
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
                return APIHelper.JsonDeserialize<Models.Receipt>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Submit a receipt for a feed item
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="receipt">Required parameter: Receipt</param>
        /// <returns>Task&lt;Models.ReceiptCreationResponse&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.ReceiptCreationResponse response from the API call</return>
        public async Task<Models.ReceiptCreationResponse> CreateOrUpdateReceiptAsync(StarlingClient starlingClient,
            Guid accountUid,
            Guid categoryUid,
            Guid feedItemUid,
            Models.Receipt receipt)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/feed/account/{accountUid}/category/{categoryUid}/{feedItemUid}/receipt");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>() {{"accountUid", accountUid}, {"categoryUid", categoryUid}, {"feedItemUid", feedItemUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetContentRequestHeaders(starlingClient, true);
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }

            //append body params
            var body = APIHelper.JsonSerialize(receipt);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
            try
            {
                var content = await response.Content.ReadAsStringAsync();
                return APIHelper.JsonDeserialize<Models.ReceiptCreationResponse>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="feedItemAttachmentUid">Required parameter: Feed item attachment uid</param>
        /// <returns>Task&lt;Stream&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> DownloadFeedItemAttachmentAsync(StarlingClient starlingClient,
            Guid accountUid,
            Guid categoryUid,
            Guid feedItemUid,
            Guid feedItemAttachmentUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/feed/account/{accountUid}/category/{categoryUid}/{feedItemUid}/attachments/{feedItemAttachmentUid}");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>()
                {
                    {"accountUid", accountUid}, {"categoryUid", categoryUid}, {"feedItemUid", feedItemUid}, {"feedItemAttachmentUid", feedItemAttachmentUid}
                });
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient, true);
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
            foreach (KeyValuePair<string, string> header in headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }

            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
            try
            {
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <returns>Task&lt;Models.FeedItem&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.FeedItem response from the API call</return>
        public async Task<Models.FeedItem> GetFeedItemAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid, Guid feedItemUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/feed/account/{accountUid}/category/{categoryUid}/{feedItemUid}");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>() {{"accountUid", accountUid}, {"categoryUid", categoryUid}, {"feedItemUid", feedItemUid}});
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
                return APIHelper.JsonDeserialize<Models.FeedItem>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <returns>Task&lt;Models.FeedItemAttachments&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.FeedItemAttachments response from the API call</return>
        public async Task<Models.FeedItemAttachments> GetFeedItemAttachmentsAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid,
            Guid feedItemUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/feed/account/{accountUid}/category/{categoryUid}/{feedItemUid}/attachments");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>() {{"accountUid", accountUid}, {"categoryUid", categoryUid}, {"feedItemUid", feedItemUid}});
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
                return APIHelper.JsonDeserialize<Models.FeedItemAttachments>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <returns>Task&lt;Models.MastercardFeedItem&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.MastercardFeedItem response from the API call</return>
        public async Task<Models.MastercardFeedItem> GetMastercardFeedItemAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid,
            Guid feedItemUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/feed/account/{accountUid}/category/{categoryUid}/{feedItemUid}/mastercard");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>() {{"accountUid", accountUid}, {"categoryUid", categoryUid}, {"feedItemUid", feedItemUid}});
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
                return APIHelper.JsonDeserialize<Models.MastercardFeedItem>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="changesSince">Required parameter: Items which have changed since</param>
        /// <returns>Task&lt;Models.FeedItems&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.FeedItems response from the API call</return>
        public async Task<Models.FeedItems> QueryFeedItemsAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid, DateTime changesSince)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/feed/account/{accountUid}/category/{categoryUid}");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>() {{"accountUid", accountUid}, {"categoryUid", categoryUid}});
            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder,
                new Dictionary<string, object>() {{"changesSince", changesSince.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK")}},
                _arrayDeserializationFormat);
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
                return APIHelper.JsonDeserialize<Models.FeedItems>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="minTransactionTimestamp">Required parameter: Minimum transaction timestamp</param>
        /// <param name="maxTransactionTimestamp">Required parameter: Maximum transaction timestamp</param>
        /// <returns>Task&lt;Models.FeedItems&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.FeedItems response from the API call</return>
        public async Task<Models.FeedItems> QueryFeedItemsWithTransactionTimesBetweenAsync(StarlingClient starlingClient,
            Guid accountUid,
            Guid categoryUid,
            DateTime minTransactionTimestamp,
            DateTime maxTransactionTimestamp)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/feed/account/{accountUid}/category/{categoryUid}/transactions-between");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>() {{"accountUid", accountUid}, {"categoryUid", categoryUid}});
            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder,
                new Dictionary<string, object>()
                {
                    {"minTransactionTimestamp", minTransactionTimestamp.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK")},
                    {"maxTransactionTimestamp", maxTransactionTimestamp.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK")}
                }, _arrayDeserializationFormat);
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
                return APIHelper.JsonDeserialize<Models.FeedItems>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="userNoteWrapper">Required parameter: User Note</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateUserNoteAsync(StarlingClient starlingClient,
            Guid accountUid,
            Guid categoryUid,
            Guid feedItemUid,
            Models.UserNoteWrapper userNoteWrapper)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/feed/account/{accountUid}/category/{categoryUid}/{feedItemUid}/user-note");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>() {{"accountUid", accountUid}, {"categoryUid", categoryUid}, {"feedItemUid", feedItemUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient);
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }

            //append body params
            var body = APIHelper.JsonSerialize(userNoteWrapper);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
        }
    }
}
