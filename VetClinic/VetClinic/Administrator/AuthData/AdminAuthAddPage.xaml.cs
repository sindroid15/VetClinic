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
    /// Логика взаимодействия для AdminAuthAddPage.xaml
    /// </summary>
    public partial class AdminAuthAddPage : Page
    {
        List<string> listStaff = new List<string>();
        int idStaff;
        public AdminAuthAddPage(int id) : this()
        {
            idStaff = id;
            txbLogin.Text = Class.saveAuthData.Login.ToString();
            txbPassword.Text = Class.saveAuthData.Password.ToString();
            cmbStaff.SelectedIndex = Class.saveAuthData.IdStaff-1;
        }


        public AdminAuthAddPage()
        {
            InitializeComponent();
            var staff = Class.db.Staff.ToList();
            foreach(var i in staff)
            {
                listStaff.Add(i.FirstName);
            }
            cmbStaff.ItemsSource = listStaff;
        }

        void StaffList()
        {
            var listStaff = Class.db.Staff.ToList();
            var select = cmbStaff.SelectedIndex;
            if (select != 0)
            {
                listStaff = listStaff.Where(i => i.IdStaff == select).ToList();
            }
        }

        private void cmbStaff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StaffList();
        }

        private void btnSaveAuthData_Click(object sender, RoutedEventArgs e)
        {
            if (Class.saveAuthData != null)
            {
                var item = Class.db.AuthData.Find(Class.saveAuthData.IdAuth);
                item.IdStaff = Class.saveAuthData.IdStaff;
                item.Login = txbLogin.Text;
                item.Password = txbPassword.Text;

                Class.db.SaveChanges();
                
            }
            else
            {
                if (txbLogin.Text != "" && txbPassword.Text != "")
                {
                    var idStaff = cmbStaff.SelectedIndex + 1;
                    var loginData = txbLogin.Text;
                    var passwordData = txbPassword.Text;

                    Class.AuthDataAdd(idStaff, loginData, passwordData);
                }
                else
                {
                    MessageBox.Show("Youre input is incorrect or another happens incorrect. \n" +
                        "TryAgain", "Not Relesed Function", MessageBoxButton.OK);
                }
            }
        }

        private void btnCancelAuthData_Click(object sender, RoutedEventArgs e)
        {
            Class.windowAdmin.frmActivity.Navigate(new Administrator.AuthData.AdminAuthDataMain());
        }
    }
}
