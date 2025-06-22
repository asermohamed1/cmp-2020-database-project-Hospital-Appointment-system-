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
    public partial class PharmacyManager : Form
    {
        Form mainform;
        int? _UserID;
        UML.USERS.sysUser user;

        public PharmacyManager(Form mainform, int? userID)
        {
            InitializeComponent();
            this.mainform = mainform;
            _UserID = userID;
            user = new UML.USERS.sysUser(_UserID);

        }

        private void manphlabel_hover(object sender, EventArgs e)
        {
            manphlabel.Cursor = Cursors.Hand;
        }

        private void manph_hover(object sender, EventArgs e)
        {
            manph.Cursor = Cursors.Hand;
        }

        private void manmedlabel_hover(object sender, EventArgs e)
        {
            manmedlabel.Cursor = Cursors.Hand;
        }

        private void manmed_hover(object sender, EventArgs e)
        {
            manmed.Cursor = Cursors.Hand;
        }

        private void phman_close(object sender, FormClosedEventArgs e)
        {
            mainform.Close();
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

        private void manph_Click(object sender, EventArgs e)
        {
            ManagePharmacy mph = new ManagePharmacy(this, mainform, _UserID);
            this.Hide();
            mph.Show();
        }

        private void manphlabel_Click(object sender, EventArgs e)
        {
            ManagePharmacy mph = new ManagePharmacy(this, mainform, _UserID);
            this.Hide();
            mph.Show();
        }

        private void manmed_Click(object sender, EventArgs e)
        {
            medicines med = new medicines(this, mainform, _UserID);
            this.Hide();
            med.Show();
        }

        private void manmedlabel_Click(object sender, EventArgs e)
        {
            medicines med = new medicines(this, mainform, _UserID);
            this.Hide();
            med.Show();
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YourProfile yp = new YourProfile(this, mainform, _UserID);
            this.Hide();
            yp.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform.Show();
        }

        private void removeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
