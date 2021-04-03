using System;
using System.IO;
using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface ITransactionFeedServices
    {
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
        Task ChangeTransactionCategoryAsync(StarlingClient starlingClient,
            Guid accountUid,
            Guid categoryUid,
            Guid feedItemUid,
            Models.UpdateSpendingCategory updateSpendingCategory);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <returns>Task&lt;Models.Receipt&gt;.</returns>
        /// <return>Returns the Models.Receipt response from the API call</return>
        Task<Models.Receipt> GetReceiptAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid, Guid feedItemUid);

        /// <summary>
        /// Submit a receipt for a feed item
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="receipt">Required parameter: Receipt</param>
        /// <returns>Task&lt;Models.ReceiptCreationResponse&gt;.</returns>
        /// <return>Returns the Models.ReceiptCreationResponse response from the API call</return>
        Task<Models.ReceiptCreationResponse> CreateOrUpdateReceiptAsync(StarlingClient starlingClient,
            Guid accountUid,
            Guid categoryUid,
            Guid feedItemUid,
            Models.Receipt receipt);

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
        /// <return>Returns the Stream response from the API call</return>
        Task<Stream> DownloadFeedItemAttachmentAsync(StarlingClient starlingClient,
            Guid accountUid,
            Guid categoryUid,
            Guid feedItemUid,
            Guid feedItemAttachmentUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <returns>Task&lt;Models.FeedItem&gt;.</returns>
        /// <return>Returns the Models.FeedItem response from the API call</return>
        Task<Models.FeedItem> GetFeedItemAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid, Guid feedItemUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <returns>Task&lt;Models.FeedItemAttachments&gt;.</returns>
        /// <return>Returns the Models.FeedItemAttachments response from the API call</return>
        Task<Models.FeedItemAttachments> GetFeedItemAttachmentsAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid, Guid feedItemUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <returns>Task&lt;Models.MastercardFeedItem&gt;.</returns>
        /// <return>Returns the Models.MastercardFeedItem response from the API call</return>
        Task<Models.MastercardFeedItem> GetMastercardFeedItemAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid, Guid feedItemUid);

        /// <summary>
        /// Categories are subdivisions within an account.
        /// Within an account, the `defaultCategory` returned by [`/api/v2/accounts`](#operations-tag-Accounts) holds the main balance and transactions. Savings goals and spending spaces are examples of other categories.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="changesSince">Required parameter: Items which have changed since</param>
        /// <returns>Task&lt;Models.FeedItems&gt;.</returns>
        /// <return>Returns the Models.FeedItems response from the API call</return>
        Task<Models.FeedItems> QueryFeedItemsAsync(StarlingClient starlingClient, Guid accountUid, Guid categoryUid, DateTime changesSince);

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
        /// <return>Returns the Models.FeedItems response from the API call</return>
        Task<Models.FeedItems> QueryFeedItemsWithTransactionTimesBetweenAsync(StarlingClient starlingClient,
            Guid accountUid,
            Guid categoryUid,
            DateTime minTransactionTimestamp,
            DateTime maxTransactionTimestamp);

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
        Task UpdateUserNoteAsync(StarlingClient starlingClient,
            Guid accountUid,
            Guid categoryUid,
            Guid feedItemUid,
            Models.UserNoteWrapper userNoteWrapper);
    }
}
