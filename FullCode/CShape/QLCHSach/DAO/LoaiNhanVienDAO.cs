using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class LoaiNhanVienDAO:DataProvider
    {
        public DataTable LayDanhSach()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_LayDanhSachLoaiNhanVien", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Them(LoaiNhanVienDTO lnvDTO)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_ThemLoaiNhanVien";
            com.Connection = conn;
            com.Parameters.Add("@ten", SqlDbType.NVarChar).Value = lnvDTO.Ten;
            com.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = lnvDTO.GhiChu;
            int kq = com.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
        }
        public bool Sua(LoaiNhanVienDTO lnvDTO)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_CapNhatLoaiNhanVien";
            com.Connection = conn;
            com.Parameters.Add("@ten", SqlDbType.NVarChar).Value = lnvDTO.Ten;
            com.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = lnvDTO.GhiChu;
            com.Parameters.Add("@maloainv", SqlDbType.Int).Value = lnvDTO.MaLoaiNV;
            int kq = com.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
        }
        public bool Xoa(int id)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_XoaLoaiNhanVien";
            com.Connection = conn;
            com.Parameters.Add("maloainv", SqlDbType.Int).Value = id;
            int kq = com.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
        }
        
    }
}
