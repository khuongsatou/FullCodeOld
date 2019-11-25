// Nguyễn Văn Khương
// MSSV:0306171362



//Hãy ghi nhớ cái lỗi quỷ quái này
#define _CRT_SECURE_NO_WARNINGS

#include<iostream>
#include<string>

#include<string.h>
using namespace std;

#include "TapTin.h"

//1
// Nguyễn Văn Khương
CTapTin::CTapTin()
{
	kt = 0;
	nam = 1900;
}

//2
// Nguyễn Văn Khương
CTapTin::CTapTin(int x,int y)
{
	kt = x;
	nam = y;
}


//3
// Nguyễn Văn Khương
CTapTin::CTapTin(const CTapTin &x)
{
	this->kt = x.kt;
	this->nam = x.nam;
}

// Nguyễn Văn Khương
CTapTin::~CTapTin()
{
	
}


//4
// Nguyễn Văn Khương
void CTapTin::nhap(){
	cout << endl;
	fflush(stdin);
	cout << "Ten Tap Tin:"; getline(cin,ten);
	cout << "N Kich Thuoc:"; cin >> kt;
	cout << "N Nam:"; cin >> nam;
}


//5
// Nguyễn Văn Khương
void CTapTin::xuat(){
	cout << endl;
	cout << "Ten Tap Tin:"<<ten<<endl;
	cout << "Kich Thuoc:"<< kt<<endl;
	cout << "Nam:" << nam<<endl;
}

//6
// Nguyễn Văn Khương
void CTapTin::layMB(){
	cout <<"B -> MB:"<< float(kt / 1024 / 1024);
}


//7
// Nguyễn Văn Khương
void CTapTin::soSanh(CTapTin x){
	if (this->kt > x.kt)
	{
		cout << "kich thuoc tap tin 1 lon hon kich thuoc tap tin 2" << endl;
	}
	else if (this->kt < x.kt){
		cout << "kich thuoc tap tin 1 nho hon kich thuoc tap tin 2" << endl;
	}
	else{
		cout << "kich thuoc tap tin 1 bang kich thuoc tap tin 2" << endl;
	}
}

// Nguyễn Văn Khương
// 8 

char* CTapTin::tenMoRong(){
	string str(ten);
	char *convent = new char[100]; //
	strcpy(convent, str.substr(str.find(".") + 1).c_str());//kểu char mới dùng được strcpy nên c_str() để chuyển sang char
	return convent;

}