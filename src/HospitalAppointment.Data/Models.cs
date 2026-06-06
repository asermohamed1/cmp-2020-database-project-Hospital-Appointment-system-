using System;

namespace HospitalAppointment.Data.Models
{
    public enum UserRole { Unknown = 0, Patient, Doctor, HospitalManager, PharmacyManager, Admin }

    public class AppUser
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Age { get; set; }
        public char? Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class DoctorInfo
    {
        public int DoctorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string DepartmentName { get; set; }
        public string HospitalName { get; set; }
        public bool IsAvailable { get; set; }
    }

    public class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime DateAndTime { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public string DoctorName { get; set; }
        public string HospitalName { get; set; }
    }

    public class MedicineStock
    {
        public int MedicineID { get; set; }
        public string MedicineName { get; set; }
        public string ActiveIngredient { get; set; }
        public string Dose { get; set; }
        public int Quantity { get; set; }
    }
}
