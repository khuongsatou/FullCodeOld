using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;


namespace DAO
{
    public class HDNhapHangDAO:DataProvider
    {
        public DataTable LayDanhSach()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [dbo].[HDNhapHang]", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int Them(HDNhapHangDTO HDNhapDTO)
        {
            conn.Open();
            string SQL = string.Format("INSERT INTO [dbo].[HDNhapHang] ([NgayNhap],[MaNV],[GhiChu]) " +
                "VALUES ('{0}',{1},N'{2}')", HDNhapDTO.NgayNhap.ToString("yyyy-MM-dd"), HDNhapDTO.MaNV, HDNhapDTO.GhiChu);
            SqlCommand com = new SqlCommand(SQL, conn);
            int kq = com.ExecuteNonQuery();
            int id = 0;
            if (kq > 0)
            {
                //Lấy mã hóa đơn tự động tăng sau khi insert
                SQL = @"SELECT @@IDENTITY";
                com = new SqlCommand(SQL, conn);
                id = (int)((decimal)com.ExecuteScalar());
            }
            conn.Close();
            return id;
        }
    }
}
