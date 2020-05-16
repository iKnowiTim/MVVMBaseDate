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
            RegistrationUserCommand = new RelayCommand(RegistrationUser);
        }

        private string _userName = "";
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _userLastName = "";
        public string UserLastName
        {
            get { return _userLastName; }
            set { _userLastName = value; }
        }

        private int _userAge = 0;
        public int UserAge
        {
            get { return _userAge; }
            set { _userAge = value; }
        }

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

        public ICommand RegistrationUserCommand { get; set; }

        private void RegistrationUser()
        {
            UserManager.RegistrationUser(UserName, UserLastName, UserAge, UserLogin, UserPassword);
        }
    }
}
