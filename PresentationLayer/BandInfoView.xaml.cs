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

namespace TokioHotelFanApp.PresentationLayer
{
    /// <summary>
    /// Interaction logic for BandInfoView.xaml
    /// </summary>
    public partial class BandInfoView : Window
    {
        public BandInfoView()
        {
            InitializeComponent();
        }

        private void UserProfile_Click(object sender, RoutedEventArgs e)
        {
            UserProfileView userProfileView = new UserProfileView();
            userProfileView.Show();
            this.Close();
        }

        private void Discography_Click(object sender, RoutedEventArgs e)
        {
            DiscographyView discographyView = new DiscographyView();
            discographyView.Show();
            this.Close();
        }
    }
}
