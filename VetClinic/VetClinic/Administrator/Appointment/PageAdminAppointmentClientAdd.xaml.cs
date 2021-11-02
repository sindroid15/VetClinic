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

namespace VetClinic.Administrator.Appointment
{
    /// <summary>
    /// Логика взаимодействия для PageAdminClientAdd.xaml
    /// </summary>
    public partial class PageAdminAppointmentClientAdd : Page
    {
        List<Database.Client> clientAppointment = new List<Database.Client>();
        public PageAdminAppointmentClientAdd()
        {
            InitializeComponent();
           lvAdminAppointmentClientAdd.ItemsSource = Class.db.Client.ToList();
        }

        

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            clientAppointment = Class.db.Client.Where(i => i.FirstName.ToLower().Contains(txbAdminAppointmentClientAdd.Text.ToLower())).ToList();
            lvAdminAppointmentClientAdd.ItemsSource = clientAppointment.ToList();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        

        private void txbAdminAppointmentClientAdd_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if(txbAdminAppointmentClientAdd.Text!="")
            {
                clientAppointment = Class.db.Client.Where(i => i.FirstName.ToLower().Contains(txbAdminAppointmentClientAdd.Text.ToLower())).ToList();
                lvAdminAppointmentClientAdd.ItemsSource = clientAppointment.ToList();
            }
            else
            {
                lvAdminAppointmentClientAdd.ItemsSource = Class.db.Client.ToList();
            }
        }

        private void lvAdminAppointmentClientAdd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(lvAdminAppointmentClientAdd.SelectedValue!=null)
            {
                var item = (Database.Client)lvAdminAppointmentClientAdd.SelectedItem;
                
                /*var idmedcard = Class.db.MedicalCard.Find(Class.changeAppointmentData.MedicalCard)*/;
                Class.newsaveClient = item;
                var firstnameclient = Class.newsaveClient.FirstName;
                
                Class.windowAdmin.frmActivity.Navigate(new Administrator.Appointment.PageAdminAppointmentPetAdd());
            }
            else
            {
                MessageBox.Show(Class.saveAuthData.Staff.IdRole.ToString(), "Not Relesed Function", MessageBoxButton.OK);
            }
        }
    }
}
