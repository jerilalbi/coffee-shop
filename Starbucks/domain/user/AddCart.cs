using Starbucks.application.datas;
using Starbucks.presentation.product;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbucks.domain.user
{
    internal class AddCart
    {
        public bool addToCart(string prod_name, int prod_amount,string prod_size,string prod_flavour,int prod_count, byte[] image)
        {
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            string checkQuery = $"select count(name) from cart where name = '{prod_name}' and price = {prod_amount} and size = '{prod_size}' and flavour = '{prod_flavour}'";
            SqlDataAdapter checkAdpt = new SqlDataAdapter(checkQuery,Database.connection);
            DataTable dt = new DataTable();
            checkAdpt.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                bool res = updateCount(prod_name, prod_amount, prod_size, prod_flavour, true);
                if (res)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }else {
                string query = $"insert into cart values('{prod_name}',{prod_amount},{prod_count},'{prod_size}','{prod_flavour}',@image)";
                SqlCommand cmd = new SqlCommand(query, Database.connection);
                cmd.Parameters.AddWithValue("@image", image);
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

        public SqlDataReader showCart()
        {
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            string query = $"select * from cart";
            SqlCommand cmd = new SqlCommand(query, Database.connection);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }

        public bool deleteProdCart(string title,int price,string size,string flavour,int count) {
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            string query = $"delete from cart where name='{title}' and price={price} and size='{size}' and flavour='{flavour}' and count={count}";
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

        public bool updateCount(string title, int price, string size, string flavour,bool isIncrease)
        {
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            string increaseQuery = $"update cart set count = count + 1 where name='{title}' and price={price} and size='{size}' and flavour='{flavour}'";
            string decreaseQuery = $"update cart set count = count - 1 where name='{title}' and price={price} and size='{size}' and flavour='{flavour}'";
            SqlCommand cmd = isIncrease ? new SqlCommand(increaseQuery, Database.connection) : new SqlCommand(decreaseQuery, Database.connection);
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
}
