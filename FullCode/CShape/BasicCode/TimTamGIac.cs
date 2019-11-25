using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TimTamGIac
    {
        static void Main()
        {
            int a,b,c;
            do
            {
                Console.Write("Nhap 3 canh a , b , c:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
            } while (a<= 0 || b <= 0 || c<=0);

            if ((a+b>c) && (a+c > b) && (c+b > a)  )
            {
                Console.WriteLine("Day la tam giac");
            }
            else
            {
                Console.WriteLine("Day khong la tam giac");
         
            }
            Console.ReadKey();
        }
    }
}
