using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhaXuatBanDTO
    {
        public int MaNXB { set; get; }
        public string Ten { set; get; }
        public string Website { set; get; }
        public string Email { set; get; }
        public bool Xoa { set; get; }
        public string GhiChu { set; get; }

        public NhaXuatBanDTO()
        {
            MaNXB = 0;
            Ten = "";
            Website = "";
            Email = "";
            Xoa = false;
            GhiChu = "";
        }
    }
}
