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

namespace Dog_Training_App_Prototype
{
    /// <summary>
    /// Interaction logic for Statistics_Page.xaml
    /// </summary>
    public partial class Statistics_Page : Window
    {
        public Statistics_Page()
        {
            InitializeComponent();
        }

        private void Back2(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
