/* ============================================================================
   Hospital Appointment System - Relational Schema (SQL Server)
   ----------------------------------------------------------------------------
   Design goals
     * Proper normalization with an ISA (table-per-type) hierarchy:
         - sysUser  -> patient / Doctor / sysAdmin / HospitalManager / PharmacyManager
         - Place    -> Hospital / Pharmacy / Clinic
     * Referential integrity: every relationship is a real FOREIGN KEY.
     * Data integrity: NOT NULL, UNIQUE, and CHECK constraints; correct data
       types (DATETIME2 / TIME / DECIMAL instead of free-text).
     * Performance: indexes on every foreign key and on the columns the
       application filters/joins on most (email, appointment dates, ...).

   Compatibility note
     The legacy WinForms app issues column-less "INSERT INTO t VALUES(...)"
     statements, so the COLUMN ORDER below is deliberately aligned with those
     statements and must not be reordered. Tables whose IDs the app supplies
     itself (via SELECT MAX(id)+1) keep plain INT primary keys; tables where the
     app does NOT supply an id (ActivityLogs, MedicalHistory) use an IDENTITY
     surrogate key, which the column-less INSERT transparently skips.
   ========================================================================== */

SET NOCOUNT ON;
SET XACT_ABORT ON;
GO

/* ---- Drop in reverse-dependency order (idempotent re-runs) --------------- */
IF OBJECT_ID('dbo.ActivityLogs','U')        IS NOT NULL DROP TABLE dbo.ActivityLogs;
IF OBJECT_ID('dbo.Bill','U')                IS NOT NULL DROP TABLE dbo.Bill;
IF OBJECT_ID('dbo.Feedback','U')            IS NOT NULL DROP TABLE dbo.Feedback;
IF OBJECT_ID('dbo.MedicalHistory','U')      IS NOT NULL DROP TABLE dbo.MedicalHistory;
IF OBJECT_ID('dbo.MedicinePrescription','U')IS NOT NULL DROP TABLE dbo.MedicinePrescription;
IF OBJECT_ID('dbo.Prescription','U')        IS NOT NULL DROP TABLE dbo.Prescription;
IF OBJECT_ID('dbo.ClinicAppointment','U')   IS NOT NULL DROP TABLE dbo.ClinicAppointment;
IF OBJECT_ID('dbo.HospitalAppointment','U') IS NOT NULL DROP TABLE dbo.HospitalAppointment;
IF OBJECT_ID('dbo.StoreMedicine','U')       IS NOT NULL DROP TABLE dbo.StoreMedicine;
IF OBJECT_ID('dbo.Medicine','U')            IS NOT NULL DROP TABLE dbo.Medicine;
IF OBJECT_ID('dbo.HospitalDepartment','U')  IS NOT NULL DROP TABLE dbo.HospitalDepartment;
IF OBJECT_ID('dbo.Clinic','U')              IS NOT NULL DROP TABLE dbo.Clinic;
IF OBJECT_ID('dbo.PharmacyManager','U')     IS NOT NULL DROP TABLE dbo.PharmacyManager;
IF OBJECT_ID('dbo.HospitalManager','U')     IS NOT NULL DROP TABLE dbo.HospitalManager;
IF OBJECT_ID('dbo.sysAdmin','U')            IS NOT NULL DROP TABLE dbo.sysAdmin;
IF OBJECT_ID('dbo.Doctor','U')              IS NOT NULL DROP TABLE dbo.Doctor;
IF OBJECT_ID('dbo.patient','U')             IS NOT NULL DROP TABLE dbo.patient;
IF OBJECT_ID('dbo.sysUser','U')             IS NOT NULL DROP TABLE dbo.sysUser;
IF OBJECT_ID('dbo.Pharmacy','U')            IS NOT NULL DROP TABLE dbo.Pharmacy;
IF OBJECT_ID('dbo.Hospital','U')            IS NOT NULL DROP TABLE dbo.Hospital;
IF OBJECT_ID('dbo.Place','U')               IS NOT NULL DROP TABLE dbo.Place;
IF OBJECT_ID('dbo.Department','U')          IS NOT NULL DROP TABLE dbo.Department;
GO

