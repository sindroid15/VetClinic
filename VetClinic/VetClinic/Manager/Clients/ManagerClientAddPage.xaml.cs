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

namespace VetClinic.Manager.Clients
{
    /// <summary>
    /// Логика взаимодействия для AdminClientAddPage.xaml
    /// </summary>
    public partial class ManagerClientAddPage : Page
    {
        List<string> genderList = new List<string>();

        void Gender()
        {
            var listgender = Class.db.Gender.ToList();
            var selectgender = cmbGender.SelectedItem.ToString();
            if(selectgender!=null)
            {
                listgender = listgender.Where(i => i.IdGender == selectgender).ToList();
            }
        }

        public ManagerClientAddPage()
        {
            InitializeComponent();
            var gender = Class.db.Gender.ToList();
            //Class.clientSave = null;
            foreach(var i in gender)
            {
                genderList.Add(i.IdGender);
            }
            
            cmbGender.ItemsSource = genderList;
            if (Class.clientSave.Address!=null&&
                Class.clientSave.Birthday!=null&&
                Class.clientSave.FirstName!=null&
                Class.clientSave.IdGender!=null&&
                Class.clientSave.LastName!=null)
            {
                txbAddres.Text = Class.clientSave.Address.ToString();
                txbBirthday.Text = Class.clientSave.Birthday.ToString();
                txbFirstName.Text = Class.clientSave.FirstName.ToString();
                txbLastName.Text = Class.clientSave.LastName.ToString();
                txbPatronymic.Text = Class.clientSave.Patronymic.ToString();
            }
        }

        private void cmbGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(Class.saveAuthData.Staff.IdRole.ToString(), "Not Relesed Function", MessageBoxButton.OK);
            Gender();
        }

        private void btnSaveClient_Click(object sender, RoutedEventArgs e)
        {
            if (Class.clientSave.Address == null ||
                Class.clientSave.Birthday == null ||
                Class.clientSave.FirstName == null ||
                Class.clientSave.IdGender == null ||
                Class.clientSave.LastName == null)
            {
                if (txbAddres.Text != "" &&
                    txbBirthday.Text != "" &&
                    txbFirstName.Text != "" &&
                    txbLastName.Text != ""
                    )
                {


                    Class.clientSave.Address = txbAddres.Text;
                    Class.clientSave.Birthday = DateTime.Parse(txbBirthday.Text);
                    Class.clientSave.FirstName = txbFirstName.Text;
                    Class.clientSave.IdGender = cmbGender.SelectedItem.ToString();
                    Class.clientSave.LastName = txbLastName.Text;
                    Class.clientSave.Patronymic = txbPatronymic.Text;

                    Class.db.Client.Add(Class.clientSave);
                    Class.db.SaveChanges();
                    Class.clientSave = null;
                    MessageBox.Show("Successfull added client)))", "Not Relesed Function", MessageBoxButton.OK);
                    Class.windowManager.frmActivity.Navigate(new Manager.Clients.ManagerClientMain());
                }
                else
                {

                }
            }
            else 
            {
                var item =Class.db.Client.Find(Class.clientSave.IdClient);
                item.Address = txbAddres.Text;
                item.Birthday = DateTime.Parse(txbBirthday.Text);
                item.FirstName = txbFirstName.Text;
                item.IdGender = cmbGender.SelectedItem.ToString();
                item.LastName = txbLastName.Text;
                item.Patronymic = txbPatronymic.Text;
                Class.clientSave = null;
                Class.db.SaveChanges();
                MessageBox.Show("Successfull changed client)))", "Not Relesed Function", MessageBoxButton.OK);
                Class.windowManager.frmActivity.Navigate(new Manager.Clients.ManagerClientMain());
            }
        }

        private void btnCancelClient_Click(object sender, RoutedEventArgs e)
        {
            Class.clientSave.Address = null;
            
            Class.clientSave.FirstName = null;
            
            //Class.clientSave.IdClient = 0;
            Class.clientSave.IdGender = null;
            Class.clientSave.LastName = null;
            Class.clientSave.Patronymic = null;
            
            Class.windowManager.frmActivity.Navigate(new Manager.Clients.ManagerClientMain());
        }
    }
}
