using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace is_sizeof
{
    class TimVaXemDoLaTamGiacGI
    {
        static void Main()
        {
            int a, b, c;
            do
            {
                Console.Write("Nhap 3 canh a b c:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
            } while (a<=0 || b<=0 || c<=0);

            if ((a+b > c) && (a+c > b) && (b+c > a))
            {
                if (a==b && a==c)
                {
                    Console.WriteLine("tam giac deu");
                }else if (a==b || a==c || b==c)
                {
                    Console.WriteLine("tam giac can");
                }
                else
                {
                    Console.WriteLine("tam giac thuong");
                }

            }
            else
            {
                Console.WriteLine("Khong phai tam giac");
            }
            Console.ReadKey();

        }
    }
}
