using Starbucks.domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Starbucks.application.events
{
    internal class Sales
    {
        public void addSales(string prod_name,int amount,int count,string category)
        {
            DateTime date = DateTime.Now;
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            string checkQuery = $"select count(product_name) from sales where product_name = '{prod_name}' and category = '{category}' and month = {date.Month} and year = '{date.Year}'";
            SqlDataAdapter checkAdpt = new SqlDataAdapter(checkQuery, Database.connection);
            DataTable dt = new DataTable();
            checkAdpt.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                updateSales(amount, count, prod_name);
            }
            else
            {
                insertSales(amount, count, prod_name, category);
            }
            Database.connection.Close();
        }

        void updateSales(int amount,int count,string prod_name)
        {
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            string updateQuery = $"update sales set amount = amount + {amount * count} , sales = sales + {count} where product_name='{prod_name}'";
            SqlCommand cmd = new SqlCommand(updateQuery, Database.connection);
            cmd.ExecuteNonQuery();
        }

        void insertSales(int amount, int count, string prod_name,string category)
        {
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            string updateQuery = $"insert into sales values('{prod_name}',{amount},{count},{DateTime.Now.Month},{DateTime.Now.Year},'{category}')";
            SqlCommand cmd = new SqlCommand(updateQuery, Database.connection);
            cmd.ExecuteNonQuery();
        }
    }
}
