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
    public partial class HireDoctor : Form
    {
        Form prevform, mainform;
        int? hosman;
        UML.USERS.HospitalManager hm;
        public HireDoctor(Form prevform, Form mainform, int? userID)
        {

            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            hosman = userID;
            hm = new UML.USERS.HospitalManager(hosman);
            departmentcomboBox1.DataSource = hm.gethosdepartments();
            departmentcomboBox1.DisplayMember = "DepartmentName";
            departmentcomboBox1.ValueMember = "DepartmentID";
        }

        private void adddoclabel_hover(object sender, EventArgs e)
        {
            adddoclabel.Cursor = Cursors.Hand;
        }

        private void adddoc_Click(object sender, EventArgs e)
        {
            int age;

            if (DocFName.Text != "" && DocLanme.Text != "" && int.TryParse(DocAge.Text, out age) && DocPassword.Text != "" && Docgender.Text != "" && DocEmail.Text != "" && departmentcomboBox1.SelectedIndex >= 0)
            {
                if (Docgender.Text == "Male" || Docgender.Text == "Female")
                {
                    Docgender.Text = Docgender.Text == "Male" ? "M" : "F";
                    hm.adddoctor(DocFName.Text, DocLanme.Text, age, Docgender.Text, (int)departmentcomboBox1.SelectedValue, DocEmail.Text, DocPassword.Text);

                }
                else
                {
                    MessageBox.Show("write in gender 'Male' for man or 'Female' for woman");
                }
            }
            else
            {
                MessageBox.Show("please fill all fields correctly");
            }
        }

        private void exitprogram_Click(object sender, EventArgs e)
        {
            mainform.Close();
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

        private void Hiredos_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void DocID_TextChanged(object sender, EventArgs e)
        {

        }

        private void HireDoctor_Load(object sender, EventArgs e)
        {

        }

        private void adddoc_hover(object sender, EventArgs e)
        {
            adddoc.Cursor = Cursors.Hand;
        }
    }
}
