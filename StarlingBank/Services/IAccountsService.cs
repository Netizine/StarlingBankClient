using System;
using System.IO;
using System.Threading.Tasks;
using StarlingBank.Models;

namespace StarlingBank.Services
{
    public interface IAccountsService
    {
        /// <summary>
        /// Get list of statement periods which are available for an account
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Example: aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa</param>
        /// <returns>Task&lt;Models.AccountStatementPeriods&gt;.</returns>
        /// <return>Returns the Models.AccountStatementPeriods response from the API call</return>
        Task<Models.AccountStatementPeriods> AvailablePeriodsAsync(StarlingClient starlingClient, Guid accountUid);

        /// <summary>
        /// Downloads either a 'application/pdf' or 'text/csv' statement
        /// </summary>
        /// <param name="statementParameters">The statement parameters.</param>
        /// <returns>Task&lt;Stream&gt;.</returns>
        /// <return>Returns the Stream response from the API call</return>
        Task<Stream> DownloadStatementAsync(StatementParameters statementParameters);

        /// <summary>
        /// To choose a file format, set the Accept header to either 'application/pdf' or 'text/csv'
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Example: aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa</param>
        /// <param name="start">Required parameter: Example:</param>
        /// <param name="end">Optional parameter: Example:</param>
        /// <returns>Task&lt;Stream&gt;.</returns>
        /// <return>Returns the Stream response from the API call</return>
        Task<Stream> DownloadPDFStatementForDateRangeAsync(StarlingClient starlingClient, Guid accountUid, DateTime start, DateTime? end = null);

        /// <summary>
        /// The balance of the account holder's account is expressed in two ways: cleared balance and effective balance.
        /// * The **cleared balance** is the balance of settled transactions and so does not include pending transactions. The cleared end of day balance is used to calculate interest.
        /// * The **effective balance** is the balance of settled and pending outgoing transactions. This is the balance most commonly presented to the account holder (e.g. in-app).
        /// Many payment types settle effectively instantly (e.g. faster payments). Card transactions usually take a few days to settle and will remain pending for this time. We've actually got a blog on [how card transactions work](https://www.starlingbank.com/blog/card-transactions-explained/).
        /// To check whether the account has enough money to make a payment, use the confirmation of funds endpoint instead.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <returns>Task&lt;Models.BalanceV2&gt;.</returns>
        /// <return>Returns the Models.BalanceV2 response from the API call</return>
        Task<Models.BalanceV2> GetAccountBalanceAsync(StarlingClient starlingClient, Guid accountUid);

        /// <summary>
        /// Identifiers come in pairs:
        /// * A bank identifier, which identifies the bank
        /// * An account identifier, which identifiers the account at the bank
        /// Identifiers can be:
        /// * Sort code and account number for domestic UK payments
        /// * BIC and IBAN for international payments
        /// * ABA and ACH routing numbers for domestic US payments
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <returns>Task&lt;Models.AccountIdentifiers&gt;.</returns>
        /// <return>Returns the Models.AccountIdentifiers response from the API call</return>
        Task<Models.AccountIdentifiers> GetAccountIdentifiersAsync(StarlingClient starlingClient, Guid accountUid);

        /// <summary>
        /// This endpoint returns a list of the accounts that you can access using the access token you supplied in the request header.
        /// Each access token is associated with a single account holder, who may have more than one account (for example, a GBP account and a euro account). This endpoint returns all the accounts that the account holder has given you permission to access.
        /// Note that an account holder in this context is either a personal account holder, or a sole trader account holder, or a business account holder or a joint account holder. An individual person may be more than one of these kinds of account holder, but each kind of account holder is a separate entity and hence requires a separate access token and permission.
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.Accounts&gt;.</returns>
        /// <return>Returns the Models.Accounts response from the API call</return>
        Task<Models.Accounts> GetAccountsAsync(StarlingClient starlingClient);

        /// <summary>
        /// Get whether there are available funds for a requested amount
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="targetAmountInMinorUnits">Required parameter: Target amount in minor units</param>
        /// <returns>Task&lt;Models.ConfirmationOfFundsResponse&gt;.</returns>
        /// <return>Returns the Models.ConfirmationOfFundsResponse response from the API call</return>
        Task<Models.ConfirmationOfFundsResponse> GetConfirmationOfFundsAsync(StarlingClient starlingClient, Guid accountUid, long targetAmountInMinorUnits);
    }
}
