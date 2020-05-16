using BaseDateMVVM.Model;
using System.ComponentModel;
using System.Windows.Input;

namespace BaseDateMVVM.ViewModel
{
    class UserControlLoginWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public UserControlLoginWindowViewModel()
        {
            InitCommand();
        }

        [System.Obsolete]
        private void InitCommand()
        {
            LoginUserCommand = new RelayCommand(LoginUser);
        }

        public ICommand LoginUserCommand { get; set; }

        private string _userLogin = "";
        public string UserLogin
        {
            get { return _userLogin; }
            set { _userLogin = value; }
        }

        private string _userPassword = "";
        public string UserPassword
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }

        [System.Obsolete]
        private void LoginUser()
        {
            UserManager.LoginUser(UserLogin, UserPassword);
        }
    }
}
