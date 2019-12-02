/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package qlsinhvien;

/**
 *
 * @author SV
 */
public class clsSinhVien {
    private int maSV;
    private String hoTen;
    private  float diemLT,diemTH;

    public clsSinhVien() {
        this(0, "", 0, 0);
    }

    
    public clsSinhVien(int maSV, String hoTen, float diemLT, float diemTH) {
        this.maSV = maSV;
        this.hoTen = hoTen;
        this.diemLT = diemLT;
        this.diemTH = diemTH;
    }

    public int getMaSV() {
        return maSV;
    }

    public void setMaSV(int maSV) {
        this.maSV = maSV;
    }

    public String getHoTen() {
        return hoTen;
    }

    public void setHoTen(String hoTen) {
        this.hoTen = hoTen;
    }

    public double getDiemLT() {
        return diemLT;
    }

    public void setDiemLT(float diemLT) {
        this.diemLT = diemLT;
    }

    public double getDiemTH() {
        return diemTH;
    }

    public void setDiemTH(float diemTH) {
        this.diemTH = diemTH;
    }
    
    public double tinhDiemTB(){
        return (this.diemLT+this.diemTH)/2;
    }
    

    @Override
    public String toString() {
        String chuoi =this.maSV+"\t"+this.hoTen+"\t"+this.diemLT+"\t"+this.diemTH+"\t"+this.tinhDiemTB()+"\n";
        return chuoi; //To change body of generated methods, choose Tools | Templates.
    }
    
   
    
    
    
}
