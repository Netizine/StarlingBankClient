using System;
using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface IProfileImagesServices
    {
        /// <summary>
        /// Get a profile image if one exists
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <returns>Task&lt;System.Object&gt;.</returns>
        /// <return>Returns the dynamic response from the API call</return>
        Task<object> DownloadProfileImageAsync(StarlingClient starlingClient, Guid accountHolderUid);

        /// <summary>
        /// Update a profile image if one already exists
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <param name="contentType">Required parameter: Example:</param>
        /// <param name="inputStream">Required parameter: Attachment input stream</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task UpdateProfileImageAsync(StarlingClient starlingClient, Guid accountHolderUid, string contentType, object inputStream);

        /// <summary>
        /// Delete a profile image if one exists
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task DeleteProfileImageAsync(StarlingClient starlingClient, Guid accountHolderUid);
    }
}
