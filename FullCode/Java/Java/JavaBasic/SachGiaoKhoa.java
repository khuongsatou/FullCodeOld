/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thuvienx;

import java.util.Scanner;

/**
 *
 * @author SV
 */
public class SachGiaoKhoa extends Sach{
    //tình trạng (mới, cũ). Nếu tình trạng sách là mới thì: thành tiền = số lượng * đơn giá. Nếu tình
    //trạng sách là cũ thì: thành tiền = số lượng * đơn giá * 50%
    private int tinhTrang; // 0: cũ, 1: mới

    /**
     * @return the tinhTrang
     */
    public int getTinhTrang() {
        return tinhTrang;
    }
    
    public SachGiaoKhoa() {
        super();
        //super.nhap();
        Scanner input = new Scanner(System.in);
        System.out.print("- Tình trạng (0: cũ, 1: mới): ");
        this.tinhTrang = input.nextInt();
        
        int thanhTien = this.getSoLuong() * this.getDonGia();
        if(this.tinhTrang == 0) {
            thanhTien /= 2;
        }
        this.setThanhTien(thanhTien);
    }
    
    public String toString() {
        String kq = super.toString();
        kq += "\n- Tình trạng: " + (this.tinhTrang == 0 ? "Cũ" : "Mới");
        kq += "\n- Thành tiền: " + this.getThanhTien();
        kq += "\n--------------------------------\n";
        
        return kq;
    }
}
