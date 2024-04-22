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
    /// Логика взаимодействия для CreateAppointmentP.xaml
    /// </summary>
    public partial class CreateAppointmentP : Page
    {
        appointment context;

        public CreateAppointmentP()
        {
            InitializeComponent();
            ServiceCB.ItemsSource = App.DB.services.ToList();
            context = new appointment();
            DataContext = context;
        }

        private void AddAppBT_Click(object sender, RoutedEventArgs e)
        {

            var selectedService = ServiceCB.SelectedItem as services;
            context.serviceId = selectedService.id;

            var selectedEmployee = EmployeeCB.SelectedItem as schedule;
            context.employeeId = selectedEmployee.employeeid;

            context.userId = App.LoggesUser.id;
            context.statusId = 2;
            context.dateAppointment = DateDP.SelectedDate;
            App.DB.appointment.Add(context);
            App.DB.SaveChanges();
            MessageBox.Show("Успешно");
            NavigationService.Navigate(new AppListUserP());
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AppListUserP());
        }

        private void DateDP_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            EmployeeCB.ItemsSource = App.DB.schedule.Where(a => a.date == DateDP.SelectedDate).ToList();
        }
    }
}
