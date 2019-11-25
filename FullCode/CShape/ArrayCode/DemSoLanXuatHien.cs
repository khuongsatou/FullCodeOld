using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_arrayCshape
{
    class DemSoLanXuatHien
    {
        static void Main()
        {
            Console.Write("Nhap N:");
            int n = int.Parse(Console.ReadLine());
            int[] nArr = new int[n];
            int[] frArr = new int[n];//?
            for (int i = 0; i < nArr.Length; i++)
			{
                Console.Write("nArr[{0}] = ",i);
                nArr[i] = int.Parse(Console.ReadLine());
                frArr[i] = -1;//?
            }
            int dem = 0;
           
            for (int i = 0; i < nArr.Length; i++)
            {
                dem = 1;// mỗi phần tử mặc định sẽ xuất hiện 1 lần
                for (int j = i+1; j < nArr.Length; j++)//so sánh 0 với 1
                {
                    if (nArr[i]== nArr[j])//==
                    {
                        dem++;// tăng đếm thêm 1
                        frArr[j] = 0;// gán phần tử đó thành 0
                    }
                }
                if (frArr[i] !=0 )//nếu 0 ! =0
                {
                    frArr[i] = dem; 
                }
                 
            }

            for (int i = 0; i < nArr.Length; i++)
            {
                if (frArr[i] !=0)
                {
                     Console.WriteLine("Phan tu thu " + nArr[i] + " xuat hien " + frArr[i]);
                }
            }

            Console.ReadKey();
            

            //muốn đếm được số lần xuất hiện  1 2 3 4 5 1 1 => 3 lần xuất hiện số 1
            // vd: 1 -> 
            //phải có 1 biến đếm và duyệt 2 lần , for i =0 { for j= 1  giữ lại thứ 0 và duyệt toàn mảng nếu có thì đếm 
        }
    }
}
