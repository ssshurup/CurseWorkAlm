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
    /// Логика взаимодействия для SheduleP.xaml
    /// </summary>
    public partial class SheduleP : Page
    {
        schedule context;
        public SheduleP()
        {
            InitializeComponent();
            EmployeeCB.ItemsSource = App.DB.employee.ToList();
            context = new schedule();
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            context.date = DaysShDP.SelectedDate;
            var selectedEmpl = EmployeeCB.SelectedItem as employee;
            context.employeeid = selectedEmpl.id; 
            App.DB.schedule.Add(context);
            App.DB.SaveChanges();
            MessageBox.Show("Успешно");
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminP());
        }
    }
}
