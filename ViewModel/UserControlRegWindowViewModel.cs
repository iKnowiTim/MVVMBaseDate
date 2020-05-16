using System.ComponentModel;
using System.Windows.Input;
using BaseDateMVVM.Model;
using BaseDateMVVM.ModelDb;

namespace BaseDateMVVM.ViewModel
{
    class UserControlRegWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        

        public UserControlRegWindowViewModel()
        {
            InitCommand();
        }

        private void InitCommand()
        {
            RegistrationUserCommand = new RelayCommand(RegistrationUser, CanExecuteRegisterUserCommand);
        }

        private string _userName = "";
        public string UserName
        {
            get { return _userName; }
            set 
            { 
                _userName = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(UserName)));
            }
        }

        private string _userLastName = "";
        public string UserLastName
        {
            get { return _userLastName; }
            set 
            { 
                _userLastName = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(UserPassword)));
            }
        }

        private int _userAge = 0;
        public int UserAge
        {
            get { return _userAge; }
            set 
            { 
                _userAge = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(UserAge)));
            }
        }

        private string _userLogin = "";
        public string UserLogin
        {
            get { return _userLogin; }
            set 
            { 
                _userLogin = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(UserLogin)));
            }
        }

        private string _userPassword = "";
        public string UserPassword
        {
            get { return _userPassword; }
            set 
            { 
                _userPassword = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(UserPassword)));
            }
        }

        public ICommand RegistrationUserCommand { get; set; }

        private bool CanExecuteRegisterUserCommand(object parameter)
        {
            return UserName.Length > 0 && UserLastName.Length > 0 && 
                UserAge > 0 && UserLogin.Length > 0 && UserPassword.Length > 0;
        }

        private void RegistrationUser()
        {
            UserManager.RegistrationUser(UserName, UserLastName, UserAge, UserLogin, UserPassword);
        }
    }
}
