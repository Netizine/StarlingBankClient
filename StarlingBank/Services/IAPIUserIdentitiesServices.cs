using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface IAPIUserIdentitiesServices
    {
        /// <summary>
        /// The individual who authorised the application
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.Individual&gt;.</returns>
        /// <return>Returns the Models.Individual response from the API call</return>
        Task<Models.Individual> GetAuthorisingIndividualAsync(StarlingClient starlingClient);

        /// <summary>
        /// This endpoint returns the permissions you have access to, the time until the token expires and the account holder's unique identifier.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.IdentityV2&gt;.</returns>
        /// <return>Returns the Models.IdentityV2 response from the API call</return>
        Task<Models.IdentityV2> GetTokenIdentityAsync(StarlingClient starlingClient);

        /// <summary>
        /// This endpoint logs an individual out by disabling all of their active access tokens.
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task LogoutIndividualAsync(StarlingClient starlingClient);
    }
}
