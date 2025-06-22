using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML.Appointments
{
    internal class ClinicAppointment
    {
        public int? _ClinicAppointmentID;
        public string _DateAndTime; 
        public int? _PatientID;
        public int? _ClinicID;

        // add queries to the setters & getters
        public int? ClinicAppointmentID
        {
            get { return _ClinicAppointmentID; }
            set { _ClinicAppointmentID = value; }
        }

        public string DateAndTime
        {
            get { return _DateAndTime; }
            set { _DateAndTime = value; }
        }

        public int? PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }

        public int? ClinicID
        {
            get { return _ClinicID; }
            set { _ClinicID = value; }
        }

        // Constructor with default values
        public ClinicAppointment(int? ClinicAppointmentID = null, string DateAndTime = null, int? PatientID = null, int? ClinicID = null)
        {
            this.ClinicAppointmentID = ClinicAppointmentID;
            this.DateAndTime = DateAndTime ?? DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Default to current time
            this.PatientID = PatientID;
            this.ClinicID = ClinicID;
        }

        //add functions as u need
    }
}
