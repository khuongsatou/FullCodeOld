#include "HinhChuNhat.h"

HinhChuNhat::HinhChuNhat() {
}

HinhChuNhat::~HinhChuNhat() {
}

void HinhChuNhat::Nhap() {
	cout << "Nhap chieu dai va chieu rong: ";
	cin >> a >> b;
}

void HinhChuNhat::Xuat() {
	cout << "Do dai 2 canh: " << a << " va " << b << endl;
	cout << "Chu vi: " << TinhChuVi() << endl;
	cout << "Dien tich: " << TinhDienTich() << endl;
}

float HinhChuNhat::TinhChuVi() {
	return (a + b) * 2;
}

float HinhChuNhat::TinhDienTich() {
	return a * b;
}
