using DBapplication;
using HospitalAppointmentProject.UML.PLACES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalAppointmentProject.UML.USERS
{
    internal class HospitalManager : Manager
    {
        public Hospital hospital_manager;
        public int? idman;

        public HospitalManager(int? UserID = null, string Email = null, string UserPassword = null, int? Age = null, char? Gender = null, string First_Name = null, string Last_Name = null,
           List<ActivityLog> ActivityLogs = null, List<Place> ManagedPlace = null) :
           base(UserID, Email, UserPassword, Age, Gender, First_Name, Last_Name, ActivityLogs, UserType.HospitalManager, ManagedPlace)
        {
            idman = UserID;
            string gethosid = "select HospitalID from HospitalManager where ManagerID=" + idman;
            object hosid = DataBase.Manager.ExecuteScalar(gethosid);
            hospital_manager = new Hospital((int)hosid);

        }

        public void changeavailbility(bool f)
        {
            char available;
            if (f == true)
                available = 'T';
            else
                available = 'F';

            string setavail = "update place set IsAvailable='" + available + "'where placeid=" + hospital_manager.id;
            int res = DataBase.Manager.ExecuteNonQuery(setavail);
            if (res == 0)
            {
                MessageBox.Show("error in updation of availbility");
            }
            else
            {
                MessageBox.Show("succesful updation  of availbility");
            }
            ActivityLog.AddActivityLog(_UserID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Set Avalibollity of the Hospital");
        }
        public void changetime(int tfrom, int tto)
        {
            string setftime, setttime;
            if (tfrom < 10 && tto < 10)
            {
                setftime = "update place set StartingTime='" + 0 + tfrom + ":" + 00 + ":" + 00 + "' where placeid=" + hospital_manager.id;
                setttime = "update place set EndingTime='" + 0 + tto + ":" + 00 + ":" + 00 + "' where placeid=" + hospital_manager.id;
            }
            else if (tfrom < 10)
            {
                setftime = "update place set StartingTime='" + 0 + tfrom + ":" + 00 + ":" + 00 + "' where placeid = " + hospital_manager.id;
                setttime = "update place set EndingTime='" + tto + ":" + 00 + ":" + 00 + "'";
            }
            else if (tto < 10)
            {
                setftime = "update place set StartingTime='" + tfrom + ":" + 00 + ":" + 00 + "' where placeid=" + hospital_manager.id;
                setttime = "update place set EndingTime='" + 0 + tto + ":" + 00 + ":" + 00 + "' where placeid=" + hospital_manager.id;
            }
            else
            {
                setftime = "update place set StartingTime='" + tfrom + ":" + 00 + ":" + 00 + "' where placeid=" + hospital_manager.id;
                setttime = "update place set EndingTime='" + tto + ":" + 00 + ":" + 00 + "' where placeid=" + hospital_manager.id;
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
            ActivityLog.AddActivityLog(_UserID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Set time of the Hospital");
        }
        public string getopendays()
        {
            string getopendays = "select OpenDays from place where placeid=" + hospital_manager.id;
            object opendays = DataBase.Manager.ExecuteScalar(getopendays);
            return opendays.ToString();
        }
        public void pushday(string day)
        {
            string setday = "update place set opendays='" + day + "' where placeid=" + hospital_manager.id;
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


        public void pushHosName(string HosName)
        {
            string sethosname = "update place set PlaceName='" + HosName + "'where placeid=" + hospital_manager.id;
            int res = DataBase.Manager.ExecuteNonQuery(sethosname);
            if (res == 0)
            {
                MessageBox.Show("faild updation hospital");
            }
           
        }
        public void pushHosEmail(string HosEmail)
        {
            string sethosemail = "update place set Email='" + HosEmail + "'where placeid=" + hospital_manager.id;
            int res = DataBase.Manager.ExecuteNonQuery(sethosemail);
            if (res == 0)
            {
                MessageBox.Show("faild updation hospital");
            }
           
        }
        public void pushHosPN(string HosPN)
        {
            string setHosPN = "update place set PhoneNumber='" + HosPN + "'where placeid=" + hospital_manager.id;
            int res = DataBase.Manager.ExecuteNonQuery(setHosPN);
            if (res == 0)
            {
                MessageBox.Show("faild updation hospital");
            }
            
        }
        public void pushHosLoction(string HosLoction)
        {
            string setHosLoction = "update place set PlaceLocation='" + HosLoction + "'where placeid=" + hospital_manager.id;
            int res = DataBase.Manager.ExecuteNonQuery(setHosLoction);
            if (res == 0)
            {
                MessageBox.Show("faild updation hospital");
            }
         
        }

        public int getavailbility()
        {
            string getavail = "select IsAvailable from place where placeid=" + hospital_manager.id;
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
            string getsatrttime = "select StartingTime from place where placeid=" + hospital_manager.id;
            object val = DataBase.Manager.ExecuteScalar(getsatrttime);

            if (val != null && TimeSpan.TryParse(val.ToString(), out TimeSpan time))
            {
                return time.Hours.ToString();
            }
            return string.Empty;
        }
        public string getendtime()
        {
            string getendtime = "select EndingTime from place where placeid=" + hospital_manager.id;
            object val = DataBase.Manager.ExecuteScalar(getendtime);

            if (val != null && TimeSpan.TryParse(val.ToString(), out TimeSpan time))
            {
                return time.Hours.ToString();
            }
            return string.Empty;
        }
        public DataTable gethosdepartments()
        {
            string hosdep = "select department.DepartmentName,department.DepartmentID from Hospital,Department,HospitalDepartment where Hospital.HospitalID=HospitalDepartment.HospitalID and Department.DepartmentID=HospitalDepartment.DepartmentID and Hospital.HospitalID=" + hospital_manager.id;
            DataTable dt = DataBase.Manager.ExecuteReader(hosdep);
            return dt;

        }
        public void adddoctor(string DocFName, string DocLanme, int DocAge, string Docgender, int dep_id, string DocEmail, string password)
        {
            string getmaxid = "select max(UserID) from sysUser";
            int maxid = (int)DataBase.Manager.ExecuteScalar(getmaxid);
            maxid++;

            string adduser = "insert into sysuser values(" + maxid + ",'" + DocEmail + "','" + password + "'," + DocAge + ",'" + Docgender + "','" + DocFName + "','" + DocLanme + "')";
            int res = DataBase.Manager.ExecuteNonQuery(adduser);
            if (res != 0)
            {
                string adddoctorc = "insert into Doctor values(" + maxid + "," + 0 + "," + dep_id + "," + hospital_manager.id + ")";
                int res2 = DataBase.Manager.ExecuteNonQuery(adddoctorc);
                if (res2 != 0)
                {
                    MessageBox.Show("successful insertion Doctor");
                }
                else
                {
                    MessageBox.Show("failed insertion Doctor");
                }
            }
            else
            {
                MessageBox.Show("failed insertion User");
            }
            ActivityLog.AddActivityLog(_UserID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Added a Doctor");
        }
        public DataTable getdoctorsdep(int dep_id)
        {
            string getdocsindep = "select doctorid,firstname,lastname,age from sysuser,doctor where userid=doctorid and departmentid=" + dep_id + "and hospitalid=" + hospital_manager.id;
            DataTable dt = DataBase.Manager.ExecuteReader(getdocsindep);
            return dt;
        }
        public DataTable getdocinhos(string fname, string lname)
        {
            string getdocinhos = "select doctorid,firstname,lastname,age from sysuser,doctor where userid=doctorid and " + " hospitalid=" + hospital_manager.id + "and firstname='" + fname + "' and lastname='" + lname + "'";
            DataTable dt = DataBase.Manager.ExecuteReader(getdocinhos);
            return dt;
        }
        public void deleteDoctor(int id)
        {
            string deldoc = "delete from sysuser where userid=" + id;
            int res = DataBase.Manager.ExecuteNonQuery(deldoc);
            if (res == 0)
            {
                MessageBox.Show("faild deletion doctor");
            }
            else
            {
                MessageBox.Show("successful deletion doctor");
            }
            ActivityLog.AddActivityLog(_UserID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Deleted a Doctor");
        }
        public void updatedoctor(string f, string l, int age, int id)
        {
            string updatedoc = "update sysuser set firstname='" + f + "',lastname='" + l + "',age=" + age + " where userid=" + id;
            int res = DataBase.Manager.ExecuteNonQuery(updatedoc);
            if (res == 0)
            {
                MessageBox.Show("failed updation doctor");
            }
            else
            {
                MessageBox.Show("successful updation doctor");
            }
            ActivityLog.AddActivityLog(_UserID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Updated a Doctor");
        }
        //add more functions as u need
    }
}
