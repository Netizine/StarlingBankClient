using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace StarlingBank.Tests
{
    [ExcludeFromCodeCoverage]
    [Collection("Individuals And Sole Traders Service Tests")]
    public class IndividualsAndSoleTradersTests : IDisposable, IClassFixture<DependencySetupFixture>
    {
        /// <summary>
        /// The service scope
        /// </summary>
        private readonly IServiceScope _scope;

        private readonly StarlingClient _starlingClient;

        public IndividualsAndSoleTradersTests(DependencySetupFixture fixture)
        {
            ServiceProvider serviceProvider = fixture.ServiceProvider;
            _scope = serviceProvider.CreateScope();
            _starlingClient = fixture.StarlingClient;
        }

        [Trait("Category", "Test Individuals And Sole Traders")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetIndividualAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Individuals And Sole Traders")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task UpdateEmailAsyncTest()
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
