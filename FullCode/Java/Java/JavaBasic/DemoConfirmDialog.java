/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package democonfirmdialog;

import javax.swing.JOptionPane;

/**
 *
 * @author SV
 */
public class DemoConfirmDialog {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        /*
        int luaChon = JOptionPane.showConfirmDialog(null, "Ban co muon dau mon nay khong?");
        if(luaChon == JOptionPane.YES_OPTION) {
            System.out.println("Yes");
        } else if (luaChon == JOptionPane.NO_OPTION) {
            System.out.println("No");
        } else {
            System.out.println("Cancel");
        }
        
        */
        // Nhập vào danh sách số nguyên
        // Tính tổng danh sách các số vừa nhập
        // Sau mỗi lần nhập hỏi người dùng có muốn nhập nữa ko?
        // YES: Nhập, NO/CANCEL --> Thoát
        /*
        int luaChon;
        int tong = 0;
        do {
            String s = JOptionPane.showInputDialog("Nhập số nguyên: ");
            tong += Integer.parseInt(s);
            luaChon = JOptionPane.showConfirmDialog(null, "Bạn muốn nhập nữa không?");
        } while(luaChon == JOptionPane.YES_OPTION);
        JOptionPane.showMessageDialog(null, "Tổng = " + tong);
        JOptionPane.showMessageDialog(null, "Cám ơn các bạn rất nhiều!");
        */
        
        String temp = JOptionPane.showInputDialog("Nhập số a: ");
        int a = Integer.parseInt(temp);
        temp = JOptionPane.showInputDialog("Nhập số b: ");
        int b = Integer.parseInt(temp);
        // Tìm UCLN
        while(b != 0) {
            int r = a % b;
            a = b;
            b = r;
        }
        JOptionPane.showMessageDialog(null, "UCLN là " + a);
    }
    
}
