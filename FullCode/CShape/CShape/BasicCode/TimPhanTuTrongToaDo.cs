using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TimPhanTuTrongToaDo
    {
        static void Main()
        {
            Console.Write("Nhap toa do X:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do Y:");
            int y = int.Parse(Console.ReadLine());

            if (x >= 0 && y >=0)
            {
                Console.WriteLine("I");
            }
            else if (x <= 0 && y <=0)
            {
                Console.WriteLine("III");
            }
            else if (x <= 0 && y >= 0)
            {
                Console.WriteLine("II");
            }
            else
            {
                Console.WriteLine("IV");
            }
            Console.ReadKey();
        }
    }
}
