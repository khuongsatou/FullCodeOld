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
    public class BAL_DM_LOP
    {
        public DataTable LayDanhSachLop()
        {
            DAL_MD_LOP lop = new DAL_MD_LOP();
            return lop.DocDanhSachLop();
        }
    }
}
