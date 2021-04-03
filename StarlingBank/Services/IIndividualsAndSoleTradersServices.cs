using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface IIndividualsAndSoleTradersServices
    {
        /// <summary>
        /// Get an individual account holder's details
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.Individual&gt;.</returns>
        /// <return>Returns the Models.Individual response from the API call</return>
        Task<Models.Individual> GetIndividualAsync(StarlingClient starlingClient);

        /// <summary>
        /// Update an individual account holder's email address
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="updateEmailRequest">Required parameter: Example:</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task UpdateEmailAsync(StarlingClient starlingClient, Models.UpdateEmailRequest updateEmailRequest);
    }
}
