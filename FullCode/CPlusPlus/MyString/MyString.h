//Nguyễn Văn Khương
//0306171362


#pragma once
class MyString
{
private:
	char *str;
	int len;
public:
	//Nguyễn Văn Khương
	//mặc định
	MyString(){
		len = 0;
		str = new char[len];
		str = NULL;
	}
	//Nguyễn Văn Khương
	//có tham số
	MyString(int x, char *s){
		len = x;
		str = new char[len];
		str = s;
	}
	//Nguyễn Văn Khương
	//sao chép
	MyString(const MyString &s){
		len = s.len;
		str = new char[len];
		str = s.str;
	}
	//Nguyễn Văn Khương
	//hàm hủy
	~MyString(){
		if (str != NULL)
		{
			str = NULL;
			delete[] str;
		}
	}

	//Nguyễn Văn Khương
	//Nhập >>
	friend istream& operator >> (istream &i, MyString &x){
		x.str = new char[x.len];
		char *tam = new char[x.len];
		gets(tam);
		strcpy(x.str, tam);
		return i;
	}

	//Nguyễn Văn Khương
	//Xuất <<
	friend ostream& operator << (ostream &i, MyString x){
		i << x.str << endl;
		/*i << "Do Dai M:" << x.len << endl;*/
		return i;
	}

	//Nguyễn Văn Khương
	//+
	//cho vào chuỗi 2
	//ý tưởng: lấy chuỗi 1 nối với chuỗi 2
	//cách làm : độ dài + độ dài  , chuỗi tạm= chuỗi 1 + chuỗi 2 
	char* operator+(MyString x)
	{
		string s(str);
		string s1(x.str);
		string tam = s + s1;
		char *k = new char[tam.length()];
		strcpy(k, tam.c_str());
		return k;
	}

	//Nguyễn Văn Khương
	//+=
	MyString operator+=(MyString x)
	{
		string s(str);
		string s1(x.str);
		s += s1;
		len += x.len;
		strcpy(str, s.c_str());
		return *this;
	}

	//Nguyễn Văn Khương
	//=
	//đầu vào là 2 chuỗi
	//ý tưởng gán chuỗi b->a cùng độ dài và cùng str
	//..
	MyString &operator=(MyString &x)
	{
		len = x.len;
		str = new char[len];
		strcpy(str, x.str);
		return x;
	}

	//Nguyễn Văn Khương
	//==
	//ý tưởng :Nếu giá trị trả về < 0 thì hàm này chỉ rằng str1 là ngắn hơn str2.
	//Nếu giá trị trả về > 0 thì hàm này chỉ rằng str2 là ngắn hơn str1.
	//Nếu giá trị trả về = 0 thì hàm này chỉ rằng str1 là bằng str2.
	//đầu vào 1 chuỗi vs 1 chuỗi gốc 
	// trả kq là 1 hoặc 0 là đúng
	bool operator==(MyString x)
	{
		if (strcmp(str,x.str) == 0)
		{
			return 1;
		}
		return 0;
	}

	//Nguyễn Văn Khương
	//>
	bool operator > (MyString x)
	{
		if (strcmp(str, x.str) > 0)
		{
			return 1;
		}
		return 0;
	}

	//Nguyễn Văn Khương
	//<
	bool operator < (MyString x)
	{
		if (strcmp(str, x.str) < 0)
		{
			return 1;
		}
		return 0;
	}

	//Nguyễn Văn Khương
	//<=
	bool operator <= (MyString x)
	{
		if (strcmp(str, x.str) <= 0)
		{
			return 1;
		}
		return 0;
	}

	//Nguyễn Văn Khương
	//>=
	bool operator >= (MyString x)
	{
		if (strcmp(str, x.str) >= 0)
		{
			return 1;
		}
		return 0;
	}

	//Nguyễn Văn Khương
	//!=
	bool operator != (MyString x)
	{
		if (strcmp(str, x.str) != 0)
		{
			return 1;
		}
		return 0;
	}

