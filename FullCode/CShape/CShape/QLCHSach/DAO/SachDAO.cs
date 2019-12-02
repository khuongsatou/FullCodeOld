using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class SachDAO:DataProvider
    {
        public DataTable LayDanhSach()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_LayDanhSachSACH", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        public bool Them(SachDTO sDTO)
        {
            conn.Open();
            string SQL = string.Format("INSERT INTO [dbo].[Sach] ([Ten],[MaTacGia],[MaTheLoai],[NgayXuatBan],[MaNXB],[GhiChu],[SoLuong],[GiaBia]) " +
                "VALUES (N'{0}',{1},{2},'{3}',{4},N'{5}',{6},{7})", sDTO.Ten, sDTO.MaTacGia, sDTO.MaTheLoai, sDTO.NgayXuatBan.ToString("yyyy-MM-dd"), sDTO.MaNXB, sDTO.GhiChu,sDTO.SoLuong,sDTO.GiaBia);
            SqlCommand com = new SqlCommand(SQL, conn);
            int kq = com.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            return false;
        }

        public bool Sua(SachDTO sDTO)
        {
            conn.Open();
            string SQL = string.Format("UPDATE [dbo].[Sach] SET [Ten]=N'{0}',[MaTacGia]={1},[MaTheLoai]={2}," +
                "[NgayXuatBan]='{3}',[MaNXB]={4},[GhiChu]=N'{5}' WHERE MaSach={6}", sDTO.Ten, sDTO.MaTacGia, sDTO.MaTheLoai, sDTO.NgayXuatBan.ToString("yyyy-MM-dd"), sDTO.MaNXB, sDTO.GhiChu, sDTO.MaSach);
            SqlCommand com = new SqlCommand(SQL, conn);
            int kq = com.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
        }

        public bool CapNhatSoLuongGiaBia(int masach, int soluong, int giabia, int gianhap)
        {
            conn.Open();
            string SQL = string.Format("UPDATE [dbo].[Sach] SET [SoLuong] = [SoLuong] + {0}, [GiaBia] = {1}, [GiaNhap] = {2}" +
                "WHERE [MaSach] = {3}", soluong, giabia, gianhap, masach);
            SqlCommand com = new SqlCommand(SQL, conn);
            int kq = com.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
        public bool CapNhatSoLuong(int masach, int soluongban)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_CapNhatSoLuongSach";
            com.Parameters.Add("@masach", SqlDbType.Int).Value = masach;
            com.Parameters.Add("@soluongban", SqlDbType.Int).Value = soluongban;
            com.Connection = conn;
            int kq = com.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
        }
        public bool Xoa(int id)
        {
            conn.Open();
            string SQL = string.Format("UPDATE [dbo].[Sach] SET [Xoa]=1 WHERE [MaSach]={0}", id);
            SqlCommand com = new SqlCommand(SQL, conn);
            int kq = com.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            return false;
        }

        public string LayTenSachTheoMa(int masach)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_LayTenSachTheoMa";
            com.Parameters.Add("@masach", SqlDbType.NVarChar).Value = masach;
            com.Connection = conn;
            Object ten = com.ExecuteScalar();
            conn.Close();
            return (string)ten;
        }

        public SachDTO LaySachTheoMa(int masach)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_LaySachTheoMa";
            com.Parameters.Add("@masach", SqlDbType.NVarChar).Value = masach;
            com.Connection = conn;
            SqlDataReader dr = com.ExecuteReader();
            SachDTO sach = new SachDTO();
            if (dr.Read())
            {
                sach.MaSach = masach;
                sach.Ten = (string)dr["Ten"];
                sach.MaTacGia = (int)dr["MaTacGia"];
                sach.MaTheLoai = (int)dr["MaTheLoai"];
                sach.MaNXB = (int)dr["MaNXB"];
                sach.NgayXuatBan = (DateTime)dr["NgayXuatBan"];
                sach.GiaBia = (int)dr["GiaBia"];
                sach.SoLuong = (int)dr["SoLuong"];
                sach.GhiChu = (string)dr["GhiChu"];
            }
            conn.Close();
            return sach;
            
        }
        public SachDTO LaySachTonKhoTheoMa(int masach)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_LaySachTonKhoTheoMa";
            com.Parameters.Add("@masach", SqlDbType.NVarChar).Value = masach;
            com.Connection = conn;
            SqlDataReader dr = com.ExecuteReader();
            SachDTO sach = new SachDTO();
            if (dr.Read())
            {
                sach.MaSach = masach;
                sach.Ten = (string)dr["Ten"];
                sach.MaTacGia = (int)dr["MaTacGia"];
                sach.MaTheLoai = (int)dr["MaTheLoai"];
                sach.MaNXB = (int)dr["MaNXB"];
                sach.NgayXuatBan = (DateTime)dr["NgayXuatBan"];
                sach.GiaBia = (int)dr["GiaBia"];
                sach.SoLuong = (int)dr["SoLuong"];
                sach.GhiChu = (string)dr["GhiChu"];
            }
            conn.Close();
            return sach;

        }
        public DataTable LayDSSachTheoTheLoai(int matheloai)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_LayDSSachTheoTheLoai @matheloai", conn);
            da.SelectCommand.Parameters.AddWithValue("@matheloai", matheloai);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LayDSSachTheoNXB(int manxb)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_LayDSSachTheoNXB @manxb", conn);
            da.SelectCommand.Parameters.AddWithValue("@manxb", manxb);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LayDSSachTonKho(int soluong)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_LayDSSachTonKho @soluong", conn);
            da.SelectCommand.Parameters.AddWithValue("@soluong", soluong);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
