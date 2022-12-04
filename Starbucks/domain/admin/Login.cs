using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Starbucks.presentation.login;
using Starbucks.presentation.admin.dashboard;
using Starbucks.presentation.employee;

namespace Starbucks.domain.admin
{
    public class Login
    {
        public bool adminLogin(String username,String password)
        {
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM login WHERE email='{username}' AND password='{password}'", Database.con);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if(dt.Rows[0]["userType"].ToString() == "employee")
                {
                    Screen_Employee employee = new Screen_Employee();
                    employee.Show();
                    return true;
                }
                Screen_Dashboard dashboard = new Screen_Dashboard();
                dashboard.Show();
                return true;
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                return false;
            }
        }
    }
}
