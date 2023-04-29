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
    /// Логика взаимодействия для NewUserPage.xaml
    /// </summary>
    public partial class NewUserPage : Page
    {
        public NewUserPage()
        {
            InitializeComponent();
            //comboBox.ItemsSource = AppData.db.Role.ToList();
        }

        private void Registr_Button(object sender, RoutedEventArgs e)
        {
            User people = new User();
            people.Login = textBox_Login.Text;
            people.Password = textBox_Password.Text;
            /*var CurrentRole = comboBox.SelectedItem as Role;
            people.RoleID = CurrentRole.RoleID;*/
            AppData.db.User.Add(people);
            AppData.db.SaveChanges();
            MessageBox.Show("Вы успешно зарегестрировались!", "Регистрация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void GoToBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignInPage());
        }
    }
}
