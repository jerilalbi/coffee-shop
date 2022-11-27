using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks.domain.admin
{
    internal class AdminDbOP
    {
        public bool expAdd(string expType,int expAmount)
        {
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            string checkQuery = $"select count(type) from expense where type = '{expType}' and month = {DateTime.Now.Month} and year = {DateTime.Now.Year}";
            SqlDataAdapter checkAdpt = new SqlDataAdapter(checkQuery, Database.connection);
            DataTable dt = new DataTable();
            checkAdpt.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                bool res = adminQuery($"update expense set amount = amount + {expAmount} where type = '{expType}' and month = {DateTime.Now.Month} and year = {DateTime.Now.Year}");
                Database.connection.Close();
                if (res)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                string query = $"insert into expense values('{expType}',{expAmount},{DateTime.Now.Month},{DateTime.Now.Year})";
                SqlCommand cmd = new SqlCommand(query, Database.connection);
                int res = cmd.ExecuteNonQuery();
                Database.connection.Close();
                if (res > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool adminQuery(string query)
        {
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
                SqlCommand cmd = new SqlCommand(query, Database.connection);
                int res = cmd.ExecuteNonQuery();
                Database.connection.Close();
                if (res > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }

        public SqlDataReader adminDataFetchQuery(string query)
        {
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            SqlCommand cmd = new SqlCommand(query, Database.connection);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }
    }
}
