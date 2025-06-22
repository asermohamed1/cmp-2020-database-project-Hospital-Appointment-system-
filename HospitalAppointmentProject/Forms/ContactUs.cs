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
    public partial class ContactUs : Form
    {
        Form prevform;
        Form mainprogram;
        public ContactUs(Form prevform, Form mainprogram)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainprogram = mainprogram;
        }

        private void contactus_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void exitprogram_Click(object sender, EventArgs e)
        {
            mainprogram.Close();
        }

        private void manHos_Click(object sender, EventArgs e)
        {

        }
    }
}
