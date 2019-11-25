using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class IsSoDoiXung
    {
        static void Main()
        {
            int soNguyen = 0;
            do
            {
                 Console.Write("Nhap so nguyen co 3 chu so: ");
                 soNguyen = int.Parse(Console.ReadLine());
                 if (soNguyen < 99 || soNguyen > 999)
                 {
                     Console.WriteLine("So khong hop le ");
                 }
            } while (soNguyen < 99 || soNguyen > 999);

            int soThuNhat = soNguyen / 100;
            int soThuHai = soNguyen % 100 % 10;

            if (soThuNhat == soThuHai)
            {
                Console.WriteLine(soNguyen + " la so doi xung ");
            }
            else
            {
                Console.WriteLine(soNguyen + " la so khong doi xung ");
            }

           
            Console.ReadKey();
        }
    }
}
