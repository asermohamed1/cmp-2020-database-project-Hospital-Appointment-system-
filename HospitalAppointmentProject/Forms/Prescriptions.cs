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
    public partial class Prescriptions : Form
    {
        Form prevform, mainform;
        int? patient_id;
        UML.USERS.Patient pa;
        public Prescriptions(Form prevform, Form mainform, int? pa_id)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            patient_id = pa_id;
            pa = new UML.USERS.Patient(patient_id);
            prescreptiondataGridView1.DataSource = pa.getpresforpa();
            prescreptiondataGridView1.Refresh();
            preNum.DataSource = pa.getpresid();
            preNum.DisplayMember = "Order";
            preNum.ValueMember = "prescriptionID";


            selmedcomboBox1.DataSource = pa.getallmeds();
            selmedcomboBox1.DisplayMember = "medicinename";
            selmedcomboBox1.ValueMember = "medicineid";
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

        private void pre_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void Prescriptions_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (preNum.SelectedIndex >= 0)
            {
                medicinedataGridView1.DataSource = pa.getmedsinpres((int)preNum.SelectedValue);
                medicinedataGridView1.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selmedcomboBox1.SelectedIndex >= 0)
            {
                Pharmacies.DataSource = pa.getpharhavemed((int)selmedcomboBox1.SelectedValue);
                Pharmacies.Refresh();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
