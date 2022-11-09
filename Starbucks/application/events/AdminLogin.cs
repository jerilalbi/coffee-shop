using Starbucks.presentation.login;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks.application.events
{
    public class AdminLogin
    {
       public bool isAdmin = false;

        public void checkUser()
        {
            if (isAdmin)
            {
                adminSelect();
                isAdmin = !isAdmin;
            }
            else
            {
                customerSelect();
                isAdmin = !isAdmin;
            }
        }

        public void adminSelect()
        {
            Screen_Login.screen_Login.admin_box.BorderColor = isAdmin ? Color.FromArgb(0, 192, 192) : Color.DarkGray;
            Screen_Login.screen_Login.admin_box.FillColor = isAdmin ? Color.FromArgb(0, 192, 192) : Color.Transparent;
            Screen_Login.screen_Login.admin_label.ForeColor = isAdmin ? Color.White : Color.DarkGray;
            Screen_Login.screen_Login.admin_user_txtBox.Visible = isAdmin ? true : false;
            Screen_Login.screen_Login.admin_passwrd_txtBox.Visible = isAdmin ? true : false;
            Screen_Login.screen_Login.admin_login_btn.Visible = isAdmin ? true : false;
            
        }

        public void customerSelect()
        {
            Screen_Login.screen_Login.customer_box.BorderColor = isAdmin ? Color.DarkGray : Color.FromArgb(0, 102, 0);
            Screen_Login.screen_Login.customer_box.FillColor = isAdmin ? Color.Transparent : Color.FromArgb(0, 102, 0);
            Screen_Login.screen_Login.customer_label.ForeColor = isAdmin ? Color.DarkGray : Color.White;
            Screen_Login.screen_Login.login_customer_text1.Visible =  isAdmin ? false : true;
            Screen_Login.screen_Login.login_customer_text2.Visible = isAdmin ? false : true;
            Screen_Login.screen_Login.continue_customer_btn.Visible = isAdmin ? false : true;
            
        }
    }
}
