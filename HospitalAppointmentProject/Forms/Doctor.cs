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

    public partial class Doctor : Form
    {
        Form mainform;
        int? _UserID;
        UML.USERS.Doctor doctor;
        UML.USERS.sysUser user;

        public Doctor(Form mainform, int? userID)
        {
            InitializeComponent();
            this.mainform = mainform;
            _UserID = userID;
            doctor = new UML.USERS.Doctor(userID);
            user = new UML.USERS.sysUser(_UserID);

        }

        private void Appoints_hover(object sender, EventArgs e)
        {
            Appoints.Cursor = Cursors.Hand;
        }

        private void curApplable_hover(object sender, EventArgs e)
        {
            curApplabel.Cursor = Cursors.Hand;
        }

        private void addpre_hover(object sender, EventArgs e)
        {
            addpre.Cursor = Cursors.Hand;
        }

        private void addprelabel_hover(object sender, EventArgs e)
        {
            addprelabel.Cursor = Cursors.Hand;
        }

        private void pinfolabel_hover(object sender, EventArgs e)
        {
            pinfolabel.Cursor = Cursors.Hand;
        }

        private void pInfo_hover(object sender, EventArgs e)
        {
            pInfo.Cursor = Cursors.Hand;
        }

        private void feedbackslabel_hover(object sender, EventArgs e)
        {
            feedbacklabel.Cursor = Cursors.Hand;
        }

        private void feedbacks_hover(object sender, EventArgs e)
        {
            feedbacks.Cursor = Cursors.Hand;
        }

        private void Appoints_Click(object sender, EventArgs e)
        {
            Doctor_Appointments ua = new Doctor_Appointments(this, mainform, _UserID);
            this.Hide();
            ua.Show();
        }

        private void curApplabel_Click(object sender, EventArgs e)
        {
            Doctor_Appointments ua = new Doctor_Appointments(this, mainform, _UserID);
            this.Hide();
            ua.Show();
        }

        private void addpre_Click(object sender, EventArgs e)
        {
            AddPrescription ap = new AddPrescription(this, mainform, _UserID);
            this.Hide();
            ap.Show();
        }

        private void addprelabel_Click(object sender, EventArgs e)
        {
            AddPrescription ap = new AddPrescription(this, mainform, _UserID);
            this.Hide();
            ap.Show();
        }

        private void pInfo_Click(object sender, EventArgs e)
        {
            PatientInfo pi = new PatientInfo(this, mainform, _UserID);
            this.Hide();
            pi.Show();
        }

        private void pinfolabel_Click(object sender, EventArgs e)
        {
            PatientInfo pi = new PatientInfo(this, mainform, _UserID);
            this.Hide();
            pi.Show();
        }

        private void feedbacks_Click(object sender, EventArgs e)
        {
            PateintsFeedbacks pfeed = new PateintsFeedbacks(this, mainform, _UserID);
            this.Hide();
            pfeed.Show();
        }

        private void exitprogram_Click(object sender, EventArgs e)
        {
            mainform.Close();
        }

        private void Doctor_Close(object sender, FormClosedEventArgs e)
        {
            mainform.Close();
        }

        private void removeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform.Show();
        }

        private void removeAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YourProfile yp = new YourProfile(this, mainform, _UserID);
            this.Hide();
            yp.Show();
        }
    }
}
