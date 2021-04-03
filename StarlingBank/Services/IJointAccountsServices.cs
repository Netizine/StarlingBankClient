using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface IJointAccountsServices
    {
        /// <summary>
        /// Get a joint account holder's details
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.JointAccount&gt;.</returns>
        /// <return>Returns the Models.JointAccount response from the API call</return>
        Task<Models.JointAccount> GetJointAccountAsync(StarlingClient starlingClient);
    }
}
