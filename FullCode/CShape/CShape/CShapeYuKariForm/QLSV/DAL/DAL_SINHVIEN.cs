using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BEL;
namespace DAL
{
    public class DAL_SINHVIEN: GENERAL
    {
        public DataTable Select()
        {
            connect_db();
            string sql = string.Format("SELECT * FROM SINHVIEN");
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            disconnect_db();
            return dt;
        }
        public DataTable Select_MaSV(int masv)
        {
            connect_db();
            string sql = string.Format("SELECT * FROM SINHVIEN WHERE MaSV = {0}",masv);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            disconnect_db();
            return dt;
        }
        public bool Them(SINHVIEN sv)
        {
            connect_db();
            string sql = string.Format("INSERT INTO SINHVIEN(MaSV,Hoten,DiaChi,NgaySinh,MaLop) VALUES({0},N'{1}',N'{2}',N'{3}',{4}) ",sv.MaSV,sv.HoTen,sv.DiaChi,sv.NgaySinh,sv.MaLop);
            SqlCommand cmd = new SqlCommand(sql, conn);
            int row = cmd.ExecuteNonQuery();
            disconnect_db();
            if (row > 0)
            {
                return true;
            }
            return false;
           
        }
        public bool Update(SINHVIEN sv,int masv)
        {
            connect_db();
            string sql = string.Format("UPDATE SINHVIEN  SET Hoten=N'{1}',DiaChi =N'{2}',NgaySinh=N'{3}',MaLop={4} WHERE MaSV = {0}", masv, sv.HoTen, sv.DiaChi, sv.NgaySinh, sv.MaLop);
            SqlCommand cmd = new SqlCommand(sql, conn);
            int row = cmd.ExecuteNonQuery();
            disconnect_db();
            if (row > 0)
            {
                return true;
            }
            return false;

        }

        public bool Delete( int masv)
        {
            connect_db();
            string sql = string.Format("DELETE FROM SINHVIEN WHERE Masv ={0}",masv);
            SqlCommand cmd = new SqlCommand(sql, conn);
            int row = cmd.ExecuteNonQuery();
            disconnect_db();
            if (row > 0)
            {
                return true;
            }
            return false;

        }

    }
}
