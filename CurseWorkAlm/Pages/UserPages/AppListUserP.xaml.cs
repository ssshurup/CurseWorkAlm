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

namespace CurseWorkAlm.Pages.UserPages
{
    /// <summary>
    /// Логика взаимодействия для AppListUserP.xaml
    /// </summary>
    public partial class AppListUserP : Page
    {
        public AppListUserP()
        {
            InitializeComponent();
            AppointmentsDG.ItemsSource = App.DB.appointment.Where(a => a.userId == App.LoggesUser.id).ToList();

        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserP());
        }
        private void AppListBT_Click(object sender, RoutedEventArgs e)
        {
            HairIMG.Visibility = Visibility.Collapsed;
            AppointmentsDG.Visibility = Visibility.Visible;
            AppointmentsDG.ItemsSource = App.DB.appointment.Where(a => a.userId == App.LoggesUser.id).ToList();

        }
        private void ReviewBT_Click(object sender, RoutedEventArgs e)
        {
            var selectedApp = AppointmentsDG.SelectedItem as appointment;
            if (selectedApp != null)
            {
                NavigationService.Navigate(new ReviewP(selectedApp));

            }
        }

        private void AddAppBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateAppointmentP());
        }
    }
}
