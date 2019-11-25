#include<iostream>
using namespace std;
#include<conio.h>
#include"HinhHoc.h"
#include"HinhChuNhat.h"
#include"HinhVuong.h"
#include"HinhElip.h"
#include"HinhTron.h"

void ShowMenu();

void main() {
	HinhHoc **dsHinh;
	int n;
	cout << "Nhap so luong hinh: ";
	cin >> n;

	dsHinh = new HinhHoc*[n];

	for (int i = 0; i < n; i++)
	{
		system("cls");
		int luaChon;

		cout << "Nhap hinh thu " << i + 1 << ":" << endl;
		ShowMenu();
		cout << "Chon hinh muon nhap: ";
		cin >> luaChon;

		switch (luaChon) {
		case 1: dsHinh[i] = new HinhChuNhat(); break;
		case 2: dsHinh[i] = new HinhVuong(); break;
		case 3: dsHinh[i] = new HinhElip(); break;
		default: dsHinh[i] = new HinhTron(); break;
		}

		dsHinh[i]->Nhap();
	}

	system("cls");

	float tongCV = 0;
	float tongDT = 0;

	for (int i = 0; i < n; i++)
	{
		cout << "Thong tin hinh thu " << i + 1 << ":" << endl;
		dsHinh[i]->Xuat();
		tongCV += dsHinh[i]->TinhChuVi();
		tongDT += dsHinh[i]->TinhDienTich();
		cout << endl;
	}

	cout << "Tong chu vi: " << tongCV << endl;
	cout << "Tong dien tich: " << tongDT << endl;

	_getch();
}

void ShowMenu() {
	cout << "1. Hinh chu nhat" << endl;
	cout << "2. Hinh vuong" << endl;
	cout << "3. Hinh elip" << endl;
	cout << "4. Hinh tron" << endl;
}