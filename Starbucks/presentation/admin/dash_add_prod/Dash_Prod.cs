using Starbucks.infrastructure.components;
using Starbucks.presentation.admin.dash_add_exp;
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

namespace Starbucks.presentation.admin.dash_add_prod
{
    public partial class Dash_Prod : UserControl
    {
        string category = "hot_coffee";
        public Dash_Prod()
        {
            InitializeComponent();
        }

        private void Dash_Prod_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                prodDisplayPanel.Controls.Add(new Dash_ProdTile
                {
                    Title = "Vanilla Frappuccino",
                    Price = 100 + i,
                }) ;
            }
            period_combobx.SelectedIndex = 0;
            category_comboBx.SelectedIndex = 0;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
           Dash_addProd addProd = new Dash_addProd();
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Clear();
            addProd.BringToFront();
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Add(addProd);
        }

        private void category_comboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (category_comboBx.SelectedIndex)
            {
                case 0: category = "hot_coffee";
                    break;
                case 1:
                    category = "cold_coffee";
                    break;
                case 2:
                    category = "cold_drink";
                    break;
                case 3:
                    category = "frappuccino";
                    break;
                case 4:
                    category = "bakery";
                    break;

            }
        }
    }
}
