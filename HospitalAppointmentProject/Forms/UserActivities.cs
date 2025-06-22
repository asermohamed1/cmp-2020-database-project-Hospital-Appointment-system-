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
    public partial class UserActivities : Form
    {
        Form prevform, mainform;
        UML.USERS.ActivityLog activityLog;  
        private void exitprogram_Click(object sender, EventArgs e)
        {
            mainform.Close();
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

        private void ua_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void startingtime_ValueChanged(object sender, EventArgs e)
        {
            activityLog = new UML.USERS.ActivityLog();
            string selectedTime = startingtime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            if (string.IsNullOrEmpty(selectedTime))
            {
                MessageBox.Show("Please select a date first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                activityLog._DatenTime = selectedTime;
            DataTable dt = activityLog.getallactivities();
                if (dt != null && dt.Rows.Count > 0)
                {
                    activityforallusers.DataSource = dt;
                    activityforallusers.Refresh();
                }
                else {
                    MessageBox.Show("No activities found after the selected time.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    activityforallusers.DataSource = null;
                }
            }
            catch (Exception ex) {
            
                    MessageBox.Show($"Error returning activities: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void UserID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void GetActivityForuser_Click(object sender, EventArgs e)
        {

            activityLog = new UML.USERS.ActivityLog();
            string id = UserIDtextbox.Text;
            if (string.IsNullOrEmpty(id)) { 
                MessageBox.Show("Please enter a User ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(id, out int uid))
            {
                MessageBox.Show("Please enter a valid integer User ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                activityLog._UserID = uid;
                DataTable dt = activityLog.getcertainactivities();
                if (dt != null && dt.Rows.Count > 0)
                {
                    activityforcertainuser.DataSource = dt;
                    activityforcertainuser.Refresh();
                }
                else
                {
                    MessageBox.Show("No activities found for this user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    activityforcertainuser.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving activities: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void activityforallusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public UserActivities(Form prevform, Form mainform)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
        }
    }
}
