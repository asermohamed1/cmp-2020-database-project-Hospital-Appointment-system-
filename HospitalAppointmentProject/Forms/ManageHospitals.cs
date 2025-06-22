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
    public partial class ManageHospitals : Form
    {
        Form prevform, mainform;
        int? hosman;
        UML.USERS.HospitalManager hm;
        int startingfull;
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

        private void Manhos_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void Ava_CheckedChanged(object sender, EventArgs e)
        {
            if (startingfull == 1)
            {
                hm.changeavailbility(Ava.Checked);
            }
        }

        private void sat_CheckedChanged(object sender, EventArgs e)
        {

            if (startingfull == 1)
            {
                string opendays = hm.getopendays();
                if (sat.Checked == true)
                {

                    opendays += "sat";
                    hm.pushday(opendays);
                }
                else
                {

                    for (int i = 0; i <= opendays.Length - 3; i += 3)
                    {
                        string chunk = opendays.Substring(i, 3);
                        if (chunk == "sat")
                        {
                            string opendays1 = opendays.Remove(i, 3);
                            hm.pushday(opendays1);
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
                string opendays = hm.getopendays();
                if (sun.Checked == true)
                {

                    opendays += "sun";
                    hm.pushday(opendays);
                }
                else
                {

                    for (int i = 0; i <= opendays.Length - 3; i += 3)
                    {
                        string chunk = opendays.Substring(i, 3);
                        if (chunk == "sun")
                        {
                            string opendays1 = opendays.Remove(i, 3);
                            hm.pushday(opendays1);

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
                string opendays = hm.getopendays();
                if (mon.Checked == true)
                {

                    opendays += "mon";
                    hm.pushday(opendays);
                }
                else
                {

                    for (int i = 0; i <= opendays.Length - 3; i += 3)
                    {
                        string chunk = opendays.Substring(i, 3);
                        if (chunk == "mon")
                        {
                            string opendays1 = opendays.Remove(i, 3);
                            hm.pushday(opendays1);

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
                string opendays = hm.getopendays();
                if (tues.Checked == true)
                {

                    opendays += "tue";
                    hm.pushday(opendays);
                }
                else
                {

                    for (int i = 0; i <= opendays.Length - 3; i += 3)
                    {
                        string chunk = opendays.Substring(i, 3);
                        if (chunk == "tue")
                        {
                            string opendays1 = opendays.Remove(i, 3);
                            hm.pushday(opendays1);

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
                string opendays = hm.getopendays();
                if (weden.Checked == true)
                {

                    opendays += "wed";
                    hm.pushday(opendays);
                }
                else
                {

                    for (int i = 0; i <= opendays.Length - 3; i += 3)
                    {
                        string chunk = opendays.Substring(i, 3);
                        if (chunk == "wed")
                        {
                            string opendays1 = opendays.Remove(i, 3);
                            hm.pushday(opendays1);

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
                string opendays = hm.getopendays();
                if (thur.Checked == true)
                {

                    opendays += "thu";
                    hm.pushday(opendays);
                }
                else
                {

                    for (int i = 0; i <= opendays.Length - 3; i += 3)
                    {
                        string chunk = opendays.Substring(i, 3);
                        if (chunk == "thu")
                        {
                            string opendays1 = opendays.Remove(i, 3);
                            hm.pushday(opendays1);

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
                string opendays = hm.getopendays();
                if (fri.Checked == true)
                {
                    opendays += "fri";
                    hm.pushday(opendays);
                }
                else
                {

                    for (int i = 0; i <= opendays.Length - 3; i += 3)
                    {
                        string chunk = opendays.Substring(i, 3);
                        if (chunk == "fri")
                        {
                            string opendays1 = opendays.Remove(i, 3);
                            hm.pushday(opendays1);

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
                        hm.changetime(timefrom, timetoc);

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

        private void upHos_Click(object sender, EventArgs e)
        {
            bool f = false;
            if (HosName.Text != "")
            {
                hm.pushHosName(HosName.Text);
                f = true;
            }
            if (HosEmail.Text != "")
            {
                hm.pushHosEmail(HosEmail.Text);
                f = true;
            }
            if (HosPN.Text != "")
            {
                hm.pushHosPN(HosPN.Text);
                f = true;
            }
            if (HosLoction.Text != "")
            {
                hm.pushHosLoction(HosLoction.Text);
                f = true;
            }
            if (!f)
            {
                MessageBox.Show("please fill the fields");
            }
            else
            {
                ActivityLog.AddActivityLog(hosman.Value, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), "Updated Hospital Info");
                MessageBox.Show("successful updation hospital");
            }
        }

        public ManageHospitals(Form prevform, Form mainform, int? userID)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            hosman = userID;
            hm = new UML.USERS.HospitalManager(hosman);
            startingfull = 0;
            string opendays = hm.getopendays();
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
            int f = hm.getavailbility();
            if (f == 1) 
                Ava.Checked = true;

            string starttime = hm.getstarttime();
            Timfrom.Text = starttime;
            string endtime = hm.getendtime();
            timeto.Text = endtime;

            startingfull = 1;
       }
    }
}
