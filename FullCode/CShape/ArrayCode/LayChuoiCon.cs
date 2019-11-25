using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class LayChuoiCon
    {
        static void Main()
        {
            Console.WriteLine("Nhap Chuoi Me:");
            string str = Console.ReadLine();
            Console.WriteLine("Start:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Lenght");
            int lenght = int.Parse(Console.ReadLine());
            char[] arr1 = str.ToCharArray(0, str.Length);
            int c = 0;
            Console.WriteLine("Chuoi Me:" + str);
            Console.WriteLine("Chuoi Con:");
            while (c < lenght)
            {
                Console.Write(arr1[start + c - 1]);
                c++;
            }

            //string str;
            //char[] arr1;
            //int pos, l, ln, c = 0;
            //Console.Write("Nhap Chuoi Me:");
            //str = Console.ReadLine();
            //ln = str.Length;
            //arr1 = str.ToCharArray(0, ln);
            //Console.Write("Nhap vi tri bat dau:");
            //pos = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhap do dai:");
            //l = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Chuoi con thu duoc la:");
            //while (c < l)
            //{
            //    Console.Write(arr1[pos + c - 1]);
            //    c++;
            //}
            

            
            //Console.WriteLine("Chuoi Con:" +c);
            Console.ReadKey();
        }
    }
}
