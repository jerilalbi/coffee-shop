using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.presentation.login
{
    public partial class Screen_Login : Form
    {
        bool isAdmin = false;
        public Screen_Login()
        {
            InitializeComponent();
            userCheck();
        }

        void userCheck()
        {
            if (user_toggle_btn.Checked)
            {
                active_userBox_color(customer_box,customer_label);
                passive_userBox_color(admin_box,admin_label);
            }
            else
            {
                active_userBox_color(admin_box,admin_label);
                passive_userBox_color(customer_box,customer_label);
            }
            customerType();
        }

        void active_userBox_color(Guna2Panel panel,Label label)
        {
            if (isAdmin)
            {
                panel.BorderColor = Color.FromArgb(0, 192, 192);
                panel.FillColor = Color.FromArgb(0, 192, 192);
                isAdmin = !isAdmin;
            }
            else
            {
                panel.BorderColor = Color.FromArgb(0, 102, 0);
                panel.FillColor = Color.FromArgb(0, 102, 0);
                isAdmin = !isAdmin;
            }
            label.ForeColor = Color.White;
        }

        void passive_userBox_color(Guna2Panel panel,Label label)
        {
            panel.BorderColor = Color.DarkGray;
            panel.FillColor = Color.Transparent;
            label.ForeColor = Color.DarkGray;
        }

        void customerType()
        {
            if (!isAdmin)
            {
                admin_user_txtBox.Visible = true;
                admin_passwrd_txtBox.Visible = true;
                admin_login_btn.Visible = true;
                login_customer_text1.Visible = false; 
                login_customer_text2.Visible = false;
                continue_customer_btn.Visible = false;

            }
            else
            {
                admin_user_txtBox.Visible = false;
                admin_passwrd_txtBox.Visible = false;
                admin_login_btn.Visible = false;
                login_customer_text1.Visible = true;
                login_customer_text2.Visible = true;
                continue_customer_btn.Visible = true;
            }
        }

        private void Screen_Login_Load(object sender, EventArgs e)
        {

        }

        private void login_back_logo_Click(object sender, EventArgs e)
        {

        }

        private void user_toggle_btn_CheckedChanged(object sender, EventArgs e)
        {
            userCheck();
        }

        private void continue_customer_btn_Click(object sender, EventArgs e)
        {
            screen_home home_page = new screen_home();
            home_page.Show();
            this.Hide();
        }
    }
}
