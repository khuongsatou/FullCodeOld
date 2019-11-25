// Nguyễn Văn Khương
// MSSV:0306171362


#include<iostream>
#include<string.h>
#include<string>
#include<cstring>
using namespace std;
#include "ThuMuc.h"

// Nguyễn Văn Khương
//mặc đinh
CThuMuc::CThuMuc()
{
	soLuongTapTin = 0;
}


// Nguyễn Văn Khương
//có tham số
CThuMuc::CThuMuc(CTapTin x)
{
	soLuongTapTin = 1;
	DSTT[0] = x;
}

// Nguyễn Văn Khương
//sao chép
CThuMuc::CThuMuc(const CThuMuc &x)
{
	for (int i = 0; i < soLuongTapTin; i++)
	{
		DSTT[i] = x.DSTT[i];
	}
}


CThuMuc::~CThuMuc()
{
}

// Nguyễn Văn Khương
//nhập 1 mảng tập tin
void CThuMuc::nhap(){
	cout << "So luong Tap Tin:"; cin >>soLuongTapTin;
	for (int i = 0; i < soLuongTapTin; i++)
	{
		cout << "\nTap Tin Thu:" << i;
		DSTT[i].nhap();
	}
}

// Nguyễn Văn Khương
//xuất mảng tập tin
void CThuMuc::xuat(){
	for (int i = 0; i < soLuongTapTin; i++)
	{
		DSTT[i].xuat();
	}
}

// Nguyễn Văn Khương
//Cho biết số lượng tập tin trong TM
int CThuMuc::soLuongTapTin_1(){
	return soLuongTapTin;
}

// Nguyễn Văn Khương
//Lấy kt thư mục
float CThuMuc::kichThuocThuMuc(){
	float tong = 0;
	for (int i = 0; i < soLuongTapTin; i++)
	{
		(float)tong += float(DSTT[i].kt/1024/1024);
	}
	return tong;
}

// Nguyễn Văn Khương
//tạo 1 tập tin mới xong rồi thêm tập tin vào mãng
void CThuMuc::Tao1TapTinMoi(CTapTin &x){
	x.nhap();
	soLuongTapTin++;
}


// Nguyễn Văn Khương
//Thêm 1 tâp tin
void CThuMuc::themTapTin(char* tenTapTin){
	DSTT[soLuongTapTin].ten = tenTapTin;
	soLuongTapTin++;
}

// Nguyễn Văn Khương
//xóa Tập tin
void CThuMuc::xoaTapTin(char* tenTapTin){
	int tim = 0;
	for (int i = 0; i < soLuongTapTin; i++)
	{
		if (strcmp(tenTapTin, DSTT[i].ten.c_str()) == 0)
		{
			tim = i;
		}
	}
	for (int i = tim; i < soLuongTapTin; i++)
	{
		DSTT[i] = DSTT[i + 1];
	}
	soLuongTapTin--;
}


// Nguyễn Văn Khương
//Tìm kiếm tập tin và mấy thằng trùng với nó 
void CThuMuc::timKiem(char* tenTapTin){
		for (int i = 0; i < soLuongTapTin; i++)
		{
			cout<<strstr((this->DSTT[i].ten.c_str()), tenTapTin)<<endl;
		}
}

// Nguyễn Văn Khương
//Nhập thì nhập 1 thư mục trong đó nhập n tập tin
// thế thì viết tm1.nhap(); -> trong hàm nhập thì sẽ có gọi số theo số lần so lượng tập tin và gọi hàm x.nhap() bên tập tin nhiều lần
void main(){
	CThuMuc tm1;
	CTapTin tt;
	tm1.nhap();
	tm1.xuat();
	cout << "Kich thuoc thu muc: " << tm1.kichThuocThuMuc() << endl;
	tm1.Tao1TapTinMoi(tt);
	tt.xuat();
	system("pause");
}