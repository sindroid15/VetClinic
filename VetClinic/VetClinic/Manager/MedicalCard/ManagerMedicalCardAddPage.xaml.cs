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

namespace VetClinic.Manager.MedicalCard
{
    /// <summary>
    /// Логика взаимодействия для AdminMedicalCardAddPage.xaml
    /// </summary>
    /// 

    

    public partial class ManagerMedicalCardAddPage : Page
    {
        List<string> clientList = new List<string>();
        List<string> petList = new List<string>();

        public int inter=0;
         
        void Pet()
        {
            var listpet = Class.db.Pet.ToList();
            

            var selectpet = cmbPet.SelectedValue.ToString();
            

            if(selectpet!=null)
            {
                listpet = listpet.Where(i => i.IdPet.ToString() == selectpet).ToList();

            }
            
        }
         void Client()
        {
            var listclient = Class.db.Client.ToList();
            var selectclient = cmbClient.SelectedItem.ToString();
            if (selectclient != null)
            {
                listclient = listclient.Where(i => i.IdClient.ToString() == selectclient).ToList();
            }

            
        }

        public ManagerMedicalCardAddPage()
        {
            InitializeComponent();

            var pet = Class.db.Pet.ToList();
            var client = Class.db.Client.ToList();

            foreach(var i in pet)
            {
                petList.Add(i.IdPet.ToString());

            }
            foreach(var i in client)
            {
                clientList.Add(i.IdClient.ToString());
               

            }

            cmbClient.ItemsSource = clientList;
            cmbPet.ItemsSource = petList;
            if (Class.MedicalCardsave.IdPet != 0 &&
                Class.MedicalCardsave.IdPet != 0)
            {
                cmbClient.SelectedValue = Class.MedicalCardsave.IdClient.ToString();
                cmbPet.SelectedValue = Class.MedicalCardsave.IdPet.ToString();
                inter+=1;
            }

        }

        private void btnSaveMedicalCard_Click(object sender, RoutedEventArgs e)
        {

            if (Class.MedicalCardsave.IdClient != 0 &&
                Class.MedicalCardsave.IdPet != 0 && inter != 0)
            {
                var item = Class.db.MedicalCard.Find(Class.MedicalCardsave.IdMedicalCard);
                item.IdClient = Class.MedicalCardsave.IdClient;
                item.IdPet = Class.MedicalCardsave.IdPet;
                Class.db.SaveChanges();
                Class.MedicalCardsave.IdMedicalCard=0;
                Class.MedicalCardsave.IdClient = 0;
                Class.MedicalCardsave.IdPet = 0;
                MessageBox.Show("Successfull changed medical card)))", "Not Relesed Function", MessageBoxButton.OK);
                Class.windowManager.frmActivity.Navigate(new Manager.MedicalCard.ManagerMedicalCardMain());
            }
            else
            {



                if (Class.MedicalCardsave.IdClient != 0 &&
                    Class.MedicalCardsave.IdPet != 0 && inter == 0)
                {
                    Class.db.MedicalCard.Add(Class.MedicalCardsave);
                    Class.db.SaveChanges();
                    MessageBox.Show("Successfull created medical card)))", "Not Relesed Function", MessageBoxButton.OK);
                    Class.windowManager.frmActivity.Navigate(new Manager.MedicalCard.ManagerMedicalCardMain());
                }
                else
                {
                    MessageBox.Show("Please select Pet or/and Client!!! \n" +
                        "TryAgain", "Not Relesed Function", MessageBoxButton.OK);
                }
            }
            Class.MedicalCardsave.IdMedicalCard = 0;
            Class.MedicalCardsave.IdClient = 0;
            Class.MedicalCardsave.IdPet = 0;
        }

        private void btnCancelMedicalCard_Click(object sender, RoutedEventArgs e)
        {
            Class.windowManager.frmActivity.Navigate(new Manager.MedicalCard.ManagerMedicalCardMain());
            Class.MedicalCardsave.IdMedicalCard = 0;
            Class.MedicalCardsave.IdClient = 0;
            Class.MedicalCardsave.IdPet = 0;
        }

        private void cmbClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
           Client();

            int id;
            bool result = int.TryParse(cmbClient.SelectedValue.ToString(), out id);
           

            Class.MedicalCardsave.IdClient = id;
        }

        private void cmbPet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int id;
            bool result = int.TryParse(cmbPet.SelectedValue.ToString(), out id);
            Pet();
            Class.MedicalCardsave.IdPet = id;
            
        }
    }
}