/* ========================= Reference / lookup ============================= */

CREATE TABLE dbo.Department (
    DepartmentID   INT          NOT NULL,
    DepartmentName NVARCHAR(100) NOT NULL,
    CONSTRAINT PK_Department PRIMARY KEY (DepartmentID),
    CONSTRAINT UQ_Department_Name UNIQUE (DepartmentName)
);
GO

/* ============================ Place hierarchy ============================= */

-- Base supertype for Hospital / Pharmacy / Clinic.
CREATE TABLE dbo.Place (
    PlaceID       INT           NOT NULL,
    PlaceName     NVARCHAR(150) NOT NULL,
    Email         NVARCHAR(255) NULL,
    PhoneNumber   VARCHAR(20)   NULL,
    StartingTime  TIME(0)       NULL,
    EndingTime    TIME(0)       NULL,
    IsAvailable   CHAR(1)       NOT NULL CONSTRAINT DF_Place_IsAvailable DEFAULT 'T',
    PlaceLocation NVARCHAR(255) NULL,
    OpenDays      VARCHAR(50)   NULL,
    CONSTRAINT PK_Place PRIMARY KEY (PlaceID),
    CONSTRAINT CK_Place_IsAvailable CHECK (IsAvailable IN ('T','F'))
);
GO

CREATE TABLE dbo.Hospital (
    HospitalID INT NOT NULL,
    CONSTRAINT PK_Hospital PRIMARY KEY (HospitalID),
    CONSTRAINT FK_Hospital_Place FOREIGN KEY (HospitalID)
        REFERENCES dbo.Place (PlaceID) ON DELETE CASCADE
);
GO

CREATE TABLE dbo.Pharmacy (
    PharmacyID INT NOT NULL,
    CONSTRAINT PK_Pharmacy PRIMARY KEY (PharmacyID),
    CONSTRAINT FK_Pharmacy_Place FOREIGN KEY (PharmacyID)
        REFERENCES dbo.Place (PlaceID) ON DELETE CASCADE
);
GO

/* ============================= User hierarchy ============================= */

-- Base supertype for every account in the system.
CREATE TABLE dbo.sysUser (
    UserID       INT           NOT NULL,
    Email        NVARCHAR(255) NOT NULL,
    userPassword NVARCHAR(255) NOT NULL,
    Age          INT           NULL,
    Gender       CHAR(1)       NULL,
    firstName    NVARCHAR(100) NOT NULL,
    LastName     NVARCHAR(100) NOT NULL,
    CONSTRAINT PK_sysUser PRIMARY KEY (UserID),
    CONSTRAINT UQ_sysUser_Email UNIQUE (Email),
    CONSTRAINT CK_sysUser_Age CHECK (Age IS NULL OR (Age >= 0 AND Age < 200)),
    CONSTRAINT CK_sysUser_Gender CHECK (Gender IS NULL OR Gender IN ('M','F','O'))
);
GO
CREATE INDEX IX_sysUser_Name ON dbo.sysUser (firstName, LastName);
GO

CREATE TABLE dbo.patient (
    patientid INT NOT NULL,
    CONSTRAINT PK_patient PRIMARY KEY (patientid),
    CONSTRAINT FK_patient_user FOREIGN KEY (patientid)
        REFERENCES dbo.sysUser (UserID) ON DELETE CASCADE
);
GO

