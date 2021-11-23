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
    /// Логика взаимодействия для PageAdminAppointmentConfirming.xaml
    /// </summary>
    /// 

    


    public partial class PageAdminAppointmentConfirming : Page
    {
        List<string> saveEditAppointmentData = new List<string>();
        public PageAdminAppointmentConfirming(int id): this()
        {
            txbNameClient.Text = Class.newsaveAppointment.MedicalCard.Client.FirstName.ToString();
            txbNamePet.Text = Class.newsaveAppointment.MedicalCard.Pet.NamePet.ToString();
            txbDateTime.Text = Class.newsaveAppointment.DateTime.ToString();
        }


        public PageAdminAppointmentConfirming()
        {
            InitializeComponent();
            if (Class.changeAppointmentData != null)
            {
                txbNameClient.Text = Class.newsaveAppointment.MedicalCard.Client.FirstName.ToString();
                txbNamePet.Text = Class.newsaveAppointment.MedicalCard.Pet.NamePet.ToString();
                txbDateTime.Text = Class.newsaveAppointment.DateTime.ToString();
            }
            else
            {
                txbNameClient.Text = Class.newsaveAppointment.MedicalCard.Client.FirstName.ToString();
                txbNamePet.Text = Class.newsaveAppointment.MedicalCard.Pet.NamePet.ToString();
                txbDateTime.Text = Class.newsaveAppointment.DateTime.ToString();
                MessageBox.Show(txbNameClient.Text, Class.newsaveAppointment.MedicalCard.Client.FirstName.ToString(), MessageBoxButton.OK);
            }
        }

        private void btnSaveAppointment_Click(object sender, RoutedEventArgs e)
        {
            if (Class.changeAppointmentData!=null&&Class.changeAppointmentData.IdAppointment!=0)
            {
                Class.changeAppointmentData.MedicalCard.IdClient = 0;
                
                Class.changeAppointmentData.IdMedicalCard = 0;
                Class.changeAppointmentData.MedicalCard.IdPet = 0;
                MessageBox.Show("Successfull changed appointment)))", "Not Relesed Function", MessageBoxButton.OK);
                Class.windowAdmin.frmActivity.Navigate(new Appointment.PageAdminAppointment());


            }
            else
            {
                Class.AppointmentSave(txbDateTime.Text);
            }
        }

        private void btnCancelAppointment_Click(object sender, RoutedEventArgs e)
        {
            Class.newsaveAppointment = null;
            Class.windowAdmin.frmActivity.Navigate(new Appointment.PageAdminAppointment());
        }

        private void btnEditAppointment_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
