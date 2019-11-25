using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class TheLoaiDAO:DataProvider
    {
        public DataTable LayDanhSach()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM THELOAISACH WHERE XOA=0", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Them(TheLoaiDTO tlDTO)
        {
            conn.Open();
            string SQL = string.Format("INSERT INTO THELOAISACH (TEN, GHICHU) VALUES (N'{0}', N'{1}')", tlDTO.Ten, tlDTO.GhiChu);
            SqlCommand com = new SqlCommand(SQL, conn);
            int kq = com.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            return false;
        }
        public bool Sua(TheLoaiDTO tlDTO)
        {
            conn.Open();
            string SQL = string.Format("UPDATE THELOAISACH SET TEN=N'{0}', GHICHU=N'{1}' WHERE MATHELOAI={2}", tlDTO.Ten, tlDTO.GhiChu, tlDTO.MaTheLoai);
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
            string SQL = string.Format("UPDATE THELOAISACH SET XOA=1 WHERE MATHELOAI={0}", id);
            SqlCommand com = new SqlCommand(SQL, conn);
            int kq = com.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            return false;
        }
        public TheLoaiDTO LayTheLoaiTheoMa(int matheloai)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_LayTheLoaiTheoMa";
            com.Connection = conn;
            com.Parameters.Add("@matheloai", SqlDbType.Int).Value = matheloai;
            SqlDataReader dr = com.ExecuteReader();
            TheLoaiDTO tl = new TheLoaiDTO();
            if (dr.Read())
            {
                tl.MaTheLoai = matheloai;
                tl.Ten = dr["Ten"].ToString();
                tl.GhiChu = dr["GhiChu"].ToString();
            }
            conn.Close();
            return tl;
        }
    }
}
