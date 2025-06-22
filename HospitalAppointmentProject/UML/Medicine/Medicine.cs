using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DBapplication;
namespace HospitalAppointmentProject.UML
{
    internal class Medicine
    {
        public int? _MedicineID;
        public string _MedicineName;
        public string _Active_Ingredinet;
        public int? _Quantity; // needed just for the pharmacy
        public string _Dose; //for Prescriptions

        // add queries to the setters & getters
        public int? MedicineID { get { return _MedicineID; } set { _MedicineID = value; } }
        public string MedicineName { get { return _MedicineName; } set { _MedicineName = value; } }
        public string Active_Ingredinet { get { return _Active_Ingredinet; } set { _Active_Ingredinet = value; } }
        public int? Quantity { get { return _Quantity; } set { _Quantity = value; } }
        
        public string Dose { get { return _Dose; } set { _Dose = value; } }
        public Medicine(int? MedicineID = null, string MedicineName = null,string Active_Ingredinet = null,int? Quantity = null,string Dose = null) 
        {
            this.MedicineID = MedicineID;
            this.MedicineName= MedicineName;
            this.Active_Ingredinet= Active_Ingredinet;
            this.Quantity = Quantity;
            this.Dose = Dose;
        }
        public DataTable GetAllMedicines()
        {
            string query = "Select * from Medicine";
            return DataBase.Manager.ExecuteReader(query);
        }
        //add more functions as u need
    }
}
