using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class Chia2MangChanVaLe
    {
        static void Main()
        {
            Console.Write("Nhap N:");
            int n = int.Parse(Console.ReadLine());
            int [] arr = new int[n];
            
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
               
                arr[i] = rd.Next(rd.Next(101) + 10);
                Console.WriteLine("a[{0}] = {1}", i,arr[i]);
                //arr3[i] = -1;
            }

           

            int[] arr1 = new int[n];//chẳn
            int[] arr2 = new int[n];//lẽ
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr1[i] = arr[i];
                    
                }
                else
                {
                    arr2[i] = arr[i];
                }
            }

            Console.WriteLine("Mang Chan");
            int demC = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if ( arr1[i] != 0)
                {
                    
                    Console.WriteLine( "arr1["+demC+"] = " + arr1[i] + "\t");
                    demC++;
                }
                 
            }
            int demL = 0;
            Console.WriteLine("Mang Le");
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] !=0)
                {
                    
                    Console.WriteLine("arr2[" + demL + "] = " + arr2[i] + "\t");
                    demL++;
                }
                
            }
            Console.ReadKey();
        }
    }
}
