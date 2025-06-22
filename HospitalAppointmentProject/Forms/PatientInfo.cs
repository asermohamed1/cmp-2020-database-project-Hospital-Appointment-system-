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
    public partial class PatientInfo : Form
    {
        Form prevform, mainform;
        UML.theMedicalHistory.MedicalHistory medHist;
        int? _UserID;
        UML.USERS.Patient patient;
        UML.Paper.Prescription pre;
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

        private void patinfo_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            patient = new UML.USERS.Patient(null, pEmail.Text, null, null, null, null, null,null, null, null, null, null,null, null, null);
            if (addDis.Checked)
            {
                if (pEmail.Text == "" || DName.Text == "" || textBoxyear.Text == "")
                {
                    MessageBox.Show("please fill all fields");
                    return;
                }
                int? patientid = patient.UserID;
                int year;
                if (!int.TryParse(textBoxyear.Text,out year))
                {
                    MessageBox.Show("year must be a number");
                    return;
                }
                medHist._PatientID = patientid;
                medHist._DiseaseDescription = DName.Text;
                medHist._AtYear = year;
                int res = medHist.newMedHistory(_UserID.Value);
                if (res == 0)
                {
                    MessageBox.Show("the email is wrong");
                    return;
                }
            }
            else if(cured.Checked)
            {
                if (pEmail.Text == "" || DName.Text == "")
                {
                    MessageBox.Show("the disease discription or email field is empty");
                    return;
                }
                int? patientid = patient.UserID;
                int year;

                medHist._PatientID = patientid;
                medHist._DiseaseDescription = DName.Text;
                int res = medHist.updatemedHistpry(_UserID.Value);
                if (res == 0)
                {
                    MessageBox.Show("the email is wrong");
                    return;
                }
            }
            else
            {
                MessageBox.Show("select an action");
                return;
            }
        }

        private void showBuutton_Click(object sender, EventArgs e)
        {
            patient = new UML.USERS.Patient(null, pEmail.Text, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (addDis.Checked)
            {
                if (pEmail.Text == "" || DName.Text == "" || textBoxyear.Text == "")
                {
                    MessageBox.Show("please fill all fields");
                    return;
                }
                int? patientid = patient.UserID;
                int year;
                if (!int.TryParse(textBoxyear.Text, out year))
                {
                    MessageBox.Show("year must be a number");
                    return;
                }
                medHist._PatientID = patientid;
                medHist._DiseaseDescription = DName.Text;
                medHist._AtYear = year;
                int res = medHist.newMedHistory(_UserID.Value);
                if (res == 0)
                {
                    MessageBox.Show("the email is wrong");
                    return;
                }
            }
            else if (cured.Checked)
            {
                if (pEmail.Text == "" || DName.Text == "")
                {
                    MessageBox.Show("the disease discription or email field is empty");
                    return;
                }
                int? patientid = patient.UserID;
                int year;

                medHist._PatientID = patientid;
                medHist._DiseaseDescription = DName.Text;
                int res = medHist.updatemedHistpry(_UserID.Value);
                if (res == 0)
                {
                    MessageBox.Show("the email is wrong");
                    return;
                }
            }
            else
            {
                MessageBox.Show("select an action");
                return;
            }
            MessageBox.Show("Medical History updated");

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            patient = new UML.USERS.Patient(null, pEmail.Text, null, null, null, null, null, null, null, null, null, null, null, null, null);
            medHist.PatientID = patient.UserID;
            pMedHist.DataSource = medHist.getmedicalhistory();
            if (pMedHist.DataSource == null)
            {
                MessageBox.Show("the email is wrong");
                return;
            }
            pMedHist.Refresh();
            DateTime d = new DateTime();
            pre = new UML.Paper.Prescription(d, null, null, patient.UserID, null, null, null);
            PPrescription.DataSource = pre.Getprescriptions();
            PPrescription.Refresh();
            if (PPrescription.DataSource == null)
            {
                MessageBox.Show("the email is wrong");
                return;
            }

        }

        public PatientInfo(Form prevform, Form mainform, int? userID)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            _UserID = userID;
            medHist = new UML.theMedicalHistory.MedicalHistory();

        }
    }
}
