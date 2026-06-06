/* ============================================================================
   Hospital Appointment System - Seed / sample data
   Realistic reference data for local development, demos and integration tests.
   Safe to re-run: every section clears its tables first.
   ========================================================================== */

SET NOCOUNT ON;
SET XACT_ABORT ON;
GO

DELETE FROM dbo.ActivityLogs;
DELETE FROM dbo.Bill;
DELETE FROM dbo.Feedback;
DELETE FROM dbo.MedicalHistory;
DELETE FROM dbo.MedicinePrescription;
DELETE FROM dbo.Prescription;
DELETE FROM dbo.ClinicAppointment;
DELETE FROM dbo.HospitalAppointment;
DELETE FROM dbo.StoreMedicine;
DELETE FROM dbo.Medicine;
DELETE FROM dbo.HospitalDepartment;
DELETE FROM dbo.Clinic;
DELETE FROM dbo.PharmacyManager;
DELETE FROM dbo.HospitalManager;
DELETE FROM dbo.sysAdmin;
DELETE FROM dbo.Doctor;
DELETE FROM dbo.patient;
DELETE FROM dbo.sysUser;
DELETE FROM dbo.Pharmacy;
DELETE FROM dbo.Hospital;
DELETE FROM dbo.Place;
DELETE FROM dbo.Department;
GO

/* ------------------------------- Departments ----------------------------- */
INSERT INTO dbo.Department (DepartmentID, DepartmentName) VALUES
 (1,'Cardiology'),
 (2,'Dermatology'),
 (3,'Pediatrics'),
 (4,'Orthopedics'),
 (5,'Neurology'),
 (6,'General Medicine');
GO

/* --------------------------------- Places -------------------------------- */
INSERT INTO dbo.Place (PlaceID, PlaceName, Email, PhoneNumber, StartingTime, EndingTime, IsAvailable, PlaceLocation, OpenDays) VALUES
 (500,'City General Hospital','info@citygeneral.example','+1-202-555-0100','08:00:00','20:00:00','T','123 Main St, Downtown','SunMonTueWedThu'),
 (501,'Riverside Medical Center','contact@riverside.example','+1-202-555-0111','09:00:00','17:00:00','T','45 River Rd, Eastside','MonTueWedThuFri'),
 (600,'HealthPlus Pharmacy','sales@healthplus.example','+1-202-555-0120','08:00:00','22:00:00','T','12 Market Ave, Downtown','SunMonTueWedThuFriSat'),
 (601,'CarePoint Pharmacy','hello@carepoint.example','+1-202-555-0131','10:00:00','18:00:00','T','78 Hill St, Eastside','MonTueWedThuFri'),
 (700,'Dr. Adams Family Clinic','clinic.adams@example','+1-202-555-0140','10:00:00','16:00:00','T','9 Oak Lane, Northside','MonWedFri'),
 (701,'Dr. Brown Skin Clinic','clinic.brown@example','+1-202-555-0151','11:00:00','19:00:00','T','22 Pine St, Westside','TueThuSat');
GO

INSERT INTO dbo.Hospital (HospitalID) VALUES (500),(501);
INSERT INTO dbo.Pharmacy (PharmacyID) VALUES (600),(601);
GO

/* ---------------------------------- Users -------------------------------- */
-- Passwords are sample plaintext to match the legacy app's comparison logic.
INSERT INTO dbo.sysUser (UserID, Email, userPassword, Age, Gender, firstName, LastName) VALUES
 -- admin
 (1,'admin@hospital.example','admin123',40,'M','System','Admin'),
 -- hospital managers
 (10,'hmanager.city@hospital.example','hm123',38,'F','Hala','Mansour'),
 (11,'hmanager.river@hospital.example','hm123',45,'M','Omar','Rashid'),
 -- pharmacy managers
 (20,'pmanager.health@hospital.example','pm123',33,'F','Nour','Saleh'),
 (21,'pmanager.care@hospital.example','pm123',29,'M','Karim','Fahmy'),
 -- doctors
 (100,'dr.adams@hospital.example','doc123',50,'M','John','Adams'),
 (101,'dr.brown@hospital.example','doc123',42,'F','Emily','Brown'),
 (102,'dr.clark@hospital.example','doc123',37,'M','David','Clark'),
 (103,'dr.davis@hospital.example','doc123',46,'F','Sara','Davis'),
 (104,'dr.evans@hospital.example','doc123',55,'M','Michael','Evans'),
 -- patients
 (5001,'patient.ali@example','pat123',28,'M','Ali','Hassan'),
 (5002,'patient.mona@example','pat123',34,'F','Mona','Tarek'),
 (5003,'patient.youssef@example','pat123',45,'M','Youssef','Adel'),
 (5004,'patient.layla@example','pat123',22,'F','Layla','Sami'),
 (5005,'patient.hassan@example','pat123',60,'M','Hassan','Nabil');
GO

INSERT INTO dbo.sysAdmin (Adminid) VALUES (1);
INSERT INTO dbo.HospitalManager (ManagerID, HospitalID) VALUES (10,500),(11,501);
INSERT INTO dbo.PharmacyManager (ManagerID, pharmacyID) VALUES (20,600),(21,601);
GO

