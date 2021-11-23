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

namespace VetClinic.Doctor.Procedure
{
    /// <summary>
    /// Логика взаимодействия для AdminProcedureMain.xaml
    /// </summary>
    public partial class DoctorProcedureMain : Page
    {
        List<Database.Procedure> listProcedure = new List<Database.Procedure>();


        public DoctorProcedureMain()
        {
            //Class.db.SaveChanges();
            InitializeComponent();
            //listProcedure = Class.db.Procedure.ToList();
            lvAdminProcedure.ItemsSource = Class.db.Procedure.ToList();
        }

        private void txbNameProcedureSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if(txbNameProcedureSearch.Text!="")
            {
                listProcedure = Class.db.Procedure.Where(i => i.NameProcedure.ToLower().Contains(txbNameProcedureSearch.Text.ToLower())).ToList();
                lvAdminProcedure.ItemsSource = listProcedure.ToList();
            }
            else
            {
                lvAdminProcedure.ItemsSource = Class.db.Procedure.ToList();
            }
        }

        

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (txbNameProcedureSearch.Text != "")
            {
                listProcedure = Class.db.Procedure.Where(i => i.NameProcedure.ToLower().Contains(txbNameProcedureSearch.Text.ToLower())).ToList();
                lvAdminProcedure.ItemsSource = listProcedure.ToList();
            }
            else
            {
                lvAdminProcedure.ItemsSource = Class.db.Procedure.ToList();
            }
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Database.Procedure item = new Database.Procedure();
            
            Class.newProcedure = item;
            Class.windowDoctor.frmActivity.Navigate(new Doctor.Procedure.DoctorProcedureAddPage());
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (lvAdminProcedure.SelectedValue != null)
            {
                var item = (Database.Procedure)lvAdminProcedure.SelectedItem;
                Class.newProcedure = item;
                Class.windowDoctor.frmActivity.Navigate(new Doctor.Procedure.DoctorProcedureAddPage());
            }
            else
            {
                MessageBox.Show("Not selected or another error.\n try again!", "Not Relesed Function", MessageBoxButton.OK);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Class.saveAuthData.Staff.IdRole.ToString(), "Not Relesed function", MessageBoxButton.OK);
        }

        private void lvAdminProcedure_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (Database.Procedure)lvAdminProcedure.SelectedItem;
            Class.newProcedure = item;
        }
    }
}
