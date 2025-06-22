using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAppointmentProject.UML.USERS;
using UML = HospitalAppointmentProject.UML;

namespace HospitalAppointmentSystem
{
    public partial class Patient : Form
    {
        Form mainform;
        int? patient_id;
        UML.USERS.sysUser user;

        public Patient(Form mainform, int? patient_id)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.patient_id = patient_id;
            user = new UML.USERS.sysUser(this.patient_id);

        }

        private void newAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addappoint_Click(object sender, EventArgs e)
        {
            Appoint app = new Appoint(this, mainform,this.patient_id);
            this.Hide();
            app.Show();
        }

        private void addappoint_hover(object sender, EventArgs e)
        {
            addappoint.Cursor = Cursors.Hand;
        }

        private void appointlabel_hover(object sender, EventArgs e)
        {
            appointlabel.Cursor = Cursors.Hand;
        }

        private void showAppointmentslabel_hover(object sender, EventArgs e)
        {
            showAppointmentslabel.Cursor = Cursors.Hand;
        }
        private void Prescriptionslabel_hover(object sender, EventArgs e)
        {
            Prescriptionslabel.Cursor = Cursors.Hand;
        }
        private void showappoints_hover(object sender, EventArgs e)
        {
            showappoints.Cursor = Cursors.Hand;
        }

        private void EditAppointmentslabel_hover(object sender, EventArgs e)
        {
            
        }

        private void EditAppointments_hover(object sender, EventArgs e)
        {
        }

        private void DocSearchlabel_hover(object sender, EventArgs e)
        {
            DocSearchlabel.Cursor = Cursors.Hand;
        }

        private void DocSearch_hover(object sender, EventArgs e)
        {
            DocSearch.Cursor = Cursors.Hand;
        }

        private void Prescript_hover(object sender, EventArgs e)
        {
            Prescript.Cursor = Cursors.Hand;
        }

        private void medhistlablel_hover(object sender, EventArgs e)
        {
            midhistlablel.Cursor = Cursors.Hand;
        }

        private void medHistory_hover(object sender, EventArgs e)
        {
          
        }

        private void dfeed_hover(object sender, EventArgs e)
        {
            
        }



        private void dfeedlabel_hover(object sender, EventArgs e)
        {
            
        }

        private void appointlabel_Click(object sender, EventArgs e)
        {
            Appoint app = new Appoint(this, mainform,this.patient_id);
            this.Hide();
            app.Show();
        }

        private void patient_close(object sender, FormClosedEventArgs e)
        {
            mainform.Close();
        }

        private void showappoints_Click(object sender, EventArgs e)
        {
            UpcomingAppointment upapp = new UpcomingAppointment(this, mainform, this.patient_id);
            this.Hide();
            upapp.Show();
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

        private void showAppointmentslabel_Click(object sender, EventArgs e)
        {
            UpcomingAppointment upapp = new UpcomingAppointment(this, mainform,this.patient_id);
            this.Hide();
            upapp.Show();
        }

        private void EditAppointmentslabel_Click(object sender, EventArgs e)
        {
            reschedule re = new reschedule(this, mainform);
            this.Hide();
            re.Show();
        }

        private void EditAppointments_Click(object sender, EventArgs e)
        {
            reschedule re = new reschedule(this, mainform);
            this.Hide();
            re.Show();
        }

        private void dfeedlabel_Click(object sender, EventArgs e)
        {
            //PateintsFeedbacks sd = new PateintsFeedbacks(this,  mainform, UserID);
            this.Hide();
            //sd.Show();
        }

        private void dfeed_Click(object sender, EventArgs e)
        {
            //PateintsFeedbacks sd = new PateintsFeedbacks(this, mainform);
            this.Hide();
            //sd.Show();
        }

        private void DocSearch_Click(object sender, EventArgs e)
        {
            Search_Doctors sd = new Search_Doctors(this, mainform, this.patient_id);
            this.Hide();
            sd.Show();
        }

        private void DocSearchlabel_Click(object sender, EventArgs e)
        {
            Search_Doctors sd = new Search_Doctors(this, mainform, this.patient_id);
            this.Hide();
            sd.Show();
        }

        private void Prescript_Click(object sender, EventArgs e)
        {
            Prescriptions p = new Prescriptions(this, mainform, patient_id);
            this.Hide();
            p.Show();
        }

        private void Prescriptionslabel_Click(object sender, EventArgs e)
        {
            Prescriptions p = new Prescriptions(this, mainform, patient_id);
            this.Hide();
            p.Show();
        }

        private void medHistory_Click(object sender, EventArgs e)
        {
            Medical_History mh = new Medical_History(this, mainform,this.patient_id);
            this.Hide();
            mh.Show();
        }

        private void midhistlablel_Click(object sender, EventArgs e)
        {
            Medical_History mh = new Medical_History(this, mainform,this.patient_id);
            this.Hide();
            mh.Show();
        }

        private void profile_ButtonClick(object sender, EventArgs e)
        {

        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //YourProfile y = new YourProfile;
            //y.Show();   
            //this.Hide();    
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YourProfile yp = new YourProfile(this, mainform, patient_id);
            this.Hide();
            yp.Show();
        }

        private void removeAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void removeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform.Show();
        }
    }
}
