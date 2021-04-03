using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using StarlingBank.Services;
using Xunit;

namespace StarlingBank.Tests
{
    [ExcludeFromCodeCoverage]
    [Collection("Account Holders Service Tests")]
    public class AccountHoldersTests : IDisposable, IClassFixture<DependencySetupFixture>
    {
        /// <summary>
        /// The service scope
        /// </summary>
        private readonly IServiceScope _scope;

        private readonly StarlingClient _starlingClient;

        public AccountHoldersTests(DependencySetupFixture fixture)
        {
            ServiceProvider serviceProvider = fixture.ServiceProvider;
            _scope = serviceProvider.CreateScope();
            _starlingClient = fixture.StarlingClient;
        }

        [Trait("Category", "Test Account Holders")]
        [Fact(DisplayName = "Get The Account Holder")]
        public async Task GetAccountHolderTest()
        {
            // Arrange
            IAccountHoldersService accountHoldersService = _scope.ServiceProvider.GetServices<IAccountHoldersService>().FirstOrDefault();
            Assert.NotNull(accountHoldersService);

            // Act
            var accountHolder = await accountHoldersService.GetAccountHolderAsync(_starlingClient);

            // Assert
            Assert.NotNull(accountHolder);
            Assert.NotNull(accountHolder.AccountHolderUid);
            Assert.True(Guid.TryParse(accountHolder.AccountHolderUid.ToString(), out Guid _));
        }

        [Trait("Category", "Test Account Holders")]
        [Fact(DisplayName = "Get The Account Holder Name")]
        public async Task GetAccountHolderNameTest()
        {
            // Arrange
            IAccountHoldersService accountHoldersService = _scope.ServiceProvider.GetServices<IAccountHoldersService>().FirstOrDefault();
            Assert.NotNull(accountHoldersService);

            // Act
            var accountHolder = await accountHoldersService.GetAccountHolderNameAsync(_starlingClient);

            // Assert
            Assert.NotNull(accountHolder);
            Assert.NotNull(accountHolder.AccountHolderNameValue);
            Assert.NotEmpty(accountHolder.AccountHolderNameValue);
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
