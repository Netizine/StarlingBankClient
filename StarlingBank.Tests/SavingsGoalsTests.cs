using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace StarlingBank.Tests
{
    [ExcludeFromCodeCoverage]
    [Collection("Savings Goals Service Tests")]
    public class SavingsGoalsTests : IDisposable, IClassFixture<DependencySetupFixture>
    {
        /// <summary>
        /// The service scope
        /// </summary>
        private readonly IServiceScope _scope;

        private readonly StarlingClient _starlingClient;

        public SavingsGoalsTests(DependencySetupFixture fixture)
        {
            ServiceProvider serviceProvider = fixture.ServiceProvider;
            _scope = serviceProvider.CreateScope();
            _starlingClient = fixture.StarlingClient;
        }

        [Trait("Category", "Test Savings Goals")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task AddMoneyAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Savings Goals")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetRecurringTransferAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Savings Goals")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task CreateOrUpdateRecurringTransferAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Savings Goals")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task DeleteRecurringTransferAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Savings Goals")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetSavingsGoalsAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Savings Goals")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task CreateSavingsGoalAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Savings Goals")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetSavingsGoalAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Savings Goals")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task UpdateSavingsGoalAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Savings Goals")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task DeleteSavingsGoalAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Savings Goals")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetSavingsGoalPhotoAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Savings Goals")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task WithdrawMoneyAsyncTest()
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
