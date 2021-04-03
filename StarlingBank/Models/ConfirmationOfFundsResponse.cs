using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Class ConfirmationOfFundsResponse.
    /// </summary>
    public class ConfirmationOfFundsResponse
    {
        /// <summary>
        /// True if requested amount is available to spend
        /// </summary>
        /// <value><c>null</c> if [requested amount available to spend] contains no value, <c>true</c> if [requested amount available to spend]; otherwise, <c>false</c>.</value>
        [JsonProperty("requestedAmountAvailableToSpend")]
        public bool? RequestedAmountAvailableToSpend { get; set; }

        /// <summary>
        /// True if spending the requested amount would put the account in overdraft
        /// </summary>
        /// <value><c>null</c> if [account would be in overdraft if requested amount spent] contains no value, <c>true</c> if [account would be in overdraft if requested amount spent]; otherwise, <c>false</c>.</value>
        [JsonProperty("accountWouldBeInOverdraftIfRequestedAmountSpent")]
        public bool? AccountWouldBeInOverdraftIfRequestedAmountSpent { get; set; }
    }
}
