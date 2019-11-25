using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class SinhVien
    {
        string _masv;

        public string Masv
        {
            get { return _masv; }
            set { _masv = value; }
        }
        string _hoten;

        public string Hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
        }
        string _ngaysinh;

        public string Ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }
        string _gioitinh;

        public string Gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        string _diachi;

        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        string _malop;

        public string Malop
        {
            get { return _malop; }
            set { _malop = value; }
        }

        public SinhVien ()
	    {
            this._masv ="";
            this._hoten = "";
            this._ngaysinh = "";
            this._gioitinh = "";
            this._diachi = "";
            this._malop = "";
	    }
        public SinhVien(string masv, string hoten,string ngaysinh,string diachi,string gioitinh,string malop)
        {
            this._masv = masv;
            this._hoten = hoten;
            this._ngaysinh = ngaysinh;
            this._gioitinh = gioitinh;
            this._diachi = diachi;
            this._malop = malop;
        }
        
    }
}
