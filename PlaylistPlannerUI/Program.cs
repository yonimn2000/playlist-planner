using System;
using System.Windows.Forms;

namespace YonatanMankovich.PlaylistPlannerUI
{
    static class Program
    {
        /// <summary> The main entry point for the application. </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //args = new string[] { @"C:\Users\Jonathan\OneDrive\Music", "02/02/2020 2:02:02 PM", "-3" };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(args));
        }
    }
}