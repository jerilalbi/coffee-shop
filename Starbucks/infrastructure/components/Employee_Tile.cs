using Starbucks.domain.admin;
using Starbucks.presentation.admin.dash_add_prod;
using Starbucks.presentation.admin.dash_employee;
using Starbucks.presentation.admin.dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.infrastructure.components
{
    public partial class Employee_Tile : UserControl
    {
        public Employee_Tile()
        {
            InitializeComponent();
        }

        #region properties
        private string _empName;
        private string _empEmail;
        private string _empPlace;
        private string _empPass;
        private string _empPhNo;
        private string tileName;

        public string EmpName
        {
            get { return _empName; }
            set { _empName = value;
                emp_name.Text = value;
            }
        }

        public string EmpEmail
        {
            get { return _empEmail; }
            set
            {
                _empEmail = value;
                emp_email.Text = value;
            }
        }

        public string EmpPlace
        {
            get { return _empPlace; }
            set
            {
                _empPlace = value;
            }
        }

        public string EmpPhoneNo
        {
            get { return _empPhNo; }
            set
            {
                _empPhNo = value;
            }
        }

        public string EmpPass
        {
            get { return _empPass; }
            set
            {
                _empPass = value;
            }
        }

        public string TileName
        {
            get { return tileName; }
            set
            {
                tileName = value;
            }
        }

        #endregion

        private void editBtn_Click(object sender, EventArgs e)
        {
            dash_add_employ add_Employ = new dash_add_employ(true,_empName,_empPlace,_empPhNo,_empEmail,_empPass);
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Clear();
            add_Employ.BringToFront();
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Add(add_Employ);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            AdminDbOP dbOP = new AdminDbOP();
            bool result = dbOP.adminQuery($"delete from login where name = '{_empName}' and place = '{_empPlace}' and ph_no = '{_empPhNo}' and email = '{_empEmail}' and password = '{_empPass}'");
            if (result)
            {
                Dash_Employ.employ.empDisplayPanel.Controls.RemoveByKey(tileName);
                Dash_Employ.emp_num -= 1;
                Dash_Employ.employ.emp_no_label.Text = $"{Dash_Employ.emp_num}";
                Dash_Employ.employ.emp_no_label.Refresh();
            }
        }
    }
}
