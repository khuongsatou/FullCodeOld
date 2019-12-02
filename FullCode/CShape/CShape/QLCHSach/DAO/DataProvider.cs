using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DataProvider
    {
        //string ChoiKetNoi = "Data Source=VANLINH-PC;Initial Catalog=QLCUAHANGSACH;Integrated Security=True";
        protected SqlConnection conn = new SqlConnection("Data Source=VANLINH-PC;Initial Catalog=QLCUAHANGSACH;Integrated Security=True");
    }
}