CREATE TABLE dbo.Doctor (
    DoctorID     INT     NOT NULL,
    ISAvailable  CHAR(1) NOT NULL CONSTRAINT DF_Doctor_ISAvailable DEFAULT 'F',
    DepartmentID INT     NULL,
    HospitalID   INT     NULL,
    CONSTRAINT PK_Doctor PRIMARY KEY (DoctorID),
    CONSTRAINT FK_Doctor_user FOREIGN KEY (DoctorID)
        REFERENCES dbo.sysUser (UserID) ON DELETE CASCADE,
    CONSTRAINT FK_Doctor_Department FOREIGN KEY (DepartmentID)
        REFERENCES dbo.Department (DepartmentID),
    CONSTRAINT FK_Doctor_Hospital FOREIGN KEY (HospitalID)
        REFERENCES dbo.Hospital (HospitalID),
    CONSTRAINT CK_Doctor_ISAvailable CHECK (ISAvailable IN ('T','F'))
);
GO
CREATE INDEX IX_Doctor_Hospital    ON dbo.Doctor (HospitalID);
CREATE INDEX IX_Doctor_Department  ON dbo.Doctor (DepartmentID);
GO

CREATE TABLE dbo.sysAdmin (
    Adminid INT NOT NULL,
    CONSTRAINT PK_sysAdmin PRIMARY KEY (Adminid),
    CONSTRAINT FK_sysAdmin_user FOREIGN KEY (Adminid)
        REFERENCES dbo.sysUser (UserID) ON DELETE CASCADE
);
GO

CREATE TABLE dbo.HospitalManager (
    ManagerID  INT NOT NULL,
    HospitalID INT NULL,
    CONSTRAINT PK_HospitalManager PRIMARY KEY (ManagerID),
    CONSTRAINT FK_HManager_user FOREIGN KEY (ManagerID)
        REFERENCES dbo.sysUser (UserID) ON DELETE CASCADE,
    CONSTRAINT FK_HManager_Hospital FOREIGN KEY (HospitalID)
        REFERENCES dbo.Hospital (HospitalID)
);
GO

CREATE TABLE dbo.PharmacyManager (
    ManagerID  INT NOT NULL,
    pharmacyID INT NULL,
    CONSTRAINT PK_PharmacyManager PRIMARY KEY (ManagerID),
    CONSTRAINT FK_PManager_user FOREIGN KEY (ManagerID)
        REFERENCES dbo.sysUser (UserID) ON DELETE CASCADE,
    CONSTRAINT FK_PManager_Pharmacy FOREIGN KEY (pharmacyID)
        REFERENCES dbo.Pharmacy (PharmacyID)
);
GO

-- A Clinic is a Place run by a single Doctor.
CREATE TABLE dbo.Clinic (
    ClinicID INT NOT NULL,
    DoctorID INT NULL,
    CONSTRAINT PK_Clinic PRIMARY KEY (ClinicID),
    CONSTRAINT FK_Clinic_Place FOREIGN KEY (ClinicID)
        REFERENCES dbo.Place (PlaceID) ON DELETE CASCADE,
    CONSTRAINT FK_Clinic_Doctor FOREIGN KEY (DoctorID)
        REFERENCES dbo.Doctor (DoctorID)
);
GO

/* ===================== Hospital <-> Department (M:N) ====================== */

CREATE TABLE dbo.HospitalDepartment (
    HospitalID   INT NOT NULL,
    DepartmentID INT NOT NULL,
    CONSTRAINT PK_HospitalDepartment PRIMARY KEY (HospitalID, DepartmentID),
    CONSTRAINT FK_HD_Hospital FOREIGN KEY (HospitalID)
        REFERENCES dbo.Hospital (HospitalID) ON DELETE CASCADE,
    CONSTRAINT FK_HD_Department FOREIGN KEY (DepartmentID)
        REFERENCES dbo.Department (DepartmentID) ON DELETE CASCADE
);
GO
CREATE INDEX IX_HD_Department ON dbo.HospitalDepartment (DepartmentID);
GO

/* ============================ Pharmacy / Medicine ========================= */

CREATE TABLE dbo.Medicine (
    MedicineID        INT           NOT NULL,
    MedicineName      NVARCHAR(150) NOT NULL,
    Active_Ingredinet NVARCHAR(150) NULL,   -- (sic) name kept to match application queries
    Dose              NVARCHAR(100) NULL,
    CONSTRAINT PK_Medicine PRIMARY KEY (MedicineID)
);
GO
CREATE INDEX IX_Medicine_Name ON dbo.Medicine (MedicineName);
GO

