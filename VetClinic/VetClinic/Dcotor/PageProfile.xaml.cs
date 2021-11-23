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

namespace VetClinic.Doctor
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
            Class.windowDoctor.frmActivity.Navigate(new Doctor.Appointment.PageDoctorAppointment());
           // Class.windowAdmin.frmActivity.Navigate(new Administrator.Appointment.PageAdminAppointmentClientAdd());
        }

        private void btnProcedure_Click(object sender, RoutedEventArgs e)
        {
            Class.windowDoctor.frmActivity.Navigate(new Doctor.Procedure.DoctorProcedureMain());
            //Class.windowDoctor.frmActivity.Navigate(new Administrator.Procedure.AdminProcedureMain());
        }

       

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
            //Class.CloseWindow();
            Class.authWindow.Show();

        }
    }
}
