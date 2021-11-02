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

namespace VetClinic.Auth
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Class.windowAdmin = new Administrator.WindowAdmin();
            var userAuth = Class.Context.AuthData.Where(i => i.Login == tbLogin.Text && i.Password == tbPassword.Text).FirstOrDefault();
            Class.saveAuthData = userAuth;
            if (Class.saveAuthData!=null)
            { 
            switch(Class.saveAuthData.Staff.IdRole)
            {
                case 1:
                    Class.windowAdmin.Show();
                    Application.Current.MainWindow.Hide();
                    break;
                case 2:
                    MessageBox.Show(Class.saveAuthData.Staff.IdRole.ToString(), "Not Relesed manager", MessageBoxButton.OK);
                    break;
                case 3:
                    MessageBox.Show(Class.saveAuthData.Staff.IdRole.ToString(), "Not Relesed doctor", MessageBoxButton.OK);
                    break;
                default:
                    MessageBox.Show(Class.saveAuthData.Staff.IdRole.ToString(), "Not Relesed user", MessageBoxButton.OK);
                    break;
            }
             }
            else
            {
                MessageBox.Show("Incorrect pas/log", "Not Relesed user", MessageBoxButton.OK);
            }

        }
    }
}
