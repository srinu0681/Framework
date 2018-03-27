using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AddressMatchTool.Commands
{
    public class DelegateCommand : ICommand
    {
        public Action WhatToExecute;
        public Func<bool> WhenToExecute;

        public DelegateCommand(Action What, Func<bool> When)
        {
            WhatToExecute = What;
            WhenToExecute = When;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return WhenToExecute();
        }

        public void Execute(object parameter)
        {
            WhatToExecute();
        }
    }
}
