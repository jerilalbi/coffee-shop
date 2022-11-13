using Guna.UI2.WinForms;
using Starbucks.application.events;
using Starbucks.domain.admin;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Starbucks.presentation.login
{
    public partial class Screen_Login : Form
    {
        public static Screen_Login screen_Login;
        
        public Screen_Login()
        {
            InitializeComponent();
            screen_Login = this;
        }

        void userCheck()
        {
            AdminLogin adminLogin = new AdminLogin();
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

        private void admin_login_btn_Click(object sender, EventArgs e)
        {
            if(validate(admin_user_txtBox, false) && validate(admin_passwrd_txtBox, true))
            {
                Login login = new Login();
               bool result = login.adminLogin(admin_user_txtBox.Text,admin_passwrd_txtBox.Text);
                if (result)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Hide();
                }
            }
            
            
        }

        bool validate(Guna2TextBox textbox,bool ispassword)
        {
            if (ispassword)
            {
                if(textbox.Text.Trim() == "")
                {
                    textbox.BorderColor = Color.Red;
                    textbox.PlaceholderForeColor = Color.Red;
                    textbox.PlaceholderText = "Enter a password";
                    return false;
                }
                else
                {
                    textbox.BorderColor = Color.FromArgb(0, 192, 192);
                    return true;
                }
            }
            else
            {

                if (textbox.Text.Trim() == "")
                {
                    textbox.BorderColor = Color.Red;
                    textbox.PlaceholderForeColor = Color.Red;
                    textbox.PlaceholderText = "Enter an Username";
                    return false;
                }
                else {
                    textbox.BorderColor = Color.FromArgb(0, 192, 192);
                    return true;
                }
            }
           
        }
    }
}
