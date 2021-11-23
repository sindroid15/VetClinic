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

namespace VetClinic.Manager
{
    /// <summary>
    /// Логика взаимодействия для PageProfile.xaml
    /// </summary>
    public partial class PageProfile : Page
    {
        public PageProfile()
        {
            InitializeComponent();
        }

        private void btnAppointment_Click(object sender, RoutedEventArgs e)
        {
            Class.windowManager.frmActivity.Navigate(new Manager.Appointment.PageManagerAppointment());
           // Class.windowAdmin.frmActivity.Navigate(new Administrator.Appointment.PageAdminAppointmentClientAdd());
        }

       
       

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
            //Class.CloseWindow();
            Class.authWindow.Show();

        }

        private void btnClients_Click(object sender, RoutedEventArgs e)
        {
            Class.windowManager.frmActivity.Navigate(new Manager.Clients.ManagerClientMain());
        }

        private void btnPet_Click(object sender, RoutedEventArgs e)
        {
            Class.windowManager.frmActivity.Navigate(new Manager.Pet.ManagerPetMain());
        }

        private void btnMedicalCard_Click(object sender, RoutedEventArgs e)
        {
            Class.windowManager.frmActivity.Navigate(new Manager.MedicalCard.ManagerMedicalCardMain());
        }
    }
}
