/* ============================================================================
   Legacy-query compatibility test
   ----------------------------------------------------------------------------
   Runs the ACTUAL SQL statements emitted by the existing WinForms application
   (extracted verbatim from the C# source, with concrete values substituted for
   the interpolated parameters) against the schema. Its purpose is to prove the
   new schema is backwards-compatible with the un-recompilable desktop app -
   especially the column-less "INSERT ... VALUES(...)" statements, whose success
   depends on exact column ordering.

   All writes run inside a transaction that is rolled back, so the seed data is
   left untouched. Any error aborts the batch (-b) and fails the test.
   ========================================================================== */

SET NOCOUNT ON;
SET XACT_ABORT ON;
GO

PRINT '--- SELECT queries (read paths) ---';

-- sysUser.cs login / lookup
SELECT UserID FROM sysUser WHERE email = 'patient.ali@example';
SELECT UserID, userPassword FROM sysUser WHERE Email = 'patient.ali@example';
SELECT patientid FROM patient WHERE patientid = 5001;
SELECT doctorid FROM doctor WHERE doctorid = 100;
SELECT Adminid FROM sysAdmin WHERE adminid = 1;
SELECT ManagerID FROM PharmacyManager WHERE ManagerID = 20;
SELECT ManagerID FROM HospitalManager WHERE ManagerID = 10;
SELECT firstName, LastName, Age, Email FROM sysUser WHERE userid = 5001;
SELECT userPassword FROM sysUser WHERE userid = 5001;

-- Patient.cs upcoming appointments (the big multi-table join)
SELECT P.PlaceName,U.FirstName,U.LastName,HA.DateAndTime,HA.HospitalAppointmentID
FROM PLACE AS P, sysUser AS U, Doctor AS D, HospitalAppointment AS HA
WHERE HA.DoctorID=U.UserID AND HA.patientid=5001 AND D.DoctorID=U.UserID
  AND D.HospitalID=P.PlaceID AND HA.DateAndTime > GETDATE()
ORDER BY DATEANDTIME;

SELECT DateAndTime,DiseaseName,DiseaseDescription FROM Prescription WHERE PatientID=5001;
SELECT PrescriptionID FROM Prescription WHERE PatientID=5001;
SELECT Medicinename,Dose FROM MedicinePrescription,medicine
 WHERE MedicinePrescription.medicineid=medicine.medicineid AND PrescriptionID=1;
SELECT medicinename,medicineid FROM medicine;
SELECT placename,PlaceLocation,PhoneNumber,Email,IsAvailable,OpenDays,StartingTime,EndingTime
 FROM StoreMedicine,place WHERE pharmacyid=placeid AND medicineID=1;

-- Doctor.cs
SELECT ISAvailable FROM doctor WHERE doctorid = 100;
SELECT thefeedback, email FROM sysUser,feedback WHERE Userid = patientid AND Doctorid = 100;
SELECT DateAndTime, firstname, lastname FROM HospitalAppointment,sysUSER
 WHERE Userid = patientid AND doctorid = 100;
SELECT HospitalID FROM Doctor WHERE DoctorID=100;
SELECT StartingTime,EndingTime,OpenDays FROM Place WHERE PlaceID=500;
SELECT DateAndTime FROM HospitalAppointment
 WHERE DoctorID=100 AND CAST(DateAndTime AS DATE)=CAST('2026-01-01T10:00:00' AS DATE);
SELECT FirstName,theFeedback FROM Feedback,sysUser WHERE DoctorID = 100 AND UserID=PatientID;

-- HospitalManager.cs / PharmacyManager.cs
SELECT HospitalID FROM HospitalManager WHERE ManagerID=10;
SELECT OpenDays FROM place WHERE placeid=500;
SELECT IsAvailable FROM place WHERE placeid=500;
SELECT department.DepartmentName,department.DepartmentID
 FROM Hospital,Department,HospitalDepartment
 WHERE Hospital.HospitalID=HospitalDepartment.HospitalID
   AND Department.DepartmentID=HospitalDepartment.DepartmentID
   AND Hospital.HospitalID=500;
SELECT max(UserID) FROM sysUser;
SELECT doctorid,firstname,lastname,age FROM sysuser,doctor
 WHERE userid=doctorid AND departmentid=1 AND hospitalid=500;
SELECT pharmacyID FROM PharmacyManager WHERE ManagerID=20;
SELECT Medicine.MedicineID,Medicine.MedicineName,Quantity,Active_Ingredinet
 FROM Medicine,StoreMedicine,pharmacy
 WHERE Medicine.MedicineID=StoreMedicine.MedicineID
   AND StoreMedicine.pharmacyid=pharmacy.pharmacyid AND Pharmacy.pharmacyid=600;

