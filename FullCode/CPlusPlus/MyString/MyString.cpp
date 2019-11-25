//Nguyễn Văn Khương
//0306171362


#define _CRT_SECURE_NO_WARNINGS

#include<iostream>
#include<conio.h>
#include<string.h>
#include<string>
using namespace std;
#include "MyString.h"
//Tất cả hàm em viết bên file .h cho tiện đỡ tốn thời gian hơn ạ


//MyString::MyString()
//{
//}


// Nhớ cái lỗi này nhé nó liên quan đến...abcxyz ~~~ delete 
//MyString::~MyString()
//{
//}

//Nguyễn Văn Khương
int main(){
	MyString m1(0," Nguyen  Van  Khuong"),m2,m3(m1);

	cin >> m2;
	cout << "Chuoi M1:"<< m1;
	cout << "Chuoi M2:"<< m2;
	cout << "Chuoi M3:"<< m3;

	// các operator
	cout<<"m1+m2:"<<m1 + m2<<endl;
	if (m1 == m2)
	{
		cout << "M1 == M2" << endl;
	}
	else{
		cout << "M1 != M2" << endl;
	}
	//truy cap theo chỉ so chuoi operator
	cout << "truy cap theo chi so chuoi M2[2]:"; m2[1];
	cout << endl;
	//lấy độ dài
	cout << "do dai chuoi M2:" << m2.length_1() << endl;
	//kiểm tra rỗng
	if (m2.empty_1())
	{
		cout << "M2 rong:" << endl;
	}
	else
	{
		cout << "M2 Khong rong" << endl;
	}
	//insert
	cout<<"Them satou vao vi tri thu 0 M2:"<<m2.insert_1(0,"Satou")<<endl;
	////xoa chuoi con
	cout <<"Xoa M2 vi tri thu 3 , xoa 1 phan tu:"<<m2.erase_1(3, 1) << endl;
	////tim chuoi con
	cout << "M2 Tim start 2, end 3:" << m2.substr_1(2, 3) << endl;
	//chuan hoa chuoi
	cout << "Chuan hoa M1:" << m1.chuan_hoa() << endl;
	//thường thành in
	cout << "In M1:" << m1.thuong_thanh_in()<< endl;
	//in thành thường
	cout << "Thuong M1:" << m1.in_thanh_thuong() << endl;
	//viet hoa chu dau
	cout << "Hoa dau M1:" << m1.bien_chu_cai_dau_moi_tu_thanh_hoa() << endl;
	_getch();
	return 0;
}
