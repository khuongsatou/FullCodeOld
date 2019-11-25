#define _CRT_SECURE_NO_WARNINGS


#include<iostream>
#include<string>
#include<string.h>
using namespace std;

#include "VatNuoi.h"


int main(){
	
	VatNuoi vn;
	vn.Nhap();
	vn.Xuat();
	vn.TinhCanNang();
	vn.TinhTongLuongSua();
	vn.TinhTongLuongTrung();
	vn.TimCanNangLonNhat();
	cout << endl;
	system("pause");
}