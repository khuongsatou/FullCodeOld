using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class LoaiNhanVienBUS
    {
        LoaiNhanVienDAO lnvDAO = new LoaiNhanVienDAO();
        public DataTable LayDanhSach()
        {
            return lnvDAO.LayDanhSach();
        }
        public bool Them(LoaiNhanVienDTO lnvDTO)
        {
            //kiểm tra dữ liệu đầu vào
            if (lnvDTO.Ten == "")
            {
                throw new Exception("Chưa nhập tên loại nhân viên");
            }
            return lnvDAO.Them(lnvDTO);
        }
        public bool Sua(LoaiNhanVienDTO lnvDTO)
        {
            if (lnvDTO.Ten == "")
            {
                throw new Exception("Chưa nhập tên loại nhân viên");
            }
            return lnvDAO.Sua(lnvDTO);

        }
        public bool Xoa(int id)
        {
            return lnvDAO.Xoa(id);
        }
    }
}
