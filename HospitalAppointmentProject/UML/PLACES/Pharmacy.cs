using DBapplication;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML.PLACES
{
    internal class Pharmacy : Place
    {
        public List<Medicine> _Medicines;
        int? _id;
        
        public List<Medicine> Medicines
        {
            get
            {
                return _Medicines;
            }
            set
            {
                _Medicines = value;
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

        
        public Pharmacy(int? PlaceID = null, string PlaceName = null, string Email = null, string PhoneNumber = null,
                        string StartingTime = null, string EndingTime = null, bool? IsAvailable = null,
                        string PlaceLocation = null, string OpenDays = null, List<Medicine> Medicines = null)
            : base(PlaceID, PlaceName, Email, PhoneNumber, StartingTime, EndingTime, IsAvailable, PlaceLocation, OpenDays, PlaceType.Pharmacy)
        {
            _id = PlaceID;
            this.Medicines = Medicines;
        }
        public int insertp()
        {
            string q = $"insert into Place values ({_PlaceID},'{_PlaceName}','{_Email}','{_PhoneNumber}','{_StartingTime}','{_EndingTime}','{_IsAvailable}','{_PlaceLocation}','{_OpenDays}') ";
            int resultpharmacy = DataBase.Manager.ExecuteNonQuery(q);
            string pidq = $"insert into Pharmacy values({_PlaceID});";
            int resultpid = DataBase.Manager.ExecuteNonQuery(pidq);
            id = PlaceID;
            if (resultpid == 0 || resultpharmacy == 0)
                return 0;
            return 1;
        }
       
        public bool CheckIfPharmacyExists(int pharmacyID)
        {
            string query = $"SELECT COUNT(*) FROM Place WHERE PlaceID = {pharmacyID}";
            int c = (int)DataBase.Manager.ExecuteScalar(query);
            return c > 0;
        }
        public int deletePharmacy()
        {
            string q = $"DELETE FROM Pharmacy where PharmacyID = {_PlaceID}; ";
            int r = DataBase.Manager.ExecuteNonQuery(q);
            string query = $"DELETE FROM Place WHERE PlaceID = {_PlaceID};";
            int resultPharmacy = DataBase.Manager.ExecuteNonQuery(query);

            if (resultPharmacy == 0 || r==0 )
                return 0;

                return 1;
          
        }

    }
}
