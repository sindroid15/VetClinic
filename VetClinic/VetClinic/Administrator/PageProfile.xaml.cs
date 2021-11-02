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

namespace VetClinic.Administrator
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
            Class.windowAdmin.frmActivity.Navigate(new Administrator.Appointment.PageAdminAppointment());
           // Class.windowAdmin.frmActivity.Navigate(new Administrator.Appointment.PageAdminAppointmentClientAdd());
        }

        private void btnClients_Click(object sender, RoutedEventArgs e)
        {
            Class.windowAdmin.frmActivity.Navigate(new Administrator.Clients.AdminClientMain());
        }

        private void btnStaff_Click(object sender, RoutedEventArgs e)
        {
            Class.windowAdmin.frmActivity.Navigate(new Administrator.Staff.AdminStaffMain());
        }

        private void btnPet_Click(object sender, RoutedEventArgs e)
        {
            Class.windowAdmin.frmActivity.Navigate(new Administrator.Pet.AdminPetMain());
        }

        private void btnProcedure_Click(object sender, RoutedEventArgs e)
        {
            Class.windowAdmin.frmActivity.Navigate(new Administrator.Procedure.AdminProcedureMain());
        }

        private void btnMedicalCard_Click(object sender, RoutedEventArgs e)
        {
            Class.windowAdmin.frmActivity.Navigate(new Administrator.MedicalCard.AdminMedicalCardMain());
        }

        private void btnAuthData_Click(object sender, RoutedEventArgs e)
        {
            Class.windowAdmin.frmActivity.Navigate(new Administrator.AuthData.AdminAuthDataMain());
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Class.CloseWindow();
            Class.authWindow.Show();

        }
    }
}
