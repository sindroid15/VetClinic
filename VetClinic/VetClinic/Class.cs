using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VetClinic
{
    class Class
    {
        public static Auth.AuthWindow authWindow = new Auth.AuthWindow();
        public static Administrator.WindowAdmin windowAdmin = new Administrator.WindowAdmin();
       // public static Administrator.Appointment.PageAdminAppointmentClientAdd addClientAppointment = new Administrator.Appointment.PageAdminAppointmentClientAdd();

        public static Database.AuthData saveAuthData = new Database.AuthData();
        public static Database.Appointment appointment = new Database.Appointment();
        public static Database.Client clientAppointment = new Database.Client();
        public static Database.Pet petAppointment = new Database.Pet();
        public static Database.AppointmentData appointmentData = new Database.AppointmentData();
        public static Database.MedicalCard saveMedicalCard = new Database.MedicalCard();

        public static Database.Appointment saveAppointment = new Database.Appointment();
        public static Database.Client clientSaveAppointment = new Database.Client();
        public static Database.Pet petSaveAppointment = new Database.Pet();


        public static Database.Appointment mainSaverAppointment = new Database.Appointment();
        public static Database.MedicalCard mainSaverMedicalCard = new Database.MedicalCard();

        public static Database.AuthData authDataSave = new Database.AuthData();
        public static Database.Appointment changeAppointmentData = new Database.Appointment();
        public static Database.MedicalCard changeMedicalCard = new Database.MedicalCard();

        public static Database.MedicalCard MedicalCardsave = new Database.MedicalCard();


        public static Database.Client clientSave = new Database.Client();

        public partial class item
        {
            public static string FirstName { get; set; }
            public static string NamePet { get; set; }
            public static string DateTime { get; set; }
        }

        public static item newitem = new item();

        public static Database.VetDBEntities Context { get; } = new Database.VetDBEntities ();
        public static Database.VetDBEntities db = new Database.VetDBEntities();

        public static void CloseWindow()
        {
            Class.windowAdmin.Close();
        }

        public static void LvAppointment()
        {
            clientAppointment.IdClient = appointment.MedicalCard.IdClient;
            petAppointment.IdPet = appointment.MedicalCard.IdPet;

            var nameClient = clientAppointment.MedicalCard;
            var namePet = petAppointment.NamePet;

            item.NamePet = namePet;
            item.FirstName = nameClient.ToString();
            item.DateTime = appointment.DateTime.ToString();
        }

        public static void CreateMedicalCard()
        {
            Database.MedicalCard item =new Database.MedicalCard();
            item.IdClient = newsaveClient.IdClient;
            item.IdPet = newsavePet.IdPet;
            Class.db.MedicalCard.Add(item);
            Class.db.SaveChanges();
            MessageBox.Show("Successfull created medical card)))", "Not Relesed Function", MessageBoxButton.OK);
        }


        public static void AppointmentSave(string dataconvert)
        {

            var searcher = Class.db.MedicalCard.Where(i => i.IdClient == newsaveClient.IdClient&&i.IdPet==newsavePet.IdPet).FirstOrDefault();

            if (searcher==null)
            {
                CreateMedicalCard();
            }
            else
            {
                mainSaverAppointment.IdStaff = saveAuthData.IdStaff;
                mainSaverAppointment.DateTime = DateTime.Parse(dataconvert);
            }
            searcher = Class.db.MedicalCard.Where(i => i.IdClient == newsaveClient.IdClient && i.IdPet == newsavePet.IdPet).FirstOrDefault();
            if (searcher.IdMedicalCard==0)
            {
                Class.MedicalCardsave.IdClient = Class.changeAppointmentData.MedicalCard.IdClient;
                Class.MedicalCardsave.IdPet = Class.changeAppointmentData.MedicalCard.IdPet;
                Class.db.MedicalCard.Add(Class.MedicalCardsave);
                Class.db.SaveChanges();
                MessageBox.Show("Successfull created medical card)))", "Not Relesed Function", MessageBoxButton.OK);
                Class.windowAdmin.frmActivity.Navigate(new Administrator.MedicalCard.AdminMedicalCardMain());
            }
            saveMedicalCard.IdMedicalCard = searcher.IdMedicalCard;
            
            mainSaverAppointment.IdMedicalCard= searcher.IdMedicalCard; 
            mainSaverAppointment.IdStaff = saveAuthData.IdStaff;
            mainSaverAppointment.DateTime = DateTime.Parse(dataconvert);
            Class.db.Appointment.Add(mainSaverAppointment);
            Class.db.SaveChanges();
            MessageBox.Show("Successfull created Appointment)))", "Not Relesed Function", MessageBoxButton.OK);
            Class.windowAdmin.frmActivity.Navigate(new Administrator.Appointment.PageAdminAppointment());
        }

        

        public static void AuthDataAdd(int IdStaff, string Login, string Password)
        {
            authDataSave.IdStaff = IdStaff;
            authDataSave.Login = Login;
            authDataSave.Password = Password;
            Class.db.AuthData.Add(authDataSave);
            Class.db.SaveChanges();

        }





































        public static Database.Appointment newsaveAppointment = new Database.Appointment();
        public static Database.Client newsaveClient = new Database.Client();
        public static Database.Pet newsavePet = new Database.Pet();
        public static Database.MedicalCard newMedicalCard = new Database.MedicalCard();
        public static Database.Pet newPet = new Database.Pet();
        public static Database.Procedure newProcedure = new Database.Procedure();


    }
}
