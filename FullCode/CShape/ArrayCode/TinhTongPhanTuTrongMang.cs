using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class TinhTongPhanTuTrongMang
    {
        static void Main()
        {
            Console.Write("Nhap N:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int tong = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("a[{0}]=", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
       

            for (int i = 0; i < arr.Length; i++)
            {
                tong += arr[i];
            }
            Console.WriteLine("Mang N co tong la " + tong);
            Console.ReadKey();


        }
    }
}
