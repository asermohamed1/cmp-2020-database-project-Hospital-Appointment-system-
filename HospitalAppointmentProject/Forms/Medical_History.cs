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
    public partial class Medical_History : Form
    {
        Form prevform, mainform;
        UML.theMedicalHistory.MedicalHistory medicalHistory;
        int? userID;
        public Medical_History(Form prevform, Form mainform, int? userid)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            this.userID = userid;
            medicalHistory = new UML.theMedicalHistory.MedicalHistory();
            medicalHistory._PatientID =userID;
            DataTable dt = medicalHistory.getmedicalhistory();
            if (dt == null || dt.Rows.Count < 0)
            {
                MessageBox.Show("there isnt medical history for you right now");
                return;
            }
            else
            {
                patientmedicalhistory.DataSource = dt;  
                patientmedicalhistory.Refresh();    
            }
        }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Medical_History_Load(object sender, EventArgs e)
        {

        }

        private void Mh_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

    
    }
}
