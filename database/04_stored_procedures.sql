/* ============================================================================
   Hospital Appointment System - Stored procedures
   ----------------------------------------------------------------------------
   A parameterized data-access API. Every procedure takes typed parameters,
   which eliminates the SQL-injection risk of the legacy string-concatenated
   queries and centralizes ID generation in the database (atomic, no MAX()+1
   race conditions).
   ========================================================================== */

SET NOCOUNT ON;
GO

/* --------------------------------- Auth ---------------------------------- */
IF OBJECT_ID('dbo.usp_LoginUser','P') IS NOT NULL DROP PROCEDURE dbo.usp_LoginUser;
GO
CREATE PROCEDURE dbo.usp_LoginUser
    @Email NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT UserID, userPassword
    FROM   dbo.sysUser
    WHERE  Email = @Email;
END
GO

-- Returns the role of a user as a single string, or NULL if the user has none.
IF OBJECT_ID('dbo.usp_GetUserRole','P') IS NOT NULL DROP PROCEDURE dbo.usp_GetUserRole;
GO
CREATE PROCEDURE dbo.usp_GetUserRole
    @UserID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT CASE
             WHEN EXISTS (SELECT 1 FROM dbo.sysAdmin        WHERE Adminid   = @UserID) THEN 'Admin'
             WHEN EXISTS (SELECT 1 FROM dbo.HospitalManager WHERE ManagerID = @UserID) THEN 'HospitalManager'
             WHEN EXISTS (SELECT 1 FROM dbo.PharmacyManager WHERE ManagerID = @UserID) THEN 'PharmacyManager'
             WHEN EXISTS (SELECT 1 FROM dbo.Doctor          WHERE DoctorID  = @UserID) THEN 'Doctor'
             WHEN EXISTS (SELECT 1 FROM dbo.patient         WHERE patientid = @UserID) THEN 'Patient'
             ELSE NULL
           END AS Role;
END
GO

/* ------------------------------ Registration ----------------------------- */
IF OBJECT_ID('dbo.usp_RegisterPatient','P') IS NOT NULL DROP PROCEDURE dbo.usp_RegisterPatient;
GO
CREATE PROCEDURE dbo.usp_RegisterPatient
    @Email     NVARCHAR(255),
    @Password  NVARCHAR(255),
    @Age       INT,
    @Gender    CHAR(1),
    @FirstName NVARCHAR(100),
    @LastName  NVARCHAR(100),
    @NewUserID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRAN;
        SELECT @NewUserID = ISNULL(MAX(UserID), 5000) + 1 FROM dbo.sysUser WITH (UPDLOCK, HOLDLOCK);
        INSERT INTO dbo.sysUser (UserID, Email, userPassword, Age, Gender, firstName, LastName)
        VALUES (@NewUserID, @Email, @Password, @Age, @Gender, @FirstName, @LastName);
        INSERT INTO dbo.patient (patientid) VALUES (@NewUserID);
    COMMIT;
END
GO

-- Hires a doctor under a hospital/department; returns the new user id.
IF OBJECT_ID('dbo.usp_AddDoctor','P') IS NOT NULL DROP PROCEDURE dbo.usp_AddDoctor;
GO
CREATE PROCEDURE dbo.usp_AddDoctor
    @Email        NVARCHAR(255),
    @Password     NVARCHAR(255),
    @Age          INT,
    @Gender       CHAR(1),
    @FirstName    NVARCHAR(100),
    @LastName     NVARCHAR(100),
    @DepartmentID INT,
    @HospitalID   INT,
    @NewDoctorID  INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRAN;
        SELECT @NewDoctorID = ISNULL(MAX(UserID), 0) + 1 FROM dbo.sysUser WITH (UPDLOCK, HOLDLOCK);
        INSERT INTO dbo.sysUser (UserID, Email, userPassword, Age, Gender, firstName, LastName)
        VALUES (@NewDoctorID, @Email, @Password, @Age, @Gender, @FirstName, @LastName);
        INSERT INTO dbo.Doctor (DoctorID, ISAvailable, DepartmentID, HospitalID)
        VALUES (@NewDoctorID, 'F', @DepartmentID, @HospitalID);
    COMMIT;
END
GO

-- Fires a doctor (cascade removes the sysUser/Doctor rows).
IF OBJECT_ID('dbo.usp_FireDoctor','P') IS NOT NULL DROP PROCEDURE dbo.usp_FireDoctor;
GO
CREATE PROCEDURE dbo.usp_FireDoctor
    @DoctorID INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.sysUser WHERE UserID = @DoctorID;
END
GO

/* ------------------------------ Appointments ----------------------------- */
IF OBJECT_ID('dbo.usp_BookHospitalAppointment','P') IS NOT NULL
    DROP PROCEDURE dbo.usp_BookHospitalAppointment;
