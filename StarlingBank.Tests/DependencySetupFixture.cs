using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StarlingBank.Models;

namespace StarlingBank.Tests
{
    /// <summary>
    /// DependencySetupFixture Class.
    /// Implements the <see cref="System.IDisposable" />
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public class DependencySetupFixture : IDisposable
    {
        /// <summary>
        /// Gets the service provider.
        /// </summary>
        /// <value>The service provider.</value>
        public ServiceProvider ServiceProvider { get; }
        public StarlingClient StarlingClient { get; }

        public Guid AccountUid { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencySetupFixture"/> class.
        /// </summary>
        public DependencySetupFixture()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddStarlingBank();
            StarlingClient = StarlingClient.Builder
                .Environment(ServerEnvironment.SANDBOX)
                .OAuthAccessToken("YOUR_OAUTH_TOKEN")
                .Build();

            AccountUid = Guid.Parse("YOUR_ACCOUNT_GUID");

            serviceCollection.AddLogging(configure => configure.AddDebug());

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (ServiceProvider == null)
                return;
            if (ServiceProvider is IDisposable disposable)
                disposable.Dispose();
        }
    }
}
