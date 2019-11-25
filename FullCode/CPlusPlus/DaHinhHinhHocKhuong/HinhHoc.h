#pragma once
#include<iostream>
using namespace std;

class HinhHoc {
public:
	HinhHoc();
	~HinhHoc();

	virtual void Nhap() = 0;
	virtual void Xuat() = 0;
	virtual float TinhChuVi() = 0;
	virtual float TinhDienTich() = 0;
};

