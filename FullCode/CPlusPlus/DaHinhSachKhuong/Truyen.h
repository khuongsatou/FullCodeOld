#pragma once
#include "Sach.h"
class Truyen :
	public Sach
{
protected:
	string TenTruyen;
	int SoTap;
	int GiaTien;
public:
	Truyen();
	~Truyen();

	virtual void nhap(){
		fflush(stdin);
		cout << "Ten Truyen: ";
		getline(cin, TenTruyen);
		cout << "So Tap:";
		cin >> SoTap;
		cout << "Gia Tien:";
		cin >> GiaTien;
	}
	virtual void xuat(){
		cout << endl;
		cout << "Ten Truyen: " << TenTruyen << endl;
		cout << "So Tap: " << SoTap << endl;
		cout << "Gia Tien: " << GiaTien << endl;
	}
};

