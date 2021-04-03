using System;
using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface IFeedRoundUpServices
    {
        /// <summary>
        /// Returns the the round-up goal associated with an account if one has been created
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <returns>Task&lt;Models.RoundUpGoalResponse&gt;.</returns>
        /// <return>Returns the Models.RoundUpGoalResponse response from the API call</return>
        Task<Models.RoundUpGoalResponse> FetchRoundUpGoalAsync(StarlingClient starlingClient, Guid accountUid);

        /// <summary>
        /// Activates transaction round-up and adds remainder to savings goal
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="roundUpGoalPayload">Required parameter: Round-up goal</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task ActivateRoundUpGoalAsync(StarlingClient starlingClient, Guid accountUid, Models.RoundUpGoalPayload roundUpGoalPayload);

        /// <summary>
        /// Deletes the round-up goal associated with an account if one exists
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Example: aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task StopRoundUpGoalAsync(StarlingClient starlingClient, Guid accountUid);
    }
}
