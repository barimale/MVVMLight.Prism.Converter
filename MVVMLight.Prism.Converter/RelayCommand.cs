using Prism.Commands;
using System;

namespace MVVMLight.Prism.Converter
{
    public class RelayCommand : DelegateCommand
    {
        public RelayCommand(Action executeMethod)
            : base(executeMethod)
        {
            //intentionally left blank
        }

        public RelayCommand(Action executeMethod, Func<bool> canExecuteMethod)
            : base(executeMethod, canExecuteMethod)
        {
            //intentionally left blank
        }
    }
}
