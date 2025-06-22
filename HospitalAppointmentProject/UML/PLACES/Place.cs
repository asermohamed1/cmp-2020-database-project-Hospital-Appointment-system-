using DBapplication;
using HospitalAppointmentProject.UML.USERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML.PLACES
{

    enum PlaceType { None,Hospital,Pharmacy,Clinic };
    internal class Place
    {
        public int? _PlaceID;
        public string _PlaceName;
        public string _Email;
        public string _PhoneNumber;
        public string _StartingTime; 
        public string _EndingTime;   
        public bool? _IsAvailable; 
        public string _PlaceLocation;
        public string _OpenDays; 
        public PlaceType _Type;
        public int? PlaceID
        {
            get { return _PlaceID; }
            set { _PlaceID = value; }
        }

        public string PlaceName
        {
            get { return _PlaceName; }
            set
            {
                _PlaceName = value;
                if (value != null)
                {
                    string query = $"UPDATE Place SET PlaceName = '{_PlaceName}' WHERE PlaceID = {_PlaceID}";
                    int result = DataBase.Manager.ExecuteNonQuery(query);
                }
            }
        }

        public string Email
        {
            get { return _Email; }
            set
            {
                _Email = value;
                if (value != null)
                {
                    string query = $"UPDATE Place SET Email = '{_Email}' WHERE PlaceID = {_PlaceID}";
                    int result = DataBase.Manager.ExecuteNonQuery(query);
                    if (result == 0)
                        _Email = null;
                }
            }
        }

        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set
            {
                _PhoneNumber = value;
                if (value != null)
                {
                    string query = $"UPDATE Place SET PhoneNumber = '{_PhoneNumber}' WHERE PlaceID = {_PlaceID}";
                    int result = DataBase.Manager.ExecuteNonQuery(query);
                    if (result == 0)
                        _PhoneNumber = null;
                }
            }
        }

        public string StartingTime
        {
            get { return _StartingTime; }
            set { _StartingTime = value; }
        }

        public string EndingTime
        {
            get { return _EndingTime; }
            set { _EndingTime = value; }
        }

        public bool? IsAvailable
        {
            get { return _IsAvailable; }
            set { _IsAvailable = value; }
        }

        public string PlaceLocation
        {
            get { return _PlaceLocation; }
            set
            {
                _PlaceLocation = value;
                if (value != null)
                {
                    {
                        string query = $"UPDATE Place SET PlaceLocation = '{_PlaceLocation}' WHERE PlaceID = {_PlaceID}";
                        int result = DataBase.Manager.ExecuteNonQuery(query);
                        if (result == 0)
                            _PlaceLocation = null;
                    }
                }
            }
        }

        public string OpenDays
        {
            get { return _OpenDays; }
            set { _OpenDays = value; }
        }

        public PlaceType Type
        {
            get { return _Type; }
            set { _Type = value; }
        }


        public Place(
            int? PlaceID = null,
            string PlaceName = null,
            string Email = null,
            string PhoneNumber = null,
            string StartingTime = null,
            string EndingTime = null,
            bool? IsAvailable = null,
            string PlaceLocation = null,
            string OpenDays = null,
            PlaceType Type = PlaceType.None)
        {
            this.PlaceID = PlaceID;
            this.PlaceName = PlaceName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.StartingTime = StartingTime;
            this.EndingTime = EndingTime;
            this.IsAvailable = IsAvailable;
            this.PlaceLocation = PlaceLocation;
            this.OpenDays = OpenDays;
            this.Type = Type;
        }
    }
}