-- MedicalHistory / Department / Hospital / Prescription / ActivityLog
SELECT DiseaseDescription,AtYear,IsCured FROM MedicalHistory WHERE PatientID = 5001;
SELECT * FROM Department;
SELECT H.PlaceName,H.PlaceID FROM Place AS H,HospitalDepartment AS HD
 WHERE HD.HospitalID=H.PlaceID AND HD.DepartmentID=1;
SELECT U.FirstName,U.UserID FROM Department AS D,Hospital AS H,HospitalDepartment AS HD,Doctor AS Dr,sysUser AS U
 WHERE Dr.HospitalID=H.HospitalID AND Dr.DepartmentID=D.DepartmentID AND U.UserID=Dr.DoctorID
   AND D.DepartmentID=1 AND HD.HospitalID=H.HospitalID AND H.HospitalID=500;
SELECT COUNT(*) FROM Place WHERE PlaceID = 500;
SELECT firstName, LastName, DiseaseName, DiseaseDescription, DateAndTime
 FROM sysUser, prescription WHERE userid = patientid AND patientid = 5001;
SELECT * FROM ActivityLogs WHERE DateAndTime > '2000-01-01T00:00:00';
SELECT DateAndTime,ActivityType FROM ActivityLogs WHERE UserID = 5001;
SELECT max(BillID) FROM Bill;
SELECT max(FeedbackID) FROM Feedback;
SELECT max(PrescriptionID) FROM prescription;
SELECT max(HospitalAppointmentID) FROM HospitalAppointment;
SELECT Price,DateandTime,IsPaid FROM Bill WHERE BillID=120001;
GO

PRINT '--- INSERT / UPDATE / DELETE (write paths, rolled back) ---';
BEGIN TRAN;

-- Column-less INSERTs: order-sensitive. These mirror the app verbatim.
INSERT INTO sysuser VALUES(99001,'newpatient@example','pw',30,'M','New','Patient');
INSERT INTO patient VALUES(99001);
INSERT INTO sysuser VALUES(99002,'newdoc@example','pw',41,'F','New','Doctor');
-- Doctor insert: 'F' is the corrected value (app bug fixed from integer 0).
INSERT INTO Doctor VALUES(99002,'F',1,500);
INSERT INTO StoreMedicine VALUES (2,601,55);
INSERT INTO MedicalHistory VALUES(5001, 'Seasonal allergy', 2024, 'F');     -- IDENTITY skipped
INSERT INTO Feedback VALUES (299001,100,5001,'Great doctor');
INSERT Bill VALUES(129001,99.99,'2026-01-02T12:00:00',500,5001,'F');
INSERT INTO prescription VALUES(9001, '2026-01-02T12:00:00', 'Flu', 5001, 'Seasonal flu', 100);
INSERT INTO MedicinePrescription VALUES(1,9001, null);
INSERT ActivityLogs VALUES(5001,'2026-01-02T12:00:00','Booked Appointment');  -- IDENTITY skipped
INSERT HospitalAppointment VALUES (1009001,'2026-01-02T12:00:00',100,5001);
INSERT INTO Place VALUES (9500,'Test Hospital','t@e','+1-000','08:00:00','17:00:00','T','Somewhere','MonTue');
INSERT INTO Hospital VALUES(9500);
INSERT INTO Place VALUES (9600,'Test Pharmacy','t@e','+1-000','08:00:00','17:00:00','T','Somewhere','MonTue');
INSERT INTO Pharmacy VALUES(9600);

-- UPDATEs
UPDATE sysUser SET Age = 31 WHERE userid = 5001;
UPDATE doctor SET ISAvailable = 'T' WHERE doctorid = 100;
UPDATE place SET IsAvailable='F' WHERE placeid=500;
UPDATE StoreMedicine SET Quantity=10 WHERE PharmacyID=600 AND medicineid=1;
UPDATE MedicalHistory SET iscured = 'T' WHERE patientid = 5001 AND DiseaseDescription = 'Seasonal allergy';

-- DELETEs
DELETE FROM HospitalAppointment WHERE HospitalAppointmentID=1009001;
DELETE FROM StoreMedicine WHERE pharmacyid=601 AND medicineid=2;

ROLLBACK;
GO

PRINT 'LEGACY COMPATIBILITY TEST PASSED: all application statements executed successfully.';
GO
