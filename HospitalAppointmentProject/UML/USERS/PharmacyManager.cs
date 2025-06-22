using DBapplication;
using HospitalAppointmentProject.UML.PLACES;
using HospitalAppointmentSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAppointmentProject.UML.USERS
{
    internal class PharmacyManager : Manager
    {
        public Pharmacy pharmacy_manager;
        public int? idman;
        public PharmacyManager(int? UserID = null, string Email = null, string UserPassword = null, int? Age = null, char? Gender = null, string First_Name = null, string Last_Name = null,
            List<ActivityLog> ActivityLogs = null, List<Place> ManagedPlace = null) :
            base(UserID, Email, UserPassword, Age, Gender, First_Name, Last_Name, ActivityLogs, UserType.PharmacyManager, ManagedPlace)
        {
            idman = UserID;
            string getphid = "select pharmacyID from PharmacyManager where ManagerID=" + idman;
            object phid = DataBase.Manager.ExecuteScalar(getphid);
            pharmacy_manager = new Pharmacy((int)phid);
        }
        public void changeavailbility(bool f)
        {
            char available;
            if (f == true)
                available = 'T';
            else
                available = 'F';

            string setavail = "update place set IsAvailable='" + available + "'where placeid=" + pharmacy_manager.id;
            int res = DataBase.Manager.ExecuteNonQuery(setavail);
            if (res == 0)
            {
                MessageBox.Show("error in updation of availbility");
            }
            else
            {
                MessageBox.Show("succesful updation  of availbility");
            }
            ActivityLog.AddActivityLog(_UserID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Set Avalibillity of the Pharamacy");
        }
        public void changetime(int tfrom, int tto)
        {
            string setftime, setttime;
            if (tfrom < 10 && tto < 10)
            {
                setftime = "update place set StartingTime='" + 0 + tfrom + ":" + 00 + ":" + 00 + "' where placeid=" + pharmacy_manager.id;
                setttime = "update place set EndingTime='" + 0 + tto + ":" + 00 + ":" + 00 + "' where placeid=" + pharmacy_manager.id;
            }
            else if (tfrom < 10)
            {
                setftime = "update place set StartingTime='" + 0 + tfrom + ":" + 00 + ":" + 00 + "' where placeid = " + pharmacy_manager.id;
                setttime = "update place set EndingTime='" + tto + ":" + 00 + ":" + 00 + "'";
            }
            else if (tto < 10)
            {
                setftime = "update place set StartingTime='" + tfrom + ":" + 00 + ":" + 00 + "' where placeid=" + pharmacy_manager.id;
                setttime = "update place set EndingTime='" + 0 + tto + ":" + 00 + ":" + 00 + "' where placeid=" + pharmacy_manager.id;
            }
            else
            {
                setftime = "update place set StartingTime='" + tfrom + ":" + 00 + ":" + 00 + "' where placeid=" + pharmacy_manager.id;
                setttime = "update place set EndingTime='" + tto + ":" + 00 + ":" + 00 + "' where placeid=" + pharmacy_manager.id;
            }
            int res1 = DataBase.Manager.ExecuteNonQuery(setftime);
            int res2 = DataBase.Manager.ExecuteNonQuery(setttime);
            if (res1 > 0 && res2 > 0)
            {
                MessageBox.Show("successful updation time");
            }
            else
            {
                MessageBox.Show("failed updation time");
            }
            ActivityLog.AddActivityLog(_UserID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Set time of the Pharmacy");
        }
        public string getopendays()
        {
            string getopendays = "select OpenDays from place where placeid=" + pharmacy_manager.id;
            object opendays = DataBase.Manager.ExecuteScalar(getopendays);
            return opendays.ToString();
        }
        public void pushday(string day)
        {


            string setday = "update place set opendays='" + day + "' where placeid=" + pharmacy_manager.id;
            int res = DataBase.Manager.ExecuteNonQuery(setday);
            if (res == 0)
            {
                MessageBox.Show("error in updation of days");
            }
            else
            {
                MessageBox.Show("succesful updation of days");
            }
           
        }

        public void pushPhName(string PhName)
        {
            string setphname = "update place set PlaceName='" + PhName + "'where placeid=" + pharmacy_manager.id;
            int res = DataBase.Manager.ExecuteNonQuery(setphname);
            if (res == 0)
            {
                MessageBox.Show("faild updation hospital");
            }
     
        }
        public void pushPhEmail(string PhEmail)
        {
            string setPhemail = "update place set Email='" + PhEmail + "'where placeid=" + pharmacy_manager.id;
            int res = DataBase.Manager.ExecuteNonQuery(setPhemail);
            if (res == 0)
            {
                MessageBox.Show("faild updation hospital");
            }
            
        }
        public void pushPhPN(string PhPN)
        {
            string setPhPN = "update place set PhoneNumber='" + PhPN + "'where placeid=" + pharmacy_manager.id;
            int res = DataBase.Manager.ExecuteNonQuery(setPhPN);
            if (res == 0)
            {
                MessageBox.Show("faild updation hospital");
            }
         
        }
        public void pushPhLoction(string PhLoction)
        {
            string setPhLoction = "update place set PlaceLocation='" + PhLoction + "'where placeid=" + pharmacy_manager.id;
            int res = DataBase.Manager.ExecuteNonQuery(setPhLoction);
            if (res == 0)
            {
                MessageBox.Show("faild updation hospital");
            }
           
        }

        public int getavailbility()
        {
            string getavail = "select IsAvailable from place where placeid=" + pharmacy_manager.id;
            object val = DataBase.Manager.ExecuteScalar(getavail);
            char isAvailable;
            try
            {
                isAvailable = val.ToString()[0];
            }
            catch (Exception e)
            {
                isAvailable = 'F';
            }

            if (isAvailable == 'T')
                return 1;
            else
                return 0;
        }
        public string getstarttime()
        {
            string getsatrttime = "select StartingTime from place where placeid=" + pharmacy_manager.id;
            object val = DataBase.Manager.ExecuteScalar(getsatrttime);

            if (val != null && TimeSpan.TryParse(val.ToString(), out TimeSpan time))
            {
                return time.Hours.ToString();
            }
            return string.Empty;
        }
        public string getendtime()
        {
            string getendtime = "select EndingTime from place where placeid=" + pharmacy_manager.id;
            object val = DataBase.Manager.ExecuteScalar(getendtime);

            if (val != null && TimeSpan.TryParse(val.ToString(), out TimeSpan time))
            {
                return time.Hours.ToString();
            }
            return string.Empty;
        }
        public DataTable getmidinstock()
        {
            string getmedinphar = "select Medicine.MedicineID,Medicine.MedicineName,Quantity,Active_Ingredinet from Medicine,StoreMedicine,pharmacy where Medicine.MedicineID=StoreMedicine.MedicineID AND StoreMedicine.pharmacyid=pharmacy.pharmacyid and Pharmacy.pharmacyid=" + pharmacy_manager.id;
            DataTable dt = DataBase.Manager.ExecuteReader(getmedinphar);
            return dt;
        }
        public DataTable getallmedicines()
        {
            string getallmed = "select medicinename,medicineid from medicine";
            DataTable dt = DataBase.Manager.ExecuteReader(getallmed);
            return dt;
        }
        public void updatemed(int medid, int quantity)
        {
            string updatemedinph = "update StoreMedicine set Quantity=" + quantity + " where PharmacyID=" + pharmacy_manager.id + "and medicineid=" + medid;
            int res = DataBase.Manager.ExecuteNonQuery(updatemedinph);
            if (res == 0)
            {
                MessageBox.Show("failed updation medicine");
            }
            else
            {
                MessageBox.Show("successful updation medicine");

            }
            ActivityLog.AddActivityLog(_UserID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "update Medicine in pharmacy");
        }
        public void insertmed(int medid, int quantity)
        {
            string updatemedinph = "insert into StoreMedicine values (" + medid + "," + pharmacy_manager.id + "," + quantity + ")";
            int res = DataBase.Manager.ExecuteNonQuery(updatemedinph);
            if (res == 0)
            {
                MessageBox.Show("failed insertion medicine");
            }
            else
            {
                MessageBox.Show("successful insertion medicine");

            }
            ActivityLog.AddActivityLog(_UserID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Add Pharmacy Medicine");
        }
        public void deletemed(int medid)
        {
            string delmedinph = "delete from StoreMedicine where pharmacyid=" + pharmacy_manager.id + " and medicineid=" + medid;
            int res = DataBase.Manager.ExecuteNonQuery(delmedinph);
            if (res == 0)
            {
                MessageBox.Show("failed deletion medicine");
            }
            else
            {
                MessageBox.Show("successful deletion medicine");

            }
            ActivityLog.AddActivityLog(_UserID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Delete Pharmacy Medicine");
        }

        //add more functions as u need
    }
}
