using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TimSoLonNhatTrong3So
    {
        static void Main()
        {
            Console.Write("Nhap 3 so nguyen : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = a > b ? a : b > c ? b : c;

            Console.Write("So Lon Nhat : " + max);
            Console.ReadKey();
        }
    }
}
