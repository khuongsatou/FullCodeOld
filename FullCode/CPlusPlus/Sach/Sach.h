#pragma once
#include<iostream>
#include<string>
using namespace std;

class Sach
{



public:
	Sach();
	~Sach();
	virtual void nhap() = 0;
	virtual void xuat() = 0;
};

