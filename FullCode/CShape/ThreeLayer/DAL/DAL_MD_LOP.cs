using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_MD_LOP : Genneral_data
    {
        public DataTable DocDanhSachLop()
        {
            SqlConnection con = connect_db();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Lop",con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
           
        }
    }
}
