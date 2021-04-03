using System;
using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface IDirectDebitMandatesServices
    {
        /// <summary>
        /// Get the direct debit mandate with the specified identifier
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <returns>Task&lt;Models.DirectDebitMandateV2&gt;.</returns>
        /// <return>Returns the Models.DirectDebitMandateV2 response from the API call</return>
        Task<Models.DirectDebitMandateV2> GetMandateAsync(StarlingClient starlingClient, Guid mandateUid);

        /// <summary>
        /// Cancel the direct debit mandate with the specified identifier
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task CancelMandateAsync(StarlingClient starlingClient, Guid mandateUid);

        /// <summary>
        /// Get a list of direct debit mandates
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.DirectDebitMandatesV2&gt;.</returns>
        /// <return>Returns the Models.DirectDebitMandatesV2 response from the API call</return>
        Task<Models.DirectDebitMandatesV2> ListMandatesAsync(StarlingClient starlingClient);

        /// <summary>
        /// Get a transaction history for a direct debit
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <param name="since">Required parameter: Start date for a transaction history</param>
        /// <returns>Task&lt;Models.DirectDebitPaymentsResponse&gt;.</returns>
        /// <return>Returns the Models.DirectDebitPaymentsResponse response from the API call</return>
        Task<Models.DirectDebitPaymentsResponse> ListPaymentsForMandateAsync(StarlingClient starlingClient, Guid mandateUid, DateTime since);
    }
}
