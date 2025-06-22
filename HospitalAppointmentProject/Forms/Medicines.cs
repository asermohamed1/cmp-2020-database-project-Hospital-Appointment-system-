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
    public partial class medicines : Form
    {
        Form prevform, mainform;
        UML.USERS.PharmacyManager pm;
        int? phman;
        public medicines(Form prevform, Form mainform, int? id)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            phman = id;
            pm = new UML.USERS.PharmacyManager(phman);

            MedinStock.DataSource = pm.getmidinstock();
            MedinStock.Refresh();

            ListOfMed.DataSource = pm.getallmedicines();
            ListOfMed.DisplayMember = "MedicineName";
            ListOfMed.ValueMember = "MedicineId";
        }

        private void greeting_Click(object sender, EventArgs e)
        {

        }

        private void upmedlabel_hover(object sender, EventArgs e)
        {
            upmedlabel.Cursor = Cursors.Hand;
        }

        private void upmed_hover(object sender, EventArgs e)
        {
            upmed.Cursor = Cursors.Hand;

        }

        private void addmedlabel_hover(object sender, EventArgs e)
        {
            addmedlabel.Cursor = Cursors.Hand;
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

        private void Med_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void medicines_Load(object sender, EventArgs e)
        {

        }

        private void upmed_Click(object sender, EventArgs e)
        {
            int quan;
            if (ListOfMed.SelectedIndex >= 0 && int.TryParse(Medamount.Text, out quan))
            {
                if (quan > 0)
                {
                    pm.updatemed((int)ListOfMed.SelectedValue, quan);
                    MedinStock.DataSource = pm.getmidinstock();
                    MedinStock.Refresh();
                }
                else
                {
                    MessageBox.Show("quantity must be positive value");
                }
            }
            else
            {
                MessageBox.Show("fill all fields correctly");
            }
        }

        private void addMed_Click(object sender, EventArgs e)
        {
            int quan;
            if (ListOfMed.SelectedIndex >= 0 && int.TryParse(Medamount.Text, out quan))
            {
                if (quan > 0)
                {
                    pm.insertmed((int)ListOfMed.SelectedValue, quan);
                    MedinStock.DataSource = pm.getmidinstock();
                    MedinStock.Refresh();
                }
                else
                {
                    MessageBox.Show("quantity must be positive value");
                }
            }
            else
            {
                MessageBox.Show("fill all fields correctly");
            }
        }

        private void delmedic_Click(object sender, EventArgs e)
        {
            if (ListOfMed.SelectedIndex >= 0)
            {

                pm.deletemed((int)ListOfMed.SelectedValue);
                MedinStock.DataSource = pm.getmidinstock();
                MedinStock.Refresh();

            }
            else
            {
                MessageBox.Show("select medicine field please");
            }
        }

        private void addmed_hover(object sender, EventArgs e)
        {
            addMed.Cursor = Cursors.Hand;
        }
    }
}
