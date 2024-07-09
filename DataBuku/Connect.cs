using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataBuku
{
    internal class Connect
    {
        public static SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=perpustakaan;Integrated Security=True";
            return Conn;
        }
    }
}
