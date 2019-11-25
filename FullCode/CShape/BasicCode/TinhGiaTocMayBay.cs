using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TinhGiaTocMayBay
    {
        static void Main()
        {
            Console.Write("Nhap van toc:");
            float v = float.Parse(Console.ReadLine());
            Console.Write("Nhap gia toc:");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Do da duong bang toi thieu:"+(Math.Pow(v,2)/(2*a)));
            Console.ReadKey();
        }
    }
}
