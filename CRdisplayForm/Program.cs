using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CRdisplayForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DisplayForm());

        }
    }
}
