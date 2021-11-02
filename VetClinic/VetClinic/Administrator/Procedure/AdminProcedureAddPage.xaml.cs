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

namespace VetClinic.Administrator.Procedure
{
    /// <summary>
    /// Логика взаимодействия для AdminProcedureAddPage.xaml
    /// </summary>
    public partial class AdminProcedureAddPage : Page
    {
        List<string> cabinetList = new List<string>();

        void ListCabinet()
        {
            var listcab = Class.db.Cabinet.ToList();
            var selectcab = cmbCabinet.SelectedItem.ToString();
            if(selectcab!=null)
            {
                listcab = listcab.Where(i => i.IdCabinet.ToString() == selectcab).ToList();
            }
        }

        public AdminProcedureAddPage()
        {
            InitializeComponent();

            var cabinet = Class.db.Cabinet.ToList();
            foreach(var i in cabinet)
            {

                cabinetList.Add(i.IdCabinet.ToString());
            }
            cmbCabinet.ItemsSource = cabinetList;
            if (Class.newProcedure!=null&&Class.newProcedure.Cabinet!=null)
            {
                txbCost.Text = Class.newProcedure.Cost.ToString();
                txbDurationInSeconds.Text = Class.newProcedure.DurationInSeconds.ToString();
                txbNameProcedure.Text = Class.newProcedure.NameProcedure.ToString();
                cmbCabinet.SelectedValue = Class.newProcedure.IdCabinet.ToString();
            }
            else
            {

            }
        }

        private void btnSaveProcedure_Click(object sender, RoutedEventArgs e)
        {
            if(Class.newProcedure.IdProcedure!=0)
            {
                var item = Class.db.Procedure.Find(Class.newProcedure.IdProcedure);
                item.IdCabinet = Int32.Parse( cmbCabinet.SelectedItem.ToString());
                item.NameProcedure = txbNameProcedure.Text;
                item.DurationInSeconds = Int32.Parse(txbDurationInSeconds.Text);
                item.Cost = Decimal.Parse(txbCost.Text);
                Class.db.SaveChanges();
                
                //Class.newProcedure.Cost = 0;
               // Class.newProcedure.IdCabinet = 0;
            //    Class.newProcedure.IdProcedure = 0;
                //Class.newProcedure.NameProcedure = null;
                MessageBox.Show("Successfull changed procedure)))", "Not Relesed Function", MessageBoxButton.OK);
                Class.windowAdmin.frmActivity.Navigate(new Administrator.Procedure.AdminProcedureMain());
            }
            else
            {
                //var item = Class.db.Procedure.Find(Class.newProcedure.IdProcedure);
                Class.newProcedure.Cabinet.IdCabinet = Int32.Parse(cmbCabinet.SelectedItem.ToString());
                Class.newProcedure.NameProcedure = txbNameProcedure.Text;
                Class.newProcedure.DurationInSeconds = Int32.Parse(txbDurationInSeconds.Text);
                Class.newProcedure.Cost = Decimal.Parse(txbCost.Text);
                Class.db.Procedure.Add(Class.newProcedure);
                Class.db.SaveChanges();
                MessageBox.Show("Successfull Procedure)))", "Not Relesed Function", MessageBoxButton.OK);
                Class.windowAdmin.frmActivity.Navigate(new Administrator.Procedure.AdminProcedureMain());
            }
        }

        private void btnCancelProcedure_Click(object sender, RoutedEventArgs e)
        {
            if (Class.newProcedure!=null)
            {
                Class.newProcedure = null;
                

                Class.windowAdmin.frmActivity.Navigate(new Administrator.Procedure.AdminProcedureMain());
            }

        }

        private void cmbCabinet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       
       
        
    }
}
