using HospitalAppointmentProject.UML.USERS;
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
    public partial class AddPrescription : Form
    {
        Form prevform, mainform;
        int? _UserID;
        UML.Paper.Prescription prescription;
        UML.Medicine med;
        UML.Medicine[] medarr;
        UML.USERS.sysUser patient;
        List<int> medid;
        public AddPrescription(Form prevform, Form mainform, int? _UserID)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            this._UserID = _UserID;
            med = new UML.Medicine();
            medid = new List<int>();
            comboBoxmed.DataSource = med.GetAllMedicines();
            comboBoxmed.ValueMember = "MedicineID";
           
            comboBoxmed.DisplayMember = "MedicineName";
        }

        private void addpre_hover(object sender, EventArgs e)
        {
            addpre.Cursor = Cursors.Hand;
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

        private void Addpre_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void addpre_Click(object sender, EventArgs e)
        {
            if (DName.Text == "" || Ddiscription.Text == "")
            {
                MessageBox.Show("please fill all fields");
                return;
            }
            if (listViewMed.Items.Count <= 0)
            {
                MessageBox.Show("You must add some Medicines");
                return;
            }
            medarr = new UML.Medicine[listViewMed.Items.Count];
            for (int i = 0; i < medarr.Length; i++)
            {
                medarr[i] = new UML.Medicine();
                medarr[i].MedicineID = medid[i];
            }
            patient = new sysUser(null, pEmail.Text, null, null, null, null);
            //MessageBox.Show(preDate.Value.ToString("dd/MM/yyyy hh:mm:ss"));
            prescription = new UML.Paper.Prescription(preDate.Value, null, DName.Text, patient.UserID, Ddiscription.Text, _UserID, medarr);
           int res = prescription.addprescription();
            if (res == 0)
                MessageBox.Show("there is an error while inserting the prescription");
            else
            {
                ActivityLog.AddActivityLog(_UserID.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Added A prescription");
                MessageBox.Show("the prescription inserted successfully");
            }

        }

        private void addmed_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = comboBoxmed.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                string medicineName = selectedRow["MedicineName"].ToString();
                ListViewItem newItem = new ListViewItem(medicineName);
                listViewMed.Items.Add(newItem);
                medid.Add((int)comboBoxmed.SelectedValue);
            }
            else
            {
                MessageBox.Show("No item selected.");
            }
        }

        private void addprelabel_Click(object sender, EventArgs e)
        {
            if (DName.Text == "" || Ddiscription.Text == "")
            {
                MessageBox.Show("please fill all fields");
                return;
            }
            if (listViewMed.Items.Count <= 0)
            {
                MessageBox.Show("You must add some Medicines");
                return;
            }
            medarr = new UML.Medicine[listViewMed.Items.Count];
            for (int i = 0; i < medarr.Length; i++)
            {
                medarr[i] = new UML.Medicine();
                medarr[i].MedicineID = medid[i];
            }
            patient = new sysUser(null, pEmail.Text, null, null, null, null);
            //MessageBox.Show(preDate.Value.ToString("dd/MM/yyyy hh:mm:ss"));
            prescription = new UML.Paper.Prescription(preDate.Value, null, DName.Text, patient.UserID, Ddiscription.Text, _UserID, medarr);
            int res = prescription.addprescription();
            if (res == 0)
                MessageBox.Show("there is an error while inserting the prescription");
            else
                MessageBox.Show("the prescription inserted successfully");
        }

        private void addprelabel_hover(object sender, EventArgs e)
        {
            addprelabel.Cursor = Cursors.Hand;
        }
    }
}
