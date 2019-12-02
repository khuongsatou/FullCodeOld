using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class SoNutBangSoXe
    {
        static void Main()
        {
            // Nút Là gì
            Console.Write("Nhap bang so xe:");
            int bangSo = int.Parse(Console.ReadLine());
            int nut1 = bangSo / 1000;//5358 -> /1000 =5
            int nut2 = bangSo % 1000 / 100;//5358 -> %1000 = 358 -> /100 -> 3
            int nut3 = bangSo % 1000 % 100 / 10; //5358  -> 358 -> 58  / 10 -> 5 
            int nut4 = bangSo % 1000 % 100 % 10; //5358  -> 358 -> 58  % 10 -> 8

            Console.WriteLine("So Nut"+(nut1+nut2+nut3+nut4));
            Console.ReadKey();


        }
    }
}
