using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace BaseDateMVVM.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            InitCommand();
        }

        public Action CloseAction { get; set; }

        private void InitCommand()
        {
            CloseWindowCommand = new RelayCommand(CloseAction);
        }

        public ICommand CloseWindowCommand { get; set; }
    }
}
