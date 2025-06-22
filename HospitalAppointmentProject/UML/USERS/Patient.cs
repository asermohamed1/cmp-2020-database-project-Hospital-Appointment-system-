using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointmentProject.UML.FeedBacks;
using HospitalAppointmentProject.UML.theMedicalHistory;
using HospitalAppointmentProject.UML.Paper;
using HospitalAppointmentProject.UML.Appointments;
using System.Data;
using DBapplication;
using System.Security.Cryptography;
using System.Runtime.Remoting.Lifetime;

namespace HospitalAppointmentProject.UML.USERS
{
    internal class Patient : sysUser
    {
        public List<MedicalHistory> _MedicalHistories;
        public List<FeedBack> _FeedBacks;
        public List<Bill> _Bills;
        public List<HospitalAppointment> _Appointments;
        public List<Prescription> _PrescriptionList;
        public List<Doctor> _myDoctors;
        public List<ClinicAppointment> _ClinicAppointments;
        public int? _id;
        public List<MedicalHistory> MedicalHistories
        {
            get
            {
                // add query
                return _MedicalHistories;
            }
            set
            {
                // don't add query
                _MedicalHistories = value;
            }
        }

        public List<FeedBack> FeedBacks
        {
            get
            {
                // add query
                return _FeedBacks;
            }
            set
            {
                // don't add query
                _FeedBacks = value;
            }
        }

        public List<Bill> Bills
        {
            get
            {
                // add query
                return _Bills;
            }
            set
            {
                // don't add query
                _Bills = value;
            }
        }

        public List<HospitalAppointment> Appointments
        {
            get
            {
                // add query
                return _Appointments;
            }
            set
            {
                // don't add query
                _Appointments = value;
            }
        }

        public List<Prescription> PrescriptionList
        {
            get
            {
                // add query
                return _PrescriptionList;
            }
            set
            {
                // don't add query
                _PrescriptionList = value;
            }
        }

        public List<Doctor> myDoctors
        {
            get
            {
                return _myDoctors;
            }
            set
            {
                _myDoctors = value;
            }
        }

        public List<ClinicAppointment> ClinicAppointments
        {
            get
            {
                return _ClinicAppointments;
            }
            set
            {
                _ClinicAppointments = value;
            }
        }
        public int? id
        {
            get
            {
                // add query
                return _id;
            }
            set
            {
                // don't add query
                _id = value;
            }
        }
        public Patient(int? UserID = null, string Email = null, string UserPassword = null, int? Age = null, char? Gender = null, string First_Name = null, string Last_Name = null,
            List<ActivityLog> ActivityLogs = null, List<MedicalHistory> MedicalHistories = null, List<FeedBack> FeedBacks = null, List<Bill> Bills = null, List<HospitalAppointment> Appointments = null, List<Prescription> prescriptions = null, List<Doctor> myDoctors = null, List<ClinicAppointment> ClinicAppointments = null) :
            base(UserID, Email, UserPassword, Age, Gender, First_Name, Last_Name, ActivityLogs, UserType.Patient)
        {
            this.MedicalHistories = MedicalHistories;
            this.FeedBacks = FeedBacks;
            this._Bills = Bills;
            this.Appointments = Appointments;
            this.PrescriptionList = prescriptions;
            this.myDoctors = myDoctors;
            this.ClinicAppointments = ClinicAppointments;
            id = UserID;
        }

        public void GetUnBaidBills() { /**load the Bills into the list Bills then use it**/ }
        public void AddFeedBack(int DoctorID) { }


        public DataTable UpcomingAppointments()
        {
            string query = "select P.PlaceName,U.FirstName,U.LastName,HA.DateAndTime,HA.HospitalAppointmentID " +
                            "from PLACE as P, sysUser as U,Doctor as D ,HospitalAppointment as HA " +
                           $"where HA.DoctorID=U.UserID And HA.patientid={this._UserID} And D.DoctorID=U.UserID And D.HospitalID=P.PlaceID AND HA.DateAndTime > GETDATE() " +
                            "ORDER BY DATEANDTIME";
            ActivityLog.AddActivityLog(_UserID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Saw Upcoming Appointments");
            DataTable dt = DataBase.Manager.ExecuteReader(query);
            return dt;
        }
        public DataTable getpresforpa()
        {
            string getallpres = "select DateAndTime,DiseaseName,DiseaseDescription from Prescription where PatientID=" + id;
            ActivityLog.AddActivityLog(_UserID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "look up for his Disease");
            DataTable dt = DataBase.Manager.ExecuteReader(getallpres);
            return dt;
        }
        public DataTable getpresid()
        {
            string getallpres = "select PrescriptionID from Prescription where PatientID=" + id;
            DataTable dt1 = DataBase.Manager.ExecuteReader(getallpres);
            if (dt1 != null)
            {
                DataTable dt = dt1.Copy();

                dt.Columns.Add("Order", typeof(int));


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["Order"] = i + 1;
                }
                dt.Columns["Order"].SetOrdinal(0);

                return dt;

            }

            return dt1;
        }
        public DataTable getmedsinpres(int preid)
        {
            string getmeds = "select Medicinename,Dose from MedicinePrescription,medicine where MedicinePrescription.medicineid=medicine.medicineid and PrescriptionID=" + preid;
            DataTable dt = DataBase.Manager.ExecuteReader(getmeds);
            ActivityLog.AddActivityLog(_UserID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Saw his Medicines");
            return dt;
        }
        public DataTable getallmeds()
        {
            string getmeds = "select medicinename,medicineid from medicine";
            DataTable dt = DataBase.Manager.ExecuteReader(getmeds);
            return dt;
        }
        public DataTable getpharhavemed(int medid)
        {
            string getphars = "select placename,PlaceLocation,PhoneNumber,Email,IsAvailable,OpenDays,StartingTime,EndingTime from StoreMedicine,place where pharmacyid=placeid and medicineID=" + medid;
            DataTable dt = DataBase.Manager.ExecuteReader(getphars);
            ActivityLog.AddActivityLog(_UserID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Lokked Up For Medcines in Pharmicies");
            return dt;
        }



        //add more fubctions as u need
    }
}

