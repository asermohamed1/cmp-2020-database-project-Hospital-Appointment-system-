using HospitalAppointmentProject.UML.USERS;
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
    public partial class ManagePharmacy : Form
    {
        Form prevform, mainform;
        UML.USERS.PharmacyManager pm;
        int startingfull;
        int? phman;
        public ManagePharmacy(Form prevform, Form mainform, int? id)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            phman = id;
            pm = new UML.USERS.PharmacyManager(phman);
            startingfull = 0;
            string opendays = pm.getopendays();
            for (int i = 0; i <= opendays.Length - 3; i += 3)
            {
                string chunk = opendays.Substring(i, 3);
                if (chunk == "fri")
                {
                    fri.Checked = true;
                }
                else if (chunk == "sun")
                {
                    sun.Checked = true;
                }
                else if (chunk == "sat")
                {
                    sat.Checked = true;
                }
                else if (chunk == "mon")
                {
                    mon.Checked = true;
                }
                else if (chunk == "tue")
                {
                    tues.Checked = true;
                }
                else if (chunk == "wed")
                {
                    weden.Checked = true;
                }
                else if (chunk == "thu")
                {
                    thur.Checked = true;
                }
            }
            int f = pm.getavailbility();
            if (f == 1)
                pharmacyisAVAcheckBox1.Checked = true;

            string starttime = pm.getstarttime();
            Timfrom.Text = starttime;
            string endtime = pm.getendtime();
            timeto.Text = endtime;

            startingfull = 1;
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

        private void ManagePharmacy_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (startingfull == 1)
            {
                pm.changeavailbility(pharmacyisAVAcheckBox1.Checked);
            }
        }

        private void sat_CheckedChanged(object sender, EventArgs e)
        {

            if (startingfull == 1)
            {
                string opendays = pm.getopendays();
                if (sat.Checked == true)
                {

                    opendays += "sat";
                    pm.pushday(opendays);
                }
                else
                {

                    for (int i = 0; i <= opendays.Length - 3; i += 3)
                    {
                        string chunk = opendays.Substring(i, 3);
                        if (chunk == "sat")
                        {
                            string opendays1 = opendays.Remove(i, 3);
                            pm.pushday(opendays1);
                            break;
                        }
                    }

                }
            }

        }

        private void sun_CheckedChanged(object sender, EventArgs e)
        {
            if (startingfull == 1)
            {
                string opendays = pm.getopendays();
                if (sun.Checked == true)
                {

                    opendays += "sun";
                    pm.pushday(opendays);
                }
                else
                {

                    for (int i = 0; i <= opendays.Length - 3; i += 3)
                    {
                        string chunk = opendays.Substring(i, 3);
                        if (chunk == "sun")
                        {
                            string opendays1 = opendays.Remove(i, 3);
                            pm.pushday(opendays1);

                            break;
                        }
                    }
                }
            }
        }

        private void mon_CheckedChanged(object sender, EventArgs e)
        {

            if (startingfull == 1)
            {
                string opendays = pm.getopendays();
                if (mon.Checked == true)
                {

                    opendays += "mon";
                    pm.pushday(opendays);
                }
                else
                {

                    for (int i = 0; i <= opendays.Length - 3; i += 3)
                    {
                        string chunk = opendays.Substring(i, 3);
                        if (chunk == "mon")
                        {
                            string opendays1 = opendays.Remove(i, 3);
                            pm.pushday(opendays1);

                            break;
                        }
                    }


                }
            }

        }

        private void tues_CheckedChanged(object sender, EventArgs e)
        {
            if (startingfull == 1)
            {
                string opendays = pm.getopendays();
                if (tues.Checked == true)
                {

                    opendays += "tue";
                    pm.pushday(opendays);
                }
                else
                {

                    for (int i = 0; i <= opendays.Length - 3; i += 3)
                    {
                        string chunk = opendays.Substring(i, 3);
                        if (chunk == "tue")
                        {
                            string opendays1 = opendays.Remove(i, 3);
                            pm.pushday(opendays1);

                            break;
                        }
                    }

                }
            }
        }

        private void weden_CheckedChanged(object sender, EventArgs e)
        {

            if (startingfull == 1)
            {
                string opendays = pm.getopendays();
                if (weden.Checked == true)
                {

                    opendays += "wed";
                    pm.pushday(opendays);
                }
                else
                {

                    for (int i = 0; i <= opendays.Length - 3; i += 3)
                    {
                        string chunk = opendays.Substring(i, 3);
                        if (chunk == "wed")
                        {
                            string opendays1 = opendays.Remove(i, 3);
                            pm.pushday(opendays1);

                            break;
                        }
                    }


                }
            }

        }

        private void thur_CheckedChanged(object sender, EventArgs e)
        {
            if (startingfull == 1)
            {
                string opendays = pm.getopendays();
                if (thur.Checked == true)
                {

                    opendays += "thu";
                    pm.pushday(opendays);
                }
                else
                {

                    for (int i = 0; i <= opendays.Length - 3; i += 3)
                    {
                        string chunk = opendays.Substring(i, 3);
                        if (chunk == "thu")
                        {
                            string opendays1 = opendays.Remove(i, 3);
                            pm.pushday(opendays1);

                            break;
                        }
                    }


                }
            }
        }

        private void fri_CheckedChanged(object sender, EventArgs e)
        {
            if (startingfull == 1)
            {
                string opendays = pm.getopendays();
                if (fri.Checked == true)
                {
                    opendays += "fri";
                    pm.pushday(opendays);
                }
                else
                {

                    for (int i = 0; i <= opendays.Length - 3; i += 3)
                    {
                        string chunk = opendays.Substring(i, 3);
                        if (chunk == "fri")
                        {
                            string opendays1 = opendays.Remove(i, 3);
                            pm.pushday(opendays1);

                            break;
                        }
                    }

                }
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (startingfull == 1)
            {
                int timefrom, timetoc;
                if (int.TryParse(Timfrom.Text, out timefrom) && int.TryParse(timeto.Text, out timetoc))
                {
                    if (timefrom >= 0 && timetoc > 0 && timetoc < 24 && timefrom <= timetoc)
                    {
                        pm.changetime(timefrom, timetoc);

                    }
                    else
                        MessageBox.Show("fill positive number please");
                }
                else
                {
                    MessageBox.Show("fill number please");

                }
            }
        }

        private void upph_Click(object sender, EventArgs e)
        {
            bool f = false;
            if (phName.Text != "")
            {
                pm.pushPhName(phName.Text);
                f = true;
            }
            if (phEmail.Text != "")
            {
                pm.pushPhEmail(phEmail.Text);
                f = true;
            }
            if (phPN.Text != "")
            {
                pm.pushPhPN(phPN.Text);
                f = true;
            }
            if (phLoction.Text != "")
            {
                pm.pushPhLoction(phLoction.Text);
                f = true;
            }
            if (!f)
            {
                MessageBox.Show("please fill the fields");
            }
            else
            {
                ActivityLog.AddActivityLog(phman.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Updated Pharmacy info");
                MessageBox.Show("successful updation hospital");
            }
        }

        private void exitprogram_Click(object sender, EventArgs e)
        {
            mainform.Close();
        }
    }
}
