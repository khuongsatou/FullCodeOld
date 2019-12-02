using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValueObject;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class LoaiHangDAO
    {
        dbConnect db = new dbConnect();
        public DataTable GetData()
        {
            //DataTable dt = new DataTable();
            //dt = db.GetData("sp_LoaiHang_Select_All", null);
            //return dt;
            return db.GetData("sp_LoaiHang_Select_All", null);
        }

        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiHang",ID)
            };
            return db.GetData("sp_LoaiHang_Select_ByID", para);
        }

       
         public int Insert(LoaiHang obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("IDLoaiHang",obj.IDLoaiHang),
                new SqlParameter("TenLoaiHang",obj.TenLoai),
                new SqlParameter("MoTa",obj.MoTa)

             };
            return db.ExecuteSQL("sp_LoaiHang_Insert", para);
        }

         public int Update(LoaiHang obj)
         {
             SqlParameter[] para =
            {
                new SqlParameter("IDLoaiHang",obj.IDLoaiHang),
                new SqlParameter("TenLoaiHang",obj.TenLoai),
                new SqlParameter("MoTa",obj.MoTa)

             };
             return db.ExecuteSQL("sp_LoaiHang_Update", para);
         }

         public int Delete(string ID)
         {
             SqlParameter[] para =
            {
                new SqlParameter("IDLoaiHang",ID)
             };
             return db.ExecuteSQL("sp_LoaiHang_Delete", para);
         }

    }
}
