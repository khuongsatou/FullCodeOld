using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class NhapXuatMang
    {
        static void Main(){
            Console.Write("Nhap N:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];// 5 ô
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("a[{0}] = ", i);

                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
       
    }
}
