using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DAL_MD_SINHVIEN : Genneral_data
    {
        //public DataTable DocDSSinhVien()
        //{
        //    SqlConnection con = connect_db();
           
        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        SqlCommand cmd = new SqlCommand("SELECT * FROM SINHVIEN",con);
        //        if (con.State == ConnectionState.Closed)
        //        {
        //            con.Open();
        //        }
        //        SqlDataReader rd = cmd.ExecuteReader();
        //        dt.Load(rd);
        //        return dt;
        //    }
        //    catch (Exception)
        //    {

        //        return null;
        //    }
           
        //}

        public DataTable DocDSSinhVien()
        {
            SqlConnection con = connect_db();

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SINHVIEN", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public void InsertDSSinhVien(string sql)
        {
            SqlConnection con = connect_db();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
