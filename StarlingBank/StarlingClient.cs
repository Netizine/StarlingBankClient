using System.ComponentModel.DataAnnotations;
using FluentValidation;
using StarlingBank.Models;

namespace StarlingBank
{
    public class StarlingClient
    {
        private StarlingClient() { }
        public static StarlingClientBuilder Builder => new StarlingClientBuilder();
        public class StarlingClientBuilder
        {
            private ServerEnvironment _environment;
            public StarlingClientBuilder Environment(ServerEnvironment environment)
            {
                _environment = environment;
                return this;
            }
            private string _oAuthAccessToken;
            public StarlingClientBuilder OAuthAccessToken(string oAuthAccessToken)
            {
                _oAuthAccessToken = oAuthAccessToken;
                return this;
            }
            public StarlingClient Build()
            {
                return ValidStarlingClient();
            }
            private StarlingClient ValidStarlingClient()
            {
                var validator = new StarlingClientValidator();
                if (_environment == ServerEnvironment.NOT_SET)
                {
                    _environment = ServerEnvironment.SANDBOX;
                }
                var starlingClient = new StarlingClient
                {
                    Environment = _environment,
                    OAuthAccessToken = _oAuthAccessToken,
                };
                validator.ValidateAndThrow(starlingClient);
                return starlingClient;
            }
        }
        public class StarlingClientValidator : AbstractValidator<StarlingClient>
        {
            public StarlingClientValidator()
            {
                RuleFor(x => x.OAuthAccessToken).NotNull().NotEmpty().NotEqual("YOUR_OAUTH_TOKEN").WithMessage("OAuthAccessToken is required.");
            }
        }
        public ServerEnvironment Environment { get; private set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "OAuthAccessToken is required.")]
        public string OAuthAccessToken { get; private set; }
    }
}
