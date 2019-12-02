using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class InThuRaEnglish
    {
        public static void Main()
        {
            int week = 0;
            do
            {
                Console.Write("Nhap Thu:");
                week = int.Parse(Console.ReadLine());
                if (week < 2 || week > 8)
                {
                    Console.WriteLine("Thu Khong hop le");
                }
            } while (week < 2 || week > 8);
            Console.WriteLine("Thu "+ week +" : "+theDaysOfWeek(week));
            Console.ReadKey();
        }
        public static string theDaysOfWeek(int week)
        {
            switch (week)
            {
                case 2: return "Monday";
                case 3: return "Tuesday";
                case 4: return "Wednesday";
                case 5: return "Thursday";
                case 6: return "Friday";
                case 7: return "Saturday";
                
            }
            return "Sunday";
        }
    }
}
