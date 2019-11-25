using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class GENERAL
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=.\;Initial Catalog=QLHS;Integrated Security=True");
        public SqlConnection connect_db()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
        public SqlConnection disconnect_db()
        {
            conn.Close();
            return conn;
        }
    }
}
