#include<iostream>
#include<string>
using namespace std;

//khu include
#include"DSSanPham.h"
#include "Sach.h"
#include"SGK.h"
#include"STK.h"
#include"Truyen.h"


int main(){
	Sach *sach = new STK();
	sach->nhap();
	sach->xuat();
	system("pause");
	return 0;
}