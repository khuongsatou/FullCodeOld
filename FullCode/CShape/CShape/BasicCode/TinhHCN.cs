using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TinhHCN
    {
        static void Main()
        {
            float _ChieuDai, _ChieuRong;
            Console.Write("Nhap Chieu Dai:");
            _ChieuDai=float.Parse(Console.ReadLine());
            Console.Write("Nhap Chieu Rong:");
            _ChieuRong = float.Parse(Console.ReadLine());
            Console.Write("Chu Vi:" + (_ChieuDai + _ChieuRong) * 2);
            Console.Write("Dien Tich:" + (_ChieuDai * _ChieuRong));
            Console.ReadKey();
        }
    }
}
