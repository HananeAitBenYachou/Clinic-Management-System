using ClinicManagementSystem.ManageAppointments;
using ClinicManagementSystem.ManageDoctors;
using ClinicManagementSystem.ManageMedicalRecords;
using ClinicManagementSystem.ManagePatients;
using ClinicManagementSystem.ManagePeople;
using ClinicManagementSystem.ManageSpecialities;
using ClinicManagementSystem.ManageUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           frmLogin LoginForm = new frmLogin();

            Application.Run(LoginForm);

            if (LoginForm.IsLoginSucceeded)
            {
                Application.Run(new frmMain());
            }

        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();


    }
}
