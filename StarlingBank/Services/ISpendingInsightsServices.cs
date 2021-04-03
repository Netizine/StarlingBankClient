using System;
using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface ISpendingInsightsServices
    {
        /// <summary>
        /// Get the spending insights grouped by counter party
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <returns>Task&lt;Models.SpendingCounterPartySummary&gt;.</returns>
        /// <return>Returns the Models.SpendingCounterPartySummary response from the API call</return>
        Task<Models.SpendingCounterPartySummary> QuerySpendingInsightsByCounterpartyAsync(StarlingClient starlingClient, Guid accountUid, string year,
            Models.Month month);

        /// <summary>
        /// Get the spending insights grouped by country
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <returns>Task&lt;Models.SpendingCountrySummary&gt;.</returns>
        /// <return>Returns the Models.SpendingCountrySummary response from the API call</return>
        Task<Models.SpendingCountrySummary>
            QuerySpendingInsightsByCountryAsync(StarlingClient starlingClient, Guid accountUid, string year, Models.Month month);

        /// <summary>
        /// Get the spending insights grouped by spending category
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <returns>Task&lt;Models.SpendingCategorySummary&gt;.</returns>
        /// <return>Returns the Models.SpendingCategorySummary response from the API call</return>
        Task<Models.SpendingCategorySummary> QuerySpendingInsightsBySpendingCategoryAsync(StarlingClient starlingClient, Guid accountUid, string year,
            Models.Month month);
    }
}
