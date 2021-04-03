using System;
using System.Threading.Tasks;

namespace StarlingBank.Services
{
    public interface ICardsServices
    {
        /// <summary>
        /// Update ATM withdrawal control
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="enabling">Required parameter: Whether ATM withdrawals should be allowed. Set to false to block, true to allow.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task EnableAtmAsync(StarlingClient starlingClient, Guid cardUid, Models.Enabling enabling);

        /// <summary>
        /// Update card lock
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="enabling">Required parameter: Whether the card should be locked. Set to false to lock, true to unlock.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task EnableCardAsync(StarlingClient starlingClient, Guid cardUid, Models.Enabling enabling);

        /// <summary>
        /// Update currency switch payments control
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="currencyFlag">Required parameter: Whether currency switch payments should be allowed for a given currency. Set to false to block, true to allow.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task EnableCurrencySwitchAsync(StarlingClient starlingClient, Guid cardUid, Models.CurrencyFlag currencyFlag);

        /// <summary>
        /// Update gambling payments control
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="enabling">Required parameter: Whether gambling payments should be allowed. Set to false to block, true to allow.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task EnableGamblingPaymentsAsync(StarlingClient starlingClient, Guid cardUid, Models.Enabling enabling);

        /// <summary>
        /// Update magstripe payments control
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="enabling">Required parameter: Whether magstripe payments should be allowed. Set to false to block, true to allow.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task EnableMagStripePaymentAsync(StarlingClient starlingClient, Guid cardUid, Models.Enabling enabling);

        /// <summary>
        /// Update mobile wallet payments control
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="enabling">Required parameter: Whether mobile wallet payments should be allowed. Set to false to block, true to allow.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task EnableMobileWalletAsync(StarlingClient starlingClient, Guid cardUid, Models.Enabling enabling);

        /// <summary>
        /// Update online payments control
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="enabling">Required parameter: Whether online payments should be allowed. Set to false to block, true to allow.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task EnableOnlinePaymentsAsync(StarlingClient starlingClient, Guid cardUid, Models.Enabling enabling);

        /// <summary>
        /// Update card present payments (contactless and chip and pin) control
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="enabling">Required parameter: Whether card present payments (contactless and chip and pin) should be allowed. Set to false to block, true to allow.</param>
        /// <returns>Task.</returns>
        /// <return>Returns the void response from the API call</return>
        Task EnablePosAsync(StarlingClient starlingClient, Guid cardUid, Models.Enabling enabling);

        /// <summary>
        /// Get all the cards for an account holder
        /// </summary>
        /// <param name="starlingClient">The starling client.</param>
        /// <returns>Task&lt;Models.Cards&gt;.</returns>
        /// <return>Returns the Models.Cards response from the API call</return>
        Task<Models.Cards> ListCardsAsync(StarlingClient starlingClient);
    }
}
