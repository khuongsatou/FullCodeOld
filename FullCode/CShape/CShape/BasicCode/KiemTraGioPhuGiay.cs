using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class KiemTraGioPhuGiay
    {
        static void Main()
        {
            int gio, phut, giay;

            Console.Write("Nhap Gio - Phut - Giay : ");
            gio = int.Parse(Console.ReadLine());
            phut = int.Parse(Console.ReadLine());
            giay = int.Parse(Console.ReadLine());

            if (isTime(gio,phut,giay))
            {
                Console.WriteLine("{0} gio {1} phut {2} giay la hop le",gio,phut,giay);
            }
            else
            {
                Console.WriteLine("{0} gio {1} phut {2} giay la khong hop le", gio, phut, giay);
            }
            Console.ReadKey();
        }

        static bool isTime(int gio, int phut, int giay)
        {
            if ((0 <= gio && gio <= 23))
            {
                if ((0 <= phut && phut <= 59))
                {
                    if ((0 <= giay && giay <= 59))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
