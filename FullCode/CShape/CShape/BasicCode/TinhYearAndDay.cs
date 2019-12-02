using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class TinhYearAndDay
    {
        public static void Main()
        {
            Console.Write("Nhap So Phut:");
            int phut = int.Parse(Console.ReadLine());
            //tính thử 1 ngày thì , nhập vào  
     
            int nam = phut / (365*24*60); // 1 day = 24 hours -> 1h = 60p 
            int ngay = phut % (365 * 24 * 60) / (24 * 60);
            //
            //int year = day / 365;
            Console.WriteLine("Ket qua:" + phut + "phut xap xi " +nam+ " nam " +ngay+" ngay");
            Console.ReadKey();
            // 1 năm = 365 ngày
            // 1 ngày = 24 giờ
            // 1 giờ = 60 phút
            // => thế 1 năm  thì là bao nhiêu phút 1 năm =
            // 1(365n * 24h * 60p) =  525600 phút
            // => thế  2 năm thì là bao nhiêu phút
            // y*(365n * 24h * 60p) = x phút
            // y = x/(365n * 24h * 60p) phút
            // thế thì 1 năm thì được bao nhiêu ngày
            // 1 năm = 365n * 24h???

        }
        public int CalHours(int phut)
        {
            return phut / 60;//nếu theo quy đổi thì 1 hour=60 minutes -> 
        }

        public int CalDay(int hour)
        {
            return hour / 24;//nếu theo quy đổi thì 1 hour=60 minutes -> 
        }

        public int CalMonth(int day)
        {
            return day / 30;//nếu theo quy đổi thì 1 hour=60 minutes -> 
        }

        public int CalYear(int month)
        {
            return month / 24;//nếu theo quy đổi thì 1 hour=60 minutes -> 
        }


    }
}
