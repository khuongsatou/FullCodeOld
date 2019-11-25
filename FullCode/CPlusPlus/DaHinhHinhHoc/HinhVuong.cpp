#include "HinhVuong.h"

HinhVuong::HinhVuong() {
}

HinhVuong::~HinhVuong() {
}

void HinhVuong::Nhap() {
	cout << "Nhap chieu dai canh: ";
	cin >> a;
	b = a;
}

void HinhVuong::Xuat() {
	cout << "Do dai canh: " << a << endl;
	cout << "Chu vi: " << TinhChuVi() << endl;
	cout << "Dien tich: " << TinhDienTich() << endl;
}
