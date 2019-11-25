#include"HinhTron.h"

HinhTron::HinhTron() {
}

HinhTron::~HinhTron() {
}

void HinhTron::Nhap() {
	cout << "Nhap ban kinh: ";
	cin >> r1;
	r2 = r1;
}

void HinhTron::Xuat() {
	cout << "Do dai ban kinh: " << r1 << endl;
	cout << "Chu vi: " << TinhChuVi() << endl;
	cout << "Dien tich: " << TinhDienTich() << endl;
}
