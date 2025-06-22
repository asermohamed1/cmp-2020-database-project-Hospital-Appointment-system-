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
    public partial class Doctor_Appointments : Form
    {
        Form prevform, mainform;
        int? _UserID;
        UML.USERS.Doctor doctor;
        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevform.Show();
        }

        private void contactus_Click(object sender, EventArgs e)
        {
            ContactUs cu = new ContactUs(this, mainform);
            this.Hide();
            cu.Show();
        }

        private void exitprogram_Click(object sender, EventArgs e)
        {
            mainform.Close();
        }

        private void DocAppointments_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void available_CheckedChanged(object sender, EventArgs e)
        {
            if (!available.Checked)
            {
                doctor.IsAvailable = 'F';
            }
            else
            {
                doctor.IsAvailable = 'T';

            }
            int res = doctor.SetAvallibillity();
            if (res == 1) MessageBox.Show("Edited Successfully");
            else MessageBox.Show("Failed");
        }

        private void Doctor_Appointments_Load(object sender, EventArgs e)
        {
            DoctorAppointments.DataSource = doctor.Appointments;
            DoctorAppointments.Refresh();
        }

        public Doctor_Appointments(Form prevform, Form mainform, int? _UserID)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            this._UserID = _UserID;
            this.doctor = new UML.USERS.Doctor(_UserID);
        }
    }
}
