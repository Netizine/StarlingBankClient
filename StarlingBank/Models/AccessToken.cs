using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Class AccessToken.
    /// </summary>
    public class AccessToken
    {
        /// <summary>
        /// The access token
        /// </summary>
        /// <value>The access token value.</value>
        [JsonProperty("accessToken")]
        public string AccessTokenValue { get; set; }

        /// <summary>
        /// The refresh token
        /// </summary>
        /// <value>The refresh token.</value>
        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// The token type, as described in https://tools.ietf.org/html/rfc6749#section-7.1
        /// </summary>
        /// <value>The type of the token.</value>
        [JsonProperty("tokenType")]
        public string TokenType { get; set; }

        /// <summary>
        /// The time in seconds from issuance at which the access token will expire
        /// </summary>
        /// <value>The access token expires in seconds.</value>
        [JsonProperty("accessTokenExpiresInSeconds")]
        public long? AccessTokenExpiresInSeconds { get; set; }

        /// <summary>
        /// The scopes which this token has permission to use: Space delimited case sensitive Strings, as described in https://tools.ietf.org/html/rfc6749#section-3.3
        /// </summary>
        /// <value>The scope.</value>
        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}
