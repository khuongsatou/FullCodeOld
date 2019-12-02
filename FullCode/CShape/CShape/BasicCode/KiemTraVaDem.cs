using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class KiemTraVaDem
    {
        static void Main()
        {
            Console.Write("Nhap so nguyen duong N:");
            int n = int.Parse(Console.ReadLine());
            int save = n;
            if (n < 0)
            {
                Console.WriteLine("So khong hop le");
            }
            else if(n==0)
            {
                Console.WriteLine("Cam On, Hen Gap Lai");
            }
            else
            {
                int dem = 0;
                while (n >= 10)
                {
                    n /= 10;
                    dem++;
                }

                Console.WriteLine("So " + save + " co "+(dem+1)+" chu so");
            }
            Console.ReadKey();
           
            

           
           
        }
    }
}
