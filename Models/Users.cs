using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TokioHotelFanApp.Models
{
    public class Users
    {
        string _user_name;
        string _password;
        string _user_email;
        Image _user_image;

        //properties
        public string UserName
        {
            get { return _user_name; }
            set { _user_name = value; }
        }
        public string Pasword
        {
            get { return _password; }
            set { _password = value; }
        }
        public string UserEmail
        {
            get { return _user_email; }
            set { _user_email = value; }
        }
        public Image Image
        {
            get { return _user_image; }
            set { _user_image = value; }
        }

    }
}
