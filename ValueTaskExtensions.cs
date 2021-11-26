using System;
using System.Threading.Tasks;

namespace System
{
    public static class ValueTaskExtensions
    {
        /// <summary>
        /// Safely execute the task without waiting for it to complete.
        /// </summary>
        /// <param name="task">The task to execute.</param>
        /// <param name="onException">An action to perform on an <c>exception</c>, if one is thrown while executing the task.
        /// If <c>null</c>, the exception will be thrown up to the caller.</param>
        public static async void SafeFireAndForget(this ValueTask task, Action<Exception>? onException = null)
        {
            try
            {
                await task.ConfigureAwait(true);
            }
            catch(Exception e) when (onException is { })
            {
                onException(e);
            }
        }
    }
}
