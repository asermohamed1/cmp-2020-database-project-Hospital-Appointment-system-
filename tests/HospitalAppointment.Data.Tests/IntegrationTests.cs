using System;
using System.Linq;
using HospitalAppointment.Data;
using HospitalAppointment.Data.Models;
using HospitalAppointment.Data.Repositories;
using Microsoft.Data.SqlClient;
using Xunit;

namespace HospitalAppointment.Data.Tests
{
    /// <summary>
    /// End-to-end tests that exercise the schema, stored procedures and
    /// repositories against a real SQL Server instance. They skip automatically
    /// when no test database is configured (see <see cref="DatabaseFixture"/>).
    /// </summary>
    [Collection("Database collection")]
    public class IntegrationTests
    {
        private readonly DatabaseFixture _fx;
        public IntegrationTests(DatabaseFixture fx) { _fx = fx; }

        private Database Db => _fx.Db;
        private void RequireDb() => Skip.IfNot(_fx.Available, _fx.SkipReason);

        /* ----------------------------- Auth / roles --------------------------- */

        [SkippableFact]
        public void Login_WithValidCredentials_ReturnsUser()
        {
            RequireDb();
            var repo = new UserRepository(Db);
            var user = repo.Login("patient.ali@example", "pat123");
            Assert.NotNull(user);
            Assert.Equal(5001, user.UserID);
        }

        [SkippableFact]
        public void Login_WithWrongPassword_ReturnsNull()
        {
            RequireDb();
            var repo = new UserRepository(Db);
            Assert.Null(repo.Login("patient.ali@example", "wrong"));
        }

        [SkippableTheory]
        [InlineData(1, UserRole.Admin)]
        [InlineData(10, UserRole.HospitalManager)]
        [InlineData(20, UserRole.PharmacyManager)]
        [InlineData(100, UserRole.Doctor)]
        [InlineData(5001, UserRole.Patient)]
        public void GetRole_ReturnsCorrectRole(int userId, UserRole expected)
        {
            RequireDb();
            var repo = new UserRepository(Db);
            Assert.Equal(expected, repo.GetRole(userId));
        }

        /* ------------------------------ Registration -------------------------- */

        [SkippableFact]
        public void RegisterPatient_CreatesUserAndPatientRows()
        {
            RequireDb();
            var repo = new UserRepository(Db);
            var newId = repo.RegisterPatient(new AppUser
            {
                Email = $"new.patient.{Guid.NewGuid():N}@example.com",
                Password = "secret", Age = 27, Gender = 'F',
                FirstName = "Test", LastName = "Patient"
            });

            Assert.True(newId > 5000);
            Assert.Equal(UserRole.Patient, repo.GetRole(newId));
        }

        [SkippableFact]
        public void RegisterPatient_RejectsInvalidEmail()
        {
            RequireDb();
            var repo = new UserRepository(Db);
            Assert.Throws<ArgumentException>(() =>
                repo.RegisterPatient(new AppUser { Email = "not-an-email", FirstName = "A", LastName = "B" }));
        }

        /* ------------------------------ Appointments -------------------------- */

        [SkippableFact]
        public void BookAndCancel_Appointment_Works()
        {
            RequireDb();
            var repo = new AppointmentRepository(Db);
            int id = repo.Book(DateTime.Today.AddDays(10).AddHours(11), 100, 5002);
            Assert.True(id > 1000000);

            var upcoming = repo.GetUpcomingForPatient(5002);
            Assert.Contains(upcoming, a => a.AppointmentID == id);

            repo.Cancel(id);
            var after = repo.GetUpcomingForPatient(5002);
            Assert.DoesNotContain(after, a => a.AppointmentID == id);
        }

        [SkippableFact]
        public void GetUpcoming_ExcludesPastAppointments()
        {
            RequireDb();
            var repo = new AppointmentRepository(Db);
            // Seed row 1000004 is in the past for patient 5004.
            Assert.DoesNotContain(repo.GetUpcomingForPatient(5004), a => a.AppointmentID == 1000004);
        }

        /* -------------------------------- Doctors ----------------------------- */

        [SkippableFact]
        public void SearchDoctors_ByDepartment_FiltersResults()
        {
            RequireDb();
            var repo = new DoctorRepository(Db);
            var cardiologists = repo.Search(departmentId: 1);
            Assert.NotEmpty(cardiologists);
            Assert.All(cardiologists, d => Assert.Equal("Cardiology", d.DepartmentName));
        }

        [SkippableFact]
        public void HireAndFire_Doctor_Works()
        {
            RequireDb();
            var repo = new DoctorRepository(Db);
            int docId = repo.Hire(new AppUser
            {
                Email = $"dr.{Guid.NewGuid():N}@example.com",
                Password = "doc", Age = 39, Gender = 'M',
                FirstName = "Hired", LastName = "Doctor"
            }, departmentId: 1, hospitalId: 500);

            Assert.Equal(UserRole.Doctor, new UserRepository(Db).GetRole(docId));
            repo.Fire(docId);
            Assert.Equal(UserRole.Unknown, new UserRepository(Db).GetRole(docId));
        }

        /* ------------------------------- Pharmacy ----------------------------- */

        [SkippableFact]
        public void Pharmacy_SetStock_UpsertsAndReads()
        {
            RequireDb();
            var repo = new PharmacyRepository(Db);
            repo.SetStock(medicineId: 3, pharmacyId: 601, quantity: 999); // new row for pharmacy 601
            var inv = repo.GetInventory(601);
            var row = inv.Single(m => m.MedicineID == 3);
            Assert.Equal(999, row.Quantity);

            repo.SetStock(3, 601, 5); // update existing
            Assert.Equal(5, repo.GetInventory(601).Single(m => m.MedicineID == 3).Quantity);
        }

        /* ---------------------------- Constraint checks ----------------------- */

        [SkippableFact]
        public void DuplicateEmail_IsRejectedByUniqueConstraint()
        {
            RequireDb();
            var ex = Assert.ThrowsAny<SqlException>(() =>
                Db.ExecuteNonQuery(
                    "INSERT INTO dbo.sysUser (UserID, Email, userPassword, firstName, LastName) " +
                    "VALUES (@id, @email, 'x', 'Dup', 'User')",
                    Database.P("id", 991001),
                    Database.P("email", "patient.ali@example"))); // already seeded
            Assert.Contains("UNIQUE", ex.Message, StringComparison.OrdinalIgnoreCase);
        }

        [SkippableFact]
        public void InvalidGender_IsRejectedByCheckConstraint()
        {
            RequireDb();
            Assert.ThrowsAny<SqlException>(() =>
                Db.ExecuteNonQuery(
                    "INSERT INTO dbo.sysUser (UserID, Email, userPassword, Age, Gender, firstName, LastName) " +
                    "VALUES (992001, 'badgender@example.com', 'x', 30, 'Z', 'Bad', 'Gender')"));
        }

        [SkippableFact]
        public void Appointment_WithMissingDoctor_IsRejectedByForeignKey()
        {
            RequireDb();
            Assert.ThrowsAny<SqlException>(() =>
                Db.ExecuteNonQuery(
                    "INSERT INTO dbo.HospitalAppointment (HospitalAppointmentID, DateAndTime, DoctorID, PatientID) " +
                    "VALUES (1099001, SYSDATETIME(), 8888888, 5001)")); // doctor 8888888 does not exist
        }
    }
}
