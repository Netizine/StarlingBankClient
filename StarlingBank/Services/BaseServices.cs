using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StarlingBank.Exceptions;

namespace StarlingBank.Services
{
    /// <summary>
    /// BaseServices Class.
    /// Implements the <see cref="StarlingBank.Services.IBaseServices" />
    /// </summary>
    /// <seealso cref="StarlingBank.Services.IBaseServices" />
    public class BaseServices : IBaseServices
    {

        /// <summary>
        /// Validates the response against HTTP errors defined at the API level
        /// </summary>
        /// <param name="request">The request object</param>
        /// <param name="response">The response received</param>
        public async Task ValidateResponse(HttpRequestMessage request, HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
                return;
            var errorHeader = "HTTP Response Not OK";
            var responseCode = (int)response.StatusCode;
            if (responseCode >= 300 && responseCode < 400)
            {
                errorHeader = "HTTP Redirection Error " + responseCode + ": " + GetHttpStatusDescription(response.StatusCode) + ". " +
                              await ParseBody(response);
                throw new APIException(errorHeader, request, response);
            }
            else if (responseCode >= 400 && responseCode < 500)
            {
                errorHeader = "HTTP Client Error " + responseCode + ": " + GetHttpStatusDescription(response.StatusCode) + ". " + await ParseBody(response);
                throw new APIException(errorHeader, request, response);
            }
            else if (responseCode >= 500)
            {
                errorHeader = "HTTP Server Error " + responseCode + ": " + GetHttpStatusDescription(response.StatusCode) + ". " + await ParseBody(response);
                throw new APIException(errorHeader, request, response);
            }
        }

        /// <summary>
        /// Parses the body.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns>Task&lt;System.String&gt;.</returns>
        public async Task<string> ParseBody(HttpResponseMessage response)
        {
            var errorMessage = "";
            Stream receiveStream = await response.Content.ReadAsStreamAsync();
            var encode = System.Text.Encoding.GetEncoding("utf-8");
            // Pipes the stream to a higher level stream reader with the required encoding format.
            using var sr = new StreamReader(receiveStream, encode);
            var s = "";
            while ((s = await sr.ReadLineAsync()) != null)
                if (s.StartsWith("{\"error\":"))
                {
                    Error? error = JsonConvert.DeserializeObject<Error>(s);
                    if (error == null)
                        continue;
                    if (error.error != null && error.error.Length > 1)
                        errorMessage = " - " + char.ToUpper(error.error[0]) + error.error.Substring(1).Replace("_", " ");
                    if (error.error_description != null)
                        errorMessage = errorMessage + " : " + char.ToUpper(error.error_description[0]) + error.error_description.Substring(1);
                }
                else if (s.StartsWith("[\"INVALID_END_DATE\"]")) errorMessage = " - Invalid End Date";

            return errorMessage;
            //{ "error":"signature_check_failed","error_description":"missing date header"}
        }

        /// <summary>
        /// Descriptions for Http Status Code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string GetHttpStatusDescription(HttpStatusCode statusCode)
        {
            switch (statusCode)
            {
                case HttpStatusCode.Continue:
                    return "Continue";
                case HttpStatusCode.SwitchingProtocols:
                    return "Switching Protocols";
                case HttpStatusCode.Processing:
                    return "Processing";
                case HttpStatusCode.OK:
                    return "OK";
                case HttpStatusCode.Created:
                    return "Created";
                case HttpStatusCode.Accepted:
                    return "Accepted";
                case HttpStatusCode.NonAuthoritativeInformation:
                    return "Non-Authoritative Information";
                case HttpStatusCode.NoContent:
                    return "No Content";
                case HttpStatusCode.ResetContent:
                    return "Reset Content";
                case HttpStatusCode.PartialContent:
                    return "Partial Content";
                case HttpStatusCode.MultiStatus:
                    return "Multi-Status";
                case HttpStatusCode.MultipleChoices:
                    return "Multiple Choices";
                case HttpStatusCode.MovedPermanently:
                    return "Moved Permanently";
                case HttpStatusCode.Found:
                    return "Found";
                case HttpStatusCode.SeeOther:
                    return "See Other";
                case HttpStatusCode.NotModified:
                    return "Not Modified";
                case HttpStatusCode.UseProxy:
                    return "Use Proxy";
                case HttpStatusCode.TemporaryRedirect:
                    return "Temporary Redirect";
                case HttpStatusCode.BadRequest:
                    return "Bad Request";
                case HttpStatusCode.Unauthorized:
                    return "Unauthorized";
                case HttpStatusCode.PaymentRequired:
                    return "Payment Required";
                case HttpStatusCode.Forbidden:
                    return "Forbidden";
                case HttpStatusCode.NotFound:
                    return "Not Found";
                case HttpStatusCode.MethodNotAllowed:
                    return "Method Not Allowed";
                case HttpStatusCode.NotAcceptable:
                    return "Not Acceptable";
                case HttpStatusCode.ProxyAuthenticationRequired:
                    return "Proxy Authentication Required";
                case HttpStatusCode.RequestTimeout:
                    return "Request Timeout";
                case HttpStatusCode.Conflict:
                    return "Conflict";
                case HttpStatusCode.Gone:
                    return "Gone";
                case HttpStatusCode.LengthRequired:
                    return "Length Required";
                case HttpStatusCode.PreconditionFailed:
                    return "Precondition Failed";
                case HttpStatusCode.RequestEntityTooLarge:
                    return "Request Entity Too Large";
                case HttpStatusCode.RequestUriTooLong:
                    return "Request-Uri Too Long";
                case HttpStatusCode.UnsupportedMediaType:
                    return "Unsupported Media Type";
                case HttpStatusCode.RequestedRangeNotSatisfiable:
                    return "Requested Range Not Satisfiable";
                case HttpStatusCode.ExpectationFailed:
                    return "Expectation Failed";
                case HttpStatusCode.UnprocessableEntity:
                    return "Unprocessable Entity";
                case HttpStatusCode.Locked:
                    return "Locked";
                case HttpStatusCode.FailedDependency:
                    return "Failed Dependency";
                case HttpStatusCode.InternalServerError:
                    return "Internal Server Error";
                case HttpStatusCode.NotImplemented:
                    return "Not Implemented";
                case HttpStatusCode.BadGateway:
                    return "Bad Gateway";
                case HttpStatusCode.ServiceUnavailable:
                    return "Service Unavailable";
                case HttpStatusCode.GatewayTimeout:
                    return "Gateway Timeout";
                case HttpStatusCode.HttpVersionNotSupported:
                    return "Http Version Not Supported";
                case HttpStatusCode.InsufficientStorage:
                    return "Insufficient Storage";
            }

            return "";
        }

        /// <summary>
        /// Class Error.
        /// </summary>
        public class Error
        {
            /// <summary>
            /// Gets or sets the error.
            /// </summary>
            /// <value>The error.</value>
            public string error { get; set; }

            /// <summary>
            /// Gets or sets the error description.
            /// </summary>
            /// <value>The error description.</value>
            public string error_description { get; set; }
        }
    }
}
