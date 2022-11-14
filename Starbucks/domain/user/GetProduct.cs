using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks.domain.user
{
    internal class GetProduct
    {
      public  SqlDataReader getData(string tb_name)
        {
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            string query = $"select * from {tb_name}";
            SqlCommand cmd = new SqlCommand(query, Database.connection);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }
    }
}
