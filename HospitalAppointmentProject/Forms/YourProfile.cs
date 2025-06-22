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
    public partial class YourProfile : Form
    {
        Form prevform, mainform;
        UML.USERS.sysUser user;
        int? _UserID;
        public YourProfile(Form prevform, Form mainform, int? _UserID)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            this._UserID = _UserID;
            user = new UML.USERS.sysUser(_UserID);
        }

        private void upprolabel_hover(object sender, EventArgs e)
        {
            upprolabel.Cursor = Cursors.Hand;
        }

        private void uppro_hover(object sender, EventArgs e)
        {
            uppro.Cursor = Cursors.Hand;
        }

        private void YourProfile_Load(object sender, EventArgs e)
        {
            DataTable dt = user.getusreinfo();
            if (dt != null)
            {
                email.Text = dt.Rows[0]["Email"].ToString();
                Fn.Text = dt.Rows[0]["FirstName"].ToString();
                Ln.Text = dt.Rows[0]["LastName"].ToString();
                age.Text = dt.Rows[0]["Age"].ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Fn.Enabled = true;
                Ln.Enabled = true;
                age.Enabled = true;
            }
            else
            {
                Fn.Enabled = false;
                Ln.Enabled = false; 
                age.Enabled = false;
            }
        }

        private void uppro_Click(object sender, EventArgs e)
        {
            user._First_Name = Fn.Text;
            user._Last_Name = Ln.Text;
            int ag;
            if (!int.TryParse(age.Text, out ag))
            {
                MessageBox.Show("age must be a number");
                return;
            }
            user._Age = ag;
            bool flag = user.updateYourprofile();
            if (flag)
            {
                MessageBox.Show("there is an error while updating");
            }
            else
            {
                MessageBox.Show("the data updated syccessfully");

            }

        }

        private void upprolabel_Click(object sender, EventArgs e)
        {
            user.First_Name = Fn.Text;
            user.Last_Name = Ln.Text;
            int ag;
            if (!int.TryParse(age.Text, out ag))
            {
                MessageBox.Show("age must be a number");
                return;
            }
            user.Age = ag;
        }

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

        private void your_profileclose(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void chpass_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile(this, mainform, _UserID);
            ep.Show();
           this.Hide();
        }
    }
}
