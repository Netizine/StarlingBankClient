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
    /// Class PaymentsServices.
    /// Implements the <see cref="StarlingBank.Services.IPaymentsServices" />
    /// </summary>
    /// <seealso cref="StarlingBank.Services.IPaymentsServices" />
    public class PaymentsServices : IPaymentsServices
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
        /// Initializes a new instance of the <see cref="PaymentsServices"/> class.
        /// </summary>
        /// <param name="clientFactory">The client factory.</param>
        /// <param name="baseServices">The base services.</param>
        public PaymentsServices(IHttpClientFactory clientFactory, IBaseServices baseServices)
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
        /// <param name="paymentOrderUid">Required parameter: Payment Order uid</param>
        /// <returns>Task&lt;Models.StandingOrder&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.StandingOrder response from the API call</return>
        public async Task<Models.StandingOrder> GetStandingOrderAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid, Guid paymentOrderUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payments/local/account/{accountUid}/category/{categoryUid}/standing-orders/{paymentOrderUid}");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>() {{"accountUid", accountUid}, {"categoryUid", categoryUid}, {"paymentOrderUid", paymentOrderUid}});
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
                return APIHelper.JsonDeserialize<Models.StandingOrder>(content);
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
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <param name="updateStandingOrderRequest">Required parameter: Standing order update request.</param>
        /// <returns>Task&lt;Models.UpdateStandingOrderResponse&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.UpdateStandingOrderResponse response from the API call</return>
        public async Task<Models.UpdateStandingOrderResponse> UpdateStandingOrderAsync(StarlingClient starlingClient,
            Guid accountUid,
            Guid categoryUid,
            Guid paymentOrderUid,
            Models.UpdateStandingOrderRequest updateStandingOrderRequest)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payments/local/account/{accountUid}/category/{categoryUid}/standing-orders/{paymentOrderUid}");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>() {{"accountUid", accountUid}, {"categoryUid", categoryUid}, {"paymentOrderUid", paymentOrderUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetContentRequestHeaders(starlingClient, true);
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //append body params
            var body = APIHelper.JsonSerialize(updateStandingOrderRequest);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
            try
            {
                var content = await response.Content.ReadAsStringAsync();
                return APIHelper.JsonDeserialize<Models.UpdateStandingOrderResponse>(content);
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
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        public async Task CancelStandingOrderAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid, Guid paymentOrderUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payments/local/account/{accountUid}/category/{categoryUid}/standing-orders/{paymentOrderUid}");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>() {{"accountUid", accountUid}, {"categoryUid", categoryUid}, {"paymentOrderUid", paymentOrderUid}});
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
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <returns>Task&lt;Models.StandingOrdersResponse&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.StandingOrdersResponse response from the API call</return>
        public async Task<Models.StandingOrdersResponse> ListStandingOrdersAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payments/local/account/{accountUid}/category/{categoryUid}/standing-orders");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>() {{"accountUid", accountUid}, {"categoryUid", categoryUid}});
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
                return APIHelper.JsonDeserialize<Models.StandingOrdersResponse>(content);
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
        /// <param name="createStandingOrderRequest">Required parameter: Standing order creation object.</param>
        /// <returns>Task&lt;Models.CreateStandingOrderResponse&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.CreateStandingOrderResponse response from the API call</return>
        public async Task<Models.CreateStandingOrderResponse> CreateStandingOrderAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid,
            Models.CreateStandingOrderRequest createStandingOrderRequest)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payments/local/account/{accountUid}/category/{categoryUid}/standing-orders");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>() {{"accountUid", accountUid}, {"categoryUid", categoryUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetContentRequestHeaders(starlingClient, true);
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //append body params
            var body = APIHelper.JsonSerialize(createStandingOrderRequest);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
            try
            {
                var content = await response.Content.ReadAsStringAsync();
                return APIHelper.JsonDeserialize<Models.CreateStandingOrderResponse>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Get a payment order
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <returns>Task&lt;Models.PaymentOrderV2&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.PaymentOrderV2 response from the API call</return>
        public async Task<Models.PaymentOrderV2> GetPaymentOrderAsync(StarlingClient starlingClient, Guid paymentOrderUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payments/local/payment-order/{paymentOrderUid}");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"paymentOrderUid", paymentOrderUid}});
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
                return APIHelper.JsonDeserialize<Models.PaymentOrderV2>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Get the payments associated with a payment order
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <returns>Task&lt;Models.PaymentOrderPaymentsResponse&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.PaymentOrderPaymentsResponse response from the API call</return>
        public async Task<Models.PaymentOrderPaymentsResponse> GetPaymentOrderPaymentsAsync(StarlingClient starlingClient, Guid paymentOrderUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payments/local/payment-order/{paymentOrderUid}/payments");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>() {{"paymentOrderUid", paymentOrderUid}});
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
                return APIHelper.JsonDeserialize<Models.PaymentOrderPaymentsResponse>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// N.B. if you're looking for only the next payment date, this is also returned when getting a standing order in the `StandingOrder` response from the field `nextDate`.
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment Order uid</param>
        /// <param name="count">Optional parameter: Number of next payment dates to retrieve, between 1 and 100. If count is greater than the number of future payments all future payments will be returned. Defaults to 10.</param>
        /// <returns>Task&lt;Models.NextPaymentDatesResponse&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.NextPaymentDatesResponse response from the API call</return>
        public async Task<Models.NextPaymentDatesResponse> ListNextPaymentDatesAsync(StarlingClient starlingClient,
            Guid accountUid,
            Guid categoryUid,
            Guid paymentOrderUid,
            int? count = null)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payments/local/account/{accountUid}/category/{categoryUid}/standing-orders/{paymentOrderUid}/upcoming-payments");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>() {{"accountUid", accountUid}, {"categoryUid", categoryUid}, {"paymentOrderUid", paymentOrderUid}});
            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder, new Dictionary<string, object>() {{"count", count}}, _arrayDeserializationFormat);
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
                return APIHelper.JsonDeserialize<Models.NextPaymentDatesResponse>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Creates and sends an immediate payment within the UK under the Faster Payments Scheme or via SEPA for payments between Euro accounts. The recipient of the payment must be a payee of the account holder (new payees can be created using the 'Payees' endpoint) OR be defined in the `paymentRecipient` member of the request.
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="instructLocalPaymentRequest">Required parameter: Payment instruction object.</param>
        /// <returns>Task&lt;Models.InstructLocalPaymentResponse&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.InstructLocalPaymentResponse response from the API call</return>
        public async Task<Models.InstructLocalPaymentResponse> MakeLocalPaymentAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid,
            Models.InstructLocalPaymentRequest instructLocalPaymentRequest)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/payments/local/account/{accountUid}/category/{categoryUid}");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder,
                new Dictionary<string, object>() {{"accountUid", accountUid}, {"categoryUid", categoryUid}});
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetContentRequestHeaders(starlingClient, true);
            var request = new HttpRequestMessage(HttpMethod.Put, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            //append body params
            var body = APIHelper.JsonSerialize(instructLocalPaymentRequest);
            request.Content = new StringContent(body);
            //prepare the API call request to fetch the response
            HttpClient client = _clientFactory.CreateClient("StarlingBank");
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
            try
            {
                var content = await response.Content.ReadAsStringAsync();
                return APIHelper.JsonDeserialize<Models.InstructLocalPaymentResponse>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }
    }
}
