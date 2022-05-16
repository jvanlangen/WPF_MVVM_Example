using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppDependencyInjection.Version1.Base
{
    public delegate void CommandAction(object commandParameter);
    public delegate bool CanExecuteFunc(object commandParameter);

    public class RelayCommand : ICommand
    {
        private readonly CommandAction _command;
        private readonly CanExecuteFunc _canExecute;

        public RelayCommand(CommandAction commandAction, CanExecuteFunc canExecute = null)
        {
            _command = commandAction;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Returns default true. 
        /// Customize to implement can execute logic.
        /// </summary>
        public virtual bool CanExecute(object parameter) =>
            _canExecute == null ? true : _canExecute(parameter);

        /// <summary>
        /// Implement changed logic if needed
        /// </summary>
        public event EventHandler CanExecuteChanged;


        public void Execute(object parameter) =>
            _command?.Invoke(parameter);
    }
}
