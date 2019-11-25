using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class ChoBietThongTinThoiTiet
    {
        static void Main()
        {
            Console.Write("Nhap nhiet do:");
            int c = int.Parse(Console.ReadLine());
            if (c < 0 )
            {
                Console.WriteLine("Thoi Tiet bang gia");
            }
            else if (c >= 0 && c < 10)
            {
                 Console.WriteLine("Thoi Tiet rat lanh");
            }
            else if (c >= 10 && c < 20)
            {
                Console.WriteLine("Thoi Tiet lanh");
            }
            else if (c >= 20 && c < 30)
            {
                Console.WriteLine("Thoi Tiet am ap");
            }
            else if (c >= 30 && c <= 40)
            {
                Console.WriteLine("Thoi Tiet nong");
            }
            else
            {
                Console.WriteLine("Thoi Tiet rat nong");
            }

            Console.ReadKey();
          

        }
    }
}
