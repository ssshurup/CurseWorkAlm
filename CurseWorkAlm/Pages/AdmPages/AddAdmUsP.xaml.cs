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
    /// Логика взаимодействия для AddAdmUsP.xaml
    /// </summary>
    public partial class AddAdmUsP : Page
    {
        users context;
        public AddAdmUsP()
        {
            InitializeComponent();
            context = new users();
            DataContext = context;
        }
        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminP());

        }
        private void RegBT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var TryReggistredUser = App.DB.users.Where(a => a.login == context.login);
                if (TryReggistredUser.Any())
                {
                    MessageBox.Show("Этот логин уже занят");
                    return;
                }
                else
                {

                    context.roleId = 2;
                    App.DB.users.Add(context);
                    App.DB.SaveChanges();
                    MessageBox.Show("Успешно");
                    NavigationService.Navigate(new AdminP());
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");

            }
        }
    }
}
