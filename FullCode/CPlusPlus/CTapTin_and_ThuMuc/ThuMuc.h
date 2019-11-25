// Nguyễn Văn Khương
// MSSV:0306171362


#pragma once
#include "TapTin.h"
class CThuMuc
{
private:
	CTapTin DSTT[100];
	int	soLuongTapTin;
	
public:
	CThuMuc();
	CThuMuc(CTapTin x);
	CThuMuc(const CThuMuc &x);
	~CThuMuc();
	

	void nhap();
	void xuat();
	int soLuongTapTin_1();
	float kichThuocThuMuc();
	void Tao1TapTinMoi(CTapTin &x);
	void themTapTin(char* tenTapTin);
	void xoaTapTin(char* tenTapTin);
	void timKiem(char* tenTapTin);
	//kết bạn với nó nữa mới dùng được private
	friend class CTapTin;
};

