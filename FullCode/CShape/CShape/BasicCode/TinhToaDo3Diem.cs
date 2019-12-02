using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace is_sizeof
{
    class TinhToaDo3Diem
    {
        static void Main()
        {
            double x1,x2,x3,y1,y2,y3;
            double side1, side2, side3;
            Console.Write("Nhap toa do diem thu 1:");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap toa do diem thu 2:");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.Write("Nhap toa do diem thu 3:");
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());

            side1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            side2 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            side3 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));

            double p = (side1 + side2 + side3)/2;
            double s =Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));

            Console.WriteLine("Dien Tich cua tam giac: "+ s);
            
            
          
            //Debug.WriteLine("Key:"+(side1)+"\t");
            //Console.WriteLine(side1);
            Console.ReadKey();

        }
    }
}
