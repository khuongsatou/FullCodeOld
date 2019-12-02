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
public class Bai3_8_a {
    public static void main(String[] args) {
        int i=1;
        double pi = 0;
        double dau = 1;
        
        while(1.0/(2 * i - 1) >= 0.000001) {
            pi += dau/(2*i - 1);
            i++;
            dau *= -1;
        }
        
        pi *= 4;
        
        System.out.println("pi = " + pi);
    }
}
