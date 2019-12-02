/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bai52;

/**
 *
 * @author SV
 */
public class Bai52 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        char[] mangKyTu = new char[100];
        for(int i=0; i<mangKyTu.length; i++) {
            mangKyTu[i] = (char)((int)(Math.random() * 26) + 97);
        }
        
        inMang(mangKyTu);
        
        System.out.println("BANG TAN SO");
        inBangTanSo(mangKyTu);
    }
    
    public static void inMang(char[] mang) {
        for(int i=0; i<mang.length; i++) {
            System.out.print(mang[i]);
        }
        System.out.println();
    }
    
    // Đếm số lần xuất hiện của ký tự c trong mảng mang
    public static int demTanSo(char[] mang, char c) {
        int dem = 0;
        for(int i=0; i<mang.length; i++) {
            if(c == mang[i]) {
                dem++;
            }
        }
        return dem;
    }
    
    public static int[] tinhBangTanSo(char[] mang) {
        int[] bangTanSo = new int[26];
        //int index = 0;
        for(char c='a'; c <= 'z'; c++) {
            bangTanSo[(int)c-97] = demTanSo(mang, c);
            //bangTanSo[index++] = demTanSo(mang, c);
        }
        return bangTanSo;
    }
    
    public static void inBangTanSo(char[] mang) {
        
        int[] bangTanSo = tinhBangTanSo(mang);
        
        double trungBinh = 0;
        int n = 0; // số lượng ký tự có tần số lớn hơn 0
        
        for(int i=0; i<bangTanSo.length; i++) {
            System.out.println((char)(i + 97) + ": " + bangTanSo[i]);
            
            trungBinh += bangTanSo[i];
            if(bangTanSo[i] > 0) {
                n++;
            }
        }
        
        trungBinh /= n;
        System.out.println("Trung Binh = " + trungBinh);
        
        double doLech = 0;
        for(int i=0; i<bangTanSo.length; i++) {         
            if(bangTanSo[i] > 0) {
                doLech = Math.pow(bangTanSo[i] - trungBinh, 2);
            }
        }
        doLech /= (n-1);
        doLech = Math.sqrt(doLech);
        
        System.out.println("Do lech chuan = " + doLech);
    }
}