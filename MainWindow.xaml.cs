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

namespace Dog_Training_App_Prototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Goto_Daily_Page(object sender, RoutedEventArgs e)
        {
            Daily_Page daily_page = new Daily_Page();
            this.Visibility = Visibility.Hidden;
            daily_page.Show();
        }

        private void Goto_Statistics(object sender, RoutedEventArgs e)
        {
            Statistics_Page statistics_page = new Statistics_Page();
            this.Visibility = Visibility.Hidden;
            statistics_page.Show();
        }

        private void Goto_Add_Skills(object sender, RoutedEventArgs e)
        {
            Add_Individual_Training_Skills skills_page = new Add_Individual_Training_Skills();
            this.Visibility = Visibility.Hidden;
            skills_page.Show();
        }

        private void Goto_Training_Path(object sender, RoutedEventArgs e)
        {
            Training_Path_Page training_path = new Training_Path_Page();
            this.Visibility = Visibility.Hidden;
            training_path.Show();
        }
    }
}
