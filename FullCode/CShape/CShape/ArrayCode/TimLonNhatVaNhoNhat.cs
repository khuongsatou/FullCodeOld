using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class TimLonNhatVaNhoNhat
    {
        static void Main()
        {
            Console.Write("Nhap N:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(5) + 1;
                Console.WriteLine("a[{0}] = {1} ", i,arr[i]);
               
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            int max = 0;
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                else
                {
                    min = arr[i];
                }
            }
            
            Console.WriteLine("Nhap Max: "+max);
            Console.WriteLine("Nhap Max: " + min);
            Console.ReadKey();
        }
    }
}
