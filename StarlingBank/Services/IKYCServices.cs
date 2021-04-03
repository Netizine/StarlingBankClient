using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface IKYCServices
    {
        /// <summary>
        /// Get KYC result for an account holder
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.KycResult&gt;.</returns>
        /// <return>Returns the Models.KycResult response from the API call</return>
        Task<Models.KycResult> GetKycResultAsync(StarlingClient starlingClient);
    }
}
