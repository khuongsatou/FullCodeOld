using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TinhGiaiThua
    {
        static void Main()
        {
           
            int n=0;

            do{
                Console.Write("Nhap so nguyen duong N: ");
                n = int.Parse(Console.ReadLine());
            }while(n<0);

            float s1 = 0;
            for (int i = 1; i <= n; i++)
            {
                s1 += i;
            }

            float s2 = 0;
            for (int i = 1; i <= n; i++)
            {
                s2 += ((2 * i - 1) - (2 * i));
            }

            float s3 = 0;
            for (int i = 1; i <= n; i++)
            {
                s3 += (float)1 / i;
            }
            float p = 1;
            for (int i = 1; i <= n; i++)
            {
                p *= i;
            }

            Console.WriteLine("S1 = {0}", s1);
            Console.WriteLine("S2 = {0}", s2);
            Console.WriteLine("S3 = {0}", s3);
            Console.WriteLine("P = {0}", p);

            Console.ReadKey();
        }
    }
}
