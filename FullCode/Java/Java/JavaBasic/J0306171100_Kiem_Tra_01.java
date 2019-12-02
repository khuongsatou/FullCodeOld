/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 * MSSV:...
 * Họ tên:....
 */
package j0306171100;

import java.util.Scanner;

/**
 *
 * @author SV
 */
public class J0306171100 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        // Nhập số nguyên dương n trong đoạn [1, 100]
        int n = nhap_so_nguyen(1, 100);
        
        // In tổng các số nguyên liên tiếp từ 1 đến n
        int tong = 0;
        for(int i=1; i<=n; i++) {
            tong += i;
        }
        System.out.println("Tong tu 1 den " + n + " = " + tong);
        
        // CA 1
        //Cho biết n có phải là số hoàn thiện hay không?
        if(la_so_hoan_thien(n)) {
            System.out.println(n + " la so hoan thien");
        } else {
            System.out.println(n + " khong phai la so hoan thien");
        }
        
        //In ra các số hoàn thiện trong đoạn từ 1 đến n
        System.out.println("Cac so hoan thien trong doan [1, n]:");
        for(int i=1; i<=n; i++) {
            if(la_so_hoan_thien(i)) {
                System.out.println(i);
            }
        }
        
        // CA 2
        //Cho biết n có phải là số nguyên tố hay không?
        if(la_so_nguyen_to(n)) {
            System.out.println(n + " la so nguyen to");
        } else {
            System.out.println(n + " khong phai la so nguyen to");
        }
        
        //In ra các số nguyên tố trong đoạn từ 1 đến n
        System.out.println("Cac so nguyen to trong doan [1, n]:");
        for(int i=1; i<=n; i++) {
            if(la_so_nguyen_to(i)) {
                System.out.println(i);
            }
        }
        
        // Test câu 1b (Ca 1)
        System.out.println("(1B - Ca 1): S = " + tinh_s1(n));
        
        // Test câu 1b (Ca 2)
        System.out.println("(1B - Ca 2): S = " + tinh_s2(n));
    }
    
    public static int nhap_so_nguyen(int a, int b) {
        Scanner input = new Scanner(System.in);
        int  n;
        do {
            System.out.print("Nhap so nguyen duong: ");
            n = input.nextInt();
        } while(n < a || n > b);
        return n;
    }
    
    // CA 1
    public static double tinh_s1(int n) {
        double s = 0;
        if(n > 0){
            s = 0.5;
        }
        double dau = 1;
        for(int i=1; i<=2*n; i++) {
            s += (dau*i) / (i+1);
            dau *= -1;
        }
        return s;
    }
    
    public static int tong_uoc(int n) {
         int tong = 0;
         for(int i=1; i<n; i++) {
            if(n % i == 0) {
               tong += i;
            }
         }
         return tong;
    }
    
    public static boolean la_so_hoan_thien(int n) {
        return (tong_uoc(n) == n);
    }
    
    // CA 2
    public static double tinh_s2(int n) {
        double s = 0;
        if(n > 0){
            s = 0.5;
        }
        double dau = 1;
        for(int i=1; i<=2*n; i++) {
            s += (dau*i) / (i+1);
            dau *= -1;
        }
        return s;
    }
    
    public static int dem_uoc(int n) {
         int dem = 0;
         for(int i=1; i<=n; i++) {
            if(n % i == 0) {
                dem++;
            }
         }
         return dem;
    }
    
    public static boolean la_so_nguyen_to(int n) {
        return (dem_uoc(n) == 2);
    }
    
}
