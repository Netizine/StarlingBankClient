using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface IBusinessesServices
    {
        /// <summary>
        /// Get a business account holder's details
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.Business&gt;.</returns>
        /// <return>Returns the Models.Business response from the API call</return>
        Task<Models.Business> GetBusinessAsync(StarlingClient starlingClient);

        /// <summary>
        /// Will fallback to registered address if not available
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.AddressV2&gt;.</returns>
        /// <return>Returns the Models.AddressV2 response from the API call</return>
        Task<Models.AddressV2> GetCorrespondenceAddressAsync(StarlingClient starlingClient);

        /// <summary>
        /// Get a company's registered address
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.AddressV2&gt;.</returns>
        /// <return>Returns the Models.AddressV2 response from the API call</return>
        Task<Models.AddressV2> GetRegisteredAddressAsync(StarlingClient starlingClient);
    }
}
