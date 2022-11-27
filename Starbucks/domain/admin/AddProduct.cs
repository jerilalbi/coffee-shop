using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks.domain.admin
{
    public class AddProduct
    {
        public bool insertProduct(string tb_name,string prod_name,int prod_amount, byte[] image) {
            if(Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            string query = $"insert into {tb_name} values('{prod_name}',{prod_amount},@image)";
            SqlCommand cmd = new SqlCommand(query, Database.connection);
            cmd.Parameters.AddWithValue("@image", image);
            int res = cmd.ExecuteNonQuery();
            Database.connection.Close();
            if(res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateProduct(string query,byte[] image)
        {
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
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
}
