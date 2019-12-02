using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class SaoChepSangMangKhac
    {
        static void Main()
        {
            Console.Write("Nhap vao N:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("a[{0}]", i);
                arr[i] = int.Parse(Console.ReadLine());

            }
            int[] arrTwo = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arrTwo[i] = arr[i];
            }

            for (int i = 0; i < arrTwo.Length; i++)
            {
                Console.WriteLine(arrTwo[i]);
            }
           
            Console.ReadKey();
        }
    }
}
