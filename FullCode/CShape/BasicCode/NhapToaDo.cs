using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class NhapToaDo
    {
        static public void Main()
        {
            Console.Write("Nhap toa do diem thu nhat:");
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            Console.Write("Nhap toa do diem thu hai:");
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
            Console.Write("Khoang cach giua hai diem: " + Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.ReadKey();
        }
    }
}
