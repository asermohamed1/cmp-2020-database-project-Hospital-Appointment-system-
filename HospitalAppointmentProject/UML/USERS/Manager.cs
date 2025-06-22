using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointmentProject.UML.PLACES;

namespace HospitalAppointmentProject.UML.USERS
{
    internal class Manager : sysUser
    {
        public List<Place> _ManagedPlace;

        public List<Place> ManagedPlace
        {
            get
            {
                // add queries
                return _ManagedPlace;
            }
            set
            {
                // add validations
                _ManagedPlace = value;
            }
        }

        public Manager(int? UserID = null, string Email = null, string UserPassword = null, int? Age = null, char? Gender = null, string First_Name = null, string Last_Name = null,
            List<ActivityLog> ActivityLogs = null,UserType usertype = UserType.None, List<Place> ManagedPlace = null):
            base(UserID, Email, UserPassword, Age, Gender, First_Name, Last_Name, ActivityLogs, usertype)
        {
            this.ManagedPlace = ManagedPlace;
        }


        public void UpdatePlaceAvaliablity(bool Avaliable = true) { }
        //add more functions as u need
    }
}
