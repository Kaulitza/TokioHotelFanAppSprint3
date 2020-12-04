using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySqlConnector;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TokioHotelFanApp.Models;
using Renci.SshNet.Messages;

namespace TokioHotelFanApp.PresentationLayer
{
    /// <summary>
    /// Interaction logic for UserProfileView.xaml
    /// </summary>
    public partial class UserProfileView : Window
    {
         UserProfileViewModel _UserProfileViewModel;
        public UserProfileView()
        {

        }
         public UserProfileView(UserProfileViewModel userProfileViewModel)
        {
            _UserProfileViewModel = userProfileViewModel;
            InitializeComponent();
        }

        private void EditInfo_Click(object sender, RoutedEventArgs e)
        {
            UserEmailTextBox.IsReadOnly = false;
            UserNameTextBox.IsReadOnly = false;
            UserPasswordTextBox.IsReadOnly = false;

           

        }

        private void SaveInformation(object sender, RoutedEventArgs e)
        {
            Users users = new Users();
            string name = UserNameTextBox.Text.ToString();
            string email = UserEmailTextBox.Text.ToString();
            string password = UserPasswordTextBox.Text.ToString();
            try
            {
                string MyConString = "Server=127.0.0.1;Port=3306;Uid=root;Pwd=;Database=tokiohotel;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "UPDATE users SET name = @nam, password=@pass,email = @eml";
                command.Parameters.AddWithValue("@nam", name);
                command.Parameters.AddWithValue("@pass", password );
                command.Parameters.AddWithValue("@eml", email);
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("DB Error");
            }
        }

        private void DeleteInfo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Are you Sure?");
            string name = UserNameTextBox.Text.ToString();
            string email = UserEmailTextBox.Text.ToString();
            string password = UserPasswordTextBox.Text.ToString();
            try
            {
                string MyConString = "Server=127.0.0.1;Port=3306;Uid=root;Pwd=;Database=tokiohotel;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "DELETE FROM users WHERE name = @nm and email=@ml";
                command.Parameters.AddWithValue("@nm", name);
                command.Parameters.AddWithValue("@ml", email);
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

                Application.Current.Shutdown();

            }
            catch (Exception)
            {
                MessageBox.Show("DB Error");
            }
        }
    }
}
