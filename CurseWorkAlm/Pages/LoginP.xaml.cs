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

namespace CurseWorkAlm.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginP.xaml
    /// </summary>
    public partial class LoginP : Page
    {
        users context;
        public LoginP()
        {
            InitializeComponent();
            context = new users();
            DataContext = context;
        }

        private void RegBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegP());
        }

        private void LogBT_Click(object sender, RoutedEventArgs e)
        {
            var loggedUser = App.DB.users.Where(a => a.login == context.login && a.password == context.password);
            if (loggedUser.Any())
            {
                App.LoggesUser = loggedUser.First();
                if(App.LoggesUser.roleId == 1) NavigationService.Navigate(new UserP());
                else if(App.LoggesUser.roleId == 2 ) NavigationService.Navigate(new AdminP());
            }
            else
            {
                MessageBox.Show("Incorrect login or password");
                return;
            }
        }
    }
}
