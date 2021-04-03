using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using StarlingBank.Exceptions;
using StarlingBank.Models;
using StarlingBank.Utilities;

namespace StarlingBank.Services
{
    /// <summary>
    ///     AccountsService Class.
    ///     Implements the <see cref="StarlingBank.Services.IAccountsService" />
    /// </summary>
    /// <seealso cref="StarlingBank.Services.IAccountsService" />
    public class AccountsService : IAccountsService
    {
        /// <summary>
        ///     The array deserialization format
        /// </summary>
        private readonly ArrayDeserialization _arrayDeserializationFormat = ArrayDeserialization.INDEXED;

        /// <summary>
        ///     The base services
        /// </summary>
        private readonly IBaseServices _baseServices;

        /// <summary>
        ///     Client factory
        /// </summary>
        private readonly IHttpClientFactory _clientFactory;

        /// <summary>
        ///     Initializes a new instance of the <see cref="AccountsService" /> class.
        /// </summary>
        /// <param name="clientFactory">The client factory.</param>
        /// <param name="baseServices">The base services.</param>
        public AccountsService(IHttpClientFactory clientFactory, IBaseServices baseServices)
        {
            _clientFactory = clientFactory;
            _baseServices = baseServices;
        }

        /// <summary>
        ///     Get list of statement periods which are available for an account
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Example: aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa</param>
        /// <returns>Task&lt;Models.AccountStatementPeriods&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.AccountStatementPeriods response from the API call</return>
        public async Task<AccountStatementPeriods> AvailablePeriodsAsync(StarlingClient starlingClient, Guid accountUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/accounts/{accountUid}/statement/available-periods");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object> {{"accountUid", accountUid}});
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
                return APIHelper.JsonDeserialize<AccountStatementPeriods>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        /// Downloads either a 'application/pdf' or 'text/csv' statement
        /// </summary>
        /// <param name="statementParameters">The statement parameters.</param>
        /// <returns>Task&lt;Stream&gt;.</returns>
        /// <exception cref="StarlingBank.Exceptions.APIException">Failed to parse the response: " + ex.Message</exception>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> DownloadStatementAsync(StatementParameters statementParameters)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/accounts/{accountUid}/statement/download");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object> {{"accountUid", statementParameters.AccountUid} });
            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder, new Dictionary<string, object> {{"yearMonth", statementParameters.Year + "-" + statementParameters.Month } }, _arrayDeserializationFormat);
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(statementParameters.StarlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(statementParameters.StarlingClient, true);
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
            request.Headers.Add("accept", statementParameters.StatementType == StatementType.CSV ? "text/csv" : "application/pdf");
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
        ///     To choose a file format, set the Accept header to either 'application/pdf' or 'text/csv'
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Example: aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa</param>
        /// <param name="start">Required parameter: Example:</param>
        /// <param name="end">Optional parameter: Example:</param>
        /// <returns>Task&lt;Stream&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> DownloadPDFStatementForDateRangeAsync(StarlingClient starlingClient, Guid accountUid, DateTime start, DateTime? end = null)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/accounts/{accountUid}/statement/downloadForDateRange");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object> {{"accountUid", accountUid}});
            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder,
                new Dictionary<string, object>
                {
                    {"start", start.ToString("yyyy'-'MM'-'dd")}, {"end", end.HasValue ? end.Value.ToString("yyyy'-'MM'-'dd") : null}
                }, _arrayDeserializationFormat);
            //validate and preprocess url
            var queryUrl = APIHelper.GetUrl(starlingClient, queryBuilder);
            //append request with appropriate headers and parameters
            Dictionary<string, string> headers = APIHelper.GetRequestHeaders(starlingClient, true);
            var request = new HttpRequestMessage(HttpMethod.Get, queryUrl);
            foreach (KeyValuePair<string, string> header in headers) request.Headers.Add(header.Key, header.Value);
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
        ///     The balance of the account holder's account is expressed in two ways: cleared balance and effective balance.
        ///     * The **cleared balance** is the balance of settled transactions and so does not include pending transactions. The
        ///     cleared end of day balance is used to calculate interest.
        ///     * The **effective balance** is the balance of settled and pending outgoing transactions. This is the balance most
        ///     commonly presented to the account holder (e.g. in-app).
        ///     Many payment types settle effectively instantly (e.g. faster payments). Card transactions usually take a few days
        ///     to settle and will remain pending for this time. We've actually got a blog on [how card transactions
        ///     work](https://www.starlingbank.com/blog/card-transactions-explained/).
        ///     To check whether the account has enough money to make a payment, use the confirmation of funds endpoint instead.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <returns>Task&lt;Models.BalanceV2&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.BalanceV2 response from the API call</return>
        public async Task<BalanceV2> GetAccountBalanceAsync(StarlingClient starlingClient, Guid accountUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/accounts/{accountUid}/balance");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object> {{"accountUid", accountUid}});
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
                return APIHelper.JsonDeserialize<BalanceV2>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        ///     Identifiers come in pairs:
        ///     * A bank identifier, which identifies the bank
        ///     * An account identifier, which identifiers the account at the bank
        ///     Identifiers can be:
        ///     * Sort code and account number for domestic UK payments
        ///     * BIC and IBAN for international payments
        ///     * ABA and ACH routing numbers for domestic US payments
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <returns>Task&lt;Models.AccountIdentifiers&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.AccountIdentifiers response from the API call</return>
        public async Task<AccountIdentifiers> GetAccountIdentifiersAsync(StarlingClient starlingClient, Guid accountUid)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/accounts/{accountUid}/identifiers");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object> {{"accountUid", accountUid}});
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
                return APIHelper.JsonDeserialize<AccountIdentifiers>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        ///     This endpoint returns a list of the accounts that you can access using the access token you supplied in the request
        ///     header.
        ///     Each access token is associated with a single account holder, who may have more than one account (for example, a
        ///     GBP account and a euro account). This endpoint returns all the accounts that the account holder has given you
        ///     permission to access.
        ///     Note that an account holder in this context is either a personal account holder, or a sole trader account holder,
        ///     or a business account holder or a joint account holder. An individual person may be more than one of these kinds of
        ///     account holder, but each kind of account holder is a separate entity and hence requires a separate access token and
        ///     permission.
        ///     Categories are subdivisions within an account.
        ///     Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main
        ///     balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.Accounts&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.Accounts response from the API call</return>
        public async Task<Accounts> GetAccountsAsync(StarlingClient starlingClient)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/accounts");
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
                return APIHelper.JsonDeserialize<Accounts>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }

