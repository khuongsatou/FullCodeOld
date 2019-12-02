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
public class DemoMang2Chieu {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int chon;
        int ngaySinh = 0;
        Scanner input = new Scanner(System.in);
        
        int[][] bang1 = {
            {1, 3, 5, 7},
            {9, 11, 13, 15},
            {17, 19, 21, 23},
            {25, 27, 29, 31}
        };
        inMang2Chieu(bang1);
        do {
            System.out.print("Ngay sinh cua ban co trong bang nay khong? (0: khong co, 1: co): ");
            chon = input.nextInt();
        } while(chon < 0 || chon > 1);
        if(chon == 1) {
            ngaySinh += bang1[0][0];
        }
        
        System.out.println("----------------------------");
        
        int[][] bang2 = {
            {2, 3, 6, 7},
            {10, 11, 14, 15},
            {18, 19, 22, 23},
            {26, 27, 30, 31}
        };
        
        inMang2Chieu(bang2);
        do {
            System.out.print("Ngay sinh cua ban co trong bang nay khong? (0: khong co, 1: co): ");
            chon = input.nextInt();
        } while(chon < 0 || chon > 1);
        if(chon == 1) {
            ngaySinh += bang2[0][0];
        }
    }
    
    public static void inMang2Chieu(int[][] mang) {
        for(int i=0; i<mang.length; i++) {
            for(int j=0; j<mang[i].length; j++) {
                System.out.print(mang[i][j] + "\t");
            }
            System.out.println();
        }
    }
}
