using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TacGiaDTO
    {
        public int MaTacGia { set; get; }
        public string HoTen { set; get; }
        public DateTime NgaySinh { set; get; }
        public bool GioiTinh { set; get; }
        public bool Xoa { set; get; }
        public string GhiChu { set; get; }

        public TacGiaDTO()
        {
            MaTacGia = 0;
            HoTen = "";
            NgaySinh = DateTime.Now;
            GioiTinh = false;
            Xoa = false;
            GhiChu = "";
        }
    }
}