-- Doctors: (DoctorID, ISAvailable, DepartmentID, HospitalID)
INSERT INTO dbo.Doctor (DoctorID, ISAvailable, DepartmentID, HospitalID) VALUES
 (100,'T',1,500),  -- Cardiology @ City General
 (101,'T',2,500),  -- Dermatology @ City General
 (102,'F',3,501),  -- Pediatrics  @ Riverside
 (103,'T',4,501),  -- Orthopedics @ Riverside
 (104,'T',6,500);  -- General Med @ City General
GO

INSERT INTO dbo.patient (patientid) VALUES (5001),(5002),(5003),(5004),(5005);
GO

-- Clinics belong to a doctor each.
INSERT INTO dbo.Clinic (ClinicID, DoctorID) VALUES (700,100),(701,101);
GO

/* ------------------------- Hospital <-> Department ------------------------ */
INSERT INTO dbo.HospitalDepartment (HospitalID, DepartmentID) VALUES
 (500,1),(500,2),(500,6),
 (501,3),(501,4),(501,5);
GO

/* -------------------------------- Medicine ------------------------------- */
INSERT INTO dbo.Medicine (MedicineID, MedicineName, Active_Ingredinet, Dose) VALUES
 (1,'Panadol','Paracetamol','500mg'),
 (2,'Augmentin','Amoxicillin/Clavulanate','1g'),
 (3,'Lipitor','Atorvastatin','20mg'),
 (4,'Ventolin','Salbutamol','100mcg'),
 (5,'Concor','Bisoprolol','5mg'),
 (6,'Voltaren','Diclofenac','50mg'),
 (7,'Nexium','Esomeprazole','40mg'),
 (8,'Zyrtec','Cetirizine','10mg');
GO

INSERT INTO dbo.StoreMedicine (MedicineID, PharmacyID, Quantity) VALUES
 (1,600,200),(2,600,80),(3,600,50),(4,600,120),(5,600,60),
 (1,601,150),(6,601,40),(7,601,75),(8,601,90);
GO

/* ------------------------------ Appointments ----------------------------- */
INSERT INTO dbo.HospitalAppointment (HospitalAppointmentID, DateAndTime, DoctorID, PatientID) VALUES
 (1000001, DATEADD(day, 3, CAST(CAST(GETDATE() AS DATE) AS DATETIME2)), 100, 5001),
 (1000002, DATEADD(day, 5, CAST(CAST(GETDATE() AS DATE) AS DATETIME2)), 101, 5002),
 (1000003, DATEADD(day, 7, CAST(CAST(GETDATE() AS DATE) AS DATETIME2)), 104, 5003),
 (1000004, DATEADD(day,-2, CAST(CAST(GETDATE() AS DATE) AS DATETIME2)), 100, 5004);  -- past
GO

INSERT INTO dbo.ClinicAppointment (ClinicAppointmentID, DateAndTime, PatientID, ClinicID) VALUES
 (800001, DATEADD(day, 2, CAST(CAST(GETDATE() AS DATE) AS DATETIME2)), 5001, 700),
 (800002, DATEADD(day, 4, CAST(CAST(GETDATE() AS DATE) AS DATETIME2)), 5005, 701);
GO

/* ------------------------------ Prescriptions ---------------------------- */
INSERT INTO dbo.Prescription (PrescriptionID, DateAndTime, DiseaseName, PatientID, DiseaseDescription, DoctorID) VALUES
 (1, DATEADD(day,-2, SYSDATETIME()), 'Hypertension', 5001, 'High blood pressure, mild', 100),
 (2, DATEADD(day,-1, SYSDATETIME()), 'Eczema',       5002, 'Skin irritation on arms',   101);
GO

INSERT INTO dbo.MedicinePrescription (MedicineID, PrescriptionID, Notes) VALUES
 (5,1,'Once daily'),
 (1,1,'As needed for headache'),
 (8,2,'Twice daily');
GO

/* ----------------------------- Medical history --------------------------- */
INSERT INTO dbo.MedicalHistory (PatientID, DiseaseDescription, AtYear, IsCured) VALUES
 (5001,'Appendectomy',2015,'T'),
 (5001,'High blood pressure, mild',2024,'F'),
 (5003,'Knee surgery',2019,'T');
GO

/* -------------------------------- Feedback ------------------------------- */
INSERT INTO dbo.Feedback (FeedbackID, DoctorID, PatientID, theFeedback) VALUES
 (200001,100,5001,'Very attentive and professional.'),
 (200002,101,5002,'Helpful and kind, explained everything.');
GO

/* --------------------------------- Bills --------------------------------- */
INSERT INTO dbo.Bill (BillID, Price, DateandTime, PlaceID, PatientID, IsPaid) VALUES
 (120001, 250.00, DATEADD(day,-2, SYSDATETIME()), 500, 5001, 'T'),
 (120002, 120.50, DATEADD(day,-1, SYSDATETIME()), 501, 5003, 'F');
GO

/* ------------------------------ Activity logs ---------------------------- */
INSERT INTO dbo.ActivityLogs (UserID, DateAndTime, ActivityType) VALUES
 (5001, DATEADD(hour,-5, SYSDATETIME()), 'Logged In'),
 (100,  DATEADD(hour,-4, SYSDATETIME()), 'Wrote a Prescription'),
 (10,   DATEADD(hour,-3, SYSDATETIME()), 'Added a Doctor');
GO

PRINT 'Seed data inserted successfully.';
GO
