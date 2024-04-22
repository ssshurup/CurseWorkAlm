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
    /// Логика взаимодействия для EmployeeListP.xaml
    /// </summary>
    public partial class EmployeeListP : Page
    {
        public EmployeeListP()
        {
            InitializeComponent();
            EmployeeListDG.ItemsSource = App.DB.employee.ToList();
        }

        private void AddEmpBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEmpP());
        }

        private void DeleteEmpBT_Click(object sender, RoutedEventArgs e)
        {
                var selectedEmp = EmployeeListDG.SelectedItem as employee;
                if (selectedEmp != null)
                {
                    App.DB.employee.Remove(selectedEmp);
                    App.DB.SaveChanges();
                    MessageBox.Show("Успешно");
                }
                else
                {
                    MessageBox.Show("Выберите что-то");
                }
            
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminP());

        }
    }
}
