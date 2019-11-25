using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class DocSoNguyen0To9
    {
        static void Main()
        {
            int soNguyen = 0;
            do
            {
                Console.Write("Nhap so nguyen:");
                soNguyen = int.Parse(Console.ReadLine());
                if (soNguyen < 0 || soNguyen > 9 )
                {
                    Console.WriteLine("So khong hop le ");
                }
            } while (soNguyen < 0 || soNguyen > 9 );
          
            Console.WriteLine(""+inTenSo(soNguyen));
        }
        static string inTenSo(int soNguyen)
        {
            switch (soNguyen)
            {
                case 1: return "Mot";
                case 2: return "Hai";
                case 3: return "Ba";
                case 4: return "Bon";
                case 5: return "Nam";
                case 6: return "Sau";
                case 7: return "Bay";
                case 8: return "Tam";
            }
            return "Chin";

        }
    }
}
