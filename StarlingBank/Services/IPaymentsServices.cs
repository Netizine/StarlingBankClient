using System;
using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface IPaymentsServices
    {
        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment Order uid</param>
        /// <returns>Task&lt;Models.StandingOrder&gt;.</returns>
        /// <return>Returns the Models.StandingOrder response from the API call</return>
        Task<Models.StandingOrder> GetStandingOrderAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid, Guid paymentOrderUid);

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
        /// <return>Returns the Models.UpdateStandingOrderResponse response from the API call</return>
        Task<Models.UpdateStandingOrderResponse> UpdateStandingOrderAsync(StarlingClient starlingClient,
            Guid accountUid,
            Guid categoryUid,
            Guid paymentOrderUid,
            Models.UpdateStandingOrderRequest updateStandingOrderRequest);

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
        Task CancelStandingOrderAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid, Guid paymentOrderUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <returns>Task&lt;Models.StandingOrdersResponse&gt;.</returns>
        /// <return>Returns the Models.StandingOrdersResponse response from the API call</return>
        Task<Models.StandingOrdersResponse> ListStandingOrdersAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="createStandingOrderRequest">Required parameter: Standing order creation object.</param>
        /// <returns>Task&lt;Models.CreateStandingOrderResponse&gt;.</returns>
        /// <return>Returns the Models.CreateStandingOrderResponse response from the API call</return>
        Task<Models.CreateStandingOrderResponse> CreateStandingOrderAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid,
            Models.CreateStandingOrderRequest createStandingOrderRequest);

        /// <summary>
        /// Get a payment order
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <returns>Task&lt;Models.PaymentOrderV2&gt;.</returns>
        /// <return>Returns the Models.PaymentOrderV2 response from the API call</return>
        Task<Models.PaymentOrderV2> GetPaymentOrderAsync(StarlingClient starlingClient, Guid paymentOrderUid);

        /// <summary>
        /// Get the payments associated with a payment order
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <returns>Task&lt;Models.PaymentOrderPaymentsResponse&gt;.</returns>
        /// <return>Returns the Models.PaymentOrderPaymentsResponse response from the API call</return>
        Task<Models.PaymentOrderPaymentsResponse> GetPaymentOrderPaymentsAsync(StarlingClient starlingClient, Guid paymentOrderUid);

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
        /// <return>Returns the Models.NextPaymentDatesResponse response from the API call</return>
        Task<Models.NextPaymentDatesResponse> ListNextPaymentDatesAsync(StarlingClient starlingClient,
            Guid accountUid,
            Guid categoryUid,
            Guid paymentOrderUid,
            int? count = null);

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
        /// <return>Returns the Models.InstructLocalPaymentResponse response from the API call</return>
        Task<Models.InstructLocalPaymentResponse> MakeLocalPaymentAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid,
            Models.InstructLocalPaymentRequest instructLocalPaymentRequest);
    }
}
