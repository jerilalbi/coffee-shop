using Starbucks.domain.admin;
using Starbucks.infrastructure.components;
using Starbucks.presentation.admin.dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.presentation.admin.dash_employee
{
    public partial class Dash_Employ : UserControl
    {
        public static int emp_num;
        public static Dash_Employ employ;
        public Dash_Employ()
        {
            employ = this;
            InitializeComponent();
        }

        private void Dash_Employ_Load(object sender, EventArgs e)
        {
            int count = 0;
            AdminDbOP dbOP = new AdminDbOP();
            SqlDataReader empNoData = dbOP.adminDataFetchQuery($"select count(name) as emp_no from login where userType='employee'");
            if (empNoData.Read())
            {
                emp_num = int.Parse(empNoData["emp_no"].ToString());
                emp_no_label.Text = $"{emp_num}";
                empNoData.Close();
            }

            empDisplayPanel.Controls.Clear();

            SqlDataReader empData = dbOP.adminDataFetchQuery($"select * from login where userType='employee'");
            while (empData.Read())
            {
                empDisplayPanel.Controls.Add(new Employee_Tile
                {
                    EmpName = empData["name"].ToString(),
                    EmpEmail = empData["email"].ToString(),
                    EmpPass = empData["password"].ToString(),
                    EmpPhoneNo = empData["ph_no"].ToString(),
                    EmpPlace = empData["place"].ToString(),
                    Name = $"tile{count}",
                    TileName = $"tile{count}",
                }) ;
                count++;
            }
            empData.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            dash_add_employ add_Employ = new dash_add_employ(false, "", "", "", "", "");
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Clear();
            add_Employ.BringToFront();
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Add(add_Employ);
            this.Dispose();
        }
    }
}
