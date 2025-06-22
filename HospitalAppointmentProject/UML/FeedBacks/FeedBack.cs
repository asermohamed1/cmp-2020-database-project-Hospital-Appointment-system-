using DBapplication;
using HospitalAppointmentProject.UML.USERS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML.FeedBacks
{
    internal class FeedBack
    {
        public int? _FeedBackID;
        public string _theFeedBack;
        public int? _PatientID;
        public int? _DoctorID;

        //add queries to the next setters & getters
        public int? FeedBackID { get { return _FeedBackID; } set { _FeedBackID = value; } }
        public int? PatientID { get { return _PatientID; } set { _PatientID = value; } }
        public int? DoctorID { get { return _DoctorID; } set { _DoctorID = value; } }
        public string theFeedBack { get { return _theFeedBack; } set { _theFeedBack = value; } }

      public FeedBack(int? FeedBackID = null,string theFeedBack = null, int? PatientID = null, int? DoctorID = null) 
        {
            this.PatientID = PatientID;
            this.FeedBackID = FeedBackID;
            this.theFeedBack = theFeedBack;
            this.DoctorID = DoctorID;
        }
        public int addfeedback()
        {
            string maxid = $"select max(FeedbackID) from Feedback;";
            object id = DataBase.Manager.ExecuteScalar(maxid);
            if (id != null && id != DBNull.Value)
                _FeedBackID = (int)id + 1;
            else
            {
                _FeedBackID = 200000; // for first time
            }
            string q = $"insert into Feedback values ({_FeedBackID},{_DoctorID},{_PatientID},'{_theFeedBack}') ;";
            int result = DataBase.Manager.ExecuteNonQuery(q);
            if (result == 0)
                return 0;
            ActivityLog.AddActivityLog(_PatientID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Added a FeedBack");
            return 1;
        }
    }
}
