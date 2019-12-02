using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class DauVaRot
    {
        static void Main()
        {
            int toan, ly, hoa;
            do
            {
                Console.Write("Nhap diem 3 mon thi:");
                toan = int.Parse(Console.ReadLine());
                ly = int.Parse(Console.ReadLine());
                hoa = int.Parse(Console.ReadLine());
                if (toan < 0 || toan > 10 || ly < 0 || ly > 10  || hoa < 0 || hoa > 10)
                {
                    Console.WriteLine("Diem Khong Hop le");
                }
            } while (toan < 0 || toan > 10 || ly < 0 || ly > 10  || hoa < 0 || hoa > 10);

            if (isDauRot( toan,  ly,  hoa))
            {
                Console.WriteLine("Dau");
                Console.WriteLine("Hoc deu cac mon");
            }
            else
            {
                Console.WriteLine("Thi hong");
                Console.WriteLine("Hoc Chua deu cac mon");
            }
            Console.ReadKey();
        }

        static bool isDauRot(int toan, int ly, int hoa)
        {
            if ((toan + ly + hoa) >= 15)
                return true;
            return false;
        }
    }
}
