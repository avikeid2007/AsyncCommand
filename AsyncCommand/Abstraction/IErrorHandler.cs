using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmAsyncCommands.Abstraction
{
    public interface IErrorHandler
    {
        void HandleError(Exception ex);
    }
}
