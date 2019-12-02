/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thongtingiaxe;

import java.util.Scanner;

/**
 *
 * @author SV
 */
public class Vehicle {
    private String tenChuXe;
    private String loaiXe;
    private int dungTich;
    private double triGia;

    public Vehicle() {
        this("", "", 0, 0);
    }

    public Vehicle(String tenChuXe, String loaiXe, int dungTich, double triGia) {
        this.tenChuXe = tenChuXe;
        this.loaiXe = loaiXe;
        this.dungTich = dungTich;
        this.triGia = triGia;
    }

    public String getTenChuXe() {
        return tenChuXe;
    }

    public void setTenChuXe(String tenChuXe) {
        this.tenChuXe = tenChuXe;
    }

    public String getLoaiXe() {
        return loaiXe;
    }

    public void setLoaiXe(String loaiXe) {
        this.loaiXe = loaiXe;
    }

    public int getDungTich() {
        return dungTich;
    }

    public void setDungTich(int dungTich) {
        this.dungTich = dungTich;
    }

    public double getTriGia() {
        return triGia;
    }

    public void setTriGia(double triGia) {
        this.triGia = triGia;
    }
    
    public double tinhThue(int dungTich){
        if (dungTich < 100) {
            return this.triGia *0.01;
        }else if(dungTich >= 100 && dungTich <=200){
            return this.triGia*0.03;
        }
        return this.triGia *0.05;
    }

    @Override
    public String toString() {
        String chuoi = this.tenChuXe+"\t"+this.loaiXe+"\t"+this.dungTich+"\t"+this.triGia+"\t"+this.tinhThue(this.dungTich);
        return chuoi; //To change body of generated methods, choose Tools | Templates.
    }
    
    public void nhap(){
        Scanner scanner = new Scanner(System.in);
        System.out.println("Nhap Ten Chu Xe");
        String tenChuXe=scanner.next();
        System.out.println("Nhap Loai");
        String loaiXe=scanner.next();
        System.out.println("Nhap Dung Tich");
        int dungTich=scanner.nextInt();
        System.out.println("Nhap Tri Gia");
        double triGia=scanner.nextDouble();
        System.out.println("Nhap Thue phai nop");
        double thue=tinhThue(this.dungTich);
    }
    
    
}