        /// <summary>
        ///     Get whether there are available funds for a requested amount
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="targetAmountInMinorUnits">Required parameter: Target amount in minor units</param>
        /// <returns>Task&lt;Models.ConfirmationOfFundsResponse&gt;.</returns>
        /// <exception cref="IBaseServices baseServices)">Failed to parse the response: " + ex.Message</exception>
        /// <return>Returns the Models.ConfirmationOfFundsResponse response from the API call</return>
        public async Task<ConfirmationOfFundsResponse> GetConfirmationOfFundsAsync(StarlingClient starlingClient, Guid accountUid,
            long targetAmountInMinorUnits)
        {
            //prepare query string for API call
            var queryBuilder = new StringBuilder();
            queryBuilder.Append("api/v2/accounts/{accountUid}/confirmation-of-funds");
            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object> {{"accountUid", accountUid}});
            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder, new Dictionary<string, object> {{"targetAmountInMinorUnits", targetAmountInMinorUnits}},
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
            //invoke request and get response
            HttpResponseMessage response = await client.SendAsync(request);
            //handle errors defined at the API level
            await _baseServices.ValidateResponse(request, response);
            try
            {
                var content = await response.Content.ReadAsStringAsync();
                return APIHelper.JsonDeserialize<ConfirmationOfFundsResponse>(content);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, request, response);
            }
        }
    }
}
