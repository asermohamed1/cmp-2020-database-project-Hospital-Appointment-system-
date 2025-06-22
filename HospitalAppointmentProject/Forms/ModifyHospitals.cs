using HospitalAppointmentProject.UML.PLACES;
using HospitalAppointmentProject.UML.USERS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UML = HospitalAppointmentProject.UML;
namespace HospitalAppointmentSystem
{
    public partial class ModifyHospitals : Form
    {
        Form prevform, mainform;
        TextBox []feilds;
        UML.PLACES.Hospital hospital;

        private void Home_Click(object sender, EventArgs e)
        {
            prevform.Show();
            this.Hide();
        }

        private void modHos_close(object sender, FormClosedEventArgs e)
        {
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
        private bool isfilled(TextBox to)
        {
            if (to.Text == "")
                return false;
            return true;
        }
        private void AddHos_Click(object sender, EventArgs e)
        {
            hospital = new UML.PLACES.Hospital();
            string hospitalID = HosID.Text;
            string hospitalName = HosName.Text;
            string hospitalEmail = HosEmail.Text;
            string hospitalPhone = HosPN.Text;
            string hospitalLocation = HosLocation.Text;
            if (string.IsNullOrEmpty(hospitalID))
            {
                MessageBox.Show("Hospital ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HosID.Focus();
                return;
            }
            int hid;
            if (!int.TryParse(hospitalID, out hid))
            {
                MessageBox.Show("please enter valid id ");
                return;
            }

            if (string.IsNullOrEmpty(hospitalName))
            {
                MessageBox.Show("Hospital Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HosName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(hospitalEmail) || !isvalidemail(hospitalEmail))
            {
                MessageBox.Show("Enter a valid Hospital Email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HosEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(hospitalPhone) || !hospitalPhone.All(char.IsDigit))
            {
                MessageBox.Show("Enter a valid Hospital Phone Number (digits only).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HosPN.Focus();
                return;
            }
            if (string.IsNullOrEmpty(hospitalLocation))
            {
                MessageBox.Show("Hospital Location is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HosLocation.Focus();
                return;
            }
            try {
                hospital._Email = hospitalEmail;
                hospital._PlaceID = hid;
                hospital._PlaceLocation = hospitalLocation;
                hospital._PhoneNumber = hospitalPhone;
                hospital._PlaceName = hospitalName;
                int r = hospital.inserthospital();
                if (r == 0) { MessageBox.Show("wrong insertion , try again "); return; }
                else { MessageBox.Show("success insertion "); return; }
            }
            catch(Exception ex) { MessageBox.Show($"Error adding Hospital: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private bool isvalidemail(string HospitalEmail)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(HospitalEmail, emailPattern);
        }

        private void UpHos_Click(object sender, EventArgs e)
        {
            hospital = new UML.PLACES.Hospital();
            string HospitalID = HosID.Text;
            string HospitalName = HosName.Text;
            string HospitalEmail = HosEmail.Text;
            string HospitalPhone = HosPN.Text;
            string HospitalLocation = HosLocation.Text;

            if (string.IsNullOrEmpty(HospitalID))
            {
                MessageBox.Show("Hospital ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HosID.Focus();
                return;
            }
            int hid;
            if (!int.TryParse(HospitalID, out hid))
            {
                MessageBox.Show("please enter valid id ");
                return;
            }

            bool HospitalExists = hospital.CheckIfHospitalExists(hid);
            if (!HospitalExists)
            {
                MessageBox.Show("Hospital with this ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
               hospital._PlaceID = hid;
                int updateResult = 0;
                if (!string.IsNullOrEmpty(HospitalLocation))
                {
                    hospital.PlaceLocation = HospitalLocation;
                    if (hospital._PlaceLocation != null)
                    {
                        updateResult++;
                    }
                }

                if (!string.IsNullOrEmpty(HospitalPhone))
                {
                    hospital.PhoneNumber = HospitalPhone;
                    if (hospital._PhoneNumber != null)
                    {
                        updateResult++;
                    }
                }
                if (!string.IsNullOrEmpty(HospitalEmail))
                {
                    hospital.Email = HospitalEmail;
                    if (hospital._Email != null)
                    {
                        updateResult++;
                    }
                }
                if (!string.IsNullOrEmpty(HospitalName))
                {
                    hospital.PlaceName = HospitalName;
                    if (hospital._PlaceName != null)
                    {
                        updateResult++;
                    }
                }

                if (updateResult == 0)
                {
                    MessageBox.Show("No updates made or invalid data provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Hospital details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Hospital: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void delHos_Click(object sender, EventArgs e)
        {
            hospital = new UML.PLACES.Hospital();
            string HospitalID = delHosID.Text;
            if (string.IsNullOrEmpty(HospitalID))
            {
                MessageBox.Show("Pharmacy ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                delHosID.Focus();
                return;
            }
            int hid;
            if (!int.TryParse(HospitalID, out hid))
            {
                MessageBox.Show("please enter valid id ");
                return;
            }

            bool HospitalExists = hospital.CheckIfHospitalExists(hid);
            if (!HospitalExists)
            {
                MessageBox.Show("Hospital with this ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                hospital._PlaceID = hid;
                int deleteResult = hospital.deletehospital();

                if (deleteResult == 0)
                {
                    MessageBox.Show("Error deleting the Hospital. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Hopital deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting Hospital: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ModifyHospitals(Form prevform, Form mainform)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            feilds = new TextBox[] { HosID, HosName, HosPN, HosEmail, HosLocation };
        }
    }
}
