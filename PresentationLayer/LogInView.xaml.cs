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
using MySqlConnector;
using System.Data;
using TokioHotelFanApp.Models;

namespace TokioHotelFanApp.PresentationLayer
{
    /// <summary>
    /// Interaction logic for LogInView.xaml
    /// </summary>
    public partial class LogInView : Window
    {
        public LogInView()
        {
            InitializeComponent();
        }
        public Users User
        {
            get { return user; }
            set { user = value; }
        }

        String id;
        UserProfileViewModel userProfileViewModel;
        DiscographyView _discographyView;
        UserProfileView _userProfileView;
        LogInView logInView;
        Users user = new Users();
        public String ID
        {
            get { return id; }
            set { id = value; }

        }

        private void LogInClick(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text.ToString();
            string password = PasswordTextBox.Text.ToString();


            try
            {
                string MyConString = "Server=127.0.0.1;Port=3306;Uid=root;Pwd=;Database=tokiohotel;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from users where email =@uname AND password =@pass";
                command.Parameters.AddWithValue("@uname", email);
                command.Parameters.AddWithValue("@pass", password);

                connection.Open();

                int count = Convert.ToInt32(command.ExecuteScalar());

                if(count>0)
                {
                    user.UserName = email;
                    user.Pasword = password;
                    ID = count.ToString();
                }
                else
                {
                    MessageBox.Show("Email or password is incorrect");
                }
                connection.Close();

                userProfileViewModel = new UserProfileViewModel(User);
                _userProfileView = new UserProfileView(userProfileViewModel);
                _userProfileView.DataContext = userProfileViewModel;
                _userProfileView.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error");
            }

         
        }

    }
}
