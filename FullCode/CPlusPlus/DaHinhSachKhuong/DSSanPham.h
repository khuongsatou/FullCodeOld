#pragma once

#include<iostream>
#include<string>
using namespace std;
class DSSanPham
{
private:
	Sach **dsSP;
	int n;
	int luachon;
public:
	DSSanPham();
	~DSSanPham();
	virtual void nhap(){
		cout << "Nhap So Luong Sach:"; cin >> n;
		cout << "Lua chon:"; cin >> luachon;
		dsSP = new Sach *[n];
		for (int i = 0; i < n; i++)
		{
			switch (luachon)
			{
			case 1:dsSP[i] = new SGK;break;
			case 2:dsSP[i] = new STK; break;
			default:dsSP[i] = new Truyen; break;
			}
		}
		
	}
	virtual void xuat(){
		cout << "Xuat So Luong Sach:" << n;
	}
};

void menu(){
	cout << "SGK" << endl;
	cout << "STK" << endl;
	cout << "Truyen Tranh" << endl;
}