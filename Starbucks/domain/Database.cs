using System;
using System.Data.SqlClient;

namespace Starbucks.domain
{
    public class Database
    {
        public static String con = "Data Source=LAPTOP-2BEHQNH6\\JERIL;Initial Catalog=starbucks;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(con);
    }
}
