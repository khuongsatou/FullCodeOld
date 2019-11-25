using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class CTHDNhapHangDAO:DataProvider
    {
        public DataTable LayDanhSach()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [dbo].[CTHDNhapHang]", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Them(CTHDNhapHangDTO CTHDNhapDTO)
        {
            conn.Open();
            string SQL = string.Format("INSERT INTO [dbo].[CTHDNhapHang] ([MaHD],[MaSach],[SoLuong],[GiaBia],[GiaNhap]) " +
                "VALUES ({0},{1},{2},{3},{4})", CTHDNhapDTO.MaHD, CTHDNhapDTO.MaSach, CTHDNhapDTO.SoLuong, CTHDNhapDTO.GiaBia,CTHDNhapDTO.GiaNhap);
            SqlCommand com = new SqlCommand(SQL, conn);
            int kq = com.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            return false;
        }
        
    }
}
