using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using StarlingBank.Models;
using StarlingBank.Services;
using Xunit;

namespace StarlingBank.Tests
{
    [ExcludeFromCodeCoverage]
    [Collection("Accounts Service Tests")]
    public class AccountsTests : IDisposable, IClassFixture<DependencySetupFixture>
    {
        /// <summary>
        /// The service scope
        /// </summary>
        private readonly IServiceScope _scope;

        private readonly StarlingClient _starlingClient;
        private readonly Guid _accountUid;


        public AccountsTests(DependencySetupFixture fixture)
        {
            ServiceProvider serviceProvider = fixture.ServiceProvider;
            _scope = serviceProvider.CreateScope();
            _starlingClient = fixture.StarlingClient;
            _accountUid = fixture.AccountUid;
        }


        [Trait("Category", "Test Accounts")]
        [Fact(DisplayName = "Get Available Periods")]
        public async Task AvailablePeriodsAsyncTest()
        {
            // Arrange
            IAccountsService accountsService = _scope.ServiceProvider.GetServices<IAccountsService>().FirstOrDefault();
            Assert.NotNull(accountsService);

            // Act
            AccountStatementPeriods availablePeriods = await accountsService.AvailablePeriodsAsync(_starlingClient, _accountUid);

            // Assert
            Assert.NotNull(availablePeriods);
            Assert.NotNull(availablePeriods.Periods);
            Assert.NotEmpty(availablePeriods.Periods);
        }

        [Trait("Category", "Test Accounts")]
        [Fact(DisplayName = "Download PDF Statement")]
        public async Task DownloadStatementAsyncTest()
        {
            // Arrange
            IAccountsService accountsService = _scope.ServiceProvider.GetServices<IAccountsService>().FirstOrDefault();
            Assert.NotNull(accountsService);

            // Act
            var statementParameters = StatementParameters.Builder
                .StarlingClient(_starlingClient)
                .AccountUid(_accountUid)
                .Year(DateTime.Now.Year.ToString(CultureInfo.InvariantCulture))
                .Month(DateTime.Now.Month.ToString("#00", CultureInfo.InvariantCulture))
                .Build();
            var statementStream = await accountsService.DownloadStatementAsync(statementParameters);

            // Assert
            Assert.NotNull(statementStream);
        }

        [Trait("Category", "Test Accounts")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task DownloadPDFStatementForDateRangeAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Accounts")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetAccountBalanceAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Accounts")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetAccountIdentifiersAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Accounts")]
        [Fact(DisplayName = "Test Getting The Account")]
        public async Task GetAccountsAsyncTest()
        {
            // Arrange
            IAccountsService accountsService = _scope.ServiceProvider.GetServices<IAccountsService>().FirstOrDefault();
            Assert.NotNull(accountsService);

            // Act
            Accounts accounts = await accountsService.GetAccountsAsync(_starlingClient);

            // Assert
            Assert.NotNull(accounts);
            Assert.NotEqual(0, accounts.AccountsValue.Count);
        }

        [Trait("Category", "Test Accounts")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetConfirmationOfFundsAsyncTest()
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
