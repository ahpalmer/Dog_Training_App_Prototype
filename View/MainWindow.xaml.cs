using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
        ObservableCollection<UserProfile> YourGridList { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            string user_str0 = "default user";
            string pass_str0 = "default pass";
            YourGridList = new ObservableCollection<UserProfile>();
            DataContext = YourGridList;

            AddUser(user_str0, pass_str0);

            //var User1 = new UserProfile(user_str0, pass_str0);
            //YourGridList.Add(User1);

            //Trace.WriteLine($"{DataContext.GetType()}");
            var User2 = new UserProfile("user2", "pass2");
            YourGridList.Add(User2);
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void LogonClick(object sender, RoutedEventArgs e)
        {
            string user_str = username_input.Text;
            //I recognize that you are not supposed to take passwords as text.  This is a placeholder to get the app working, and then I'll start looking into programatic ways to input passwords.
            string pass_str = password_input.Text;
            AddUser(user_str, pass_str);
            //TODO: add user to DB after you connect DB to model
        }

        public void AddUser(string user, string pass)
        {
            var User = new UserProfile(user, pass);
            YourGridList.Add(User);
        }

        private void CreateUserClick(object sender, RoutedEventArgs e)
        {
            //I recognize that you are not supposed to take passwords as text.  This is a placeholder to get the app working, and then I'll start looking into programatic ways to input passwords.
            string pass_str = password_input.Text;
            AddUser(username_input.Text, pass_str);
            //TODO: add user to DB after you connect DB to model
        }
    }
}
