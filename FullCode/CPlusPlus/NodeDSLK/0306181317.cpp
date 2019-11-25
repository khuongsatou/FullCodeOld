#include<iostream>
#include<conio.h>
using namespace std;

//Đề 1
struct node
{
	int info;
	node *next;
};
struct list
{
	node *head;
	node *tail;
};
node* GetNode(int x)
{
	node *p;
	p = new node;
	if (p == NULL)
	{
		cout << "Khong du bo nho";
		exit(1);
	}
	p->info = x;
	p->next = NULL;
	return p;
}
void InsertTail(list &l, int x)
{
	node *p = GetNode(x);
	if (p == NULL)
	{
		cout << "Khong tao duoc nut moi !";
		exit(1);
	}
	if (l.head == NULL)
		l.head = l.tail = p;
	else
	{
		l.tail->next = p;
		l.tail = p;
	}
}
void NhapDStuFile(char *FileName, list &l)
{
	FILE *f;
	f = fopen(FileName, "rt");
	if (f == NULL)
	{
		return;
	}
	int n;
	fscanf(f, "%d\n", &n);
	for (int i = 0; i < n; i++)
	{
		int x;
		fscanf(f, "%d", &x);
		InsertTail(l, x);
	}
	fclose(f);
}
void Output(list &l)
{
	node *p;
	p = l.head;
	while (p != NULL)
	{
		cout << p->info << " ";
		p = p->next;
	}
}
void DeleteAfter(list &l, node* q)
{
	node *p;
	if (q != NULL)
	{
		p = q->next;
		if (p != NULL)
		{
			if (p == l.tail)
				l.tail = q;
			q->next = p->next;
			delete p;
		}
	}
}
void DeleteHead(list &l)
{
	node *p;
	if (l.head != NULL)
	{
		p = l.head;
		l.head = l.head->next;
		delete p;
		if (l.head == NULL)
			l.tail = NULL;
	}
}
void TimPTNhoHonx(list &l, int x)
{
	node *p;
	p = l.head;
	while (p != NULL)
	{
		if (p->info < x)
			cout << p -> info << " ";
		p = p->next;
	}
	
}
void XoaPTBangx(list &l, int x)
{
	while (l.head != NULL && l.head->info == x)
		DeleteHead(l);
	if (l.head != NULL)
	{
		node *p;
		p = l.head;
		while (p != NULL)
		{
			node *q;
			q = p->next;
			if (q != NULL && q->info == x)
			{
				DeleteAfter(l, p);
			}
			p = p->next;
		}
	}
}
void GiamDan(list &l)
{
	node *max;
	node *p, *q;
	p = l.head;
	while (p != l.tail)
	{
		max = p; q = p->next;
		while (q != NULL)
		{
			if (q->info > max->info)
				max = q;
			q = q->next;
		}
		swap(max->info, p->info);
		p = p->next;
	}
}
void main()
{
	list l;
	int x, p;
	l.head = l.tail = NULL;
	char *FileName1;
	FileName1 = "KiemTra2.txt";
	NhapDStuFile(FileName1, l); // 1
	Output(l); // 2

	// 3
	cout << "\n\nTim gia tri nho hon x: ";
	cin >> x;
	cout << endl;
	TimPTNhoHonx(l, x);

	// 4
	cout << "\n\nNhap gia tri x can xoa: ";
	cin >> x;
	XoaPTBangx(l, x);
	cout << endl;
	Output(l);

	// 5
	GiamDan(l);
	cout << "\n\nDSLk theo chieu giam dan: \n\n";
	Output(l);
	
	_getch();
}