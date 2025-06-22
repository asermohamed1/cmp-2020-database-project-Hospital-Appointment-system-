using HospitalAppointmentProject.UML.PLACES;
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
using UML = HospitalAppointmentProject.UML;

namespace HospitalAppointmentSystem
{
    public partial class ModifyPharmacies : Form
    {
        Form prevform, mainform;
        UML.PLACES.Pharmacy pharmacy;
        private void exitprogram_Click(object sender, EventArgs e)
        {
            mainform.Close();
            pharmacy = new UML.PLACES.Pharmacy();
        }

        private void contactus_Click(object sender, EventArgs e)
        {
            ContactUs cu = new ContactUs(this, mainform);
            this.Hide();
            cu.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevform.Show();
        }

        private void modph_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void addPh_Click(object sender, EventArgs e)
        {

            pharmacy = new UML.PLACES.Pharmacy();
            string pharmacyID = phID.Text;
            string pharmacyName = phName.Text;
            string pharmacyEmail = phEmail.Text;
            string pharmacyPhone = phPN.Text;
            string pharmacyLocation = phLoction.Text;

        
            if (string.IsNullOrEmpty(pharmacyID))
            {
                MessageBox.Show("Pharmacy ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phID.Focus();
                return;
            }
            int pid;
            if(!int.TryParse(pharmacyID,out pid)){
                MessageBox.Show("please enter valid id ");
                return;
            }

            if (string.IsNullOrEmpty(pharmacyName))
            {
                MessageBox.Show("Pharmacy Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pharmacyEmail) || !isvalidemail(pharmacyEmail))
            {
                MessageBox.Show("Enter a valid Pharmacy Email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pharmacyPhone) || !pharmacyPhone.All(char.IsDigit))
            {
                MessageBox.Show("Enter a valid Pharmacy Phone Number (digits only).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phPN.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pharmacyLocation))
            {
                MessageBox.Show("Pharmacy Location is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phLoction.Focus();
                return;
            }

            try
            {
              
                pharmacy._Email = pharmacyEmail; 
                pharmacy._PlaceID = pid;
                pharmacy._PlaceLocation=pharmacyLocation;
                pharmacy._PhoneNumber=pharmacyPhone;
                pharmacy._PlaceName=pharmacyName;
                int r=pharmacy.insertp();
                if (r == 0) { MessageBox.Show("wrong insertion , try again "); return; }
                else { MessageBox.Show("success insertion "); return; }

            }
            catch(Exception ex) { MessageBox.Show($"Error adding pharmacy: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private bool isvalidemail(string pharmacyEmail)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(pharmacyEmail, emailPattern);

        }

        private void Updateph_Click(object sender, EventArgs e)
        {

            pharmacy = new UML.PLACES.Pharmacy();
            string pharmacyID = phID.Text;
            string pharmacyName = phName.Text;
            string pharmacyEmail = phEmail.Text;
            string pharmacyPhone = phPN.Text;
            string pharmacyLocation = phLoction.Text;

            if (string.IsNullOrEmpty(pharmacyID))
            {
                MessageBox.Show("Pharmacy ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phID.Focus();
                return;
            }
            int pid;
            if (!int.TryParse(pharmacyID, out pid))
            {
                MessageBox.Show("please enter valid id ");
                return;
            }
            
            bool pharmacyExists = pharmacy.CheckIfPharmacyExists(pid);
            if (!pharmacyExists)
            {
                MessageBox.Show("Pharmacy with this ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                pharmacy._PlaceID = pid;    
                int updateResult = 0;
                if (!string.IsNullOrEmpty(pharmacyLocation))
                {
                    pharmacy.PlaceLocation=pharmacyLocation;
                    if (pharmacy._PlaceLocation != null)
                    {
                        updateResult++;
                    }
                }

                if (!string.IsNullOrEmpty(pharmacyPhone))
                {
                    pharmacy.PhoneNumber=pharmacyPhone;
                    if (pharmacy._PhoneNumber != null)
                    {
                        updateResult++;
                    }
                }
                if (!string.IsNullOrEmpty(pharmacyEmail))
                {
                    pharmacy.Email = pharmacyEmail;
                    if (pharmacy._Email != null)
                    {
                        updateResult++;
                    }
                }
                if (!string.IsNullOrEmpty(pharmacyName))
                {
                    pharmacy.PlaceName = pharmacyName;
                    if (pharmacy._PlaceName != null)
                    {
                        updateResult++;
                    }
                }
            
                if (updateResult == 0)
                {
                    MessageBox.Show("No updates made or invalid data provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return ;
                }
                else
                {
                    MessageBox.Show("Pharmacy details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return ;    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating pharmacy: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void delph_Click(object sender, EventArgs e)
        {
            pharmacy = new UML.PLACES.Pharmacy();
            string pharmacyID = delphid.Text;
            if (string.IsNullOrEmpty(pharmacyID))
            {
                MessageBox.Show("Pharmacy ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                delphid.Focus();
                return;
            }
            int pid;
            if (!int.TryParse(pharmacyID, out pid))
            {
                MessageBox.Show("please enter valid id ");
                return;
            }

            bool pharmacyExists = pharmacy.CheckIfPharmacyExists(pid);
            if (!pharmacyExists)
            {
                MessageBox.Show("Pharmacy with this ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                pharmacy._PlaceID = pid;
                int deleteResult = pharmacy.deletePharmacy();

                if (deleteResult == 0)
                {
                    MessageBox.Show("Error deleting the pharmacy. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Pharmacy deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting pharmacy: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public ModifyPharmacies(Form prevform, Form mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.prevform = prevform;
        }



    }
}
