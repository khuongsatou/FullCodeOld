using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class NamAndMonthOfDay
    {
        static void Main()
        {
            Console.Write("Nhap so nguyen: ");
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Thang "+month+" nam "+year+" co "+isMonth(month, year)+" ngay " );
            Console.ReadKey();
        }

        static bool isLeafYear(int year)
        {
            return ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) ? true : false;
        }

        static int isMonth(int month,int year)
        {
            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (isLeafYear(year))
                         return 29;
                    return 28;
            }
            return 31;
        }
    }
}
