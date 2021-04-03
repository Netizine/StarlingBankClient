using System;
using System.Threading.Tasks;
namespace StarlingBank.Utilities
{
    public static class RetryHelper
    {
        public static async Task RetryOnExceptionAsync(
            int times, TimeSpan delay, Func<Task> operation)
        {
            await RetryOnExceptionAsync<Exception>(times, delay, operation).ConfigureAwait(false);
        }
        public static async Task RetryOnExceptionAsync<TException>(
            int times, TimeSpan delay, Func<Task> operation) where TException : Exception
        {
            if (times < 0)
                throw new ArgumentOutOfRangeException(nameof(times));
            var attempts = -1;
            do
            {
                try
                {
                    attempts++;
                    await operation().ConfigureAwait(false);
                    break;
                }
                catch (TException ex)
                {
                    if (attempts == times)
                        throw;
                    await Task.Delay(delay).ConfigureAwait(false);
                }
            } while (true);
        }
    }
}
