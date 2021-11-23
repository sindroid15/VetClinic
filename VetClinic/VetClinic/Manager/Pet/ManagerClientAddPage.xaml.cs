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

namespace VetClinic.Manager.Pet
{
    /// <summary>
    /// Логика взаимодействия для AdminClientAddPage.xaml
    /// </summary>
    public partial class ManagerClientAddPage : Page
    {
        List<string> petGende = new List<string>();
        List<string> petTypePet = new List<string>();


        void PetGender()
        {
            var listpetgender = Class.db.Gender.ToList();
            var selectpetgender = cmbGender.SelectedItem.ToString();
            if(selectpetgender!=null)
            {
                listpetgender = listpetgender.Where(i => i.IdGender == selectpetgender).ToList();
            }
        }

        void PetType()
        {
            var listpettypepet = Class.db.TypePet.ToList();
            var selecttypepet = cmbTypePet.SelectedItem.ToString();
            if(selecttypepet!=null)
            {
                listpettypepet = listpettypepet.Where(i => i.IdTypePet.ToString() == selecttypepet).ToList();
            }
        }

        public ManagerClientAddPage()
        {
            InitializeComponent();
            var petgender = Class.db.Gender.ToList();
            var pettypepet = Class.db.TypePet.ToList();
            foreach (var i in petgender)
            {
                petGende.Add(i.IdGender);
            }
            foreach (var i in pettypepet)
            {
                petTypePet.Add(i.IdTypePet.ToString());
            }
            cmbGender.ItemsSource = petGende;
            cmbTypePet.ItemsSource = petTypePet;
            if (Class.newPet.IdPet != 0)
            {
                
                txbNamePet.Text = Class.newPet.NamePet.ToString();
                txbBirthday.Text = Class.newPet.Birthday.ToString();
                cmbGender.SelectedValue = Class.newPet.IdGender.ToString();
                cmbTypePet.SelectedValue = Class.newPet.IdTypePet.ToString();
            }
        }

        private void txbNamePet_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void cmbTypePet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnSavePet_Click(object sender, RoutedEventArgs e)
        {
            if (Class.newPet.IdPet!=0)
            {
                var item = Class.db.Pet.Find(Class.newPet.IdPet);
                
                item.NamePet = txbNamePet.Text;
                
                item.Birthday = DateTime.Parse(txbBirthday.Text);
                
                item.IdGender = cmbGender.SelectedItem.ToString();
                
                item.IdTypePet = Int32.Parse(cmbTypePet.SelectedItem.ToString());
                
                Class.db.SaveChanges();
                MessageBox.Show("Successfull changed pet)))", "Not Relesed Function", MessageBoxButton.OK);
                Class.windowManager.frmActivity.Navigate(new Manager.Pet.ManagerPetMain());
            }
            else 
            {
                var item = Class.db.Pet.Find(Class.newPet.IdPet);
                Class.newPet.NamePet = txbNamePet.Text;
                Class.newPet.Birthday = DateTime.Parse(txbBirthday.Text);
                Class.newPet.IdGender= cmbGender.SelectedItem.ToString();
                Class.newPet.IdTypePet= Int32.Parse(cmbTypePet.SelectedItem.ToString());
                Class.db.Pet.Add(Class.newPet);
                Class.db.SaveChanges();
                MessageBox.Show("Successfull added pet)))", "Not Relesed Function", MessageBoxButton.OK);
                Class.windowManager.frmActivity.Navigate(new Manager.Pet.ManagerPetMain());
            }

        }

        private void btnCancelPet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmbGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txbBirthday_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
