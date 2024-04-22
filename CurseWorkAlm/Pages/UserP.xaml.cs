using CurseWorkAlm.Pages.UserPages;
using System;
using System.Collections.Generic;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;

namespace CurseWorkAlm.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserP.xaml
    /// </summary>
    public partial class UserP : Page
    {

        public UserP()
        {
            InitializeComponent();
            HelloTB.Text += App.LoggesUser.name;
        }

       

     

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginP());
        }

        private void AppListBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AppListUserP());
        }
    }
}
