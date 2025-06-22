using DBapplication;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML
{
    internal class Department
    {
        public int? _DepartmentID;
        public string _DepartmentName;
        public string _Location; // when loading the hospitals locantions are required

        // add queries to setters & getters
        public int? DepartmentID { get { return _DepartmentID; } set { _DepartmentID = value; } }
        public string DepartmentName { get { return _DepartmentName; } set { _DepartmentName = value; } }
        public string Location { get { return _Location; } set { _Location = value; } }

       public Department(int? DepartmentID = null,string DepartmentName = null,string Location = null) 
        {
            this.DepartmentName = DepartmentName;
            this.DepartmentID = DepartmentID;   
            this.Location = Location;
        }

        public DataTable GetDepartments() 
        {
            string query = "select * from Department";
            return DataBase.Manager.ExecuteReader(query);
        }

        public DataTable GetAllHospitals()
        {
            string query = "select H.PlaceName,H.PlaceID " +
                           "from Place as H,HospitalDepartment as HD " +
                          $"where HD.HospitalID=H.PlaceID AND HD.DepartmentID={this._DepartmentID}";
            return DataBase.Manager.ExecuteReader(query);
        }
        public void ReName() { }
        //add more functions as u need
    }
}
