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
    /// Логика взаимодействия для AdminPetMain.xaml
    /// </summary>
    public partial class ManagerPetMain : Page
    {
        List<Database.Pet> listPet = new List<Database.Pet>();



        public ManagerPetMain()
        {
            InitializeComponent();

            lvAdminPet.ItemsSource = Class.db.Pet.ToList();
            
            
            
            
        }

        private void txbPetSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if(txbPetSearch.Text!="")
            {
                //lvAdminPet.ItemsSource = Class.db.Pet.Where(i => i.NamePet.ToLower().Contains(txbPetSearch.Text.ToLower())).ToList();
                listPet= Class.db.Pet.Where(i => i.NamePet.ToLower().Contains(txbPetSearch.Text.ToLower())).ToList();
                lvAdminPet.ItemsSource = listPet.ToList();
            }
            else
            {
                lvAdminPet.ItemsSource = Class.db.Pet.ToList();
            }
        }

      

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Database.Pet item =new  Database.Pet();
            Class.newPet = item;
            Class.windowManager.frmActivity.Navigate(new Manager.Pet.ManagerClientAddPage());
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if(lvAdminPet.SelectedItem!=null)
            {
                var item = (Database.Pet)lvAdminPet.SelectedItem;
                Class.newPet = item;
                Class.windowManager.frmActivity.Navigate(new Manager.Pet.ManagerClientAddPage());
            }
            else
            {
                MessageBox.Show("No selected. Please Select", "Not Relesed Function", MessageBoxButton.OK);
            }
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lvAdminPet.SelectedValue != null)
            {
                var item = (Database.Pet)lvAdminPet.SelectedItem;
                var delitem = Class.db.Pet.Find(item.IdPet);
                Class.db.Pet.Remove(delitem);
                Class.db.SaveChanges();
                lvAdminPet.ItemsSource = Class.db.Pet.ToList();
                MessageBox.Show("Successfull delete)))", "Not Relesed Function", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("No selected appointment. Please Select", "Not Relesed Function", MessageBoxButton.OK);
            }
        }

        private void lvAdminPet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