GO
CREATE PROCEDURE dbo.usp_BookHospitalAppointment
    @DateAndTime DATETIME2(0),
    @DoctorID    INT,
    @PatientID   INT,
    @NewAppointmentID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRAN;
        SELECT @NewAppointmentID = ISNULL(MAX(HospitalAppointmentID), 1000000) + 1
        FROM dbo.HospitalAppointment WITH (UPDLOCK, HOLDLOCK);
        INSERT INTO dbo.HospitalAppointment (HospitalAppointmentID, DateAndTime, DoctorID, PatientID)
        VALUES (@NewAppointmentID, @DateAndTime, @DoctorID, @PatientID);
    COMMIT;
END
GO

IF OBJECT_ID('dbo.usp_CancelHospitalAppointment','P') IS NOT NULL
    DROP PROCEDURE dbo.usp_CancelHospitalAppointment;
GO
CREATE PROCEDURE dbo.usp_CancelHospitalAppointment
    @HospitalAppointmentID INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.HospitalAppointment WHERE HospitalAppointmentID = @HospitalAppointmentID;
END
GO

IF OBJECT_ID('dbo.usp_GetUpcomingAppointmentsForPatient','P') IS NOT NULL
    DROP PROCEDURE dbo.usp_GetUpcomingAppointmentsForPatient;
GO
CREATE PROCEDURE dbo.usp_GetUpcomingAppointmentsForPatient
    @PatientID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT HospitalAppointmentID, DateAndTime, DoctorID, DoctorName, HospitalName
    FROM   dbo.vw_UpcomingHospitalAppointments
    WHERE  PatientID = @PatientID
    ORDER BY DateAndTime;
END
GO

IF OBJECT_ID('dbo.usp_GetDoctorAppointments','P') IS NOT NULL
    DROP PROCEDURE dbo.usp_GetDoctorAppointments;
GO
CREATE PROCEDURE dbo.usp_GetDoctorAppointments
    @DoctorID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT ha.DateAndTime, u.firstName, u.LastName
    FROM   dbo.HospitalAppointment ha
           JOIN dbo.sysUser u ON u.UserID = ha.PatientID
    WHERE  ha.DoctorID = @DoctorID
    ORDER BY ha.DateAndTime;
END
GO

/* ------------------------------- Doctor search --------------------------- */
IF OBJECT_ID('dbo.usp_SearchDoctors','P') IS NOT NULL DROP PROCEDURE dbo.usp_SearchDoctors;
GO
CREATE PROCEDURE dbo.usp_SearchDoctors
    @Name         NVARCHAR(200) = NULL,
    @DepartmentID INT = NULL,
    @HospitalID   INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT DoctorID, firstName, LastName, Age, DepartmentName, HospitalName, ISAvailable
    FROM   dbo.vw_DoctorDirectory
    WHERE  (@Name IS NULL OR firstName LIKE '%' + @Name + '%' OR LastName LIKE '%' + @Name + '%')
      AND  (@DepartmentID IS NULL OR DepartmentID = @DepartmentID)
      AND  (@HospitalID   IS NULL OR HospitalID   = @HospitalID)
    ORDER BY LastName, firstName;
END
GO

/* ------------------------------ Prescriptions ---------------------------- */
IF OBJECT_ID('dbo.usp_AddPrescription','P') IS NOT NULL DROP PROCEDURE dbo.usp_AddPrescription;
GO
CREATE PROCEDURE dbo.usp_AddPrescription
    @DateAndTime        DATETIME2(0),
    @DiseaseName        NVARCHAR(150),
    @PatientID          INT,
    @DiseaseDescription NVARCHAR(500),
    @DoctorID           INT,
    @NewPrescriptionID  INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRAN;
        SELECT @NewPrescriptionID = ISNULL(MAX(PrescriptionID), 0) + 1
        FROM dbo.Prescription WITH (UPDLOCK, HOLDLOCK);
        INSERT INTO dbo.MedicalHistory (PatientID, DiseaseDescription, AtYear, IsCured)
        VALUES (@PatientID, @DiseaseDescription, YEAR(@DateAndTime), 'F');
        INSERT INTO dbo.Prescription (PrescriptionID, DateAndTime, DiseaseName, PatientID, DiseaseDescription, DoctorID)
        VALUES (@NewPrescriptionID, @DateAndTime, @DiseaseName, @PatientID, @DiseaseDescription, @DoctorID);
    COMMIT;
END
GO

IF OBJECT_ID('dbo.usp_AddMedicineToPrescription','P') IS NOT NULL
    DROP PROCEDURE dbo.usp_AddMedicineToPrescription;
GO
CREATE PROCEDURE dbo.usp_AddMedicineToPrescription
    @MedicineID     INT,
    @PrescriptionID INT,
    @Notes          NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.MedicinePrescription (MedicineID, PrescriptionID, Notes)
    VALUES (@MedicineID, @PrescriptionID, @Notes);
END
GO

IF OBJECT_ID('dbo.usp_GetPatientPrescriptions','P') IS NOT NULL
    DROP PROCEDURE dbo.usp_GetPatientPrescriptions;
