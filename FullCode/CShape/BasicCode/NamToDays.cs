using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class NamToDays
    {
        static void Main()
        {
            
            int year = 0;
            do
            {
                Console.Write("Nhap Nam:");
                year = int.Parse(Console.ReadLine());
                if (year < 0)
                {
                   
                    Console.WriteLine("Nam Phai lon hon 0");
                }
            } while (year < 0);
            Console.WriteLine("Nam {0} co {1} Ngay ", year, totalDayOfYear(year));
            Console.ReadKey();
        }
        static bool isLeafYear(int year)
        {
            return ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) ? true : false;
        }

        static int totalDayOfYear(int year)
        {
            return isLeafYear(year) ? 366 : 365;
        }
    }

   
}
