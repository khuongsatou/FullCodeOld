using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_sizeof
{
    class XepHangHocLuc
    {
        static void Main()
        {
            int diemBaiKiemTra,diemThiGiuaKi,diemThiCuoiKi;
            Console.Write("Nhap 3 diem thi: ");
            do
            {
                 diemBaiKiemTra = int.Parse(Console.ReadLine());
                 diemThiGiuaKi = int.Parse(Console.ReadLine());
                 diemThiCuoiKi = int.Parse(Console.ReadLine());
                 if (diemBaiKiemTra < 0 || diemBaiKiemTra > 10 || diemThiGiuaKi < 0 || diemThiGiuaKi > 10 || diemThiCuoiKi<0 || diemThiCuoiKi > 10)
                 {
                     Console.WriteLine("Diem Thi Khong Hop Le");                     
                 }
            } while (diemBaiKiemTra < 0 || diemBaiKiemTra > 10 || diemThiGiuaKi < 0 || diemThiGiuaKi > 10 || diemThiCuoiKi<0 || diemThiCuoiKi > 10);

            float diemTrungBinh = (float)(diemBaiKiemTra + diemThiGiuaKi + diemThiCuoiKi) / 3;
            string hang = "";
            if (diemTrungBinh > 9.0)
            {
                hang = "A";
            }
            else if (diemTrungBinh >= 7.0 && diemTrungBinh < 9.0)
            {
                hang = "B";
            }
            else if (diemTrungBinh >= 5.0 && diemTrungBinh < 7.0)
            {
                hang = "C";
            }
            else
            {
                hang = "F";
            }

            Console.WriteLine("Ket Qua : " + diemTrungBinh);
            Console.WriteLine("Hang " + hang);
            Console.ReadKey();

        }


    }
}
