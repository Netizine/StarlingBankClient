using System;
using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface IRecurringCardPaymentsServices
    {
        /// <summary>
        /// Fetch recurring card payments for an account holder
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Example: aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa</param>
        /// <returns>Task&lt;Models.RecurringCardPayment&gt;.</returns>
        /// <return>Returns the Models.RecurringCardPayment response from the API call</return>
        Task<Models.RecurringCardPayment> ListRecurringPaymentsAsync(StarlingClient starlingClient, Guid accountUid);
    }
}
