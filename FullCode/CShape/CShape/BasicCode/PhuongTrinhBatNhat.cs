using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class PhuongTrinhBatNhat
    {
        static void Main()
        {
            Console.Write("Nhap 2 so nguyen:");
            int soNguyenOne = int.Parse(Console.ReadLine());
            int soNguyenTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Nghiem x = {0}", ((float)-soNguyenTwo / (soNguyenOne)));
            Console.ReadKey();
        }
    }
}
