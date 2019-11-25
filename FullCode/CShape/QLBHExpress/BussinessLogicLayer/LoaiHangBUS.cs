using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using ValueObject;
using System.Data;
namespace BusinessLogicLayer
{
    public class LoaiHangBUS
    {
        LoaiHangDAO dao = new LoaiHangDAO();

        public DataTable GetData()
        {
            return dao.GetData();
        }

        public DataTable GetDataByID(string id)
        {
            return dao.GetDataByID(id);
        }

        public int Insert(LoaiHang obj)
        {
            return dao.Insert(obj);
        }

        public int Update(LoaiHang obj)
        {
            return dao.Update(obj);
        }

        public int Delete(string ID)
        {
            return dao.Delete(ID);
        }


    }
}