CREATE TABLE dbo.StoreMedicine (
    MedicineID INT NOT NULL,
    PharmacyID INT NOT NULL,
    Quantity   INT NOT NULL CONSTRAINT DF_StoreMedicine_Quantity DEFAULT 0,
    CONSTRAINT PK_StoreMedicine PRIMARY KEY (MedicineID, PharmacyID),
    CONSTRAINT FK_SM_Medicine FOREIGN KEY (MedicineID)
        REFERENCES dbo.Medicine (MedicineID) ON DELETE CASCADE,
    CONSTRAINT FK_SM_Pharmacy FOREIGN KEY (PharmacyID)
        REFERENCES dbo.Pharmacy (PharmacyID) ON DELETE CASCADE,
    CONSTRAINT CK_StoreMedicine_Quantity CHECK (Quantity >= 0)
);
GO
CREATE INDEX IX_SM_Pharmacy ON dbo.StoreMedicine (PharmacyID);
GO

/* ============================== Appointments ============================== */

CREATE TABLE dbo.HospitalAppointment (
    HospitalAppointmentID INT         NOT NULL,
    DateAndTime           DATETIME2(0) NOT NULL,
    DoctorID              INT         NOT NULL,
    PatientID             INT         NOT NULL,
    CONSTRAINT PK_HospitalAppointment PRIMARY KEY (HospitalAppointmentID),
    CONSTRAINT FK_HA_Doctor  FOREIGN KEY (DoctorID)  REFERENCES dbo.Doctor (DoctorID),
    CONSTRAINT FK_HA_Patient FOREIGN KEY (PatientID) REFERENCES dbo.patient (patientid)
);
GO
CREATE INDEX IX_HA_Doctor_Date  ON dbo.HospitalAppointment (DoctorID, DateAndTime);
CREATE INDEX IX_HA_Patient_Date ON dbo.HospitalAppointment (PatientID, DateAndTime);
GO

CREATE TABLE dbo.ClinicAppointment (
    ClinicAppointmentID INT         NOT NULL,
    DateAndTime         DATETIME2(0) NOT NULL,
    PatientID           INT         NOT NULL,
    ClinicID            INT         NOT NULL,
    CONSTRAINT PK_ClinicAppointment PRIMARY KEY (ClinicAppointmentID),
    CONSTRAINT FK_CA_Patient FOREIGN KEY (PatientID) REFERENCES dbo.patient (patientid),
    CONSTRAINT FK_CA_Clinic  FOREIGN KEY (ClinicID)  REFERENCES dbo.Clinic (ClinicID)
);
GO
CREATE INDEX IX_CA_Clinic_Date  ON dbo.ClinicAppointment (ClinicID, DateAndTime);
CREATE INDEX IX_CA_Patient_Date ON dbo.ClinicAppointment (PatientID, DateAndTime);
GO

/* ============================ Clinical records ============================ */

CREATE TABLE dbo.Prescription (
    PrescriptionID     INT           NOT NULL,
    DateAndTime        DATETIME2(0)  NOT NULL,
    DiseaseName        NVARCHAR(150) NULL,
    PatientID          INT           NOT NULL,
    DiseaseDescription NVARCHAR(500) NULL,
    DoctorID           INT           NOT NULL,
    CONSTRAINT PK_Prescription PRIMARY KEY (PrescriptionID),
    CONSTRAINT FK_Presc_Patient FOREIGN KEY (PatientID) REFERENCES dbo.patient (patientid),
    CONSTRAINT FK_Presc_Doctor  FOREIGN KEY (DoctorID)  REFERENCES dbo.Doctor (DoctorID)
);
GO
CREATE INDEX IX_Presc_Patient ON dbo.Prescription (PatientID);
GO

