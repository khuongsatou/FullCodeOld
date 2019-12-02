using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BEL;
using DAL;
namespace BAL
{
    public class BAL_DM_SINHVIEN
    {
        public DataTable LayDSSinhVien()
        {
            DAL_MD_SINHVIEN sv = new DAL_MD_SINHVIEN();
            return sv.DocDSSinhVien();
        }


    }
}
