using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace StarlingBank.Tests
{
    [ExcludeFromCodeCoverage]
    [Collection("Payees Service Tests")]
    public class PayeesTests : IDisposable, IClassFixture<DependencySetupFixture>
    {
        /// <summary>
        /// The service scope
        /// </summary>
        private readonly IServiceScope _scope;

        private readonly StarlingClient _starlingClient;

        public PayeesTests(DependencySetupFixture fixture)
        {
            ServiceProvider serviceProvider = fixture.ServiceProvider;
            _scope = serviceProvider.CreateScope();
            _starlingClient = fixture.StarlingClient;
        }

        [Trait("Category", "Test Payees")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetPayeesAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Payees")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task CreatePayeeAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Payees")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task CreatePayeeAccountAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Payees")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task DeletePayeeAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Payees")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task DeletePayeeAccountAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Payees")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task ListPaymentOrdersForAccountAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Payees")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task ListPaymentsForPayeeAccountAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Payees")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task ServePayeeImageFileAsyncTest()
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
