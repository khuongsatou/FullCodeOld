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
public class Bai3_5_b {
    public static void main(String[] args) {
        int n = 6;
        System.out.println("Pattern A");
        for(int i=1; i<=n; i++) {
            for(int j=1; j<=i; j++) {
                System.out.print(j+ " ");
            }
            System.out.println();
        }
        
        System.out.println("\nPattern B");
        for(int i=n; i>0; i--) {
            for(int j=1; j<=i; j++) {
                System.out.print(j+ " ");
            }
            System.out.println();
        }
        
        System.out.println("\nPattern C");
        for(int i=n; i>0; i--) {
            // In nữa trái (Khoảng trống)
            for(int j=1; j<i; j++) {
                System.out.print("  ");
            }
            // In nữa phải (số)
            for(int j=n-i+1; j>0; j--) {
                System.out.print(j+ " ");
            }
            System.out.println();
        }
        
        System.out.println("\nPattern D");
        for(int i=1; i<=n; i++) {
            // In nữa trái (Khoảng trống)
            for(int j=1; j<i; j++) {
                System.out.print("  ");
            }
            // In nữa phải (số)
            for(int j=1; j<n-i+2; j++) {
                System.out.print(j+ " ");
            }
            System.out.println();
        }
    }
}
