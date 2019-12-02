/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bai3_5_a;

import javax.swing.JOptionPane;

/**
 *
 * @author SV
 */
public class Bai3_9 {
    public static void main(String[] args) {
        int year = 0;
        int weekday = -1;
        String temp = "";
        
        do {
            temp = JOptionPane.showInputDialog("Nhập năm (1900 - 3000): ");
            year = Integer.parseInt(temp);
        } while (year < 1900 || year > 3000);
        
        do {
            temp = JOptionPane.showInputDialog("Nhập thứ của ngày 1/1/" + year + "(0: CN, 1: thứ 2,..., 6: thứ 7): ");
            weekday = Integer.parseInt(temp);
        } while (weekday < 0 || weekday > 6);
        
        int soNgay = 0; // Số ngày từ ngày 1 của tháng hiện tại đến ngày 1 tháng kế tiếp
        for(int month=1; month<13; month++) {
            weekday = (soNgay + weekday) % 7;
            
            // In thứ của month
            System.out.print("- 1/" + month + "/" + year + " là ");
            switch(weekday) {
                case 0:
                    System.out.println("CN");
                    break;
                case 1:
                    System.out.println("Thứ 2");
                    break;
                case 2:
                    System.out.println("Thứ 3");
                    break;
                case 3:
                    System.out.println("Thứ 4");
                    break;
                case 4:
                    System.out.println("Thứ 5");
                    break;
                case 5:
                    System.out.println("Thứ 6");
                    break;
                case 6:
                    System.out.println("Thứ 7");
                    break;
            }
            
            // Tính Số ngày từ ngày 1 của tháng hiện tại đến ngày 1 tháng kế tiếp
            switch(month) {
		case 4:
		case 6:		
		case 9:
		case 11:
                    soNgay = 30; break;
		case 2:
                    if(year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                            soNgay = 29;
                    else
                            soNgay = 28;
                    break;
		default: //1, 3, 5, 7, 8, 10, 12
                    soNgay = 31;
            }
        }
    }
}
