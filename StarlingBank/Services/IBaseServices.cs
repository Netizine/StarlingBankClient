using System.Net.Http;
using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface IBaseServices
    {
        /// <summary>
        /// Validates the response against HTTP errors defined at the API level
        /// </summary>
        /// <param name="request">The request object</param>
        /// <param name="response">The response received</param>
        Task ValidateResponse(HttpRequestMessage request, HttpResponseMessage response);

        /// <summary>
        /// Parses the body.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns>Task&lt;System.String&gt;.</returns>
        Task<string> ParseBody(HttpResponseMessage response);
    }
}
