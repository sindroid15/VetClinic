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
using System.Windows.Shapes;

namespace VetClinic.Administrator
{
    /// <summary>
    /// Логика взаимодействия для WindowAdmin.xaml
    /// </summary>
    public partial class WindowAdmin : Window
    {
        public WindowAdmin()
        {
            InitializeComponent();
            frmProfile.Navigate(new PageProfile());

        }
        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            this.Close();
            Class.authWindow.Show();
        }
    }
}
