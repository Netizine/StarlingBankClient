using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace StarlingBank.Exceptions
{
    /// <summary>
    /// Class APIException.
    /// Implements the <see cref="System.Exception" />
    /// </summary>
    /// <seealso cref="System.Exception" />
    [JsonObject]
    public class APIException : Exception
    {
        /// <summary>
        /// HttpRequest stores the request
        /// </summary>
        /// <value>The HTTP request.</value>
        public HttpRequestMessage HttpRequest { get; set; }

        /// <summary>
        /// HttpResponse stores the response
        /// </summary>
        /// <value>The HTTP response.</value>
        public HttpResponseMessage HttpResponse { get; set; }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason">The reason for throwing exception</param>
        /// <param name="request">The HTTP request objects</param>
        /// <param name="response">The HTTP response objects</param>
        public APIException(string reason, HttpRequestMessage request, HttpResponseMessage response)
            : base(reason)
        {
            HttpRequest = request;
            HttpResponse = response;
            //if a derived exception class is used, then perform deserialization of response body
            if (GetType().Name.Equals("APIException", StringComparison.OrdinalIgnoreCase) || response?.Content == null)
                return;
            var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            if (!string.IsNullOrWhiteSpace(content))
                try
                {
                    JsonConvert.PopulateObject(content, this);
                }
                catch
                {
                } //ignoring response body from deserailization
        }
    }
}
