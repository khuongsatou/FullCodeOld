#include"HinhElip.h"

#define PI 3.14

HinhElip::HinhElip() {
}

HinhElip::~HinhElip() {
}

void HinhElip::Nhap() {
	cout << "Nhap do dai ban truc lon va ban truc nho: ";
	cin >> r1 >> r2;
}

void HinhElip::Xuat() {
	cout << "Do dai 2 ban truc: " << r1 << " va " << r2 << endl;
	cout << "Chu vi: " << TinhChuVi() << endl;
	cout << "Dien tich: " << TinhDienTich() << endl;
}

float HinhElip::TinhChuVi() {
	return 2 * PI * sqrt((r1 * r1 + r2 * r2) / 2);
}

float HinhElip::TinhDienTich() {
	return PI * r1 * r2;
}
