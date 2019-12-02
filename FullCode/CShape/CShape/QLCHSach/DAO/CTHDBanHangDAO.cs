using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class CTHDBanHangDAO:DataProvider
    {
        public DataTable LayDanhSach()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [dbo].[CTHDBanHang]", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LayDanhSachTheoMaHD(int mahd)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT c.*, s.Ten TenSach FROM dbo.CTHDBanHang c, dbo.Sach s WHERE c.MaSach=s.MaSach AND MaHD=" + mahd.ToString(), conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Them(CTHDBanHangDTO cthd)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_ThemCTHDBanHang";
            com.Parameters.Add("@mahd", SqlDbType.Int).Value = cthd.MaHD;
            com.Parameters.Add("@masach", SqlDbType.Int).Value = cthd.MaSach;
            com.Parameters.Add("@soluong", SqlDbType.Int).Value = cthd.SoLuong;
            com.Parameters.Add("@giaban", SqlDbType.Int).Value = cthd.GiaBan;
            com.Parameters.Add("@khuyenmai", SqlDbType.Int).Value = cthd.KhuyenMai;
            com.Parameters.Add("@thanhtien", SqlDbType.Int).Value = cthd.ThanhTien;
            com.Connection = conn;
            int kq = com.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
        }
    }
}
