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

namespace VetClinic.Manager.Clients
{
    /// <summary>
    /// Логика взаимодействия для AdminClientMain.xaml
    /// </summary>
    public partial class ManagerClientMain : Page
    {
        List<Database.Client> clientList = new List<Database.Client>();
        public ManagerClientMain()
        {
            InitializeComponent();

            lvAdminClient.ItemsSource = Class.db.Client.ToList();
        }

        private void txbClient_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if(txbClient.Text!="")
            {
                clientList = Class.db.Client.Where(i => i.FirstName.ToLower().Contains(txbClient.Text.ToLower())).ToList();
                lvAdminClient.ItemsSource = clientList.ToList();
            }
            else
            {
                lvAdminClient.ItemsSource = Class.db.Client.ToList();
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (txbClient.Text != "")
            {
                clientList = Class.db.Client.Where(i => i.FirstName.ToLower().Contains(txbClient.Text.ToLower())).ToList();
                lvAdminClient.ItemsSource = clientList.ToList();
            }
            else
            {
                lvAdminClient.ItemsSource = Class.db.Client.ToList();
            }
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Class.windowManager.frmActivity.Navigate(new Manager.Clients.ManagerClientAddPage());
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

            if (lvAdminClient.SelectedValue != null)
            {
                var item = lvAdminClient.SelectedItem;
                Class.clientSave = (Database.Client)item;

                Class.windowManager.frmActivity.Navigate(new Manager.Clients.ManagerClientAddPage());
            }
            else
            {
                MessageBox.Show("No selected appointment. Please Select", "Not Relesed Function", MessageBoxButton.OK);
            }
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lvAdminClient.SelectedItem != null)
            {


                var item = lvAdminClient.SelectedItem;
                Class.clientSave = (Database.Client)item;
                Class.db.Client.Remove(Class.clientSave);
                Class.db.SaveChanges();
                MessageBox.Show("Successfull deleted client)))", "Not Relesed Function", MessageBoxButton.OK);
                lvAdminClient.ItemsSource = Class.db.Client.ToList();
            }
            else 
            {
                MessageBox.Show("Not selected or another error.\n try again!", "Not Relesed Function", MessageBoxButton.OK);
            }
        }

        private void lvAdminClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
