using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MySqlConnector;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TokioHotelFanApp.Models;
using TokioHotelFanApp.DataLayer.Data;

namespace TokioHotelFanApp.PresentationLayer
{
    /// <summary>
    /// Interaction logic for SignUpView.xaml
    /// </summary>
    public partial class SignUpView : Window
    {
        UserProfileViewModel userProfileViewModel;
        DiscographyView _discographyView;
        UserProfileView _userProfileView;
        LogInView logInView;
        Users user = new Users();
        String id;
        public Users User
        {
            get { return user; }
            set { user = value; }
        }
        public String ID
        {
            get { return id; }
            set { id = value; }

        }

        public SignUpView()
        {
            InitializeComponent();
        }

        private void SignupButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text.ToString();
            string email = EmailTextBox.Text.ToString();
            string password = PasswordTextBox.Text.ToString();
            try
            {
                string MyConString = "Server=127.0.0.1;Port=3306;Uid=root;Pwd=;Database=tokiohotel;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO users (name,password,email,image) VALUES (@nam,@pass, @eml,@img)";
                //command.Parameters.AddWithValue("@id", 2);

                command.Parameters.AddWithValue("@nam", name);
                command.Parameters.AddWithValue("@pass", password);
                command.Parameters.AddWithValue("@eml", email);
                command.Parameters.AddWithValue("@img", "none");

                connection.Open();

                command.ExecuteNonQuery();
                command.CommandText = "select id from users where name=@na and email=@mai and password=@pas";
                command.Parameters.AddWithValue("@na", name);
                command.Parameters.AddWithValue("@pas", password);
                command.Parameters.AddWithValue("@mai", email);
                MySqlDataReader Reader;
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    ID= Reader[0].ToString();
                   
                }
                user.UserName = name;
                user.Pasword = password;
                user.UserEmail = email;
                connection.Close();

                MessageBox.Show("User Added Successfully");

                NameTextBox.Text = "";
                EmailTextBox.Text = "";
                PasswordTextBox.Text = "";

                userProfileViewModel = new UserProfileViewModel(User);
                _userProfileView = new UserProfileView(userProfileViewModel);
                _userProfileView.DataContext = userProfileViewModel;
                _userProfileView.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("DB Error");
            }

        }

        private void ViewLogin_Click(object sender, RoutedEventArgs e)
        {
            logInView = new LogInView();
            logInView.Show();
            NameTextBox.Text = "";
            EmailTextBox.Text = "";
            PasswordTextBox.Text = "";
        }
    }
}
