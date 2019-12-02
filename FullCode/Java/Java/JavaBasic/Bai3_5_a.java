/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bai3_5_a;

/**
 *
 * @author SV
 */
public class Bai3_5_a {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int n = 8;
        for(int i=1; i<=n; i++) {
            // n-i khoảng trắng bên trái
            for(int j=1; j<n-i+1; j++) {
                System.out.print("\t");
            }
            
            // in nữa tam giác trái
            for(int j=1; j<=i; j++) {
                int value = 1;
                for(int k=1; k<j; k++) {
                    value *= 2;
                }
                System.out.print(value + "\t");
            }
            
            // in nữa tam giác phải
            for(int j=i-1; j>0; j--) {
                int value = 1;
                for(int k=1; k<j; k++) {
                    value *= 2;
                }
                System.out.print(value + "\t");
            }
            System.out.println();
        }
    }
    
}
