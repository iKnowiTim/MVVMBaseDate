using System;
using System.Windows.Input;

namespace BaseDateMVVM.ViewModel
{
    class RelayCommand : ICommand
    {
        private Action _execute { get; set; }
        private Func<object, bool> _canExecute { get; set; }

        public RelayCommand(Action execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute();
        }
    }
}
