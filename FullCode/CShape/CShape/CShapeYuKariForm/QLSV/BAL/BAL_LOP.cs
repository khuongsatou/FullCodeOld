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
    public class BAL_LOP
    {
        DAL_LOP objdal = new DAL_LOP();
        public DataTable getLop()
        {
            return objdal.Select();
        }
    }
}
