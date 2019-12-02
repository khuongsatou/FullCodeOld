using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TinhGiaTocTrungBinh
    {
        static public void Main()
        {
            Console.Write("Nhap van toc v0:");
            float v0 = float.Parse( Console.ReadLine());
            Console.Write("Nhap van toc v1:");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Nhap thoi gian t:");
            float t = float.Parse(Console.ReadLine());
            Console.Write("a="+((v1-v0)/t));
            Console.ReadKey();
        }
    }
}
