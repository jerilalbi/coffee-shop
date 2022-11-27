using Starbucks.domain.admin;
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

namespace Starbucks.presentation.admin.dash_employee
{
    public partial class dash_add_employ : UserControl
    {
        bool isupdate;
        string emp_name,emp_place,emp_phNo,emp_email,emp_pass;

        private void add_btn_Click(object sender, EventArgs e)
        {
            AdminDbOP dbOP = new AdminDbOP();
            if (isupdate)
            {
                bool result = dbOP.adminQuery($"update login set name = '{nameTxt.Text}', place = '{placeTxt.Text}', ph_no = '{phNumTxt.Text}', email = '{emailTxt.Text}', password = '{passTxt.Text}' where name = '{emp_name}' and place = '{emp_place}' and ph_no = '{emp_phNo}' and email = '{emp_email}' and password = '{emp_pass}'");
                if (result)
                {
                    addFunction();
                }
            }
            else
            {
                bool result = dbOP.adminQuery($"insert into login values('{nameTxt.Text}','{placeTxt.Text}','{phNumTxt.Text}','{emailTxt.Text}','{passTxt.Text}','employee')");
                if (result)
                {
                    addFunction();
                }
            }
        }
        async void addFunction()
        {
            if (isupdate)
            {
                add_btn.Text = "UPDATED";
                add_btn.FillColor = Color.Blue;
                await Task.Delay(2000);
                add_btn.Text = "UPDATE";
                add_btn.FillColor = Color.FromArgb(0, 102, 0);
            }
            else
            {
                add_btn.Text = "ADDED";
                add_btn.FillColor = Color.Blue;
                await Task.Delay(2000);
                add_btn.Text = "ADD";
                add_btn.FillColor = Color.FromArgb(0, 102, 0);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Dash_Employ employ = new Dash_Employ();
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Clear();
            employ.BringToFront();
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Add(employ);
            this.Dispose();
        }

        private void dash_add_employ_Load(object sender, EventArgs e)
        {
            updateOrAdd();
        }

        public dash_add_employ(bool isEdit,string name,string place,string phNo,string email, string password)
        {
            isupdate = isEdit;
            emp_name = name;
            emp_place = place;
            emp_phNo = phNo;
            emp_email = email;
            emp_pass = password;
            InitializeComponent();
        }

        void updateOrAdd()
        {
            if (isupdate)
            {
                nameTxt.Text = emp_name;
                placeTxt.Text = emp_place;
                emailTxt.Text = emp_email;
                phNumTxt.Text = emp_phNo;
                passTxt.Text = emp_pass;
                add_btn.Text = "UPDATE";
            }
        }
    }
}
