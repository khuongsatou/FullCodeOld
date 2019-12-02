/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package qlsinhvien;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author SV
 */
public class QLSinhVien {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        clsSinhVien sv1= new clsSinhVien(001,"Nguyen Van Khuong",10,11);
        System.err.println(""+sv1.toString());
       
        
        clsSinhVien sv2= new clsSinhVien(002,"Ban Hoai",10,110);
        System.err.println(""+sv2.toString());
        
        clsSinhVien sv3= new clsSinhVien();
        Scanner scanner = new Scanner(System.in);
        System.out.println("Nhap MaSV:");
        int maSV = scanner.nextInt();
        System.out.println("Nhap Ho Ten:");
        String hoTen = scanner.next();
        System.out.println("Nhap Diem LT:");
        float diemLT = scanner.nextFloat();
        System.out.println("Nhap Diem TH:");
        float diemTH = scanner.nextFloat();
        
        
        sv3.setMaSV(maSV);
        
        sv3.setHoTen(hoTen);
        
        sv3.setDiemLT(diemLT);
       
        sv3.setDiemTH(diemTH);
      
        System.out.println(sv3.toString());
        
        List<clsSinhVien> sinhViens = new ArrayList<>();
        sinhViens.add(sv1);
        sinhViens.add(sv2);
        sinhViens.add(sv3);
        System.out.println("----Danh Sinh Vien----");
        for (clsSinhVien sinhVien : sinhViens) {
            System.out.println(sinhVien.toString());
        }
         
       
    }
    
}
