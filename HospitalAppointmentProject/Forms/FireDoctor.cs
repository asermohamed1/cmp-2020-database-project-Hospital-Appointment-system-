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


namespace HospitalAppointmentSystem
{
    public partial class FireDoctor : Form
    {
        Form prevform, mainform;
        int? hosman;
        UML.USERS.HospitalManager hm;
        public FireDoctor(Form prevform, Form mainform, int? userID)
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

        private void firedoclabel_hover(object sender, EventArgs e)
        {
            firedoclabel.Cursor = Cursors.Hand;
        }

        private void firedoc_hover(object sender, EventArgs e)
        {
            firedoc.Cursor = Cursors.Hand;
        }

        private void updoc_hover(object sender, EventArgs e)
        {
            updoc.Cursor = Cursors.Hand;
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

        private void contactus_Click(object sender, EventArgs e)
        {

            ContactUs cu = new ContactUs(this, mainform);
            this.Hide();
            cu.Show();
        }

        private void firedoc_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocFName.Text != "" && DocLName.Text != "")
            {
                DoctorsSearch.DataSource = hm.getdocinhos(DocFName.Text, DocLName.Text);
                DoctorsSearch.Refresh();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            int age;
            int id;
            if (int.TryParse(DocAge.Text, out age) && fnameDoc.Text != "" && lnameDoc.Text != "" && int.TryParse(DocIdtextBox1.Text, out id))
            {
                if (age > 0 && id > 0)
                {
                    hm.updatedoctor(fnameDoc.Text, lnameDoc.Text, age, id);

                    DocDatagroupBox1.Enabled = false;
                    DocAge.Text = "";
                    fnameDoc.Text = "";
                    lnameDoc.Text = "";
                }
                else
                    MessageBox.Show("fill age or id with positive value");
            }
            else
            {
                MessageBox.Show("fill all fields correct");
            }
        }

        private void firedoc_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(DocIdtextBox1.Text, out id))
            {
                if (id > 0)
                    hm.deleteDoctor(id);
                else
                    MessageBox.Show("fill id with positive value");

            }
            firedoclabel.Cursor = Cursors.Hand;
        }

        private void updoc_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(DocIdtextBox1.Text, out id))
            {
                if (id > 0)
                    DocDatagroupBox1.Enabled = true;
                else
                    MessageBox.Show("fill id with positive value");
            }
        }

        private void departmentcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(departmentcomboBox1.SelectedValue.ToString(), out id))
            {
                DoctorsinDeps.DataSource = hm.getdoctorsdep(id);
                DoctorsinDeps.Refresh();
            }
        }

        private void updoclabel_hover(object sender, EventArgs e)
        {
            updoclabel.Cursor = Cursors.Hand;
        }
    }
}
