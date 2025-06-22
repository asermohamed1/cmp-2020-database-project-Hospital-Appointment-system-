using DBapplication;
using HospitalAppointmentProject.UML.USERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML.Appointments
{
    internal class HospitalAppointment
    {
        public int? _HospitalAppointmentID;
        public string _DateAndTime;
        public int? _DoctorID;
        public int? _PatientID;

        // add queries to the setters & getters
        public int? HospitalAppointmentID
        {
            get { return _HospitalAppointmentID; }
            set { _HospitalAppointmentID = value; }
        }

        public string DateAndTime
        {
            get { return _DateAndTime; }
            set { _DateAndTime = value; }
        }

        public int? DoctorID
        {
            get { return _DoctorID; }
            set { _DoctorID = value; }
        }

        public int? PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }


       

        public HospitalAppointment(int? HospitalAppointmentID = null, string DateAndTime = null, int? DoctorID = null, int? PatientID = null)
        {
            this.HospitalAppointmentID = HospitalAppointmentID;
            this.DateAndTime = DateAndTime ?? DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Default to current time in standard format
            this.DoctorID = DoctorID;
            this.PatientID = PatientID;
        }

        public int CancleAppointment()
        {
            string query = $"delete from HospitalAppointment Where HospitalAppointmentID={_HospitalAppointmentID}";
            ActivityLog.AddActivityLog(_PatientID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Canceled An Appointment");
            return DataBase.Manager.ExecuteNonQuery(query);
        }

        public int AddAppointment()
        {
            string maxid = $"select max(HospitalAppointmentID) from HospitalAppointment";
            object id = DataBase.Manager.ExecuteScalar(maxid);
            _HospitalAppointmentID = 1000000;
            if (id != null && id != DBNull.Value)
            {
                _HospitalAppointmentID = (int)id + 1;
            }
            ActivityLog.AddActivityLog(_PatientID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Addedd An Appointment");
            string query = $"insert HospitalAppointment Values ({_HospitalAppointmentID},'{_DateAndTime}',{_DoctorID},{_PatientID})";
            return DataBase.Manager.ExecuteNonQuery(query);
        }

        //add functions as u need
    }
}
