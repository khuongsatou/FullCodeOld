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
public class SachThamKhao extends Sach {
    // thuế. Thành tiền = số lượng * đơn giá +thuế
    private int thue;

    /**
     * @return the thue
     */
    public int getThue() {
        return thue;
    }
    
    public SachThamKhao() {
        super();
        //super.nhap();
        Scanner input = new Scanner(System.in);
        System.out.print("- Thuế: ");
        this.thue = input.nextInt();
        
        this.setThanhTien(this.getSoLuong() * this.getDonGia() + thue);
    }
    
    public String toString() {
        String kq = super.toString();
        kq += "\n- Thuế: " + this.thue;
        kq += "\n- Thành tiền: " + this.getThanhTien();
        kq += "\n--------------------------------\n";
        
        return kq;
    }
}
