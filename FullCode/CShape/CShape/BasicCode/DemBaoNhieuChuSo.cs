using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class DemBaoNhieuChuSo
    {
        static void Main()
        {
            // nhập vào 1 số -> 1
            // 2 số -> 2
            // 3 số -> 3
            // n số -> n
            //thế thì n / 10 -> vd 10 -> 1
            // 100 / 10 -> 10 / 10 -> 1
            //lặp chia hoài luôn
           
            int n=0;
            do
            {
                Console.Write("Nhap so nguyen duong N:");
                n = int.Parse(Console.ReadLine());
            } while (n<=0);

            int save =n;
            int dem = 0;
            while (n >= 10)
            {
                n /= 10;
                dem++;
            }

            Console.WriteLine("So "+ save +" co " + (dem+1) + " chu so");

            Console.ReadKey();
        }
    }
}
