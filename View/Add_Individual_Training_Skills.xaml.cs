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
    /// Interaction logic for Add_Individual_Training_Skills.xaml
    /// </summary>
    public partial class Add_Individual_Training_Skills : Window
    {
        public Add_Individual_Training_Skills()
        {
            InitializeComponent();
        }

        private void ReturnMain(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void AddSit(object sender, RoutedEventArgs e)
        {

        }

        private void AddLayDown(object sender, RoutedEventArgs e)
        {

        }

        private void AddCome(object sender, RoutedEventArgs e)
        {

        }
    }
}
