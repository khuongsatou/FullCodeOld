using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class BangTinhToan
    {
        static void Main()
        {
            Console.Write("Nhap 2 so nguyen :");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("-------- PHEP TOAN --------");
            int chon = 0;
            float ketqua = 0f;
            string math = "";
            bool kiemtra = false;
            do
            {
                Console.WriteLine("Cong (a+b) ");
                Console.WriteLine("Cong (a-b) ");
                Console.WriteLine("Cong (a*b) ");
                Console.WriteLine("Cong (a/b) ");
                Console.WriteLine("-------- --------");
                chon = int.Parse(Console.ReadLine());

            } while (chon < 0 || chon > 4);

            switch (chon)
            {
                case 1:
                    ketqua = a + b;
                    math = "+";
                    break;
                case 2:
                    ketqua = a - b;
                    math = "-";
                    break;
                case 3:
                    ketqua = a * b;
                    math = "*";
                    break;
                case 4:
                    if (b != 0)
                    {
                        ketqua = a / b;
                        math = "/";
                        kiemtra = true;
                    }
                    else
                    {
                        kiemtra = false;
                    }
                    break; 
            }
            if (chon == 4)
            {
                if (kiemtra)
                {
                    Console.WriteLine("Ket qua {0} {1} {2} = {3}", a, math, b, ketqua);
                }
                else
                {
                    Console.WriteLine("Ket qua b phai khac 0");
                }
            }
            else
            {
                Console.WriteLine("Ket qua {0} "+ math +" {1} = {2}", a , b, ketqua);
            }
            Console.ReadKey();
        }

        
    }
}
