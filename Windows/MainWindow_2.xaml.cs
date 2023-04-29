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
using System.Windows.Shapes;

namespace Course.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow_2.xaml
    /// </summary>
    public partial class MainWindow_2 : Window
    {
        public MainWindow_2(bool isAdmin)
        {
            InitializeComponent();
            if (!isAdmin)
            {
                firstGridColumn.IsEnabled = false;
                firstGridColumn.Width = new GridLength(0);
                WindowStyle = WindowStyle.None;
                ResizeMode = ResizeMode.NoResize;
                WindowState = WindowState.Maximized;
                mainFrame.Navigate(new ServicesPage(false));
            }
        }

        private void navigateToServices(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ServicesPage(true));
        }
    }
}
