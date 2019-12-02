using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TinhGiay
    {
        static void Main()
        {
            Console.Write("Nhap Tong so giay:");
            int _Giay = int.Parse(Console.ReadLine());
            int _Phut = _Giay / 60;
            int _GiayDu = (_Giay % 60);
            Console.WriteLine("Quy Doi:" + _Phut + " Phut - " + _GiayDu + " giay");
            Console.ReadKey();
        }
    }
}
