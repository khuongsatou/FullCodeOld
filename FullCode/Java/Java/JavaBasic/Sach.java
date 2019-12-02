/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thuvienx;

import java.util.Date;
import java.util.Scanner;

/**
 *
 * @author SV
 */
public class Sach {
    //Mã sách, ngày nhập (ngày, tháng, năm), đơn giá, số lượng, nhà xuất bản
    private int maSach;
    private Date ngayNhap;
    private int donGia;
    private int soLuong;
    private String nhaXuatBan;
    private int thanhTien;

    /**
     * @return the maSach
     */
    public int getMaSach() {
        return maSach;
    }

    /**
     * @return the ngayNhap
     */
    public Date getNgayNhap() {
        return ngayNhap;
    }

    /**
     * @return the donGia
     */
    public int getDonGia() {
        return donGia;
    }

    /**
     * @return the soLuong
     */
    public int getSoLuong() {
        return soLuong;
    }

    /**
     * @return the nhaXuatBan
     */
    public String getNhaXuatBan() {
        return nhaXuatBan;
    }

    /**
     * @return the thanhTien
     */
    public int getThanhTien() {
        return thanhTien;
    }

    /**
     * @param thanhTien the thanhTien to set
     */
    public void setThanhTien(int thanhTien) {
        this.thanhTien = thanhTien;
    }
    
    public Sach() {
        Scanner input = new Scanner(System.in);
        System.out.println("Nhập thông tin sách:");
        System.out.print("- Mã sách: ");
        this.maSach = input.nextInt();
        System.out.print("- Ngày nhập (dd MM yyyy): ");
        int ngay = input.nextInt();
        int thang = input.nextInt();
        int nam = input.nextInt();
        this.ngayNhap = new Date(nam - 1900, thang - 1, ngay); // thâng: 0-->11
        System.out.print("- Đơn giá: ");
        this.donGia = input.nextInt();
        System.out.print("- Số lượng: ");
        this.soLuong = input.nextInt();
        input.nextLine();
        System.out.print("- Nhà xuất bản: ");
        this.nhaXuatBan = input.nextLine();
    }
    
    /*
    public void nhap() {
        Scanner input = new Scanner(System.in);
        System.out.println("Nhập thông tin sách:");
        System.out.print("- Mã sách: ");
        this.maSach = input.nextInt();
        System.out.print("- Ngày nhập (dd MM yyyy): ");
        int ngay = input.nextInt();
        int thang = input.nextInt();
        int nam = input.nextInt();
        this.ngayNhap = new Date(nam - 1900, thang - 1, ngay); // thâng: 0-->11
        System.out.print("- Đơn giá: ");
        this.donGia = input.nextInt();
        System.out.print("- Số lượng: ");
        this.soLuong = input.nextInt();
        //input.nextLine();
        System.out.print("- Nhà xuất bản: ");
        this.nhaXuatBan = input.nextLine();
    }
   */
    
    // overide phương thức toString() của lớp Object
    // xuất kết quả
    public String toString() {
        String kq = "--------------------------------\n";
        kq += "- Mã sách:  " + this.maSach;
        kq += "\n- Ngày nhập: " + inNgay(this.ngayNhap);
        kq += "\n- Đơn giá: " + this.donGia;
        kq += "\n- Số lượng: " + this.soLuong;
        kq += "\n- Nhà xuất bản: " + this.nhaXuatBan;
        
        return kq;
    }
    
    public String inNgay(Date ngay) {
        return ngay.getDate() + "/" + ngay.getMonth() + "/" + ngay.getYear();
    }
}
