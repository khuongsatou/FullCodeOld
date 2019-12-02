using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_LOP: GENERAL
    {
        public DataTable Select()
        {
            connect_db();
            string sql = string.Format("SELECT * FROM LOP");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            disconnect_db();
            return dt;
        }

    }
}
