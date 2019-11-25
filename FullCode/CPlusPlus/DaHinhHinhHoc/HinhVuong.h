#pragma once
#include"HinhChuNhat.h"

class HinhVuong: public HinhChuNhat {
public:
	HinhVuong();
	~HinhVuong();

	virtual void Nhap();
	virtual void Xuat();
};

