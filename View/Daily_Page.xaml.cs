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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Dog_Training_App_Prototype
{
    /// <summary>
    /// Interaction logic for Daily_Page.xaml
    /// </summary>
    public partial class Daily_Page : Window
    {
        public Daily_Page()
        {
            InitializeComponent();
        }

        private void Back1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
