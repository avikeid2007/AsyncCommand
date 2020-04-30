using AsyncCommands.Abstraction;
using System;
using System.Threading.Tasks;

namespace AsyncCommands
{
    public static class TaskUtilities
    {
        public static async void FireAndForgetSafeAsync(this Task task, IErrorHandler errorHandler)
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                errorHandler?.HandleError(ex);
            }
        }
    }
}