CREATE TABLE dbo.MedicinePrescription (
    MedicineID     INT NOT NULL,
    PrescriptionID INT NOT NULL,
    Notes          NVARCHAR(255) NULL,
    CONSTRAINT PK_MedicinePrescription PRIMARY KEY (MedicineID, PrescriptionID),
    CONSTRAINT FK_MP_Medicine FOREIGN KEY (MedicineID)
        REFERENCES dbo.Medicine (MedicineID),
    CONSTRAINT FK_MP_Prescription FOREIGN KEY (PrescriptionID)
        REFERENCES dbo.Prescription (PrescriptionID) ON DELETE CASCADE
);
GO

-- IDENTITY surrogate key: the app inserts (PatientID, DiseaseDescription,
-- AtYear, IsCured) with no column list, so the IDENTITY column is skipped.
CREATE TABLE dbo.MedicalHistory (
    MedicalHistoryID   INT IDENTITY(1,1) NOT NULL,
    PatientID          INT           NOT NULL,
    DiseaseDescription NVARCHAR(500) NOT NULL,
    AtYear             INT           NULL,
    IsCured            CHAR(1)       NOT NULL CONSTRAINT DF_MedicalHistory_IsCured DEFAULT 'F',
    CONSTRAINT PK_MedicalHistory PRIMARY KEY (MedicalHistoryID),
    CONSTRAINT FK_MH_Patient FOREIGN KEY (PatientID) REFERENCES dbo.patient (patientid),
    CONSTRAINT CK_MH_IsCured CHECK (IsCured IN ('T','F'))
);
GO
CREATE INDEX IX_MH_Patient ON dbo.MedicalHistory (PatientID);
GO

CREATE TABLE dbo.Feedback (
    FeedbackID  INT           NOT NULL,
    DoctorID    INT           NOT NULL,
    PatientID   INT           NOT NULL,
    theFeedback NVARCHAR(1000) NULL,
    CONSTRAINT PK_Feedback PRIMARY KEY (FeedbackID),
    CONSTRAINT FK_FB_Doctor  FOREIGN KEY (DoctorID)  REFERENCES dbo.Doctor (DoctorID),
    CONSTRAINT FK_FB_Patient FOREIGN KEY (PatientID) REFERENCES dbo.patient (patientid)
);
GO
CREATE INDEX IX_FB_Doctor ON dbo.Feedback (DoctorID);
GO

CREATE TABLE dbo.Bill (
    BillID      INT           NOT NULL,
    Price       DECIMAL(10,2) NOT NULL CONSTRAINT DF_Bill_Price DEFAULT 0,
    DateandTime DATETIME2(0)  NOT NULL,
    PlaceID     INT           NOT NULL,
    PatientID   INT           NOT NULL,
    IsPaid      CHAR(1)       NOT NULL CONSTRAINT DF_Bill_IsPaid DEFAULT 'F',
    CONSTRAINT PK_Bill PRIMARY KEY (BillID),
    CONSTRAINT FK_Bill_Place   FOREIGN KEY (PlaceID)   REFERENCES dbo.Place (PlaceID),
    CONSTRAINT FK_Bill_Patient FOREIGN KEY (PatientID) REFERENCES dbo.patient (patientid),
    CONSTRAINT CK_Bill_IsPaid CHECK (IsPaid IN ('T','F')),
    CONSTRAINT CK_Bill_Price CHECK (Price >= 0)
);
GO
CREATE INDEX IX_Bill_Patient ON dbo.Bill (PatientID);
GO

-- IDENTITY surrogate key: the app inserts (UserID, DateAndTime, ActivityType)
-- with no column list, so the IDENTITY column is skipped.
CREATE TABLE dbo.ActivityLogs (
    LogID        INT IDENTITY(1,1) NOT NULL,
    UserID       INT           NOT NULL,
    DateAndTime  DATETIME2(0)  NOT NULL,
    ActivityType NVARCHAR(255) NULL,
    CONSTRAINT PK_ActivityLogs PRIMARY KEY (LogID),
    CONSTRAINT FK_AL_User FOREIGN KEY (UserID) REFERENCES dbo.sysUser (UserID)
);
GO
CREATE INDEX IX_AL_User_Date ON dbo.ActivityLogs (UserID, DateAndTime);
GO

PRINT 'Schema created successfully.';
GO
