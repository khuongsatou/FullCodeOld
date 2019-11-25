using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class NhaXuatBanDAO:DataProvider
    {
        public DataTable LayDanhSach()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_LayDanhSachNXB", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Them(NhaXuatBanDTO nxbDTO)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_ThemNXB";
            com.Connection = conn;
            com.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nxbDTO.Ten;
            com.Parameters.Add("@website", SqlDbType.VarChar).Value = nxbDTO.Website;
            com.Parameters.Add("@email", SqlDbType.VarChar).Value = nxbDTO.Email;
            com.Parameters.Add("@ghichu", SqlDbType.NText).Value = nxbDTO.GhiChu;
            int kq = com.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
        }

        public bool Sua(NhaXuatBanDTO nxbDTO)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_SuaNXB";
            com.Connection = conn;
            com.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nxbDTO.Ten;
            com.Parameters.Add("@website", SqlDbType.VarChar).Value = nxbDTO.Website;
            com.Parameters.Add("@email", SqlDbType.VarChar).Value = nxbDTO.Email;
            com.Parameters.Add("@ghichu", SqlDbType.NText).Value = nxbDTO.GhiChu;
            com.Parameters.Add("@manxb", SqlDbType.Int).Value = nxbDTO.MaNXB;
            int kq = com.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
        }

        public NhaXuatBanDTO LayNhaXuatBanTheoMa(int manxb)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_LayNXBTheoMa";
            com.Connection = conn;
            com.Parameters.Add("@manxb", SqlDbType.Int).Value = manxb;
            
            NhaXuatBanDTO nxb = new NhaXuatBanDTO();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                nxb.MaNXB = manxb;
                nxb.Ten = (string)dr["Ten"];
                nxb.Website = (string)dr["Website"];
                nxb.Email = (string)dr["Email"];
                nxb.GhiChu = (string)dr["GhiChu"];
            }
            conn.Close();
            return nxb;
        }

        public bool Xoa(int id)
        {
            conn.Open();
            string SQL = string.Format("UPDATE [dbo].[NhaXuatBan] SET [Xoa] = 1 WHERE [MaNXB] = {0}", id);
            SqlCommand com = new SqlCommand(SQL, conn);
            int kq = com.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            return false;
        }

    
    }
}
