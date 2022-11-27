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

namespace Starbucks.presentation.admin.dash_add_exp
{
    public partial class Dash_Exp : UserControl
    {
        string period = "month";
        int month = DateTime.Now.Month,year = 0;
        public static Dash_Exp Dashexpense;
        public Dash_Exp()
        {
            Dashexpense = this;
            InitializeComponent();
        }

        private void Dash_Exp_Load(object sender, EventArgs e)
        {
            fetchAlldata();

            for (int i = 0; i < 10; i++)
            {
                expDisplayPanel.Controls.Add(new Expense_Tile {
                    ExpType = "Electricity",
                    ExpAmount = 100+i
                }) ;
            }
            period_combobx.SelectedIndex = 0;
        }

      internal  void fetchAlldata()
        {
            expTypeChartData.DataPoints.Clear();
            AdminDbOP dbOP = new AdminDbOP();
            SqlDataReader noExp = (period == "month") ? dbOP.adminDataFetchQuery($"select count(*) as noExp from expense where month = {month}") : dbOP.adminDataFetchQuery($"select count(*) as noExp from expense where year = {year}");
            if (noExp.Read())
            {
                noExpVal.Text = noExp["noExp"].ToString();
                noExp.Close();
            }

            SqlDataReader highExp = (period == "month") ? dbOP.adminDataFetchQuery($"select type from expense where amount = (select max(amount) from expense) and month = {month}") : dbOP.adminDataFetchQuery($"select type from expense where amount = (select max(amount) from expense) and year = {year}");
            if (highExp.Read())
            {
                highExpVal.Text = highExp["type"].ToString();
                highExp.Close();
            }

            SqlDataReader totalExp = (period == "month") ? dbOP.adminDataFetchQuery($"select sum(amount) as totalExp from expense where month = {month}") : dbOP.adminDataFetchQuery($"select sum(amount) as totalExp from expense where year = {year}");
            if (totalExp.Read())
            {
                totalExpVal.Text = totalExp["totalExp"].ToString();
                totalExp.Close();
            }

            SqlDataReader expenses = (period == "month") ? dbOP.adminDataFetchQuery($"select * from expense where month = {month}") : dbOP.adminDataFetchQuery($"select * from expense where year = {year}");
            expDisplayPanel.Controls.Clear();
            int count = 0;
            while (expenses.Read())
            {
                expDisplayPanel.Controls.Add(new Expense_Tile 
                { 
                    ExpType = expenses["type"].ToString(),
                    ExpAmount = int.Parse(expenses["amount"].ToString()),
                    ExpMonth = int.Parse(expenses["month"].ToString()),
                    ExpYear = int.Parse(expenses["year"].ToString()),
                    Name = $"tile{count}",
                    TileName = $"tile{count}",
                });

                expTypeChartData.DataPoints.Add(expenses["type"].ToString(), int.Parse(expenses["amount"].ToString()));
                count++;
            }
            expenses.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Dash_addExp ad_Exp = new Dash_addExp();
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Clear();
            ad_Exp.BringToFront();
            Screen_Dashboard.sc_dash.base_dashboard.Controls.Add(ad_Exp);
            this.Dispose();
        }

        private void period_combobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (period_combobx.SelectedIndex)
            {
                case 0: month = DateTime.Now.Month;
                    period = "month";
                    break;
                case 1:
                    period = "year";
                    year = DateTime.Now.Year;
                    break;
            }
            fetchAlldata();
        }
    }
}
