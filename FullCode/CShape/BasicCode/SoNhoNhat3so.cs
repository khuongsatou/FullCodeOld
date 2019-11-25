using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class SoNhoNhat3so
    {
        static void Main()
        {
            Console.Write("Nhap 3 so nguyen : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int min = a > b ? b : a > c ? c : b;

            Console.Write("So Lon Nhat : " + min);
            Console.ReadKey();

        }
    }
}
