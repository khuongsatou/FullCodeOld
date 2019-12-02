using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using DTO;

namespace DAO
{
    public class NhanVienDAO : DataProvider
    {
        public DataTable LayDanhSach()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_LayDanhSachNhanVien", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Them(NhanVienDTO nvDTO)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_ThemNhanVien";
            com.Connection = conn;

            com.Parameters.Add("@matkhau", SqlDbType.Char).Value = MaHoaMD5(nvDTO.MatKhau);
            com.Parameters.Add("@maloainv", SqlDbType.Int).Value = nvDTO.MaLoaiNV;
            com.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = nvDTO.HoTen;
            com.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = nvDTO.NgaySinh.ToString("yyyy-MM-dd");
            com.Parameters.Add("@gioitinh", SqlDbType.Bit).Value = nvDTO.GioiTinh;
            com.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = nvDTO.DiaChi;
            com.Parameters.Add("@dienthoai", SqlDbType.VarChar).Value = nvDTO.DienThoai;
            com.Parameters.Add("@email", SqlDbType.VarChar).Value = nvDTO.Email;
            com.Parameters.Add("@ghichu", SqlDbType.NText).Value = nvDTO.GhiChu;

            int kq = com.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
        }
        public bool Sua(NhanVienDTO nvDTO)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_CapNhatNhanVien";
            com.Connection = conn;

            com.Parameters.Add("@maloainv", SqlDbType.Int).Value = nvDTO.MaLoaiNV;
            com.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = nvDTO.HoTen;
            com.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = nvDTO.NgaySinh.ToString("yyyy-MM-dd");
            com.Parameters.Add("@gioitinh", SqlDbType.Bit).Value = nvDTO.GioiTinh;
            com.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = nvDTO.DiaChi;
            com.Parameters.Add("@dienthoai", SqlDbType.VarChar).Value = nvDTO.DienThoai;
            com.Parameters.Add("@email", SqlDbType.VarChar).Value = nvDTO.Email;
            com.Parameters.Add("@ghichu", SqlDbType.NText).Value = nvDTO.GhiChu;
            com.Parameters.Add("@manv", SqlDbType.Int).Value = nvDTO.MaNV;

            int kq = com.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
        }
        public bool Xoa(int id)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_XoaNhanVien";
            com.Connection = conn;
            com.Parameters.Add("@manv", SqlDbType.Int).Value = id;

            int kq = com.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
        }
        
        public NhanVienDTO LayNhanVienTheoMaNV(int manv)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_LayNhanVienTheoMaNV";
            com.Connection = conn;
            com.Parameters.Add("@manv", SqlDbType.Int).Value = manv;

            NhanVienDTO nv = new NhanVienDTO();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                nv.MaNV = manv;
                nv.MaLoaiNV = (int)dr["MaLoaiNV"];
                nv.TenLoaiNV = (string)dr["TenLoaiNV"];
                nv.HoTen = (string)dr["HoTen"];
                nv.NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
                nv.GioiTinh = (bool)dr["GioiTinh"];
                nv.DiaChi = (string)dr["DiaChi"];
                nv.DienThoai = (string)dr["DienThoai"];
                nv.Email = (string)dr["Email"];
                nv.GhiChu = (string)dr["GhiChu"];
            }
            conn.Close();
            return nv;
        }
 
        public bool ResetMatKhau(int manv, string matkhau)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_ResetMatKhau";
            com.Connection = conn;
            com.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            com.Parameters.Add("@matkhau", SqlDbType.Char).Value = MaHoaMD5(matkhau);

            int kq = com.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
            
        }

        public int DangNhap(int manv, string matkhau)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_DangNhap";
            com.Connection = conn;
            com.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            com.Parameters.Add("@matkhau", SqlDbType.Char).Value = MaHoaMD5(matkhau);

            object kq = com.ExecuteScalar();
            conn.Close();
            if (kq != null)
                return Convert.ToInt32(kq);
            return 0;
        }

        public string MaHoaMD5(string input)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
