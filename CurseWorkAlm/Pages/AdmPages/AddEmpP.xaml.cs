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
    /// Логика взаимодействия для AddEmpP.xaml
    /// </summary>
    public partial class AddEmpP : Page
    {
        employee context;
        public AddEmpP()
        {
            InitializeComponent();
            PostCB.ItemsSource = App.DB.post.ToList();
            context = new employee();
            DataContext = context;
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeeListP());
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedPost = PostCB.SelectedItem as post;
                context.postId = selectedPost.id;
                App.DB.employee.Add(context);
                App.DB.SaveChanges();
                MessageBox.Show("Успешно");
                NavigationService.Navigate(new EmployeeListP());

            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
