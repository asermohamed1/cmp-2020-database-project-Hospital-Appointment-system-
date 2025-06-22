using DBapplication;
using HospitalAppointmentProject.UML.Appointments;
using HospitalAppointmentProject.UML.FeedBacks;
using HospitalAppointmentProject.UML.Paper;
using HospitalAppointmentProject.UML.PLACES;
using HospitalAppointmentProject.UML.theMedicalHistory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HospitalAppointmentSystem;


namespace HospitalAppointmentProject.UML.USERS
{
    internal class Doctor : sysUser
    {
        public Hospital _DoctorHospital;
        public DataTable _FeedBacks;
        public List<Clinic> _Clincs;
        public DataTable _Appointments;
        public List<Patient> _myPatients;
        public Department _DoctorDepartment;
        public List<ClinicAppointment> _ClinicAppointments;
        public char _isavailable;
        Hospital DoctorHospital
        {
            get
            {
                // add queries
                return _DoctorHospital;
            }
            set
            {
                // add queries
                _DoctorHospital = value;
            }
        }
        public char IsAvailable
        {
            get
            {
                string query = $"select ISAvailable from doctor where doctorid = {_UserID}";
                _isavailable = (char)DataBase.Manager.ExecuteScalar(query);
                return _isavailable;
            }
            set
            {
                   _isavailable = value;
            }
        }

        public int SetAvallibillity()
        {
            string query;
            if (_isavailable == 'T')
                query = $"Update doctor set ISAvailable = 'T' where doctorid = {_UserID}";
            else
                query = $"Update doctor set ISAvailable = 'F' where doctorid = {_UserID}";
            ActivityLog.AddActivityLog(_UserID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Updated his Avaliility");
            return DataBase.Manager.ExecuteNonQuery(query);
        }
        public DataTable FeedBacks
        {
            get
            {
                // add query
                if (_FeedBacks == null) return null; 
                string query = $"select thefeedback, email from sysUser,feedback where Userid = patientid and Doctorid = {_UserID}";
                _FeedBacks = DataBase.Manager.ExecuteReader(query);
                return _FeedBacks;
            }
            set
            {
                // don't add query
                _FeedBacks = value;
            }
        }

        public List<Clinic> Clincs
        {
            get
            {
                // add query
                return _Clincs;
            }
            set
            {
                // don't add query
                _Clincs = value;
            }
        }

        public DataTable Appointments
        {
            get
            {
                // add query
                string query = $"select DateAndTime, firstname, lastname from HospitalAppointment,sysUSER where Userid = patientid and doctorid = {_UserID}";
                _Appointments = DataBase.Manager.ExecuteReader(query);
                return _Appointments;
            }
            set
            {
                // don't add query
                _Appointments = value;
            }
        }

        public Department DoctorDepartment
        {
            get
            {
                // add query
                return _DoctorDepartment;
            }
            set
            {
                // add query
                _DoctorDepartment = value;
            }
        }

        public List<Patient> myPatients
        {
            get
            {
                // add query
                return _myPatients;
            }
            set
            {
                _myPatients = value;
            }
        }

        public List<ClinicAppointment> ClinicAppointments
        {
            get
            {
                return _ClinicAppointments;
            }
            set
            {
                _ClinicAppointments = value;
            }
        }




        public Doctor(int? UserID = null, string Email = null, string UserPassword = null, int? Age = null, char? Gender = null, string First_Name = null, string Last_Name = null,
            List<ActivityLog> ActivityLogs = null,Hospital DoctorHospital = null, List<Clinic> Clincs = null, Department DoctorDepartment = null, List<Bill> Bills = null, DataTable Appointments = null,List<Patient> myPatients = null,List<ClinicAppointment> ClinicAppointments = null) :
            base(UserID, Email, UserPassword, Age, Gender, First_Name, Last_Name, ActivityLogs, UserType.Doctor)
        {
            this.myPatients = myPatients;
            this.Clincs = Clincs;
            this.DoctorDepartment = DoctorDepartment;   
            this.DoctorHospital = DoctorHospital;
            this.FeedBacks = FeedBacks;
            this.Appointments = Appointments;
            this.ClinicAppointments = ClinicAppointments;
        }



        public int GetHosiptalID()
        {
            string GetHospitalID = $"select HospitalID from Doctor where DoctorID={this._UserID}";
            return (int)DataBase.Manager.ExecuteScalar(GetHospitalID);
        }
        public DataTable GetAllAvailableTimes(int DoctorId, DateTime AppointmentTime)
        {

            string day = AppointmentTime.DayOfWeek.ToString().Substring(0, 3).ToLower();

            //check doctor avaliballity
            string GetHospitalID = $"select HospitalID from Doctor where DoctorID={DoctorId}";
            int HospitalID = (int)DataBase.Manager.ExecuteScalar(GetHospitalID);






            //check hispital starting days
            string GetAvallableTimes = $"select StartingTime,EndingTime,OpenDays From Place Where PlaceID={HospitalID}";
            DataTable dt1 = DataBase.Manager.ExecuteReader(GetAvallableTimes);
            if (dt1 == null) return null;
            TimeSpan startingTime = (TimeSpan)dt1.Rows[0]["StartingTime"];
            TimeSpan EndingTime = (TimeSpan)dt1.Rows[0]["EndingTime"];
            string OpenDays = dt1.Rows[0]["OpenDays"].ToString();

            if (OpenDays.IndexOf(day) == -1) return null;

            string GetDoctorAppointments = $"select DateAndTime from HospitalAppointment where DoctorID={DoctorId} and CAST(DateAndTime AS DATE)=CAST('{AppointmentTime.ToString("yyyy-MM-ddTHH:mm:ss")}' AS DATE)";
            DataTable dt2 = DataBase.Manager.ExecuteReader(GetDoctorAppointments);

            if (dt2 == null) dt2 = new DataTable("DateAndTime");

            List<TimeSpan> appointmentTimes = new List<TimeSpan>();
            foreach (DataRow row in dt2.Rows)
            {
                if (row["DateAndTime"] != DBNull.Value)
                {
                    appointmentTimes.Add(Convert.ToDateTime(row["DateAndTime"]).TimeOfDay);
                }
            }


            List<TimeSpan> AppointmentTimes = new List<TimeSpan>();
            DataTable Result = new DataTable();
            Result.Columns.Add("AppointmentTime", typeof(TimeSpan));

            TimeSpan increment = TimeSpan.FromMinutes(30);
            for (TimeSpan Current = startingTime; Current <= EndingTime; Current += increment)
            {
                if (!appointmentTimes.Contains(Current))
                {
                    AppointmentTimes.Add(Current);
                }
            }

            foreach (TimeSpan apptime in AppointmentTimes)
            {
                DataRow newrow = Result.NewRow();
                if ((AppointmentTime.Date == DateTime.Now.Date && apptime > DateTime.Now.TimeOfDay) || AppointmentTime.Date > DateTime.Now.Date)
                {
                    newrow["AppointmentTime"] = apptime;
                    Result.Rows.Add(newrow);
                }
            }

            return Result;
        }
        public DataTable getfeedback()
        {
            string q = $"select FirstName,theFeedback from Feedback,sysUser where DoctorID = {_UserID} and UserID=PatientID";
            DataTable result = DataBase.Manager.ExecuteReader(q);
            return result;
        }

    
   

    }
}
