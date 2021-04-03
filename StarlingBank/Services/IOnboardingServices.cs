using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface IOnboardingServices
    {
        /// <summary>
        /// Get the onboarding status of the account
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.OnboardingStatus&gt;.</returns>
        /// <return>Returns the Models.OnboardingStatus response from the API call</return>
        Task<Models.OnboardingStatus> GetOnboardingStatusAsync(StarlingClient starlingClient);

        /// <summary>
        /// Onboard an account
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="onboardingRequest">Required parameter: Account onboarding request</param>
        /// <returns>Task&lt;Models.OnboardingResponse&gt;.</returns>
        /// <return>Returns the Models.OnboardingResponse response from the API call</return>
        Task<Models.OnboardingResponse> OnboardAsync(StarlingClient starlingClient, Models.OnboardingRequest onboardingRequest);
    }
}