	//Nguyễn Văn Khương
	//[]
	//truy xuất phần tử trong mảng con trỏ gồm N phần tử
	//ý tưởng: 1 chuỗi string thì khi truyền vào  1 sẽ in kí tự mảng đó 
	//truyền vào 2 thì sẽ in ra kí tự 2

	//Nguyễn Văn Khương
	void operator[](int x)//i này là mảng thứ n
	{
		string s(str);
		if ( x <= s.length())
		{
			cout << s[x];
		}
		else
		{
			cout << "Khong co ki tu nao trong chuoi"; 
		}
	}

	//Nguyễn Văn Khương
	//----------
	//Lấy độ dài chuỗi, Viết phương thức length();
	int  length_1(){
		return strlen(str);
	}

	//Nguyễn Văn Khương
	// Kiêm tra rỗng rỗng =1 , không rỗng =0
	bool empty_1(){
		string s(str);
		return s.empty();
	}

	//Nguyễn Văn Khương
	// Hàm insert
	//đầu vào vào vị trí , chuỗi cần chèn
	//trả về *this đã tham chiếu
	char* insert_1(int vitri,char *x){
		string s(str);
		string tam = s.insert(vitri,x);
		char *k = new char;
		strcpy(k,tam.c_str());
		return k;
	}

	//Nguyễn Văn Khương
	//xóa chuỗi con
	char* erase_1(int vitri,int sl){
		string s(str);
		string tam = s.erase(vitri, sl);
		char *k = new char[30];
		strcpy(k, tam.c_str());
		return k;
	}

	//Nguyễn Văn Khương
	//dọn sạch chuỗi
	char* clear_1(){
		string s(str);
		s.clear();
		str = new char;
		strcpy(str, s.c_str());
		return str;
	}

	//Nguyễn Văn Khương
	//tìm chuỗi
	char* substr_1(int i,int j){
		string s(str);
		string tam=s.substr(i,j);
		str = new char;
		strcpy(str, tam.c_str());
		return str;
	}


	//Nguyễn Văn Khương
	//đầu vào là 1 chuỗi nhiều khoảng trắng ,
	//nếu trong chuỗi có nhiều hơn 2 khoảng trắng thì xóa 1
	char* chuan_hoa(){
		string s(str);
		str = new char;
		int length = s.length();
		string luu= s;
		for (int i = 0; i < length; i++)
		{
			if (s[i] ==' ' && s[i+1] == ' ')
			{
				luu = s.erase(i,1);
				i--;
				length--;
			}
		}
		
		if (s[0] == ' ')
		{
			luu=s.erase(0,1);
			length--;
		}
		if (s[length-1]==' ')
		{
			luu=s.erase(length-1, 1);
			length--;
		}
		strcpy(str, luu.c_str());
		return str;
	}

	//Nguyễn Văn Khương
	//thường thành in
	char* thuong_thanh_in(){
		string s(str);
		int length =s.length();
		str = new char;
		for (int i = 0; i < length; i++)
		{
			if (s[i] >= 'a' && s[i]<='z')
			{
				s[i] -= 32;
			}
		}
		strcpy(str,s.c_str());
		return str;
	}


	//Nguyễn Văn Khương
	//in thành thường
	char* in_thanh_thuong(){
		string s(str);
		int length = s.length();
		str = new char;
		for (int i = 0; i < length; i++)
		{
			if (s[i] >= 'A' && s[i] <= 'Z')
			{
				s[i] += 32;
			}
		}
		strcpy(str, s.c_str());
		return str;
	}


	//Nguyễn Văn Khương
	//viết hoa chữ đầu
	char* bien_chu_cai_dau_moi_tu_thanh_hoa(){
		string s(str);
		int length = s.length();
		str = new char;
		if (s[0] != ' ')
		{
			if (s[0] >= 'a' && s[0] <= 'z')
			{
				s[0] -= 32;
			}
		}
		for (int i = 0; i < length; i++)
		{
			if (s[i] == ' ' && s[i + 1] != ' ')
			{
				if (s[i+1] >= 'a' && s[i+1] <='z')
				{
					s[i + 1] -= 32;
				}
			}
		}
		strcpy(str, s.c_str());
		return str;
	}

	
	//======================= end ==============
};
