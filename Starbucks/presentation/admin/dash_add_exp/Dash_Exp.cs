using Starbucks.infrastructure.components;
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
    public partial class Dash_Exp : UserControl
    {
        public Dash_Exp()
        {
            InitializeComponent();
        }

        private void Dash_Exp_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                expDisplayPanel.Controls.Add(new Expense_Tile {
                    ExpType = "Electricity",
                    ExpAmount = 100+i
                }) ;
            }
            period_combobx.SelectedIndex = 0;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Dash_addExp ad_Exp = new Dash_addExp();
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Clear();
            ad_Exp.BringToFront();
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Add(ad_Exp);
        }
    }
}
