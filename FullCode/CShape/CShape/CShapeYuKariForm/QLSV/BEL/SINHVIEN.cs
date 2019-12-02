using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class SINHVIEN
    {
        private int _maSV;

        public int MaSV
        {
            get { return _maSV; }
            set { _maSV = value; }
        }
        private string _hoTen;

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private DateTime _ngaySinh;

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }
        private int _maLop;

        public int MaLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }

        public SINHVIEN()
        {

        }

        public SINHVIEN(int masv,string hoten ,string diachi,DateTime ngaysinh,int malop)
        {
            this._maSV = masv;
            this._hoTen = hoten;
            this._diaChi = diachi;
            this._ngaySinh = ngaysinh;
            this._maLop = malop;
        }
    }
}
