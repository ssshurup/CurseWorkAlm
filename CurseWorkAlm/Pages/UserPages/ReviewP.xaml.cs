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
    /// Логика взаимодействия для ReviewP.xaml
    /// </summary>
    public partial class ReviewP : Page
    {
        review context;
        appointment contextApp;
        public ReviewP(appointment appoint)
        {
            InitializeComponent();
            contextApp = appoint;
            context = new review();
            DataContext = context;
        }

        private void AddRewBT_Click(object sender, RoutedEventArgs e)
        {
            context.appointmentId = contextApp.id;
            App.DB.review.Add(context);
            App.DB.SaveChanges();
            MessageBox.Show("Успешно");
            NavigationService.Navigate(new UserP());
        }
    }
}
