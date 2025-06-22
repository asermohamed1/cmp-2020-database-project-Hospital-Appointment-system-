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
    public partial class PateintsFeedbacks : Form
    {
        Form prevform, mainform;
        int? _UserID;
        Type currentType;
        UML.USERS.Doctor doctor;


        public PateintsFeedbacks(Form prevform, Form mainform, int? _UserID)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            this._UserID = _UserID;
            currentType = prevform.GetType();
            doctor = new UML.USERS.Doctor(_UserID);
            doctor._UserID = _UserID;
            PateintFeedbacks.DataSource = doctor.getfeedback();
            PateintFeedbacks.Refresh();
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

        private void feedback_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void PateintsFeedbacks_Load(object sender, EventArgs e)
        {

          
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevform.Show();
        }
    }
}
