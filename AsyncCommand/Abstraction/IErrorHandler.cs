using System;

namespace AsyncCommands.Abstraction
{
    public interface IErrorHandler
    {
        void HandleError(Exception ex);
    }
}
