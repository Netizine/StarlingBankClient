using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace StarlingBank.Tests
{
    [ExcludeFromCodeCoverage]
    [Collection("API User Identities Service Tests")]
    public class APIUserIdentitiesTests : IDisposable, IClassFixture<DependencySetupFixture>
    {
        /// <summary>
        /// The service scope
        /// </summary>
        private readonly IServiceScope _scope;

        private readonly StarlingClient _starlingClient;

        public APIUserIdentitiesTests(DependencySetupFixture fixture)
        {
            ServiceProvider serviceProvider = fixture.ServiceProvider;
            _scope = serviceProvider.CreateScope();
            _starlingClient = fixture.StarlingClient;
        }


        [Trait("Category", "Test API User Identities")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetAuthorisingIndividualAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test API User Identities")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetTokenIdentityAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test API User Identities")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task LogoutIndividualAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (_scope == null)
                return;
            if (_scope is IDisposable disposable)
                disposable.Dispose();
        }
    }
}
