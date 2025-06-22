using DBapplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HospitalAppointmentProject.UML.Paper
{
    internal class Prescription
    {
        public int? _PrescriptionID;
        public DateTime _DateAndTime;
        public string _DiseaseName;
        public int? _PatientID;
        public string _DiseaseDescription;
        public int? _DoctorID;
        public Medicine[] _Medicines;

        // add queries to the setters & getters
        public int? PrescriptionID
        {
            get { return _PrescriptionID; }
            set { _PrescriptionID = value; }
        }

        public DateTime DateAndTime
        {
            get { return _DateAndTime; }
            set { _DateAndTime = value; }
        }

        public string DiseaseName
        {
            get { return _DiseaseName; }
            set { _DiseaseName = value; }
        }

        public int? PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }

        public string DiseaseDescription
        {
            get { return _DiseaseDescription; }
            set { _DiseaseDescription = value; }
        }

        public int? DoctorID
        {
            get { return _DoctorID; }
            set { _DoctorID = value; }
        }

        public Medicine[] Medicines
        {
            get { return _Medicines; }
            set { _Medicines = value; }
        }
        public Prescription(DateTime DateAndTime, int? PrescriptionID = null, string DiseaseName = null, int? PatientID = null, string DiseaseDescription = null, int? DoctorID = null, Medicine[] Medicines = null)
        {
            this.PrescriptionID = PrescriptionID;
            this.DateAndTime = DateAndTime;
            this.DiseaseName = DiseaseName;
            this.PatientID = PatientID;
            this.DiseaseDescription = DiseaseDescription;
            this.DoctorID = DoctorID;
            this.Medicines = Medicines;
        }
        public int addprescription()
        {
            string maxid = "select max(PrescriptionID) from prescription";
            object id = DataBase.Manager.ExecuteScalar(maxid);
            if (id != null && id != DBNull.Value)
                _PrescriptionID = (int)id + 1;
            else{
                _PrescriptionID = 1;
                };
            string formattedDateTime = _DateAndTime.ToString("yyyy-MM-ddTHH:mm:ss");
            string atyear = _DateAndTime.ToString("yyyy");

            string medicalquery = $"insert into MedicalHistory values({_PatientID}, '{_DiseaseDescription}', {int.Parse(atyear)} , 'F')";
            int medres = DataBase.Manager.ExecuteNonQuery(medicalquery);
            if (medres == 0)
                return 0;
            string query = $"insert into prescription values({_PrescriptionID}, '{formattedDateTime}', '{_DiseaseName}' , {_PatientID}, '{_DiseaseDescription}', {_DoctorID})";
            int Pres = DataBase.Manager.ExecuteNonQuery(query);
            if (Pres == 0)
                return 0;
            for (int i = 0; i < Medicines.Length; i++)
            {
                string q = $"insert into MedicinePrescription values( {_Medicines[i].MedicineID},{_PrescriptionID}, null);";
                int mres = DataBase.Manager.ExecuteNonQuery(q);
                if (mres == 0)
                    return mres;


            }
            return Pres;
        }
        public DataTable Getprescriptions()
        {
            string query = $"select firstName, LastName, DiseaseName, DiseaseDescription, DateAndTime from sysUser, prescription where userid = patientid and patientid = {_PatientID}";
            DataTable dt = DataBase.Manager.ExecuteReader(query);
            return dt;
        }
        //public DataTable
        //add functions as u need
    }
}
