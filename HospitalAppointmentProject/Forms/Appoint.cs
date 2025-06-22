using DBapplication;
using HospitalAppointmentProject.UML.USERS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML = HospitalAppointmentProject.UML;

namespace HospitalAppointmentSystem
{

    public partial class Appoint : Form
    {
        Form prevform;
        Form mainform;
        int? patientID;
        UML.Appointments.HospitalAppointment Appointment;
        UML.Department Department;
        UML.PLACES.Hospital hospital;
        UML.USERS.Doctor doctor;
        UML.Paper.Bill bill;
        public Appoint(Form prevform, Form mainform, int? patientID)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            this.patientID = patientID;
            Appointment = new UML.Appointments.HospitalAppointment();
            Department = new UML.Department();
            hospital = new UML.PLACES.Hospital();
            doctor = new UML.USERS.Doctor();
            bill = new UML.Paper.Bill();
            DataTable dataTable = Department.GetDepartments();
            Departments.ValueMember = "DepartmentID";
            Departments.DisplayMember = "DepartmentName";
            Hospitals.ValueMember = "PlaceID";
            Hospitals.DisplayMember = "PlaceName";
            Doctors.ValueMember = "UserID";
            Doctors.DisplayMember = "FirstName";
            datetoAppoint.Enabled = false;
            Departments.DataSource = dataTable;
        }

        private void Add_hover(object sender, EventArgs e)
        {
            addappoint.Cursor = Cursors.Hand;
        }

        private void addlabel_hover(object sender, EventArgs e)
        {
            Add.Cursor = Cursors.Hand;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            prevform.Show();
            this.Hide();
        }

        private void Appoin_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
            this.Hide();
        }

        private void exitprogram_Click(object sender, EventArgs e)
        {
            mainform.Close();
        }

        private void contactus_Click(object sender, EventArgs e)
        {

            ContactUs cu = new ContactUs(this, mainform);
            this.Hide();
            cu.Show();
        }

        private void addappoint_Click(object sender, EventArgs e)
        {
            if (Departments.SelectedValue == null && Hospitals.SelectedValue == null && Doctors.SelectedValue == null && times.SelectedValue == null)
            {
                MessageBox.Show("please Select an Appointment first");
                return;
            }

            Appointment._PatientID = patientID;
            Appointment._DateAndTime = datetoAppoint.Value.ToString().Substring(0, 10) + " " + (times.SelectedValue).ToString();
            MessageBox.Show(Appointment._DateAndTime);
            Appointment._DoctorID = (int)Doctors.SelectedValue;
            int res = Appointment.AddAppointment();
            if (res == 1)
            {
                MessageBox.Show("Appointed Successfully");
                datetoAppoint_ValueChanged(sender, e);

                bill._Price = 100;
                bill._PatientID = patientID;
                bill._DatenTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                doctor._UserID = (int)Doctors.SelectedValue;
                bill._PlaceID = doctor.GetHosiptalID();
                bill.IsPaid = false;
                bill._DatenTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                Bill.DataSource = bill.InsertBill();
                Bill.Refresh();
            }
            else MessageBox.Show("Failed");
        }

        private void Departments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Departments.SelectedIndex < 0)
            {
                Hospitals.Enabled = false;
                return;
            }
            Hospitals.Enabled = true;
            Department._DepartmentID = (int)(Departments.SelectedValue);
            DataTable dt = Department.GetAllHospitals();
            Hospitals.DataSource = dt;
        }

        private void Hospitals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Hospitals.Enabled || Hospitals.SelectedIndex < 0)
            {
                Doctors.Enabled = false;
                return;
            }
            Hospitals.ValueMember = "PlaceID";
            Hospitals.DisplayMember = "PlaceName";
            Doctors.Enabled = true;
            hospital._PlaceID = (int)(Hospitals.SelectedValue);
            DataTable dt = hospital.GetDoctorsInDepartment((int)(Departments.SelectedValue));
            Doctors.ValueMember = "UserID";
            Doctors.DisplayMember = "FirstName";
            Doctors.DataSource = dt;
        }

        private void Doctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            datetoAppoint.Enabled = Doctors.Enabled && Doctors.SelectedIndex >= 0;
        }

        private void datetoAppoint_ValueChanged(object sender, EventArgs e)
        {
            if (datetoAppoint.Value.Date < DateTime.Now.Date || Doctors.SelectedIndex < 0)
            {
                times.DataSource = null;
                return;
            }
            DataTable dt = doctor.GetAllAvailableTimes((int)Doctors.SelectedValue, datetoAppoint.Value);
            times.DisplayMember = "AppointmentTime";
            times.ValueMember = "AppointmentTime";
            times.DataSource = dt;
        }
    }
}
