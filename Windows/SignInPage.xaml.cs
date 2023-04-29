using Course.Model;
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

namespace Course.Windows
{
    /// <summary>
    /// Логика взаимодействия для SignInPage.xaml
    /// </summary>
    public partial class SignInPage : Page
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void SignIn_Button(object sender, RoutedEventArgs e)
        {
            var CurrentUser = AppData.db.User.FirstOrDefault(u => u.Login == textBox_Login.Text && u.Password == textBox_Password.Text);

            if (CurrentUser != null)
            {
                NavigationService.Navigate(new WelcomePage());
            }
            else
            {
                MessageBox.Show("Пользователь не найден!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void GoToRegist_Window(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewUserPage());
        }

        private void GoToAdminWindow(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminWindow());
        }
    }
}
