using Starbucks.domain.admin;
using Starbucks.infrastructure.components;
using Starbucks.presentation.admin.dash_add_exp;
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

namespace Starbucks.presentation.admin.dash_add_prod
{
    public partial class Dash_Prod : UserControl
    {
        public static Dash_Prod dash_prod_insts;
        string category = "hot_coffee";
        string period = "month";
        int month = DateTime.Now.Month,year;
        byte[] photo_array;
        public Dash_Prod()
        {
            dash_prod_insts = this;
            InitializeComponent();
        }

        private void Dash_Prod_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        internal void fetchData()
        {
            AdminDbOP dbOP = new AdminDbOP();
            SqlDataReader prodNo = dbOP.adminDataFetchQuery($"select count(name) as prodCount from {category}");
            if (prodNo.Read())
            {
                prodNoVal.Text = prodNo["prodCount"].ToString();
                prodNo.Close();
            }

            prodDisplayPanel.Controls.Clear();
            SqlDataReader products = dbOP.adminDataFetchQuery($"select * from {category}");
            int count = 0;
            while (products.Read())
            {
                photo_array = (byte[])products["image"];
                prodDisplayPanel.Controls.Add(new Dash_ProdTile 
                {
                    Title = products["name"].ToString(),
                    Price = int.Parse(products["price"].ToString()),
                    Image = photo_array,
                    Name = $"product{count}",
                    TileName = $"product{count}",
                    ProdCategory = category,
                });
                count++;
            }
            products.Close();

        }

        private void period_combobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (period_combobx.SelectedIndex)
            {
                case 0: period = "month"; month = DateTime.Now.Month;
                    break;
                case 1: period = "year"; year = DateTime.Now.Year;
                    break;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
           Dash_addProd addProd = new Dash_addProd();
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Clear();
            addProd.BringToFront();
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Add(addProd);
            this.Dispose();
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
