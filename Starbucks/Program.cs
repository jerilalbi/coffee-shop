using Starbucks.presentation.admin.dashboard;
using Starbucks.presentation.login;
using Starbucks.presentation.product;
using System;
using System.Windows.Forms;

namespace Starbucks
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Screen_Dashboard());
        }
    }
}

// form size 1439, 781