using BaseDateMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BaseDateMVVM.MyUserComponent
{
    /// <summary>
    /// Логика взаимодействия для UserControlRegistrationWindow.xaml
    /// </summary>
    public partial class UserControlRegistrationWindow : UserControl
    {
        public UserControlRegistrationWindow()
        {
            InitializeComponent();
            DataContext = new UserControlRegWindowViewModel();
        }
    }
}
