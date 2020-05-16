using BaseDateMVVM.ModelDb;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace BaseDateMVVM.Model
{
    static class UserManager
    {
        private static Users _users { get; set; }
        private static MVVMBaseDatePeopleEntities db = new MVVMBaseDatePeopleEntities();

        public static void RegistrationUser(string name, string lastName, int age, string login, string password)
        {
            _users = new Users(name, lastName, age, login, password);
            db.Users.Add(_users);
            MessageBox.Show("Успешно зарегестрирован!");
            db.SaveChanges();
        }

        [System.Obsolete]
        public static void LoginUser(string login, string password)
        {
            db = new MVVMBaseDatePeopleEntities();
            db.Users.Load();

            var user = db.Users
                .Where(u => u.Login == login && u.Password == password)
                .FirstOrDefault();
            if (user != null)
                MessageBox.Show("Нормально вошел!");
            if (user == null)
                MessageBox.Show("Fuck");
            
        }
    }
}
