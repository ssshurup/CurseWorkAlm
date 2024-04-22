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

namespace CurseWorkAlm.Pages.AdmPages
{
    /// <summary>
    /// Логика взаимодействия для AppointmentP.xaml
    /// </summary>
    public partial class AppointmentP : Page
    {
        public AppointmentP()
        {
            InitializeComponent();
            AppointmentsDG.ItemsSource = App.DB.appointment.Where(a => a.statusId == 2).ToList();
            WayPayCB.ItemsSource = App.DB.wayPayment.ToList();
        }
        private void DropAppBT_Click(object sender, RoutedEventArgs e)
        {
            var selectedAppointment = AppointmentsDG.SelectedItem as appointment;
            if (selectedAppointment != null)
            {
                App.DB.appointment.Remove(selectedAppointment);
                App.DB.SaveChanges();
                MessageBox.Show("Успешно");
            }
            else
            {
                MessageBox.Show("Выберите что-то");
            }
            AppointmentsDG.ItemsSource = App.DB.appointment.Where(a => a.statusId == 2).ToList();

        }
        private void EditAppBT_Click(object sender, RoutedEventArgs e)
        {
            var selectedAppointment = AppointmentsDG.SelectedItem as appointment;
            if (selectedAppointment != null)
            {
                if (WayPayCB.SelectedItem != null)
                {
                    selectedAppointment.statusId = 1;
                    var selectedWayPay = WayPayCB.SelectedItem as wayPayment;
                    selectedAppointment.wayPayId = selectedWayPay.id;
                    App.DB.SaveChanges();
                    MessageBox.Show("Готово");
                    AppointmentsDG.ItemsSource = App.DB.appointment.Where(a => a.statusId == 2).ToList();
                    App.DB.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Выберите способ оплаты");
                }

            }
        }
        private void CompleteAppBT_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsDG.ItemsSource = App.DB.appointment.Where(a => a.statusId == 1).ToList();
        }

        private void NotCompleteAppBT_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsDG.ItemsSource = App.DB.appointment.Where(a => a.statusId == 2).ToList();

        }

        private void ShowReviewBT_Click(object sender, RoutedEventArgs e)
        {
            var selectedApp = AppointmentsDG.SelectedItem as appointment;
            if (selectedApp != null)
            {
                try
                {
                    var ReviewAboutApp = App.DB.review.Where(a => a.appointmentId == selectedApp.id);
                    if (selectedApp != null)
                    {
                        MessageBox.Show(ReviewAboutApp.First().reviewText);
                    }
                }
                catch
                {
                    MessageBox.Show("Нет отзыва");
                }
            }
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminP());
        }
    }
}
