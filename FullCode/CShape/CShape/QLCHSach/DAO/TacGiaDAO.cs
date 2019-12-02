using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class TacGiaDAO:DataProvider
    {
        public DataTable LayDanhSach()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TACGIA WHERE XOA=0", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Them(TacGiaDTO tgDTO)
        {
            conn.Open();
            string SQL = string.Format("INSERT INTO TACGIA (HOTEN,NGAYSINH,GIOITINH,GHICHU)" +
                " VALUES (N'{0}','{1}','{2}',N'{3}')", tgDTO.HoTen, tgDTO.NgaySinh.ToString("yyyy-MM-dd"), tgDTO.GioiTinh, tgDTO.GhiChu);
            SqlCommand com = new SqlCommand(SQL, conn);
            int kq = com.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            return false;
        }
        public bool Sua(TacGiaDTO tgDTO)
        {
            conn.Open();
            string SQL = string.Format("UPDATE TACGIA SET HOTEN = N'{0}', NGAYSINH = '{1}', GIOITINH = '{2}', GHICHU = N'{3}' " +
                "WHERE MATACGIA = {4}", tgDTO.HoTen, tgDTO.NgaySinh.ToString("yyyy-MM-dd"), tgDTO.GioiTinh, tgDTO.GhiChu, tgDTO.MaTacGia);
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
            string SQL = string.Format("UPDATE TACGIA SET XOA=1 WHERE MATACGIA={0}", id);
            SqlCommand com = new SqlCommand(SQL, conn);
            int kq = com.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            return false;
        }
        public TacGiaDTO LayTacGiaTheoMa(int matacgia)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SP_LayTacGiaTheoMa";
            com.Parameters.Add("matacgia", SqlDbType.Int).Value = matacgia;
            com.Connection = conn;
            SqlDataReader dr = com.ExecuteReader();
            TacGiaDTO tg = new TacGiaDTO();

            if (dr.Read())
            {
                tg.MaTacGia = matacgia;
                tg.HoTen = (string)dr["HoTen"];
                tg.NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
                tg.GioiTinh = (bool)dr["GioiTinh"];
                tg.GhiChu = (string)dr["GhiChu"];
            }
            conn.Close();
            return tg;
        }
    }
}
