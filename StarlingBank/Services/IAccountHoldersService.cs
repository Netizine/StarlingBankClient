using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface IAccountHoldersService
    {
        /// <summary>
        /// Get basic information about the account holder
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.AccountHolder&gt;.</returns>
        /// <return>Returns the Models.AccountHolder response from the API call</return>
        Task<Models.AccountHolder> GetAccountHolderAsync(StarlingClient starlingClient);

        /// <summary>
        /// Get the name of the account holder
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.AccountHolderName&gt;.</returns>
        /// <return>Returns the Models.AccountHolderName response from the API call</return>
        Task<Models.AccountHolderName> GetAccountHolderNameAsync(StarlingClient starlingClient);
    }
}
