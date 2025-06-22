using HospitalAppointmentProject.UML.PLACES;
using HospitalAppointmentProject.UML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML = HospitalAppointmentProject.UML;
using System.Security.Cryptography;
namespace HospitalAppointmentSystem
{
    public partial class Search_Doctors : Form
    {
        Form prevform, mainform;
 
        UML.Department Department;
        UML.PLACES.Hospital hospital;
        UML.USERS.Doctor doctor;
        UML.FeedBacks.FeedBack feedback;
        int? patientID;
        public Search_Doctors(Form prevform, Form mainform,int? patientID)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            Department = new UML.Department();
            hospital = new UML.PLACES.Hospital();
            doctor= new UML.USERS.Doctor(); 
            feedback = new UML.FeedBacks.FeedBack();  
            this.patientID = patientID;
            DataTable dataTable = Department.GetDepartments();
            Departments.ValueMember = "DepartmentID";
            Departments.DisplayMember = "DepartmentName";
            Hospitals.ValueMember = "PlaceID";
            Hospitals.DisplayMember = "PlaceName";
            Doctors.ValueMember = "UserID";
            Doctors.DisplayMember = "FirstName";
            Departments.DataSource = dataTable;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

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

        private void search_doctors_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            if (Departments.SelectedValue == null)
            {
                MessageBox.Show("please Select a Department");
                return;
            }

            if (Hospitals.SelectedValue == null)
            {
                MessageBox.Show("please Select a Hospital");
                return;
            }

            if (Doctors.SelectedValue == null)
            {
                MessageBox.Show("please Select a Doctor");
                return;
            }
            if (string.IsNullOrEmpty(feedbacktxtbox.Text))
            {
                MessageBox.Show("please write the Feedback.");
                return;
            }

            try
            {
                feedback._DoctorID = (int)Doctors.SelectedValue;
                feedback._PatientID = patientID;
                feedback._theFeedBack = feedbacktxtbox.Text;

                int r =feedback.addfeedback();
                if (r == 0) { MessageBox.Show("wrong insertion , try again ");
                    return; 
                }
                else { MessageBox.Show("success insertion "); 
                    return;
                }

            }
            catch (Exception ex) { MessageBox.Show($"Error adding Feedback: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }



        }

        private void PateintFeedbacks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Doctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Doctors.SelectedIndex < 0)
            {
                PateintFeedbacks.DataSource = null;
                return;
            }
            doctor._UserID = (int)Doctors.SelectedValue;
            DataTable dt = doctor.getfeedback();
            if (dt == null || dt.Rows.Count <= 0)
            {
                MessageBox.Show("there aren't Feedbacks For this doctor");
                return;
            }
            Doctors.ValueMember = "UserID";
            Doctors.DisplayMember = "FirstName";
            PateintFeedbacks.DataSource = dt;
            PateintFeedbacks.Refresh();

        }
     


        private void Hospitals_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!Hospitals.Enabled || Hospitals.SelectedIndex < 0)
            {
                Doctors.Enabled = false;
                return;
            }
            Doctors.Enabled = true;
            hospital._PlaceID = (int)(Hospitals.SelectedValue);
            DataTable dt = hospital.GetDoctorsInDepartment((int)(Departments.SelectedValue));
            Doctors.DataSource = dt;
        }

        private void Departments_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Departments.SelectedIndex < 0)
            {
                Hospitals.Enabled = false;
                return;
            }
            Hospitals.ValueMember = "PlaceID";
            Hospitals.DisplayMember = "PlaceName";
            Hospitals.Enabled = true;
            Department._DepartmentID = (int)(Departments.SelectedValue);
            DataTable dt = Department.GetAllHospitals();
            Hospitals.DataSource = dt;

        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevform.Show();
        }
    }
}
