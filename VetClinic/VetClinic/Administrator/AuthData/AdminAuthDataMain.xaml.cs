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

namespace VetClinic.Administrator.AuthData
{
    /// <summary>
    /// Логика взаимодействия для AdminAuthDataMain.xaml
    /// </summary>
    public partial class AdminAuthDataMain : Page
    {
        List<Database.AuthData> listAuth = new List<Database.AuthData>();
        public AdminAuthDataMain()
        {
            InitializeComponent();
            lvAdminAuthData.ItemsSource = Class.db.AuthData.ToList();
        }

        private void txbUserSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if(txbUserSearch.Text!="")
            {
                listAuth = Class.db.AuthData.Where(i => i.Staff.FirstName.ToLower().Contains(txbUserSearch.Text.ToLower())).ToList();
                lvAdminAuthData.ItemsSource = listAuth.ToList();
            }
            else
            {
                lvAdminAuthData.ItemsSource = Class.db.AuthData.ToList();
            }
        }


        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Class.windowAdmin.frmActivity.Navigate(new Administrator.AuthData.AdminAuthAddPage());
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(Class.saveAuthData.Staff.IdRole.ToString(), "Not Relesed Function", MessageBoxButton.OK);
            var item = (Database.AuthData)lvAdminAuthData.SelectedItem;
            Class.saveAuthData = item;

            Class.windowAdmin.frmActivity.Navigate(new Administrator.AuthData.AdminAuthAddPage(Class.saveAuthData.IdStaff));
            
        }

        private void lvAdminAuthData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Class.saveAuthData.Staff.IdRole.ToString(), "Not Relesed Function", MessageBoxButton.OK);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(Class.saveAuthData.Staff.IdRole.ToString(), "Not Relesed Function", MessageBoxButton.OK);
            if (lvAdminAuthData.SelectedItem != null)
            {
                var item = (Database.AuthData)lvAdminAuthData.SelectedItem;
                Class.saveAuthData = item;
                Class.db.AuthData.Remove(Class.saveAuthData);
                Class.db.SaveChanges();
                MessageBox.Show("Successfull delete)))", "Not Relesed Function", MessageBoxButton.OK);
                lvAdminAuthData.ItemsSource = Class.db.AuthData.ToList();
            }
            else
            {
                MessageBox.Show("Please select auth data!!! \n" +
                    "TryAgain", "Not Relesed Function", MessageBoxButton.OK);
            }

        }
    }
}
