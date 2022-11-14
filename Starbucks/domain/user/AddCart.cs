using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
