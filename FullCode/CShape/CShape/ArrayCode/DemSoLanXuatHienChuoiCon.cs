using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class DemSoLanXuatHienChuoiCon
    {
        static void Main()
        {
            Console.WriteLine("Nhap S1:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Nhap S2:");
            string str2 = Console.ReadLine();
            int cnt = -1;
            int idx = -1;
            int strt = 0;
            while (strt !=-1)
            {
                strt = str1.IndexOf(str2, idx + 1);
                cnt++;
                idx = strt;
            }

            Console.Write("Chuoi con '{0}' xuat hien " + cnt + " lan", str2);
            Console.ReadKey();
            
        }
    }
}
