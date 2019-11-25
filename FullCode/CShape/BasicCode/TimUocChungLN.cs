using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TimUocChungLN
    {
        static void Main()
        {
            int a,b;
            do
            {
                Console.Write("Nhap 2 so nguyen duong:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
            } while (a<=0||b<=0);

            while (a!=b)
            {
                if (a>b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
