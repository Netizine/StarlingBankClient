using Microsoft.Extensions.DependencyInjection;
using StarlingBank.Services;
namespace StarlingBank
{
    public static class ServiceCollectionExtensions
    {
        public static void AddStarlingBank(this IServiceCollection services)
        {
            services.AddHttpClient("StarlingBank", c =>
            {
                // Set common user-agent
                c.DefaultRequestHeaders.Add("User-Agent", "Starling Bank C# Client");
            });
            services.AddSingleton<IBaseServices, BaseServices>();
            services.AddSingleton<IAccountHoldersService, AccountHoldersService>();
            services.AddSingleton<IAccountsService, AccountsService>();
            services.AddSingleton<IAddressesService, AddressesService>();
            services.AddSingleton<IAPIUserIdentitiesServices, APIUserIdentitiesServices>();
            services.AddSingleton<IBusinessesServices, BusinessesServices>();
            services.AddSingleton<ICardsServices, CardsServices>();
            services.AddSingleton<IDirectDebitMandatesServices, DirectDebitMandatesServices>();
            services.AddSingleton<IFeedRoundUpServices, FeedRoundUpServices>();
            services.AddSingleton<IIndividualsAndSoleTradersServices, IndividualsAndSoleTradersServices>();
            services.AddSingleton<IJointAccountsServices, JointAccountsServices>();
            services.AddSingleton<IKYCServices, KYCServices>();
            services.AddSingleton<IOnboardingServices, OnboardingServices>();
            services.AddSingleton<IPayeesServices, PayeesServices>();
            services.AddSingleton<IPaymentsServices, PaymentsServices>();
            services.AddSingleton<IProfileImagesServices, ProfileImagesServices>();
            services.AddSingleton<IRecurringCardPaymentsServices, RecurringCardPaymentsServices>();
            services.AddSingleton<ISavingsGoalsServices, SavingsGoalsServices>();
            services.AddSingleton<ISettleUpServices, SettleUpServices>();
            services.AddSingleton<ISoleTradersServices, SoleTradersServices>();
            services.AddSingleton<ISpendingInsightsServices, SpendingInsightsServices>();
            services.AddSingleton<ITransactionFeedServices, TransactionFeedServices>();
            services.AddSingleton<IWebhooksServices, WebhooksServices>();
        }
    }
}
