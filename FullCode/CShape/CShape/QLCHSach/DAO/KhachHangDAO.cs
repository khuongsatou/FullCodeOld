using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;


namespace DAO
{
    public class KhachHangDAO : DataProvider
    {
        public DataTable LayDanhSach()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHACHHANG WHERE XOA=0", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Them(KhachHangDTO khDTO)
        {
            conn.Open();
            string SQL = string.Format("INSERT INTO [dbo].[KhachHang] ([HoTen],[NgaySinh],[GioiTinh],[DiaChi],[DienThoai],[Email],[GhiChu]) " +
                "VALUES (N'{0}','{1}','{2}',N'{3}','{4}','{5}',N'{6}')", khDTO.HoTen, khDTO.NgaySinh.ToString("yyyy-MM-dd"), khDTO.GioiTinh, khDTO.DiaChi, khDTO.DienThoai, khDTO.Email, khDTO.GhiChu);
            SqlCommand com = new SqlCommand(SQL, conn);
            int kq = com.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            return false;
        }
        public bool Sua(KhachHangDTO khDTO)
        {
            conn.Open();
            string SQL = string.Format("UPDATE KHACHHANG SET HOTEN = N'{0}', " +
                "NGAYSINH = '{1}', GIOITINH = '{2}', DIACHI = N'{3}', " +
                "DIENTHOAI = '{4}', EMAIL = '{5}', GHICHU = N'{6}' WHERE MAKH={7}", khDTO.HoTen, khDTO.NgaySinh.ToString("yyyy-MM-dd"), khDTO.GioiTinh, khDTO.DiaChi, khDTO.DienThoai, khDTO.Email, khDTO.GhiChu, khDTO.MaKH);
            SqlCommand com = new SqlCommand(SQL, conn);
            int kq = com.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            return false;
        }
        public bool Xoa(int id)
        {
            conn.Open();
            string SQL = string.Format("UPDATE KHACHHANG SET XOA=1 WHERE MAKH={0}", id);
            SqlCommand com = new SqlCommand(SQL, conn);
            int kq = com.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            return false;
        }
        public string LayTenKHTheoMa(int makh)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_LayTenKHTheoMa";
            com.Parameters.Add("@makh", SqlDbType.Int).Value = makh;
            com.Connection = conn;
            string tenkh = (string)com.ExecuteScalar();
            conn.Close();
            return tenkh;
        }
        public KhachHangDTO LayKHTheoMa(int makh)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_LayKHTheoMa";
            com.Parameters.Add("@makh", SqlDbType.Int).Value = makh;
            com.Connection = conn;
            SqlDataReader dr = com.ExecuteReader();
            KhachHangDTO kh = new KhachHangDTO();
            if (dr.Read())
            {
                kh.MaKH = makh;
                kh.HoTen = (string)dr["HoTen"];
                kh.NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
                kh.GioiTinh = (bool)dr["GioiTinh"];
                kh.DiaChi = (string)dr["DiaChi"];
                kh.DienThoai = (string)dr["DienThoai"];
                kh.Email = (string)dr["Email"];
                kh.GhiChu = (string)dr["GhiChu"];
            }
            conn.Close();
            return kh;
        }
    }
}
