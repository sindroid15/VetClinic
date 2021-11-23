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

namespace VetClinic.Manager.Appointment
{
    /// <summary>
    /// Логика взаимодействия для PageAdminAppointmentPetAdd.xaml
    /// </summary>
    public partial class PageManagerAppointmentPetAdd : Page
    {
        List<Database.Pet> petList = new List<Database.Pet>();
        public PageManagerAppointmentPetAdd()
        {
            InitializeComponent();
            lvAdminAppointmentPetAdd.ItemsSource = Class.db.Pet.ToList();
        }

        private void txbPetSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (txbPetSearch.Text != "")
            {
                petList = Class.db.Pet.Where(i => i.NamePet.ToLower().Contains(txbPetSearch.Text.ToLower())).ToList();
                lvAdminAppointmentPetAdd.ItemsSource = petList.ToList();
            }
            else 
            {
                lvAdminAppointmentPetAdd.ItemsSource = Class.db.Pet.ToList();
            }
        }

        private void txbNameClientSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            petList = Class.db.Pet.Where(i => i.NamePet.ToLower().Contains(txbPetSearch.Text.ToLower())).ToList();
            lvAdminAppointmentPetAdd.ItemsSource = petList.ToList();
        }

        
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (txbPetSearch.Text != "")
            {
                petList = Class.db.Pet.Where(i => i.NamePet.ToLower().Contains(txbPetSearch.Text.ToLower())).ToList();
                lvAdminAppointmentPetAdd.ItemsSource = petList.ToList();
            }
            else
            {
                lvAdminAppointmentPetAdd.ItemsSource = Class.db.Pet.ToList();
            }
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Class.windowManager.frmActivity.Navigate(new Manager.Pet.ManagerClientAddPage());
        }

        

        private void lvAdminAppointmentPetAdd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (lvAdminAppointmentPetAdd.SelectedValue != null)
            {
                var item = (Database.Pet)lvAdminAppointmentPetAdd.SelectedItem;
                Class.newsavePet = item;
                var idClient = Class.newsaveClient.IdClient;
                var idPet = Class.newsavePet.IdPet;
                Class.newMedicalCard.IdClient = idClient;

                Class.newMedicalCard.IdPet = idPet;
                Class.db.MedicalCard.Add(Class.newMedicalCard);
                Class.db.SaveChanges();
                var itemmedcard = Class.newMedicalCard;
                Database.Appointment app = new Database.Appointment();
                Class.newsaveAppointment = app;
                Class.newsaveAppointment.MedicalCard = itemmedcard;

                Class.windowManager.frmActivity.Navigate(new Manager.Appointment.PageManagerAppointmentConfirming());
            }
            else
            {
                MessageBox.Show(Class.saveAuthData.Staff.IdRole.ToString(), "Not Relesed Function", MessageBoxButton.OK);
            }
        }
    }
}
