using DBapplication;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML.USERS
{
    internal class ActivityLog
    {
        public int? _UserID;
        public string _DatenTime;
        public string _ActivityType;


        // add queries to the setters & getters
        public string ActivityType { get { return _ActivityType; } set { _ActivityType = value; } }
        public int? UserID { get { return _UserID; } set { _UserID = value; } }
        public string DatenTime { get { return _DatenTime; } set { _DatenTime = value; } }


        static public void AddActivityLog (int userID, string DatenTime,string ActivityType)
        {
            string query = $"insert ActivityLogs Values({userID},'{DatenTime}','{ActivityType}')";
            DataBase.Manager.ExecuteNonQuery(query);
        }


        public ActivityLog(int? UserID = null,string DatenTime = null,string ActivityType = null) 
        {
            this.ActivityType = ActivityType;
            this.DatenTime = DatenTime ?? DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Default to current time in standard format
            this.UserID = UserID;
        }
        public DataTable getallactivities()
        {
            string q = $"select * from ActivityLogs where DateAndTime >'{_DatenTime}' ;";
            DataTable result = DataBase.Manager.ExecuteReader(q);
            return result;    
        }

        public DataTable getcertainactivities()
        {
            string q = $"select DateAndTime,ActivityType from ActivityLogs where UserID ={_UserID}; ";
            DataTable result = DataBase.Manager.ExecuteReader(q);
            return result;
        }
    }
}
