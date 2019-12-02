using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Genneral_data
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QuanLiSinhVien;Integrated Security=True");
        public SqlConnection connect_db()
        {
            if (ConnectionState.Closed == con.State)
            {
                con.Open();
            }
            return con;
        }

    }
}
