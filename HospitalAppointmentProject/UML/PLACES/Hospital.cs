using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DBapplication;
using HospitalAppointmentProject.UML.Appointments;
using HospitalAppointmentProject.UML.USERS;

namespace HospitalAppointmentProject.UML.PLACES
{
    internal class Hospital : Place
    {
        public List<Department> _HospitalsDepartments;
        public List<Doctor> _Doctors;
        public List<HospitalAppointment> _Appointments;
        public int? _id;

        public List<Department> HospitalsDepartments
        {
            get
            {
                return _HospitalsDepartments;
            }
            set
            {
                _HospitalsDepartments = value;
            }
        }


        public List<Doctor> Doctors
        {
            get
            {
                return _Doctors;
            }
            set
            {
                _Doctors = value;
            }
        }

        public List<HospitalAppointment> Appointments
        {
            get
            {
                return _Appointments;
            }
            set
            {
                _Appointments = value;
            }
        }

        public int? id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public Hospital(int? PlaceID = null, string PlaceName = null, string Email = null, string PhoneNumber = null,
                        string StartingTime = null, string EndingTime = null, bool? IsAvailable = null,
                        string PlaceLocation = null, string OpenDays = null, List<Department> HospitalsDepartments = null,
                        List<Doctor> Doctors = null, List<HospitalAppointment> Appointments = null)
            : base(PlaceID, PlaceName, Email, PhoneNumber, StartingTime, EndingTime, IsAvailable, PlaceLocation, OpenDays, PlaceType.Hospital)
        {
            this.HospitalsDepartments = HospitalsDepartments;
            this.Doctors = Doctors;
            this.Appointments = Appointments;
            id = PlaceID;
        }



        public DataTable GetDoctorsInDepartment(int DepartmentId)
        {
            string query = "select U.FirstName,U.UserID " +
                           "from Department as D,Hospital as H,HospitalDepartment as HD,Doctor as Dr,sysUser as U " +
                          $"where Dr.HospitalID=H.HospitalID AND Dr.DepartmentID=D.DepartmentID And U.UserID=Dr.DoctorID And D.DepartmentID={DepartmentId} and HD.HospitalID=H.HospitalID and H.HospitalID={this._PlaceID}";
            return DataBase.Manager.ExecuteReader(query);
        }
  

        public int inserthospital()
        {
            string q = $"insert into Place values ({_PlaceID},'{_PlaceName}','{_Email}','{_PhoneNumber}','{_StartingTime}','{_EndingTime}','{_IsAvailable}','{_PlaceLocation}','{_OpenDays}') ";
            int resulthos = DataBase.Manager.ExecuteNonQuery(q);
            string hosq = $"insert into Hospital values({_PlaceID});";
            int resulthid = DataBase.Manager.ExecuteNonQuery(hosq);
            if (resulthid == 0 || resulthos == 0)
                return 0;
            return 1;
        }
        public int deletehospital()
        {
            string q = $"DELETE FROM Hospital where HospitalID = {_PlaceID}; ";
            int r = DataBase.Manager.ExecuteNonQuery(q);
            string query = $"DELETE FROM Place WHERE PlaceID = {_PlaceID};";
            int resultPharmacy = DataBase.Manager.ExecuteNonQuery(query);
            if (resultPharmacy == 0 || r == 0)
                return 0;

            return 1;

        }

        public bool CheckIfHospitalExists(int hid)
        {
            string query = $"SELECT COUNT(*) FROM Place WHERE PlaceID = {hid}";
            int c = (int)DataBase.Manager.ExecuteScalar(query);
            return c > 0;
        }

    }
}
