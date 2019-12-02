using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using BEL;
namespace BAL
{
    public class BAL_SINHVIEN
    {
        DAL_SINHVIEN objdal = new DAL_SINHVIEN();
        public DataTable getSinhVien()
        {
            return objdal.Select();
        }
        public DataTable getSinhVien_MaSV(int masv)
        {
            return objdal.Select_MaSV(masv);
        }
        public bool Them(SINHVIEN sv)
        {
            return objdal.Them(sv);
        }
        public bool CapNhat(SINHVIEN sv,int masv)
        {
            return objdal.Update(sv,masv);
        }

        public bool Xoa(int masv)
        {
            return objdal.Delete(masv);
        }
    }
}
