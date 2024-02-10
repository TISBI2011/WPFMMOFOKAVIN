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

namespace WPF2_FokavinMMO.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void TBLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = BLogin.Text;
            string password = BPassword.Text;

            var loggedUser = App.DB.User.FirstOrDefault(x => x.Login == login && x.Password == password);
            if (loggedUser == null)
            {
                MessageBox.Show("Не верный логин или пароль");
                return;
            }
            App.LoggedUser = loggedUser;
            if (loggedUser.id == 1)
            {
                NavigationService.Navigate(new MenuPage());
                MessageBox.Show("Салам аллейку братишка");
            }
        }
    }
}
