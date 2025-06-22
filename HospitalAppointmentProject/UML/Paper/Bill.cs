using DBapplication;
using HospitalAppointmentProject.UML.USERS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML.Paper
{
    internal class Bill
    {
        public int? _BillID;
        public float? _Price;
        public string _DatenTime;
        public int? _PatientID;
        public int? _PlaceID;
        bool _IsPaid;


        // add queries to the setters & getters
        public int? BillID
        {
            get { return _BillID; }
            set { _BillID = value; }
        }

        public float? Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public string DatenTime
        {
            get { return _DatenTime; }
            set { _DatenTime = value; }
        }

        public int? PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }

        public int? PlaceID
        {
            get { return _PlaceID; }
            set { _PlaceID = value; }
        }

        public bool IsPaid
        {
            get { return _IsPaid; }
            set { _IsPaid = value; }
        }

        public Bill(int? BillID = null, float? Price = null, string DatenTime = null, int? PatientID = null, int? PlaceID = null, bool IsPaid = false)
        {
            this.BillID = BillID;
            this.Price = Price;
            this.DatenTime = DatenTime;
            this.PatientID = PatientID;
            this.PlaceID = PlaceID;
            this.IsPaid = IsPaid;
        }

        public DataTable InsertBill()
        {
            string maxid = "select max(BillID) from Bill";
            object id = DataBase.Manager.ExecuteScalar(maxid);
            _BillID = 120000;
            if (id != null && id != DBNull.Value)
                _BillID = (int)id + 1;

            ActivityLog.AddActivityLog(_PatientID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Got Billed");
            ActivityLog.AddActivityLog(_PlaceID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Made a Bill");
            char c = _IsPaid ? 'T' : 'F';
            string query1 = $"insert Bill values({_BillID},{_Price},'{_DatenTime}',{_PlaceID},{_PatientID},'{c}')";
            DataBase.Manager.ExecuteNonQuery(query1);

            string query2 = $"select Price,DateandTime,IsPaid from Bill where BillID={_BillID}";
            return DataBase.Manager.ExecuteReader(query2);
        }

        //add more functions as u need
    }
}
