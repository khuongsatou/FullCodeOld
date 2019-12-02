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
public class Bai53 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int m;
        System.out.print("Nhap kich thuoc ma tran (so dong = so cot): ");
        m = input.nextInt();
        
        int[][] maTranA = taoMang2Chieu(m, m);
        System.out.println("Ma tran A: ");
        inMang2Chieu(maTranA);
        
        int[][] maTranB = taoMang2Chieu(m, m);
        System.out.println("Ma tran A: ");
        inMang2Chieu(maTranB);
        
        int[][] maTranC = tinhTong2MaTran(maTranA, maTranB);
        System.out.println("A + B: ");
        inMang2Chieu(maTranC);
        
        int[][] maTranD = nhan2MaTran(maTranA, maTranB);
        System.out.println("A x B: ");
        inMang2Chieu(maTranD);
        
    }
    
    // Tạo số nguyên ngẫu nhiên có giá trị trong đoạn [min, max]
    public static int taoSoNgauNhien(int min, int max) {
        return ((int)(Math.random() * (max - min + 1)) + min);
    }
    
    // Tạo mảng 2 chiều với các phần tử dong x cot
    // các phần tử của mảng có giá trị trong đoạn từ 1 đến 10
    public static int[][] taoMang2Chieu(int dong, int cot) {
        int[][] mang = new int[dong][cot];
        for(int i=0; i<dong; i++) {
            for(int j=0; j<cot; j++) {
                mang[i][j] = taoSoNgauNhien(1, 10);
            }
        }
        return mang;
    }
    
    public static void inMang2Chieu(int[][] mang) {
        for(int i=0; i<mang.length; i++) {
            for(int j=0; j<mang[i].length; j++) {
                System.out.print(mang[i][j] + "\t");
            }
            System.out.println();
        }
    }
    
    // Tính tổng 2 ma trận
    public static int[][] tinhTong2MaTran(int[][] a, int[][] b) {
        int[][] c = new int[a.length][a[0].length];
        
        for(int i=0; i<a.length; i++) {
            for(int j=0; j<a[0].length; j++) {
                c[i][j] = a[i][j] + b[i][j];
            }
        }
        return c;
    }
    
    // Nhân 2 ma trận
    public static int[][] nhan2MaTran(int[][] a, int[][] b) {
        int[][] c = new int[a.length][a[0].length];
        
        for(int i=0; i<a.length; i++) {
            for(int j=0; j<a[0].length; j++) {
                for(int k=0; k<a.length; k++) {
                    c[i][j] += a[i][k] * b[k][j];
                }
            }
        }
        return c;
    }
}
