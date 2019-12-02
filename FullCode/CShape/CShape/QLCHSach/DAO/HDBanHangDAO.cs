using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class HDBanHangDAO:DataProvider
    {
        public DataTable LayDanhSach()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [dbo].[HDBanHang]", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int Them(HDBanHangDTO hd)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_ThemHDBanHang";
            com.Parameters.Add("@ngayban", SqlDbType.DateTime).Value = hd.NgayBan;
            com.Parameters.Add("@manv", SqlDbType.Int).Value = hd.MaNV;
            com.Parameters.Add("@makh", SqlDbType.Int).Value = hd.MaKH;
            com.Connection = conn;
            int kq = com.ExecuteNonQuery();
            int id = 0;
            if (kq > 0)
            {
                //Lấy mã hóa đơn tự động tăng sau khi insert
                string SQL = @"SELECT @@IDENTITY";
                com = new SqlCommand(SQL, conn);
                id = (int)((decimal)com.ExecuteScalar());
            }
            conn.Close();
            return id;
        }
        public bool CapNhatTongTien(int mahd, int tongtien)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_CapNhatTongTien_HDBanHang";
            com.Parameters.Add("@mahd", SqlDbType.Int).Value = mahd;
            com.Parameters.Add("@tongtien", SqlDbType.Int).Value = tongtien;
            com.Connection = conn;
            int kq = com.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
        }
        public DataTable LayDSHDTheoNgay(DateTime ngaybd, DateTime ngaykt)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_LayDSHDBanHangTheoNgay @ngaybd, @ngaykt", conn);
            da.SelectCommand.Parameters.AddWithValue("@ngaybd", ngaybd);
            da.SelectCommand.Parameters.AddWithValue("@ngaykt", ngaykt);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
