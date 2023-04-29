using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Page
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Back_Button(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void login(object sender, RoutedEventArgs e)
        {
            if (pinCodeInput.Password == "123456")
            {
                MainWindow_2 a = new MainWindow_2(true);
                a.Show();
            }
            else
            {
                MessageBox.Show("Не верный PIN!", "Вход не выполнен", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
