#pragma once
#include<iostream>
using namespace std;
//

class PhanSo {
private:
	int tu, mau;
public:
	PhanSo();
	PhanSo(int tu, int mau);
	PhanSo(const PhanSo &phanSo);
	~PhanSo();
	//
	void chuanHoa();
	void rutGon();

	PhanSo operator+(PhanSo phanSo);
	PhanSo operator-(PhanSo phanSo);
	PhanSo operator*(PhanSo phanSo);
	PhanSo operator/(PhanSo phanSo);
	PhanSo& operator=(PhanSo phanSo);
	PhanSo& operator+= (PhanSo phanSo);
	PhanSo& operator-=(PhanSo phanSo);
	PhanSo& operator*=(PhanSo phanSo);
	PhanSo& operator/=(PhanSo phanSo);
	PhanSo operator++();
	PhanSo operator++(int);
	PhanSo operator--();
	PhanSo operator--(int);
	bool operator<(PhanSo phanSo);
	bool operator<=(PhanSo phanSo);
	bool operator>(PhanSo phanSo);
	bool operator>=(PhanSo phanSo);
	bool operator==(PhanSo phanSo);
	bool operator!=(PhanSo phanSo);
	friend istream& operator>>(istream& in, PhanSo& phanSo);
	friend ostream& operator>>(ostream& out, PhanSo phanSo);
};
int gcd(int a, int b);
istream& operator>>(istream& in, PhanSo& phanSo);
ostream& operator>>(ostream& on, PhanSo phanSo);