using Starbucks.presentation.admin.dashboard;
using Starbucks.presentation.basket;
using Starbucks.presentation.employee;
using Starbucks.presentation.login;
using Starbucks.presentation.payment;
using Starbucks.presentation.product;
using Starbucks.presentation.summary;
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
            Application.Run(new Screen_Employee());
        }
    }
}

// form size 1439, 781