using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface ISettleUpServices
    {
        /// <summary>
        /// Fetch Settle Up profile for an account holder
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.SettleUpProfile&gt;.</returns>
        /// <return>Returns the Models.SettleUpProfile response from the API call</return>
        Task<Models.SettleUpProfile> GetSettleUpProfileAsync(StarlingClient starlingClient);
    }
}
