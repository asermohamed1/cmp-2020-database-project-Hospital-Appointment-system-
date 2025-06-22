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
    public partial class HospitalManager : Form
    {
        Form mainform;
        int? _UserID;
        UML.USERS.sysUser user;

        public HospitalManager(Form mainForm, int? userID)
        {
            InitializeComponent();
            mainform = mainForm;
            _UserID = userID;
            user = new UML.USERS.sysUser(_UserID);

        }

        private void manHoslabel_hover(object sender, EventArgs e)
        {
            manHoslabel.Cursor = Cursors.Hand;
        }

        private void manHos_hover(object sender, EventArgs e)
        {
            manHos.Cursor = Cursors.Hand;
        }

        private void adddoclabel_hover(object sender, EventArgs e)
        {
            adddoclabel.Cursor = Cursors.Hand;
        }

        private void adddoc_hover(object sender, EventArgs e)
        {
            addDoc.Cursor = Cursors.Hand;
        }

        private void fireDoc_hover(object sender, EventArgs e)
        {
            fireDoc.Cursor = Cursors.Hand;
        }

        private void fireDoclabel_hover(object sender, EventArgs e)
        {
            fireDoclabel.Cursor = Cursors.Hand;
        }

        private void manHos_Click(object sender, EventArgs e)
        {
            ManageHospitals MH = new ManageHospitals(this, mainform, _UserID);
            this.Hide();
            MH.Show();

        }

        private void manHoslabel_Click(object sender, EventArgs e)
        {
            ManageHospitals MH = new ManageHospitals(this, mainform, _UserID);
            this.Hide();
            MH.Show();
        }

        private void addDoc_Click(object sender, EventArgs e)
        {
            HireDoctor HD = new HireDoctor(this, mainform, _UserID);
            this.Hide();
            HD.Show();
        }

        private void adddoclabel_Click(object sender, EventArgs e)
        {
            HireDoctor HD = new HireDoctor(this, mainform, _UserID);
            this.Hide();
            HD.Show();
        }

        private void fireDoc_Click(object sender, EventArgs e)
        {
            FireDoctor FD = new FireDoctor(this, mainform, _UserID);
            this.Hide();
            FD.Show();
        }

        private void fireDoclabel_Click(object sender, EventArgs e)
        {
            FireDoctor FD = new FireDoctor(this, mainform, _UserID);
            this.Hide();
            FD.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {

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

        private void ManHos_close(object sender, FormClosedEventArgs e)
        {
            mainform.Close();
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

        private void HospitalManager_Load(object sender, EventArgs e)
        {

        }
    }
}
