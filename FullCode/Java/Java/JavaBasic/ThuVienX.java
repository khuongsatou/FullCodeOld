/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thuvienx;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author SV
 */
public class ThuVienX {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        ArrayList<Sach> dsSach = new ArrayList();
        Scanner input = new Scanner(System.in);
        System.out.print("Nhập số lượng loại sách: ");
        int n = input.nextInt();
        
        for(int i=0; i<n; i++) {
            System.out.print("Loại sách (0: GK, 1: TK): ");
            int loai = input.nextInt();
            Sach sach;
            if(loai == 0) {
                sach = new SachGiaoKhoa();
            } else {
                sach = new SachThamKhao();
            }
            dsSach.add(sach);
        }
        
        // In danh sách
        for(Sach sach : dsSach) { // foreach trong Java
            System.out.println(sach.toString());
        }
        
        // Tính tổng tiền cho từng loại
        int tongTienGK = 0;
        int tongTienTK = 0;
        for(Sach sach : dsSach) { // foreach trong Java
            if(sach instanceof SachGiaoKhoa) {
                tongTienGK += sach.getThanhTien();
            } else {
                tongTienTK += sach.getThanhTien();
            }
        }
        System.out.println("Tổng tiền:");
        System.out.println("Sách giáo khoa: " + tongTienGK);
        System.out.println("Sách tham khảo: " + tongTienTK);
    }
    
}
