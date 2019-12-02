/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package demomang2chieu;

import java.util.Scanner;

/**
 *
 * @author SV
 */
public class DoanNgaySinh {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner input = new Scanner(System.in);
        int ngaySinh = 0;
        int chon;
        // In ra 5 bảng
        for(int i=1; i<6; i++) {
            int[][] bang = taoBang(i);
            inMang2Chieu(bang);
            do {
                System.out.print("Ngay sinh cua ban co trong bang nay khong? (1: co, 0: khong): ");
                chon = input.nextInt();
            }while(chon < 0 || chon > 1);

            if(chon == 1) {
                ngaySinh += bang[0][0];
            }
        }
        System.out.println("Ngay sinh cua ban la: " + ngaySinh);
    }
    
    public static void inMang2Chieu(int[][] mang) {
        for(int i=0; i<mang.length; i++) {
            for(int j=0; j<mang[i].length; j++) {
                System.out.print(mang[i][j] + "\t");
            }
            System.out.println();
        }
    }
    
    public static int[][] taoBang(int thuTu) {
        int[][] bang = new int[4][4];
        int dong = 0, cot = 0;
        // Xét các ngày từ 1->31
        for(int i=1; i<32; i++) {
            // Chuyển qua chuỗi nhị phân của ngày i
            String binary = Integer.toBinaryString(i);
            // Nếu chuỗi chưa đủ 5 bit thì thêm số 0 vào trước
            int len = binary.length();
            for(int j = 0; j<5-len; j++) {
                binary = '0' + binary;
            }
            // Xét bit tại vị trí thuTu co bằng 1 không?
            // Nếu đúng ==> đưa vào bảng
            if(binary.charAt(5 - thuTu) == '1') {
               bang[dong][cot++] = i;
               if(cot == 4) {
                   dong++;
                   cot = 0;
               }
            }
        }
        return bang;
    }
}
