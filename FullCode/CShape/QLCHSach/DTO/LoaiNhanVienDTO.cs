using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoaiNhanVienDTO
    {
        //Các thuộc tính
        public int MaLoaiNV { set; get; }
        public string Ten { set; get; }
        public bool Xoa { set; get; }
        public string GhiChu { set; get; }

        //Phương thức khởi tạo
        public LoaiNhanVienDTO()
        {
            MaLoaiNV = 0;
            Ten = "";
            Xoa = false;
            GhiChu = "";
        }
    }
}
