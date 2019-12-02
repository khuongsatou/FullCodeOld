using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{

    public class NhaXuatBanBUS
    {
        NhaXuatBanDAO nxbDAO = new NhaXuatBanDAO();
        public DataTable LayDanhSach()
        {
            return nxbDAO.LayDanhSach();
        }

        public bool Them(NhaXuatBanDTO nxbDTO)
        {
            if (nxbDTO.Ten == "")
            {
                throw new Exception("Chưa nhập tên nhà xuất bản!");
            }
            return nxbDAO.Them(nxbDTO);
        }

        public bool Sua(NhaXuatBanDTO nxbDTO)
        {
            if (nxbDTO.Ten == "")
            {
                throw new Exception("Chưa nhập tên nhà xuất bản!");
            }
            return nxbDAO.Sua(nxbDTO);
        }

        public bool Xoa(int id)
        {
            return nxbDAO.Xoa(id);
        }

        public NhaXuatBanDTO LayNhaXuatBanTheoMa(int manxb)
        {
            return nxbDAO.LayNhaXuatBanTheoMa(manxb); 
        }
    }
}
