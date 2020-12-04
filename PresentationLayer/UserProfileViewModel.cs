using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TokioHotelFanApp.BusinessLayer;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.ObjectModel;
using TokioHotelFanApp.Models;
using TokioHotelFanApp.DataLayer.Data;


namespace TokioHotelFanApp.PresentationLayer
{
   public class UserProfileViewModel
    {
        private Users users_;

        public UserProfileViewModel(Users users_)
        {
            User = users_;
        }
        public Users User
        {
            get => this.users_;
            set
            {
                this.users_ = value;
                //this.onPropertyRaised(nameof(this.users_));
            }
        }
    }
}
