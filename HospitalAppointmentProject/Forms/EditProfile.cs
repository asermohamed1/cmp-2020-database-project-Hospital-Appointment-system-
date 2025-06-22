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
    public partial class EditProfile : Form
    {
        Form prevform, mainform;
        int? _UserID;
        UML.USERS.sysUser user;
        public EditProfile(Form prevform, Form mainform, int? User)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            this._UserID = User;
            user = new UML.USERS.sysUser(_UserID);
        }

        private void uppass_hover(object sender, EventArgs e)
        {
            uppass.Cursor = Cursors.Hand;
        }

        private void uppasslabel_hover(object sender, EventArgs e)
        {
            uppasslabel.Cursor = Cursors.Hand;
        }
        private void uppass_Click(object sender, EventArgs e)
        {
            if (oldpass.Text == "" || newpass.Text == "" || conpass.Text == "")
            {
                MessageBox.Show("please fill all fields");
                return;
            }
            user._UserPassword = oldpass.Text;
            if (!user.checkPassword())
            {
                MessageBox.Show("please write a correct password");
            }
            else
            {
                if (newpass.Text.Length < 8)
                {
                    MessageBox.Show("the password must contain at least 8 characters");

                }
                else
                {
                    if (conpass.Text != newpass.Text)
                    {
                        MessageBox.Show("the passwords doesn't match");
                    }
                    else
                    {
                        user._UserPassword = newpass.Text;
                        int res = user.changePassword();
                        if (res != 0)
                        {
                            MessageBox.Show("the passwords updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("there is an error in updating password");
                        }
                    }
                }
            }
        }
        private void editprofile_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }
        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevform.Show();
        }
        private void exitprogram_Click(object sender, EventArgs e)
        {
            mainform.Close();
        }

        private void Home_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            prevform.Show();

        }

        private void showpass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                newpass.PasswordChar = '\0';
                conpass.PasswordChar = '\0';
                oldpass.PasswordChar = '\0';
            }
            else
            {
                newpass.PasswordChar = '\0';
                conpass.PasswordChar = '\0';
                oldpass.PasswordChar = '\0';
            }
        }

        private void exitprogram_Click_1(object sender, EventArgs e)
        {
            mainform.Close();
        }

        private void closeEditProfile(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void uppass_Click_1(object sender, EventArgs e)
        {
            if (oldpass.Text == "" || newpass.Text == "" || conpass.Text == "")
            {
                MessageBox.Show("please fill all fields");
                return;
            }
            user._UserPassword = oldpass.Text;
            if (!user.checkPassword())
            {
                MessageBox.Show("please write a correct password");
            }
            else
            {
                if (newpass.Text.Length < 8)
                {
                    MessageBox.Show("the password must contain at least 8 characters");

                }
                else
                {
                    if (conpass.Text != newpass.Text)
                    {
                        MessageBox.Show("the passwords doesn't match");
                    }
                    else
                    {
                        user._UserPassword = newpass.Text;
                        int res = user.changePassword();
                        if (res != 0)
                        {
                            MessageBox.Show("the passwords updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("there is an error in updating password");
                        }
                    }
                }
            }
        
    }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
