using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class DemThuongHoaSoKiTu
    {
        static void Main()
        {
            Console.WriteLine("Nhap Chuoi:");
            string str = Console.ReadLine();
            int chucai = 0, chuso = 0, kitu = 0;
       
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z') )
                {
                    chucai++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    chuso++;
                }
                else 
                {
                    kitu++;
                }
            }

            Console.WriteLine("ChuCai {0},ChuSo {1} Kitu {2}", chucai, chuso, kitu);

            Console.ReadKey();
        }
    }
}
