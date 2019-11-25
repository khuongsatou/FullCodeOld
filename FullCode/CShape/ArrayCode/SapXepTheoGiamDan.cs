using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class SapXepTheoGiamDan
    {
        static void Main()
        {
            Console.WriteLine("Nhap N:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(10) + 1;
                Console.WriteLine("a[{0}] = {1}", i, arr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("SS Tang Dan");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("a[{0}] = {1} ", i, arr[i]);
            }
            Console.ReadKey();
        }
    }
}
