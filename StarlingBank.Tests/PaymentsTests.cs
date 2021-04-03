using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace StarlingBank.Tests
{
    [ExcludeFromCodeCoverage]
    [Collection("Payments Service Tests")]
    public class PaymentsTests : IDisposable, IClassFixture<DependencySetupFixture>
    {
        /// <summary>
        /// The service scope
        /// </summary>
        private readonly IServiceScope _scope;

        private readonly StarlingClient _starlingClient;

        public PaymentsTests(DependencySetupFixture fixture)
        {
            ServiceProvider serviceProvider = fixture.ServiceProvider;
            _scope = serviceProvider.CreateScope();
            _starlingClient = fixture.StarlingClient;
        }

        [Trait("Category", "Test Payments")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetStandingOrderAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Payments")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task UpdateStandingOrderAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Payments")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task CancelStandingOrderAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Payments")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task ListStandingOrdersAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Payments")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task CreateStandingOrderAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Payments")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetPaymentOrderAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Payments")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetPaymentOrderPaymentsAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Payments")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task ListNextPaymentDatesAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Payments")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task MakeLocalPaymentAsyncTest()
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
