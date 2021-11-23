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
using System.Data;


namespace VetClinic.Manager.Appointment
{
    /// <summary>
    /// Логика взаимодействия для PageAdminAppointment.xaml
    /// </summary>
    public partial class PageManagerAppointment : Page
    {
        List<Database.Appointment> listAppointmentData = new List<Database.Appointment>();
        
        public PageManagerAppointment()
        {
            InitializeComponent();
            Database.Appointment app = new Database.Appointment();

            lvAdminAppointment.Items.Refresh();
            lvAdminAppointment.ItemsSource = Class.db.Appointment.ToList();
            
            

        }

        private void txbAppointment_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (txbAppointment.Text != "")
            {
                listAppointmentData = Class.db.Appointment.Where(i => i.MedicalCard.Client.FirstName.ToLower().Contains(txbAppointment.Text.ToLower())).ToList();
                lvAdminAppointment.ItemsSource = listAppointmentData.ToList();
            }
            else
            {
                lvAdminAppointment.ItemsSource = Class.db.Appointment.ToList();
            }

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            listAppointmentData= Class.db.Appointment.Where(i => i.MedicalCard.Client.FirstName.ToLower().Contains(txbAppointment.Text.ToLower())).ToList();
            lvAdminAppointment.ItemsSource = listAppointmentData.ToList();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Class.windowManager.frmActivity.Navigate(new Manager.Appointment.PageManagerAppointmentClientAdd());
           
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (lvAdminAppointment.SelectedItem!=null)
            {
                var item = (Database.Appointment)lvAdminAppointment.SelectedItem;
                Class.newsaveAppointment = item;
                var idclientsave = Class.newsaveAppointment.MedicalCard.IdClient;
                var idpetsave = Class.newsaveAppointment.MedicalCard.IdPet;
                Class.newsaveClient.IdClient = idclientsave;
                Class.newsavePet.IdPet = idpetsave;
                Class.windowManager.frmActivity.Navigate(new Manager.Appointment.PageManagerAppointmentConfirming(Class.newsaveAppointment.IdAppointment));
            }
            else
            {
                MessageBox.Show("No selected appointment. Please Select", "Not Relesed Function", MessageBoxButton.OK);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lvAdminAppointment.SelectedItem != null)
            {
                var item = (Database.Appointment)lvAdminAppointment.SelectedItem;
                var delitem = Class.db.Appointment.Find(item.IdAppointment);

                Class.changeAppointmentData.IdAppointment = item.IdAppointment;
                Class.db.Appointment.Remove(delitem);
                MessageBox.Show("Successfull delete)))", "Not Relesed Function", MessageBoxButton.OK);
                Class.db.SaveChanges();
                lvAdminAppointment.Items.Refresh();
                lvAdminAppointment.ItemsSource = Class.db.Appointment.ToList();

            }
            else
            {
                MessageBox.Show("No selected appointment. Please Select", "Not Relesed Function", MessageBoxButton.OK);
            }
            

        }

        private void lvAdminAppointment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
