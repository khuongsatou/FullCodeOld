using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TimUocChungAVaB
    {
        static void Main()
        {
            
            int a,b;
            do
            {
                Console.Write("Nhap 2 so nguyen duong: ");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
            } while (a<=0 || b<=0);


            Console.WriteLine();
            int ucln = UCLN(a, b);
            for (int i = 1; i <= ucln; i++)
            {
                if (ucln % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }


        static int UCLN(int a,int b)
        {
            while (a!=b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
    }
}
