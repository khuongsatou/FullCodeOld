package com.example.bestchikass3of2.model;

public class Loaisp {
    public int id;
    public String TenLoaisp;
    public String HinhAnhsp;

    public Loaisp(int id, String tenLoaisp, String hinhAnhsp) {
        this.id = id;
        TenLoaisp = tenLoaisp;
        HinhAnhsp = hinhAnhsp;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getTenLoaisp() {
        return TenLoaisp;
    }

    public void setTenLoaisp(String tenLoaisp) {
        TenLoaisp = tenLoaisp;
    }

    public String getHinhAnhsp() {
        return HinhAnhsp;
    }

    public void setHinhAnhsp(String hinhAnhsp) {
        HinhAnhsp = hinhAnhsp;
    }
}
