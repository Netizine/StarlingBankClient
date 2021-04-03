using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface ISoleTradersServices
    {
        /// <summary>
        /// Get sole trader business details
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.SoleTrader&gt;.</returns>
        /// <return>Returns the Models.SoleTrader response from the API call</return>
        Task<Models.SoleTrader> GetSoleTraderAsync(StarlingClient starlingClient);
    }
}
