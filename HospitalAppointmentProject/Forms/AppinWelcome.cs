using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAppointmentSystem
{
    public partial class welcometoappin : Form
    {
        public welcometoappin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            login log = new login(this, this);
            this.Hide();
            log.Show();
        }

        private void contactus_Click(object sender, EventArgs e)
        {
            ContactUs cu = new ContactUs(this, this);
            this.Hide();
            cu.Show();
        }
        private void exitprogram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
