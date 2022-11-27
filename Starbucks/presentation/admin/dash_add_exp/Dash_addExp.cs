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

namespace Starbucks.presentation.admin.dash_add_exp
{
    public partial class Dash_addExp : UserControl
    {
        public Dash_addExp()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AdminDbOP dbOP = new AdminDbOP();
            bool expAdded = dbOP.expAdd(exp_type.Text.ToLower(),int.Parse(exp_amount.Text.ToString()));
            if (expAdded)
            {
                addFunction();
            }
        }

         async void addFunction()
        {
            add_btn.Text = "ADDED";
            add_btn.FillColor = Color.Blue;
            await Task.Delay(2000);
            add_btn.Text = "ADD";
            add_btn.FillColor = Color.FromArgb(0, 102, 0);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Dash_Exp dash_Exp = new Dash_Exp();
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Clear();
            dash_Exp.BringToFront();
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Add(dash_Exp);
            this.Dispose();
        }
    }
}
