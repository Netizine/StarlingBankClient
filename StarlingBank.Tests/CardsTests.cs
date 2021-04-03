using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace StarlingBank.Tests
{
    [ExcludeFromCodeCoverage]
    [Collection("Cards Service Tests")]
    public class CardsTests : IDisposable, IClassFixture<DependencySetupFixture>
    {
        /// <summary>
        /// The service scope
        /// </summary>
        private readonly IServiceScope _scope;

        private readonly StarlingClient _starlingClient;

        public CardsTests(DependencySetupFixture fixture)
        {
            ServiceProvider serviceProvider = fixture.ServiceProvider;
            _scope = serviceProvider.CreateScope();
            _starlingClient = fixture.StarlingClient;
        }

        [Trait("Category", "Test Cards")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task EnableAtmAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Cards")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task EnableCardAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Cards")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task EnableCurrencySwitchAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Cards")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task EnableGamblingPaymentsAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Cards")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task EnableMagStripePaymentAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Cards")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task EnableMobileWalletAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Cards")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task EnableOnlinePaymentsAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Cards")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task EnablePosAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Cards")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task ListCardsAsyncTest()
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
