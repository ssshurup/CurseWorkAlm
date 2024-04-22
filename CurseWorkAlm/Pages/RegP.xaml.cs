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
    /// Логика взаимодействия для RegP.xaml
    /// </summary>
    public partial class RegP : Page
    {
        users context;
        public RegP()
        {
            InitializeComponent();
            context = new users();
            DataContext = context;
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginP());

        }

        private void RegBT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var TryReggistredUser = App.DB.users.Where(a => a.login == context.login);
                if (TryReggistredUser.Any())
                {
                    MessageBox.Show("This login is already used");
                    return;
                }
                else
                {
                    context.roleId = 1;
                    App.DB.users.Add(context);
                    App.DB.SaveChanges();
                    MessageBox.Show("Успешно");
                    NavigationService.Navigate(new LoginP());
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");

            }
        }
    }
}
