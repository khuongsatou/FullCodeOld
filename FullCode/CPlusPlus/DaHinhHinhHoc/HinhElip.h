#pragma once
#include"HinhHoc.h"

class HinhElip: public HinhHoc {
protected:
	float r1;
	float r2;
public:
	HinhElip();
	~HinhElip();

	virtual void Nhap();
	virtual void Xuat();
	virtual float TinhChuVi();
	virtual float TinhDienTich();
};

