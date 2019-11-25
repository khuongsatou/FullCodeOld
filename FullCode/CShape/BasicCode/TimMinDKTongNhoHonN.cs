using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TimMinDKTongNhoHonN
    {
        static void Main()
        {
            int n =0;
            do
            {
                Console.Write("Nhap so nguyen duong N:");
                n = int.Parse(Console.ReadLine());
            } while (n<=0);
            //int tong = 0;
            //int dem = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    tong += i;
            //    if (n > tong)
            //    {
            //        dem++;
            //    } 
            //}
            int i = 0;
            int tong = 0;
            int dem = 0;
            while (i<=n)
            {
                tong += i;
                if (tong < n)
                {
                    dem++;
                }
                i++;
            }
            Console.WriteLine(dem);
            Console.ReadKey();
            
        }
    }
}
