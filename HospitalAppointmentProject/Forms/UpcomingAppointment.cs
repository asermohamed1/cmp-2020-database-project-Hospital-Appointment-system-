using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML = HospitalAppointmentProject.UML;

namespace HospitalAppointmentSystem
{

    public partial class UpcomingAppointment : Form
    {
        Form prevform;
        Form mainform;
        UML.USERS.Patient patient;
        UML.Appointments.HospitalAppointment Appointment;
        int? userID;
        public UpcomingAppointment(Form prevform, Form mainform, int? userid)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            this.userID = userid;

            patient = new UML.USERS.Patient();
            Appointment = new UML.Appointments.HospitalAppointment();



            patient._UserID = userID;
            DataTable dataTable = patient.UpcomingAppointments();

            CurrentAppointments.DisplayMember = "DateAndTime";
            CurrentAppointments.ValueMember = "HospitalAppointmentID";
            CurrentAppointments.DataSource = dataTable;

            Appointments.DataSource = dataTable;
            Appointments.Refresh();



        }

        private void Cancel_hover(object sender, EventArgs e)
        {
            Cancel.Cursor = Cursors.Hand;
        }

        private void cancellabel_hover(object sender, EventArgs e)
        {
            Cancellabel.Cursor = Cursors.Hand;
        }

        private void upAppointments_close(object sender, FormClosedEventArgs e)
        {
            this.Show();
            prevform.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevform.Show();
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

        private void Cancellabel_Click(object sender, EventArgs e)
        {
            if (CurrentAppointments.SelectedIndex < 0)
            {
                MessageBox.Show("Select The Appointment That you want to delete first, you are really sick bro" + "\nwhat is " + CurrentAppointments.Text + " anyways?");
                return;
            }

            Appointment._HospitalAppointmentID = (int)(CurrentAppointments.SelectedValue);
            Appointment._PatientID = userID;
            int IsDeleted = Appointment.CancleAppointment();
            if (IsDeleted == 0)
            {
                MessageBox.Show("Nothing is Canceled For some reason");
                return;
            }
            DataTable dataTable = patient.UpcomingAppointments();
            CurrentAppointments.DisplayMember = "DateAndTime";
            CurrentAppointments.ValueMember = "HospitalAppointmentID";
            CurrentAppointments.DataSource = dataTable;
            Appointments.DataSource = dataTable;
            Appointments.Refresh();
            MessageBox.Show("Canceled Successfully");
        }
    }
}
