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
    /// Логика взаимодействия для AdminListP.xaml
    /// </summary>
    public partial class AdminListP : Page
    {
        public AdminListP()
        {
            InitializeComponent();
            AdminListDG.ItemsSource = App.DB.users.Where(a => a.roleId == 2).ToList();
        }

        private void AddEmpBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddAdmUsP());
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminP());
        }

        private void DeleteEmpBT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedUs = AdminListDG.SelectedItem as users;
                if (selectedUs != null)
                {
                    App.DB.users.Remove(selectedUs);
                    App.DB.SaveChanges();
                    MessageBox.Show("Успешно");
                    AdminListDG.ItemsSource = App.DB.users.Where(a => a.roleId == 2).ToList();
                }
                else
                {
                    MessageBox.Show("Выберите что-то");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
