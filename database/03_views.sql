/* ============================================================================
   Hospital Appointment System - Views
   Convenience views over the most common multi-table joins in the app.
   ========================================================================== */

SET NOCOUNT ON;
GO

IF OBJECT_ID('dbo.vw_DoctorDirectory','V') IS NOT NULL DROP VIEW dbo.vw_DoctorDirectory;
GO
CREATE VIEW dbo.vw_DoctorDirectory
AS
    SELECT  d.DoctorID,
            u.firstName,
            u.LastName,
            u.Email,
            u.Age,
            d.ISAvailable,
            d.DepartmentID,
            dep.DepartmentName,
            d.HospitalID,
            p.PlaceName AS HospitalName
    FROM    dbo.Doctor d
            JOIN dbo.sysUser u   ON u.UserID = d.DoctorID
            LEFT JOIN dbo.Department dep ON dep.DepartmentID = d.DepartmentID
            LEFT JOIN dbo.Hospital h  ON h.HospitalID = d.HospitalID
            LEFT JOIN dbo.Place p     ON p.PlaceID = h.HospitalID;
GO

IF OBJECT_ID('dbo.vw_UpcomingHospitalAppointments','V') IS NOT NULL
    DROP VIEW dbo.vw_UpcomingHospitalAppointments;
GO
CREATE VIEW dbo.vw_UpcomingHospitalAppointments
AS
    SELECT  ha.HospitalAppointmentID,
            ha.DateAndTime,
            ha.PatientID,
            pu.firstName + ' ' + pu.LastName AS PatientName,
            ha.DoctorID,
            du.firstName + ' ' + du.LastName AS DoctorName,
            p.PlaceName AS HospitalName
    FROM    dbo.HospitalAppointment ha
            JOIN dbo.sysUser pu ON pu.UserID = ha.PatientID
            JOIN dbo.Doctor  d  ON d.DoctorID = ha.DoctorID
            JOIN dbo.sysUser du ON du.UserID = ha.DoctorID
            LEFT JOIN dbo.Place p ON p.PlaceID = d.HospitalID
    WHERE   ha.DateAndTime > GETDATE();
GO

IF OBJECT_ID('dbo.vw_PharmacyInventory','V') IS NOT NULL DROP VIEW dbo.vw_PharmacyInventory;
GO
CREATE VIEW dbo.vw_PharmacyInventory
AS
    SELECT  sm.PharmacyID,
            p.PlaceName AS PharmacyName,
            m.MedicineID,
            m.MedicineName,
            m.Active_Ingredinet,
            m.Dose,
            sm.Quantity
    FROM    dbo.StoreMedicine sm
            JOIN dbo.Medicine m ON m.MedicineID = sm.MedicineID
            JOIN dbo.Place p    ON p.PlaceID = sm.PharmacyID;
GO

PRINT 'Views created successfully.';
GO
