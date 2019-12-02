using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class PhuongTrinhBacHai
    {
        static void Main()
        {
            Console.Write("Nhap 3 so nguyen:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double denta = Math.Pow(b, 2) - 4 * a * c;
            if (denta > 0)
            {
                Console.WriteLine("Phuong Trinh Co Nghiem Phan Biet:");
                Console.WriteLine("X1 = " + (-b + Math.Sqrt(denta))/(2*a));
                Console.WriteLine("X2 = " + (-b - Math.Sqrt(denta)) / (2 * a));
            }
            else if (denta < 0)
            {
                Console.WriteLine("Phuong Trinh Co Nghiem Kep");
                Console.WriteLine("X1 = X2 = " + (-b)/(2*a));

            }
            else
            {
                Console.WriteLine("Phuong Trinh Vo Ngiem:");
            }

            Console.ReadKey();

        }
    }
}
