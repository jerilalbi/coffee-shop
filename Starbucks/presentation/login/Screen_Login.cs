using Guna.UI2.WinForms;
using Starbucks.application.events;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Starbucks.presentation.login
{
    public partial class Screen_Login : Form
    {
        public static Screen_Login screen_Login;
        AdminLogin adminLogin = new AdminLogin();
        public Screen_Login()
        {
            InitializeComponent();
            screen_Login = this;
        }

        void userCheck()
        {
            if (user_toggle_btn.Checked)
            {
                adminLogin.isAdmin = true;
                adminLogin.adminSelect();
                adminLogin.customerSelect();
            }
            else
            {
                adminLogin.isAdmin = false;
                adminLogin.customerSelect();
                adminLogin.adminSelect();
            }
        }

        private void user_toggle_btn_CheckedChanged(object sender, EventArgs e)
        {
            userCheck();
        }


        private void continue_customer_btn_Click(object sender, EventArgs e)
        {
            screen_home home = new screen_home();
            home.Show();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.Hide();
        }
    }
}
