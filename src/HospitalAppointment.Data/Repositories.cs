using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using HospitalAppointment.Data.Models;

namespace HospitalAppointment.Data.Repositories
{
    /// <summary>Authentication and account management.</summary>
    public class UserRepository
    {
        private readonly Database _db;
        public UserRepository(Database db) { _db = db ?? throw new ArgumentNullException(nameof(db)); }

        /// <summary>Returns the user if the credentials match, otherwise null.</summary>
        public AppUser Login(string email, string password)
        {
            var table = _db.QueryProcedure("dbo.usp_LoginUser", Database.P("Email", email));
            if (table.Rows.Count == 0) return null;
            var row = table.Rows[0];
            if (!string.Equals((string)row["userPassword"], password, StringComparison.Ordinal))
                return null;
            return new AppUser { UserID = (int)row["UserID"], Email = email };
        }

        public UserRole GetRole(int userId)
        {
            var role = _db.ScalarProcedure("dbo.usp_GetUserRole", Database.P("UserID", userId)) as string;
            switch (role)
            {
                case "Admin": return UserRole.Admin;
                case "HospitalManager": return UserRole.HospitalManager;
                case "PharmacyManager": return UserRole.PharmacyManager;
                case "Doctor": return UserRole.Doctor;
                case "Patient": return UserRole.Patient;
                default: return UserRole.Unknown;
            }
        }

        /// <summary>Registers a new patient and returns the generated user id.</summary>
        public int RegisterPatient(AppUser user)
        {
            if (!Validation.IsValidEmail(user.Email))
                throw new ArgumentException("Invalid email address.");
            if (user.Gender.HasValue && !Validation.IsValidGender(user.Gender.Value))
                throw new ArgumentException("Invalid gender.");

            var idOut = Database.Out("NewUserID", SqlDbType.Int);
            _db.ExecuteProcedure("dbo.usp_RegisterPatient",
                Database.P("Email", user.Email),
                Database.P("Password", user.Password),
                Database.P("Age", user.Age),
                Database.P("Gender", user.Gender),
                Database.P("FirstName", user.FirstName),
                Database.P("LastName", user.LastName),
                idOut);
            return (int)idOut.Value;
        }
    }

    /// <summary>Doctor search and lifecycle (hire/fire) plus feedback.</summary>
    public class DoctorRepository
    {
        private readonly Database _db;
        public DoctorRepository(Database db) { _db = db ?? throw new ArgumentNullException(nameof(db)); }

        public List<DoctorInfo> Search(string name = null, int? departmentId = null, int? hospitalId = null)
        {
            var table = _db.QueryProcedure("dbo.usp_SearchDoctors",
                Database.P("Name", name),
                Database.P("DepartmentID", departmentId),
                Database.P("HospitalID", hospitalId));

            var result = new List<DoctorInfo>();
            foreach (DataRow r in table.Rows)
            {
                result.Add(new DoctorInfo
                {
                    DoctorID = (int)r["DoctorID"],
                    FirstName = r["firstName"] as string,
                    LastName = r["LastName"] as string,
                    Age = r["Age"] == DBNull.Value ? (int?)null : (int)r["Age"],
                    DepartmentName = r["DepartmentName"] as string,
                    HospitalName = r["HospitalName"] as string,
                    IsAvailable = Validation.FromFlag(r["ISAvailable"] as string)
                });
            }
            return result;
        }

        public int Hire(AppUser user, int departmentId, int hospitalId)
        {
            var idOut = Database.Out("NewDoctorID", SqlDbType.Int);
            _db.ExecuteProcedure("dbo.usp_AddDoctor",
                Database.P("Email", user.Email),
                Database.P("Password", user.Password),
                Database.P("Age", user.Age),
                Database.P("Gender", user.Gender),
                Database.P("FirstName", user.FirstName),
                Database.P("LastName", user.LastName),
                Database.P("DepartmentID", departmentId),
                Database.P("HospitalID", hospitalId),
                idOut);
            return (int)idOut.Value;
        }

        public void Fire(int doctorId)
            => _db.ExecuteProcedure("dbo.usp_FireDoctor", Database.P("DoctorID", doctorId));

        public DataTable GetFeedback(int doctorId)
            => _db.QueryProcedure("dbo.usp_GetDoctorFeedback", Database.P("DoctorID", doctorId));
    }

    /// <summary>Hospital appointment booking and queries.</summary>
    public class AppointmentRepository
    {
        private readonly Database _db;
        public AppointmentRepository(Database db) { _db = db ?? throw new ArgumentNullException(nameof(db)); }

        public int Book(DateTime when, int doctorId, int patientId)
        {
            var idOut = Database.Out("NewAppointmentID", SqlDbType.Int);
            _db.ExecuteProcedure("dbo.usp_BookHospitalAppointment",
                Database.P("DateAndTime", when),
                Database.P("DoctorID", doctorId),
                Database.P("PatientID", patientId),
                idOut);
            return (int)idOut.Value;
        }

        public void Cancel(int appointmentId)
            => _db.ExecuteProcedure("dbo.usp_CancelHospitalAppointment",
                Database.P("HospitalAppointmentID", appointmentId));

        public List<Appointment> GetUpcomingForPatient(int patientId)
        {
            var table = _db.QueryProcedure("dbo.usp_GetUpcomingAppointmentsForPatient",
                Database.P("PatientID", patientId));
            var result = new List<Appointment>();
            foreach (DataRow r in table.Rows)
            {
                result.Add(new Appointment
                {
                    AppointmentID = (int)r["HospitalAppointmentID"],
                    DateAndTime = (DateTime)r["DateAndTime"],
                    DoctorID = (int)r["DoctorID"],
                    DoctorName = r["DoctorName"] as string,
                    HospitalName = r["HospitalName"] as string,
                    PatientID = patientId
                });
            }
            return result;
        }
    }

    /// <summary>Pharmacy inventory management.</summary>
    public class PharmacyRepository
    {
        private readonly Database _db;
        public PharmacyRepository(Database db) { _db = db ?? throw new ArgumentNullException(nameof(db)); }

        public void SetStock(int medicineId, int pharmacyId, int quantity)
        {
            if (quantity < 0) throw new ArgumentOutOfRangeException(nameof(quantity));
            _db.ExecuteProcedure("dbo.usp_UpsertStoreMedicine",
                Database.P("MedicineID", medicineId),
                Database.P("PharmacyID", pharmacyId),
                Database.P("Quantity", quantity));
        }

        public List<MedicineStock> GetInventory(int pharmacyId)
        {
            var table = _db.QueryProcedure("dbo.usp_GetPharmacyInventory",
                Database.P("PharmacyID", pharmacyId));
            var result = new List<MedicineStock>();
            foreach (DataRow r in table.Rows)
            {
                result.Add(new MedicineStock
                {
                    MedicineID = (int)r["MedicineID"],
                    MedicineName = r["MedicineName"] as string,
                    ActiveIngredient = r["Active_Ingredinet"] as string,
                    Dose = r["Dose"] as string,
                    Quantity = (int)r["Quantity"]
                });
            }
            return result;
        }
    }
}
