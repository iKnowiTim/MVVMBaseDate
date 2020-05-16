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

        private bool _registrationComponentVisibility;
        public bool RegistrationComponentVisibility
        {
            get
            {
                return _registrationComponentVisibility;
            }
            set
            {
                _registrationComponentVisibility = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(RegistrationComponentVisibility)));
            }
        }

        private void InitCommand()
        {
            CloseWindowCommand = new RelayCommand(CloseWindow);
        }

        public ICommand CloseWindowCommand { get; set; }

        public void CloseWindow()
        {
            Application.Current.Shutdown();
        }
    }
}
