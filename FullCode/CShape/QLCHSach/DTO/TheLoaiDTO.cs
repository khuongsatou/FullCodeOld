using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TheLoaiDTO
    {
        public int MaTheLoai { set; get; }
        public string Ten { set; get; }
        public bool Xoa { set; get; }
        public string GhiChu { set; get; }

        public TheLoaiDTO()
        {
            MaTheLoai = 0;
            Ten = "";
            Xoa = false;
            GhiChu = "";
        }
    }
}
