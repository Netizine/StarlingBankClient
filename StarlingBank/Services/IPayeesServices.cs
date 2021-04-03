using System;
using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface IPayeesServices
    {
        /// <summary>
        /// Get an account holder's payees
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.Payees&gt;.</returns>
        /// <return>Returns the Models.Payees response from the API call</return>
        Task<Models.Payees> GetPayeesAsync(StarlingClient starlingClient);

        /// <summary>
        /// Create a payee
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="payeeCreationRequest">Required parameter: Payee creation object</param>
        /// <returns>Task&lt;Models.PayeeCreationResponse&gt;.</returns>
        /// <return>Returns the Models.PayeeCreationResponse response from the API call</return>
        Task<Models.PayeeCreationResponse> CreatePayeeAsync(StarlingClient starlingClient, Models.PayeeCreationRequest payeeCreationRequest);

        /// <summary>
        /// Create a payee account
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="payeeAccountCreationRequest">Required parameter: Payee account creation object</param>
        /// <returns>Task&lt;Models.PayeeAccountCreationResponse&gt;.</returns>
        /// <return>Returns the Models.PayeeAccountCreationResponse response from the API call</return>
        Task<Models.PayeeAccountCreationResponse> CreatePayeeAccountAsync(StarlingClient starlingClient, Guid payeeUid,
            Models.PayeeAccountCreationRequest payeeAccountCreationRequest);

        /// <summary>
        /// Deletes a payee
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task DeletePayeeAsync(StarlingClient starlingClient, Guid payeeUid);

        /// <summary>
        /// Delete a payee account
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task DeletePayeeAccountAsync(StarlingClient starlingClient, Guid payeeUid, Guid accountUid);

        /// <summary>
        /// Get scheduled payments
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <returns>Task&lt;Models.ScheduledPayments&gt;.</returns>
        /// <return>Returns the Models.ScheduledPayments response from the API call</return>
        Task<Models.ScheduledPayments> ListPaymentOrdersForAccountAsync(StarlingClient starlingClient, Guid payeeUid, Guid accountUid);

        /// <summary>
        /// View a history of payments to your payee
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <param name="since">Required parameter: Start date for a transaction history</param>
        /// <returns>Task&lt;Models.Payments&gt;.</returns>
        /// <return>Returns the Models.Payments response from the API call</return>
        Task<Models.Payments> ListPaymentsForPayeeAccountAsync(StarlingClient starlingClient, Guid payeeUid, Guid accountUid, DateTime since);

        /// <summary>
        /// Serves the image for the payee
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <returns>Task&lt;System.Object&gt;.</returns>
        /// <return>Returns the dynamic response from the API call</return>
        Task<object> ServePayeeImageFileAsync(StarlingClient starlingClient, Guid payeeUid);
    }
}
