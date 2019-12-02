using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TinhTong3chuSo
    {
        static void Main()
        {
            Console.Write("Nhap so Nguyen co 3 chu so:");
            int s1 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());
            int s3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong 3 chu so:" + (s1 + s2 + s3));
            Console.ReadKey();
        }
    }
}