GO
CREATE PROCEDURE dbo.usp_GetPatientPrescriptions
    @PatientID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT DateAndTime, DiseaseName, DiseaseDescription
    FROM   dbo.Prescription
    WHERE  PatientID = @PatientID
    ORDER BY DateAndTime DESC;
END
GO

/* ------------------------------- Feedback -------------------------------- */
IF OBJECT_ID('dbo.usp_AddFeedback','P') IS NOT NULL DROP PROCEDURE dbo.usp_AddFeedback;
GO
CREATE PROCEDURE dbo.usp_AddFeedback
    @DoctorID    INT,
    @PatientID   INT,
    @TheFeedback NVARCHAR(1000)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @NewID INT;
    BEGIN TRAN;
        SELECT @NewID = ISNULL(MAX(FeedbackID), 200000) + 1 FROM dbo.Feedback WITH (UPDLOCK, HOLDLOCK);
        INSERT INTO dbo.Feedback (FeedbackID, DoctorID, PatientID, theFeedback)
        VALUES (@NewID, @DoctorID, @PatientID, @TheFeedback);
    COMMIT;
END
GO

IF OBJECT_ID('dbo.usp_GetDoctorFeedback','P') IS NOT NULL DROP PROCEDURE dbo.usp_GetDoctorFeedback;
GO
CREATE PROCEDURE dbo.usp_GetDoctorFeedback
    @DoctorID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT u.firstName, f.theFeedback
    FROM   dbo.Feedback f
           JOIN dbo.sysUser u ON u.UserID = f.PatientID
    WHERE  f.DoctorID = @DoctorID;
END
GO

/* ----------------------------- Pharmacy stock ---------------------------- */
IF OBJECT_ID('dbo.usp_UpsertStoreMedicine','P') IS NOT NULL
    DROP PROCEDURE dbo.usp_UpsertStoreMedicine;
GO
CREATE PROCEDURE dbo.usp_UpsertStoreMedicine
    @MedicineID INT,
    @PharmacyID INT,
    @Quantity   INT
AS
BEGIN
    SET NOCOUNT ON;
    MERGE dbo.StoreMedicine AS tgt
    USING (SELECT @MedicineID AS MedicineID, @PharmacyID AS PharmacyID) AS src
        ON tgt.MedicineID = src.MedicineID AND tgt.PharmacyID = src.PharmacyID
    WHEN MATCHED THEN UPDATE SET Quantity = @Quantity
    WHEN NOT MATCHED THEN
        INSERT (MedicineID, PharmacyID, Quantity) VALUES (@MedicineID, @PharmacyID, @Quantity);
END
GO

IF OBJECT_ID('dbo.usp_GetPharmacyInventory','P') IS NOT NULL
    DROP PROCEDURE dbo.usp_GetPharmacyInventory;
GO
CREATE PROCEDURE dbo.usp_GetPharmacyInventory
    @PharmacyID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT MedicineID, MedicineName, Active_Ingredinet, Dose, Quantity
    FROM   dbo.vw_PharmacyInventory
    WHERE  PharmacyID = @PharmacyID
    ORDER BY MedicineName;
END
GO

/* -------------------------------- Billing -------------------------------- */
IF OBJECT_ID('dbo.usp_AddBill','P') IS NOT NULL DROP PROCEDURE dbo.usp_AddBill;
GO
CREATE PROCEDURE dbo.usp_AddBill
    @Price       DECIMAL(10,2),
    @DateandTime DATETIME2(0),
    @PlaceID     INT,
    @PatientID   INT,
    @IsPaid      CHAR(1),
    @NewBillID   INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRAN;
        SELECT @NewBillID = ISNULL(MAX(BillID), 120000) + 1 FROM dbo.Bill WITH (UPDLOCK, HOLDLOCK);
        INSERT INTO dbo.Bill (BillID, Price, DateandTime, PlaceID, PatientID, IsPaid)
        VALUES (@NewBillID, @Price, @DateandTime, @PlaceID, @PatientID, @IsPaid);
    COMMIT;
END
GO

/* ---------------------------- Medical history ---------------------------- */
IF OBJECT_ID('dbo.usp_GetMedicalHistory','P') IS NOT NULL
    DROP PROCEDURE dbo.usp_GetMedicalHistory;
GO
CREATE PROCEDURE dbo.usp_GetMedicalHistory
    @PatientID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT DiseaseDescription, AtYear, IsCured
    FROM   dbo.MedicalHistory
    WHERE  PatientID = @PatientID
    ORDER BY AtYear DESC;
END
GO

/* ----------------------------- Activity logs ----------------------------- */
IF OBJECT_ID('dbo.usp_AddActivityLog','P') IS NOT NULL DROP PROCEDURE dbo.usp_AddActivityLog;
GO
CREATE PROCEDURE dbo.usp_AddActivityLog
    @UserID       INT,
    @DateAndTime  DATETIME2(0),
    @ActivityType NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.ActivityLogs (UserID, DateAndTime, ActivityType)
    VALUES (@UserID, @DateAndTime, @ActivityType);
END
GO

PRINT 'Stored procedures created successfully.';
GO
