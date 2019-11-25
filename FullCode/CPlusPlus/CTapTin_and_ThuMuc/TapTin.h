// Nguyễn Văn Khương
// MSSV:0306171362

#pragma once
class CTapTin
{
private:
	int kt, nam;
	string ten;
public:
	CTapTin();
	CTapTin(int x, int y);
	CTapTin(const CTapTin &x);
	~CTapTin();

	void nhap();
	void xuat();
	void layMB();
	float layMB_2();
	void soSanh(CTapTin x);
	char* tenMoRong();
	friend class CThuMuc;
};

