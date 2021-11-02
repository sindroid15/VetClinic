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

namespace VetClinic.Administrator.MedicalCard
{
    /// <summary>
    /// Логика взаимодействия для AdminMedicalCardMain.xaml
    /// </summary>
    public partial class AdminMedicalCardMain : Page
    {
        List<Database.MedicalCard> listMedicalCard = new List<Database.MedicalCard>();
        public List<Database.Client> Client { get; set; }
        public List<Database.Pet> Pet { get; set; }


        public AdminMedicalCardMain()
        {
            InitializeComponent();
            lvAdminMedicalCard.ItemsSource = Class.db.MedicalCard.ToList();
            
        }

        private void txbMedicalCardSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (txbMedicalCardSearch.Text!="")
            {
                listMedicalCard = Class.db.MedicalCard.Where(i => i.Client.FirstName.ToLower().Contains(txbMedicalCardSearch.Text.ToLower())).ToList();
                lvAdminMedicalCard.ItemsSource = listMedicalCard.ToList();
            }
            else
            {
                lvAdminMedicalCard.ItemsSource = Class.db.MedicalCard.ToList();
            }
        }

        private void txbClientSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void txbPetSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Class.saveAuthData.Staff.IdRole.ToString(), "Not Relesed Function", MessageBoxButton.OK);
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Class.windowAdmin.frmActivity.Navigate(new Administrator.MedicalCard.AdminMedicalCardAddPage());
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

            Database.MedicalCard mcSave = new Database.MedicalCard();
            mcSave = (Database.MedicalCard)lvAdminMedicalCard.SelectedItem;
            if (lvAdminMedicalCard.SelectedValue!=null)
            {
                Class.MedicalCardsave.IdClient = mcSave.IdClient;
                Class.MedicalCardsave.IdPet = mcSave.IdPet;
                Class.MedicalCardsave.IdMedicalCard = mcSave.IdMedicalCard;
                Class.windowAdmin.frmActivity.Navigate(new Administrator.MedicalCard.AdminMedicalCardAddPage());
            }
            else 
            {
                MessageBox.Show("Pls select somth.\nTryAgain", "Not Relesed Function", MessageBoxButton.OK);
            }
            //MessageBox.Show(Class.saveAuthData.Staff.IdRole.ToString(), "Not Relesed Function", MessageBoxButton.OK);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //.Show(Class.saveAuthData.Staff.IdRole.ToString(), "Not Relesed Function", MessageBoxButton.OK);
            Database.MedicalCard mcSave = new Database.MedicalCard();
            if (lvAdminMedicalCard.SelectedValue!=null)
            {
                mcSave = (Database.MedicalCard)lvAdminMedicalCard.SelectedItem;
                var item = Class.db.MedicalCard.Find(mcSave.IdMedicalCard);

                Class.db.MedicalCard.Remove(item);
                Class.db.SaveChanges();
                MessageBox.Show("Successfull created medical card)))", "Not Relesed Function", MessageBoxButton.OK);
                lvAdminMedicalCard.ItemsSource = Class.db.MedicalCard.ToList();
            }
            else
            {
                MessageBox.Show("Pls select somth.\nTryAgain", "Not Relesed Function", MessageBoxButton.OK);
            }
        }

        private void lvAdminMedicalCard_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
