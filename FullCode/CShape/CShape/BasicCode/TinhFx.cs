using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TinhFx
    {
        static void Main()
        {
            Console.Write("Nhap x:");
            int x = int.Parse(Console.ReadLine());
            double f = 0f;
            if (x >= 5)
            {
                f = 2 * Math.Pow(x, 2) + 5 * x + 9;
            }
            else
            {
                f = -2 * Math.Pow(x, 2) + 4 * x - 9;
            }
            Console.WriteLine("f({0}) = {1}", x, f);
            Console.ReadKey();
        }
    }
}
