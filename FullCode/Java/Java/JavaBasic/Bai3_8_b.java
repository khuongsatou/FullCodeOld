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
public class Bai3_8_b {
    public static void main(String[] args) {
        int n = 10000; // thay các giá trị 20000, 30000, ..., 100000
        double e = 2;
        for(int i=2; i<=n; i++) {
            double gt = 1;
            for(int j=1; j<=i; j++) {
                gt *= j;
            }
            e += 1/gt;
        }
        
        System.out.println("e = " + e);
    }
}
