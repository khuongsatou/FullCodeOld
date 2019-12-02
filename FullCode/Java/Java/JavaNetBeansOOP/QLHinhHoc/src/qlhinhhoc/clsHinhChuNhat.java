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
public class clsHinhChuNhat {
    private int ChieuDai,ChieuRong;

    public clsHinhChuNhat() {
        this.ChieuDai =0;
        this.ChieuRong =0;
    }

    
    
    public clsHinhChuNhat(int ChieuDai, int ChieuRong) {
        this.ChieuDai = ChieuDai;
        this.ChieuRong = ChieuRong;
    }

    public int getChieuDai() {
        return ChieuDai;
    }

    public void setChieuDai(int ChieuDai) {
        this.ChieuDai = ChieuDai;
    }

    public int getChieuRong() {
        return ChieuRong;
    }

    public void setChieuRong(int ChieuRong) {
        this.ChieuRong = ChieuRong;
    }
    
    public double tinhDienTich(){
        return this.ChieuDai *this.ChieuRong;
    }
    
    public double tinhChuVi(){
        return (this.ChieuDai+this.ChieuRong)*2;
    }
    
    @Override
    public String toString(){
        return "cd: "+this.ChieuDai+"\t cr: "+this.ChieuRong+"\t cv: "+tinhChuVi()+"\t dt: "+tinhDienTich();
    }
    
    
    
}
