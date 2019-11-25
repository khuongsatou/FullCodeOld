#pragma once


class DongVat
{
protected:
	int MaSo,MaLoai;
	float CanNang;
	char *TenGiong = new char[50],*GioiTinh = new char[50];
public:
	DongVat(){}
	~DongVat(){}

	virtual void Nhap() = 0;
	virtual void Xuat() = 0;
	virtual float TinhCanNang() = 0;
	virtual float  TinhTongLuongSua() = 0;
	virtual float  TinhTongLuongTrung() = 0;
	virtual int getMaSo() = 0;
};


class Bo: public DongVat
{
protected:
	float SLSua;

public:
	Bo(){
		this->MaLoai = 1;
	}
	~Bo(){}
	virtual void Nhap(){
		cout << "\n\t+Nhap Ma So:"; cin >> MaSo;
		fflush(stdin);
		cout << "\n\t+Nhap Ten Giong Bo:"; gets(TenGiong);
		cout << "\n\t+Nhap San Luong Sua:"; cin >> SLSua;
		fflush(stdin);
		cout << "\n\t+Nhap Gioi Tinh:"; gets(GioiTinh);
		cout << "\n\t+Nhap Can Nang:"; cin >> CanNang;
	}
	virtual void Xuat(){
		cout << "\n\t+Ma Loai " << MaLoai;
		cout << "\n\t+Ma So:" << MaSo;
	
		cout << "\n\t+Ten Giong Bo:"<<TenGiong;
		cout << "\n\t+San Luong Sua:"<< SLSua;
	
		cout << "\n\t+Gioi Tinh:"<<GioiTinh;
		cout << "\n\t+Can Nang:"<<CanNang;
	}
	virtual float TinhCanNang(){
		return CanNang;
	}
	virtual float  TinhTongLuongSua(){
		return SLSua;
	}
	virtual float  TinhTongLuongTrung(){
		return 0;
	}
	
	virtual int  getMaSo(){
		return MaSo;
	}
};

class Heo : public DongVat
{
public:
	Heo(){
		this->MaLoai = 2;
	}
	~Heo(){}
	virtual void Nhap(){
		cout << "\n\t+Nhap Ma So:"; cin >> MaSo;
		fflush(stdin);
		cout << "\n\t+Nhap Ten Giong Heo:"; gets(TenGiong);

		fflush(stdin);
		cout << "\n\t+Nhap Gioi Tinh:"; gets(GioiTinh);
		cout << "\n\t+Nhap Can Nang:"; cin >> CanNang;
	}
	virtual void Xuat(){
		cout << "\n\t+Ma Loai " << MaLoai;
		cout << "\n\t+Ma So:" << MaSo;

		cout << "\n\t+Ten Giong Heo:" << TenGiong;

		cout << "\n\t+Gioi Tinh:" << GioiTinh;
		cout << "\n\t+Can Nang:" << CanNang;
	}

	virtual float TinhCanNang(){
		return CanNang;
	}

	virtual float  TinhTongLuongSua(){
		return 0;
	}
	virtual float  TinhTongLuongTrung(){
		return 0;
	}

	virtual int  getMaSo(){
		return MaSo;
	}
};

class Ga : public DongVat
{
protected:
	float SLTrung;
public:
	Ga(){
		this->MaLoai = 3;
	}
	~Ga(){}

	virtual void Nhap(){
		cout << "\n\t+Nhap Ma So:"; cin >> MaSo;
		fflush(stdin);
		cout << "\n\t+Nhap Ten Giong Ga:"; gets(TenGiong);
		cout << "\n\t+Nhap San Luong Trung:"; cin >> SLTrung;
		fflush(stdin);
		cout << "\n\t+Nhap Gioi Tinh:"; gets(GioiTinh);
		cout << "\n\t+Nhap Can Nang:"; cin >> CanNang;
	}
	virtual void Xuat(){
		cout << "\n\t+Ma Loai " << MaLoai;
		cout << "\n\t+Ma So:" << MaSo;

		cout << "\n\t+Ten Giong Ga:" << TenGiong;
		cout << "\n\t+San Luong Trung:"<< SLTrung;
		cout << "\n\t+Gioi Tinh:" << GioiTinh;
		cout << "\n\t+Can Nang:" << CanNang;
	}

	virtual float TinhCanNang(){
		return CanNang;
	}
	virtual float  TinhTongLuongSua() {
		return 0;
	}
	virtual float  TinhTongLuongTrung(){
		return SLTrung;
	}

	virtual int  getMaSo(){
		return MaSo;
	}
};

void showMenu(){
	cout << "1. Bo" << endl;
	cout << "2. Heo" << endl;
	cout << "3. Ga" << endl;

}


class VatNuoi
{
protected:
	DongVat **dv;
	int n,luachon;
	int TongCanNang = 0, TongLuongSua = 0, TongLuongTrung = 0,vitri,max;
public:
	VatNuoi(){}
	~VatNuoi(){
		delete[]dv;
	}

	void Nhap(){
		cout << "Nhap So Luong Con:"; cin >> n;
		dv = new DongVat*[n];
		for (int i = 0; i < n; i++)
		{
			system("cls");

			cout << "Con Thu__" << i + 1 <<"___"<< endl;
			cout << "_______Menu_______" << endl;
			showMenu();

			cout << "Lua Chon_"; cin >> luachon;
			switch (luachon)
			{
				case 1:dv[i] = new Bo; break;
				case 2:dv[i] = new Heo; break;
				default:dv[i] = new Ga; break;
			}
			dv[i]->Nhap();
		}

		system("cls");
	}

	void Xuat(){
		
		cout << "_____Danh Sach Vat Nuoi_____" << endl;
		for (int i = 0; i < n; i++)
		{
			cout << "Con Thu:__" << i + 1 << "___" << endl;
			dv[i]->Xuat();
			cout << endl;
		}
	}

	void TinhCanNang(){
		cout << "_____Tinh Tong Can Nang_____" << endl;
		for (int i = 0; i < n; i++)
		{
			TongCanNang += dv[i]->TinhCanNang();
		}
		cout << "\t+Can Nang All:" << TongCanNang << endl;
	}

	void TinhTongLuongSua(){
		cout << "_____Tinh Tong Sua_____" << endl;
		for (int i = 0; i < n; i++)
		{
			TongLuongSua += dv[i]->TinhTongLuongSua();
		}
		cout << "\t+Tong Sua:" << TongLuongSua << endl;
	}

	void TinhTongLuongTrung(){
		cout << "_____Tinh Tong Luong Trung_____" << endl;
		for (int i = 0; i < n; i++)
		{
			TongLuongTrung += dv[i]->TinhTongLuongTrung();
		}
		cout << "\t+Tong Trung:" << TongLuongTrung << endl;
	}
	

	void TimCanNangLonNhat(){
		cout << "_____Tim Can Nang lon Nhat_____" << endl;
		max = dv[0]->TinhCanNang();
		for (int i = 0; i < n; i++)
		{
			if (max < dv[i]->TinhCanNang())
			{
				max = dv[i]->TinhCanNang();
				vitri = i;
			}
		}
		
		cout << "\t+Ma So:" << dv[vitri]->getMaSo() << endl;
	}

};
