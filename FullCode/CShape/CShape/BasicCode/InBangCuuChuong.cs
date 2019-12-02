using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class InBangCuuChuong
    {
        static void Main()
        {
            
            int soNguyen = 0;
            do
            {
                Console.Write("Nhap so nguyen duong N: ");
                soNguyen = int.Parse(Console.ReadLine());
            } while (soNguyen < 0);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(soNguyen + " x " + i + " = " + (soNguyen*i) );
               
            }
            Console.ReadKey();
        }
    }
}
