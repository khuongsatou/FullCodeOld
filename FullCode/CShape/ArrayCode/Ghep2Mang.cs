using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class Ghep2Mang
    {
        static void Main()
        {
            Console.Write("Nhap N:");
            int n = int.Parse(Console.ReadLine());
            int[] nSoNguyen = new int[n];
            for (int i = 0; i < nSoNguyen.Length; i++)
            {
                Console.Write("n[{0}] = ", i);
                nSoNguyen[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Nhap M:");
            int m = int.Parse(Console.ReadLine());
            int[] mSoNguyen = new int[m];
            for (int i = 0; i < mSoNguyen.Length; i++)
            {
                Console.Write("m[{0}] = ", i);
                mSoNguyen[i] = int.Parse(Console.ReadLine());
            }

            int nSL = n + m;
            int[] newSoNguyen = new int[nSL];
            for (int i = 0; i < nSoNguyen.Length; i++)
            {
                newSoNguyen[i] = nSoNguyen[i];
            }
            int dem = 0;
            for (int i = nSoNguyen.Length; i < newSoNguyen.Length; i++)
            {
                newSoNguyen[i] = mSoNguyen[dem];
                dem++;
            }
            Console.WriteLine("Mang Chua Duoc Sap Xep:");
            //duyệt mảng
            for (int i = 0; i < newSoNguyen.Length; i++)
            {
                Console.WriteLine(newSoNguyen[i]);
            }


            
            for (int i = 0; i < newSoNguyen.Length; i++)
            {
                for (int j = i+1; j < newSoNguyen.Length; j++)
                {
                    if (newSoNguyen[i] > newSoNguyen[j])
                    {
                        swap(ref newSoNguyen[i], ref newSoNguyen[j]);
                    }
                }
               
            }

            Console.WriteLine("Mang Duoc Sap Xep:");
            for (int i = 0; i < newSoNguyen.Length; i++)
            {
                Console.WriteLine(newSoNguyen[i]);
            }
            Console.ReadKey();

        }

        private static void swap(ref int p1, ref int p2)
        {
            int temp = p1;
            p1 = p2;
            p2 = temp;
        }
    }
}
