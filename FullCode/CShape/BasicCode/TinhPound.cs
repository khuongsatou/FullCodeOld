using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TinhPound
    {
        static void Main()
        {
            Console.Write("Nhap so Pound:");
            float _pound = float.Parse(Console.ReadLine());
            Console.Write("Quy Doi:" + _pound * 0.454);
            Console.ReadKey();
        }
    }
}
