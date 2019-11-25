#pragma once
#include "SGK.h"
class STK :
	public SGK
{
protected:
	string TenMon;
public:
	STK();
	~STK();

	virtual void nhap(){
		fflush(stdin);
		cout << "Ten Sach: ";
		getline(cin, Ten);
		fflush(stdin);
		cout << "Ten Mon: ";
		getline(cin, TenMon);
		cout << "Nam:";
		cin >> Nam;
		cout << "Gia:";
		cin >> Gia;
	}
	virtual void xuat(){
		cout << endl;
		cout << "Ten Sach: " << Ten << endl;
		cout << "Ten Mon: " << TenMon << endl;
		cout << "Nam: " << Nam << endl;
		cout << "Gia: " << Gia << endl;
	}
};

