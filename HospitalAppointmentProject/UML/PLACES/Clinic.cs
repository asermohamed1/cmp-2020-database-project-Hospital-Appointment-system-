using HospitalAppointmentProject.UML.Appointments;
using HospitalAppointmentProject.UML.USERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML.PLACES
{
    internal class Clinic : Place
    {
        public List<ClinicAppointment> _ClinicAppointments;
        public Department _ClinicDepartment;
        public int? _DoctorID;

        
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

       
        public Department ClinicDepartment
        {
            get
            {
                return _ClinicDepartment;
            }
            set
            {
                _ClinicDepartment = value;
            }
        }

       
        public int? DoctorID
        {
            get
            {
                return _DoctorID;
            }
            set
            {
                _DoctorID = value;
            }
        }

        
        public Clinic(int? PlaceID = null, string PlaceName = null, string Email = null, string PhoneNumber = null,
                      string StartingTime = null, string EndingTime = null, bool? IsAvailable = null,
                      string PlaceLocation = null, string OpenDays = null, List<ClinicAppointment> ClinicAppointments = null,
                      Department ClinicDepartment = null, int? DoctorID = null) : base(PlaceID, PlaceName, Email, PhoneNumber,
                                                                                        StartingTime, EndingTime, IsAvailable,
                                                                                        PlaceLocation, OpenDays, PlaceType.Clinic)
        {
            this.ClinicAppointments = ClinicAppointments;
            this.ClinicDepartment = ClinicDepartment;
            this.DoctorID = DoctorID;
        }

        // Add more methods or functions if needed
    }
}
