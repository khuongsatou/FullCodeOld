#pragma once
#include "Sach.h"
class SGK :
	public Sach
{
protected:
	string Ten;
	int Nam, Gia;

public:
	SGK();
	~SGK();
	virtual void nhap(){
		fflush(stdin);
		cout << "Ten Sach: ";
		getline(cin,Ten);
		cout << "Nam:" ;
		cin >> Nam;
		cout << "Gia:" ;
		cin >> Gia;
	}
	virtual void xuat(){
		cout << endl;
		cout << "Ten Sach: " << Ten << endl; 
		cout << "Nam: " << Nam << endl;
		cout << "Gia: " << Gia << endl;
	}
};

