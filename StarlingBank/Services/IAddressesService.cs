using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface IAddressesService
    {
        /// <summary>
        /// Get the account holder's addresses
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.AddressesV2&gt;.</returns>
        /// <return>Returns the Models.AddressesV2 response from the API call</return>
        Task<Models.AddressesV2> GetAddressesAsync(StarlingClient starlingClient);

        /// <summary>
        /// Update the account holder's current address
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="addressUpdateRequest">Required parameter: Update account holder's current address</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task UpdateCurrentAddressAsync(StarlingClient starlingClient, Models.AddressUpdateRequest addressUpdateRequest);
    }
}
