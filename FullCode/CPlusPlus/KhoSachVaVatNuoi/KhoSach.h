#pragma once
// Ho ten: Nguyen Van Khuong
// MSSV: 0306171362
// Lop: CDTH17D
//



class Sach
{
protected:
	int maSach, nam;
	int soLuongTonKho, maLoai;
	float giatien;
	char* tenSach = new char[50];
public:
	Sach(){}
	~Sach(){}

	virtual void Nhap() = 0;
	virtual void Xuat() = 0;
	virtual float TinhTongTien() = 0;
	virtual float TinhTongTien(int maLoai) = 0;
	virtual float TimSachReNhat() = 0;
};

void ShowMenu(){
	cout << "1.Sach Giao Khoa" << endl;
	cout << "2.Truyen Tranh" << endl;
	cout << "3.Tieu Thuyet" << endl;
}


class SachGiaoKhoa : public Sach
{
protected:
	char* tenMon = new char[50];
public:
	SachGiaoKhoa(){
		this->maLoai = 1;
	}
	~SachGiaoKhoa(){}

	virtual void Nhap(){
		cout << "Nhap Ma Sach:"; cin >> maSach;
		fflush(stdin);
		cout << "Nhap Ten Sach:"; gets(tenSach);
		fflush(stdin);
		cout << "Nhap Ten Mon:"; gets(tenMon);
		cout << "Nhap Nam Xuat Ban:"; cin >> nam;
		cout << "Nhap Gia Tien:"; cin >> giatien;
	}
	virtual void Xuat(){
		cout << "Ma Loai:" << maLoai << endl;
		cout << "Ma Sach:" << maSach<<endl;
		cout << "Ten Sach:"<< tenSach<<endl;
		cout << "Nhap Ten Mon:"<<tenMon<<endl;
		cout << "Nhap Nam Xuat Ban:" << nam << endl;
		cout << "Gia Tien:" << giatien<<endl;
	}

	virtual float TinhTongTien(){
		return giatien;
	}

	virtual float TinhTongTien(int maLoai){
		if (maLoai == 1)
		{
			return giatien;
		}
		return 0;
	}

	virtual float TimSachReNhat(){
		return giatien;
	}
};


class  TruyenTranh :public Sach
{
public:
	TruyenTranh(){
		this->maLoai = 2;
	}
	~TruyenTranh(){}
	virtual void Nhap(){
		cout << "Nhap Ma Sach:"; cin >> maSach;
		fflush(stdin);
		cout << "Nhap Ten Sach:"; gets(tenSach);
		fflush(stdin);
		cout << "Nhap Nam Xuat Ban:"; cin >> nam;
		cout << "Nhap Gia Tien:"; cin >> giatien;
	}
	virtual void Xuat(){
		cout << "Ma Loai:" << maLoai << endl;
		cout << "Ma Sach:" << maSach << endl;
		cout << "Ten Sach:" << tenSach << endl;
		cout << "Nhap Nam Xuat Ban:" << nam << endl;
		cout << "Gia Tien:" << giatien << endl;
	}

	virtual float TinhTongTien(){
		return giatien;
	}

	virtual float TinhTongTien(int maLoai){
		if (maLoai == 2)
		{
			return giatien;
		}
		return 0;
	}


	virtual float TimSachReNhat(){
		return giatien;
	}
};


class  TieuThuyet :public Sach
{
protected:
	char* tenTacGia = new char[50];
public:
	TieuThuyet(){
		this->maLoai = 3;
	}
	~TieuThuyet(){}

	virtual void Nhap(){
		cout << "Nhap Ma Sach:"; cin >> maSach;
		fflush(stdin);
		cout << "Nhap Ten Sach:"; gets(tenSach);
		fflush(stdin);
		cout << "Nhap Ten Tac Gia:"; gets(tenTacGia);
		cout << "Nhap Gia Tien:"; cin >> giatien;
	}
	virtual void Xuat(){
		cout << "Ma Loai:" << maLoai << endl;
		cout << "Ma Sach:" << maSach << endl;
		cout << "Ten Sach:" << tenSach << endl;
		cout << "Nhap Ten Mon:" << tenTacGia << endl;
		cout << "Gia Tien:" << giatien << endl;
	}

	virtual float TinhTongTien(){
		return giatien;
	}

	virtual float TinhTongTien(int maLoai){
		if (maLoai == 3)
		{
			return giatien;
		}
		return 0;
	}

	virtual float TimSachReNhat(){
		return giatien;
	}
};






class KhoSach
{
protected:
	Sach **s;
	int n;

public:
	KhoSach(){}
	~KhoSach(){

	}

	void Nhap(){
		
		//số lượng
		cout << "Nhap SL Sach:"; cin >> n;
		//khởi tạo
		s = new Sach*[n];

		for (int i = 0; i < n; i++)
		{
			system("cls");
			int luachon;

			cout << "Nhap Sach Thu:" << i + 1 << endl;
			ShowMenu();

			//kiểm tra lựa chọn
			do
			{
				cout << "Lua Chon:_";
				cin >> luachon;
			} while (luachon<0 || luachon>4);

			//lựa chọn
			switch (luachon)
			{
			case 1:  s[i] = new SachGiaoKhoa; break;
			case 2:  s[i] = new TruyenTranh; break;
			default: s[i] = new TieuThuyet; break;
			}
			//nhập phần tủ đầu
			s[i]->Nhap();
		}

		system("cls");

	}
	void Xuat(){
		//tính tiền all
		float TinhTongTienALL = 0;
		for (int i = 0; i < n; i++)
		{
			cout << "__Sach thu__:" << i + 1 << endl;
			s[i]->Xuat();
			TinhTongTienALL += s[i]->TinhTongTien();
			cout << endl;
		}

		cout << endl;
		cout << "___Tinh Tien Tat Ca Loai Sach___" << endl;
		cout << "Tien Sach Trong Kho:" << TinhTongTienALL << endl;

		//giá 1 loại sách
		cout << endl;
		cout << "___Tinh Tien 1 Loai sach nao do___" << endl;

		int one;
		cout << "Nhap Loai Sach:"; cin >> one;
		float TinhTongTienOne = 0;
		for (int i = 0; i < n; i++)
		{
			TinhTongTienOne += s[i]->TinhTongTien(one);
		}

		cout << "Tien Ma Loai " << one << " la :" << TinhTongTienOne << endl;


		//tìm sách nhỏ nhất
		float min = s[0]->TimSachReNhat();
		int vitri = 0;
		for (int i = 0; i < n; i++)
		{
			if (s[i]->TimSachReNhat() < min)
			{
				min = s[i]->TimSachReNhat();
				vitri = i;
			}
		}

		cout << endl;
		cout << "___Sach Re Nhat___" << endl;
		s[vitri]->Xuat();

		// if (max>i)-> max=i
	}
	/*float TinhTongTien(){

	}
	float TinhTongTien(int maLoai){

	}
	float TimSachReNhat(){

	}*/
};

