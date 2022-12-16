using Starbucks.domain.admin;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Starbucks.presentation.admin.dash_overview
{
    public partial class Dash_Overview : UserControl
    {
        int month = DateTime.Now.Month, year = DateTime.Now.Year,expense = 0,totalRevenue,netRev;
        string period = "month";
        public Dash_Overview()
        {
            InitializeComponent();
            period_combobx.SelectedIndex = 0;
        }

        private void revenueChart_GetToolTipText(object sender,ToolTipEventArgs e)
        {
            toolTipChart(e);
        }

        void toolTipChart(ToolTipEventArgs e)
        {
            switch (e.HitTestResult.ChartElementType)
            {
                case ChartElementType.DataPoint:
                    var dataPoint = e.HitTestResult.Series.Points[e.HitTestResult.PointIndex];
                    e.Text = string.Format("{0} ( {1} )", dataPoint.AxisLabel, dataPoint.YValues[0]);
                    break;
            }
        }

        private void productChart_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            toolTipChart(e);
        }

        private void Dash_Overview_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        private void period_combobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (period_combobx.SelectedIndex)
            {
                case 0: period = "month";break;
                case 1: period = "year";break;
            }
            fetchData();
        }

        void fetchData()
        {
            AdminDbOP dbOP = new AdminDbOP();
            SqlDataReader orderNo =(period == "month") ? dbOP.adminDataFetchQuery($"select sum(sales) as no_order from sales where month = {month}") : dbOP.adminDataFetchQuery($"select sum(sales) as no_order from sales where year = {year}");
            if (orderNo.Read())
            {
                if (orderNo["no_order"].ToString() == "")
                {
                    noOrderVal.Text = "0";
                }
                else
                {
                    noOrderVal.Text = orderNo["no_order"].ToString();
                }

            }
            orderNo.Close();

            SqlDataReader totalExp = (period == "month") ? dbOP.adminDataFetchQuery($"select sum(amount) as totexpense from expense where month = {month}") : dbOP.adminDataFetchQuery($"select sum(amount) as totexpense from expense where year = {year}");
            if (totalExp.Read())
            {
                if(totalExp["totexpense"].ToString() == "")
                {
                    totExpVal.Text = "0";
                }
                else
                {
                    totExpVal.Text = totalExp["totexpense"].ToString();
                    expense = int.Parse(totalExp["totexpense"].ToString());
                }
                
            }
            totalExp.Close();

            SqlDataReader netRevenue = (period == "month") ? dbOP.adminDataFetchQuery($"select sum(amount) as totalrev from sales where month = {month}") : dbOP.adminDataFetchQuery($"select sum(amount) as totalrev from sales where year = {year}");
            if (netRevenue.Read())
            {
                if(netRevenue["totalrev"].ToString() == "")
                {
                    netRevVal.Text = "0";
                }
                else
                {
                    totalRevenue = int.Parse(netRevenue["totalrev"].ToString());
                    netRev = totalRevenue - expense;
                    netRevVal.Text = $"{netRev}";
                }
            }
            netRevenue.Close();
            productChart.Series["prod_sales"].Points.Clear();
            revenueChart.Series["total_revenue"].Points.Clear();
            fillGraphs(dbOP);
        }

        void fillGraphs(AdminDbOP dbOP)
        {
            string[] months = {"JAN","FEB","MARCH","APRIL","MAY","JUNE","JULY","AUG","SEP","OCT","NOV","DEC"};
            int monthIndex = 1;
            SqlDataReader revnueGraph;
            
            while(monthIndex <= 12)
            {
                Console.WriteLine("Printed");
                revnueGraph = dbOP.adminDataFetchQuery($"select sum(amount) as totalrev from sales where month = {monthIndex} ");
                if (revnueGraph.Read())
                {
                    if (revnueGraph["totalrev"].ToString() == "")
                    {
                        revenueChart.Series["total_revenue"].Points.AddXY(months[monthIndex - 1], 0);
                    }
                    else
                    {
                        revenueChart.Series["total_revenue"].Points.AddXY(months[monthIndex - 1], int.Parse(revnueGraph["totalrev"].ToString()));
                    }
                    monthIndex++;
                }
                revnueGraph.Close();
            }

            SqlDataReader prodGraph = (period == "month") ? dbOP.adminDataFetchQuery($"select top 5 product_name,amount from sales where month = {month} order by amount desc") : dbOP.adminDataFetchQuery($"select top 5 product_name,amount from sales where year = {year} order by amount desc");
            while (prodGraph.Read())
            {
                productChart.Series["prod_sales"].Points.AddXY(prodGraph["product_name"].ToString(), int.Parse(prodGraph["amount"].ToString()));
            }
            prodGraph.Close();

        }


    }
}
