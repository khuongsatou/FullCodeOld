package com.example.bestchikass3of2.model;

import java.io.Serializable;

public class SanPham  implements Serializable {
    public  int id;
    public String Tensanpham;
    public Integer Giasanpham;
    public String HinhAnhsanpham;
    public String MoTasanpham;
    public int idsanpham;

    public SanPham(int id, String tensanpham, Integer giasanpham, String hinhAnhsanpham, String moTasanpham, int idsanpham) {
        this.id = id;
        Tensanpham = tensanpham;
        Giasanpham = giasanpham;
        HinhAnhsanpham = hinhAnhsanpham;
        MoTasanpham = moTasanpham;
        this.idsanpham = idsanpham;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getTensanpham() {
        return Tensanpham;
    }

    public void setTensanpham(String tensanpham) {
        Tensanpham = tensanpham;
    }

    public Integer getGiasanpham() {
        return Giasanpham;
    }

    public void setGiasanpham(Integer giasanpham) {
        Giasanpham = giasanpham;
    }

    public String getHinhAnhsanpham() {
        return HinhAnhsanpham;
    }

    public void setHinhAnhsanpham(String hinhAnhsanpham) {
        HinhAnhsanpham = hinhAnhsanpham;
    }

    public String getMoTasanpham() {
        return MoTasanpham;
    }

    public void setMoTasanpham(String moTasanpham) {
        MoTasanpham = moTasanpham;
    }

    public int getIdsanpham() {
        return idsanpham;
    }

    public void setIdsanpham(int idsanpham) {
        this.idsanpham = idsanpham;
    }
}
