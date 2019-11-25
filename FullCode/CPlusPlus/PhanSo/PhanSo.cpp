#include"PhanSo.hpp"
//
PhanSo::PhanSo() {
	tu = 0;
	mau = 1;
}
PhanSo::PhanSo(int tu, int mau) {
	this->tu = tu;
	this->mau = mau;
}
PhanSo::PhanSo(const PhanSo &phanSo) {
	tu = phanSo.tu;
	mau = phanSo.mau;
}
PhanSo:: ~PhanSo() {};
void PhanSo::chuanHoa() {
	if (tu < 0 && mau < 0) {
		tu = abs(tu);
		mau = abs(mau);
	}
	if (tu > 0 && mau < 0) {
		tu = -tu;
		mau = abs(mau);
	}
}
void PhanSo::rutGon() {
	int temp = gcd(tu, mau);
	tu /= temp;
	mau /= temp;
}
PhanSo PhanSo::operator+(PhanSo phanSo) {
	PhanSo ketQua;
	ketQua.tu = tu * phanSo.mau + mau * phanSo.tu;
	ketQua.mau = mau * phanSo.mau;
	ketQua.chuanHoa();
	ketQua.rutGon();
	return ketQua;
}
PhanSo PhanSo::operator-(PhanSo phanSo) {
	PhanSo ketQua;
	ketQua.tu = tu * phanSo.mau - mau * phanSo.tu;
	ketQua.mau = mau * phanSo.mau;
	ketQua.chuanHoa();
	ketQua.rutGon();
	return ketQua;
}
PhanSo PhanSo::operator*(PhanSo phanSo) {
	PhanSo ketQua;
	ketQua.tu = tu * phanSo.tu;
	ketQua.mau = mau * phanSo.mau;
	ketQua.chuanHoa();
	ketQua.rutGon();
	return ketQua;
}
PhanSo PhanSo::operator/(PhanSo phanSo) {
	PhanSo ketQua;
	ketQua.tu = tu * phanSo.mau;
	ketQua.mau = mau * phanSo.tu;
	ketQua.chuanHoa();
	ketQua.rutGon();
	return ketQua;
}
PhanSo& PhanSo::operator=(PhanSo phanSo) {
	tu = phanSo.tu;
	mau = phanSo.mau;
	return *this;
}
PhanSo& PhanSo::operator+=(PhanSo phanSo) {
	*this = *this + phanSo;
	return *this;
}
PhanSo& PhanSo::operator-=(PhanSo phanSo) {
	*this = *this - phanSo;
	return *this;
}
PhanSo& PhanSo::operator*=(PhanSo phanSo) {
	*this = *this * phanSo;
	return *this;
}
PhanSo& PhanSo::operator/=(PhanSo phanSo) {
	*this = *this / phanSo;
	return *this;
}
PhanSo PhanSo::operator++() {
	tu += mau;
	return *this;
}
PhanSo PhanSo::operator++(int) {
	PhanSo temp = *this;
	this->tu += this->mau;
	return temp;
}
PhanSo PhanSo::operator--() {
	tu -= mau;
	return *this;
}
PhanSo PhanSo::operator--(int) {
	PhanSo temp = *this;
	this->tu -= this->mau;
	return temp;
}
bool PhanSo::operator<(PhanSo phanSo) {
	if (tu*phanSo.mau < mau * phanSo.tu) {
		return true;
	}
	return false;
}
bool PhanSo::operator<=(PhanSo phanSo) {
	if (tu*phanSo.mau <= mau * phanSo.tu) {
		return true;
	}
	return false;
}
bool PhanSo::operator>(PhanSo phanSo) {
	if (tu*phanSo.mau > mau * phanSo.tu) {
		return true;
	}
	return false;
}
bool PhanSo::operator>=(PhanSo phanSo) {
	if (tu*phanSo.mau >= mau * phanSo.tu) {
		return true;
	}
	return false;
}
bool PhanSo::operator==(PhanSo phanSo) {
	if (tu*phanSo.mau == mau * phanSo.tu) {
		return true;
	}
	return false;
}
bool PhanSo::operator!=(PhanSo phanSo) {
	if (tu*phanSo.mau != mau * phanSo.tu) {
		return true;
	}
	return false;
}
istream& operator>>(istream& in, PhanSo& phanSo) {
	cout << "Nhap tu: ";
	cin >> phanSo.tu;
	cout << "Nhap mau: ";
	cin >> phanSo.mau;
	return in;
}
ostream& operator>>(ostream& out, PhanSo phanSo) {
	cout << phanSo.tu << "/" << phanSo.mau << endl;
	return out;
}
int gcd(int a, int b) {
	while (b != 0) {
		int r = a % b;
		a = b;
		b = r;
	}
	return a;
}
