#pragma once
#include"HinhHoc.h"

class HinhChuNhat: public HinhHoc {
protected:
	float a;
	float b;
public:
	HinhChuNhat();
	~HinhChuNhat();

	virtual void Nhap();
	virtual void Xuat();
	virtual float TinhChuVi();
	virtual float TinhDienTich();
};

