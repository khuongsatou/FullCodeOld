using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HDNhapHangDTO
    {
        public int MaHD { get; set; }
        public DateTime NgayNhap { get; set; }
        public int MaNV { get; set; }
        public string GhiChu { get; set; }

        public HDNhapHangDTO()
        {
            MaHD = 0;
            NgayNhap = DateTime.Now;
            MaNV = 0;
            GhiChu = "";
        }
    }
}
