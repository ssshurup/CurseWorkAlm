using CurseWorkAlm.Pages.AdmPages;
using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
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

namespace CurseWorkAlm.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminP.xaml
    /// </summary>
    public partial class AdminP : Page
    {
        public AdminP()
        {
            InitializeComponent();
         
        }

        private void AddEmpBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEmpP());
        }
        private void AddAdmBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddAdmUsP());
        }
        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginP());

        }
        private void ScheduleP_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SheduleP());
        }
        private void AppBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AppointmentP());
        }
        private void AdBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminListP());
        }
        private void UsBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeeListP());
        }
    }
}
