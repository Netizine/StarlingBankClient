using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace StarlingBank.Tests
{
    [ExcludeFromCodeCoverage]
    [Collection("Transaction Feed Service Tests")]
    public class TransactionFeedTests : IDisposable, IClassFixture<DependencySetupFixture>
    {
        /// <summary>
        /// The service scope
        /// </summary>
        private readonly IServiceScope _scope;

        private readonly StarlingClient _starlingClient;

        public TransactionFeedTests(DependencySetupFixture fixture)
        {
            ServiceProvider serviceProvider = fixture.ServiceProvider;
            _scope = serviceProvider.CreateScope();
            _starlingClient = fixture.StarlingClient;
        }

        [Trait("Category", "Test Transaction Feed")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task ChangeTransactionCategoryAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Transaction Feed")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetReceiptAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Transaction Feed")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task CreateOrUpdateReceiptAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Transaction Feed")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task DownloadFeedItemAttachmentAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Transaction Feed")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetFeedItemAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Transaction Feed")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetFeedItemAttachmentsAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Transaction Feed")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task GetMastercardFeedItemAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Transaction Feed")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task QueryFeedItemsAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Transaction Feed")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task QueryFeedItemsWithTransactionTimesBetweenAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Trait("Category", "Test Transaction Feed")]
        [Fact(DisplayName = "Test Getting The Account Holder")]
        public async Task UpdateUserNoteAsyncTest()
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
