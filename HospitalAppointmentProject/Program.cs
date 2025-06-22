using DBapplication;
using HospitalAppointmentProject.UML.USERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAppointmentSystem;
namespace HospitalAppointmentProject
{
    internal static class Program
    {

        //use DataBase.Manager.ExecuteReader(query);
        //if not working use the required namwspace (using DBapplication;)

        // Example
        // how to call querys inside the pateint form 

        //Patient p = new Patient();
        //p.UserID = 1;
        //p.LogIn();
        //then use P.UpdatedValue if any
        //if there is no updated values just put it as the return type of ur function

        //add a constructors in any class as u need if it would make u faster
        //or just use the constructor i provided with nulls => ie.(patientID,null,PatienLastName) "just include the values u need"

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new welcometoappin());
        }
    }
}
