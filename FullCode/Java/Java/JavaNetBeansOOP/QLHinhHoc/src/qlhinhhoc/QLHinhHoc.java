/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package qlhinhhoc;

/**
 *
 * @author SV
 */
import java.util.Scanner;
public class QLHinhHoc {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        Scanner s = new Scanner(System.in);
        int chieuRong = s.nextInt();
        int chieuDai = s.nextInt();
        clsHinhChuNhat chuNhat = new clsHinhChuNhat(chieuDai, chieuRong);
        System.out.println(""+ chuNhat.toString());
       
    }
    
}
