USE [master]
GO
/****** Object:  Database [QLCUAHANGSACH]    Script Date: 13/12/2018 4:03:22 PM ******/
CREATE DATABASE [QLCUAHANGSACH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLCUAHANGSACH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLCUAHANGSACH.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLCUAHANGSACH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLCUAHANGSACH_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLCUAHANGSACH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLCUAHANGSACH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLCUAHANGSACH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLCUAHANGSACH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLCUAHANGSACH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLCUAHANGSACH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET RECOVERY FULL 
GO
ALTER DATABASE [QLCUAHANGSACH] SET  MULTI_USER 
GO
ALTER DATABASE [QLCUAHANGSACH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLCUAHANGSACH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLCUAHANGSACH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLCUAHANGSACH] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLCUAHANGSACH', N'ON'
GO
USE [QLCUAHANGSACH]
GO
/****** Object:  Table [dbo].[CTHDBanHang]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHDBanHang](
	[MaHD] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[GiaBan] [int] NULL,
	[KhuyenMai] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_CTHDBanHang] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTHDNhapHang]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHDNhapHang](
	[MaHD] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [int] NULL,
	[GiaBia] [int] NULL,
 CONSTRAINT [PK_CTHDNhapHang] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HDBanHang]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDBanHang](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[NgayBan] [datetime] NULL,
	[MaNV] [int] NULL,
	[MaKH] [int] NULL,
	[TongTien] [int] NULL,
 CONSTRAINT [PK_HDBanHang] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HDNhapHang]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDNhapHang](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[NgayNhap] [datetime] NULL,
	[MaNV] [int] NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [PK_HDNhapHang] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [ntext] NULL,
	[DienThoai] [varchar](15) NULL,
	[Email] [varchar](30) NULL,
	[Xoa] [bit] NULL CONSTRAINT [DF_KhachHang_Xoa]  DEFAULT ((0)),
	[GhiChu] [ntext] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiNhanVien]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNhanVien](
	[MaLoaiNV] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](30) NULL,
	[Xoa] [bit] NULL CONSTRAINT [DF_LoaiNhanVien_Xoa]  DEFAULT ((0)),
	[GhiChu] [ntext] NULL,
 CONSTRAINT [PK_LoaiNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[MatKhau] [char](32) NOT NULL,
	[MaLoaiNV] [int] NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [varchar](15) NULL,
	[Email] [varchar](30) NULL,
	[Xoa] [bit] NULL CONSTRAINT [DF_NhanVien_Xoa]  DEFAULT ((0)),
	[GhiChu] [ntext] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaXuatBan](
	[MaNXB] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](256) NULL,
	[Website] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Xoa] [bit] NULL CONSTRAINT [DF_NhaXuatBan_Xoa]  DEFAULT ((0)),
	[GhiChu] [ntext] NULL,
 CONSTRAINT [PK_NhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](256) NULL,
	[MaTacGia] [int] NULL,
	[MaTheLoai] [int] NULL,
	[NgayXuatBan] [datetime] NULL,
	[MaNXB] [int] NULL,
	[GiaNhap] [int] NULL,
	[GiaBia] [int] NULL,
	[SoLuong] [int] NULL,
	[AnhBia] [varchar](255) NULL,
	[Xoa] [bit] NULL CONSTRAINT [DF_Sach_Xoa]  DEFAULT ((0)),
	[GhiChu] [ntext] NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTacGia] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
	[Xoa] [bit] NULL CONSTRAINT [DF_TacGia_Xoa]  DEFAULT ((0)),
	[GhiChu] [ntext] NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TheLoaiSach]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoaiSach](
	[MaTheLoai] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Xoa] [bit] NULL CONSTRAINT [DF_TheLoaiSach_Xoa]  DEFAULT ((0)),
	[GhiChu] [ntext] NULL,
 CONSTRAINT [PK_TheLoaiSach] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[CTHDBanHang] ([MaHD], [MaSach], [SoLuong], [GiaBan], [KhuyenMai], [ThanhTien]) VALUES (1, 1, 1, 34000, 0, 68000)
INSERT [dbo].[CTHDNhapHang] ([MaHD], [MaSach], [SoLuong], [GiaNhap], [GiaBia]) VALUES (1, 1, 15, 27200, 34000)
INSERT [dbo].[CTHDNhapHang] ([MaHD], [MaSach], [SoLuong], [GiaNhap], [GiaBia]) VALUES (1, 2, 10, 43200, 54000)
SET IDENTITY_INSERT [dbo].[HDBanHang] ON 

INSERT [dbo].[HDBanHang] ([MaHD], [NgayBan], [MaNV], [MaKH], [TongTien]) VALUES (1, CAST(N'2018-12-13 15:26:44.670' AS DateTime), 2, 1, 68000)
SET IDENTITY_INSERT [dbo].[HDBanHang] OFF
SET IDENTITY_INSERT [dbo].[HDNhapHang] ON 

INSERT [dbo].[HDNhapHang] ([MaHD], [NgayNhap], [MaNV], [GhiChu]) VALUES (1, CAST(N'2018-12-13 00:00:00.000' AS DateTime), 1, N'')
SET IDENTITY_INSERT [dbo].[HDNhapHang] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Email], [Xoa], [GhiChu]) VALUES (1, N'Khách Lẻ', CAST(N'2018-01-01 00:00:00.000' AS DateTime), 1, N'', N'', N'', 0, N'')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Email], [Xoa], [GhiChu]) VALUES (2, N'Nguyễn Văn A', CAST(N'2018-12-13 00:00:00.000' AS DateTime), 1, N'Bình Chánh', N'', N'', 0, N'')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[LoaiNhanVien] ON 

INSERT [dbo].[LoaiNhanVien] ([MaLoaiNV], [Ten], [Xoa], [GhiChu]) VALUES (1, N'Quản Lý', 0, N'')
INSERT [dbo].[LoaiNhanVien] ([MaLoaiNV], [Ten], [Xoa], [GhiChu]) VALUES (2, N'Nhân Viên Bán Hàng', 0, N'')
SET IDENTITY_INSERT [dbo].[LoaiNhanVien] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [MaLoaiNV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Email], [Xoa], [GhiChu]) VALUES (1, N'23fb42c7ddc1017599541a953efb68bb', 1, N'Admin', CAST(N'2018-01-01 00:00:00.000' AS DateTime), 1, N'', N'', N'', 0, N'')
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [MaLoaiNV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Email], [Xoa], [GhiChu]) VALUES (2, N'23fb42c7ddc1017599541a953efb68bb', 2, N'Admin', CAST(N'2018-01-01 00:00:00.000' AS DateTime), 0, N'', N'', N'', 0, N'')
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [MaLoaiNV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Email], [Xoa], [GhiChu]) VALUES (3, N'202cb962ac59075b964b07152d234b70', 1, N'linh', CAST(N'2018-12-08 00:00:00.000' AS DateTime), 1, N'', N'', N'', 0, N'')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[NhaXuatBan] ON 

INSERT [dbo].[NhaXuatBan] ([MaNXB], [Ten], [Website], [Email], [Xoa], [GhiChu]) VALUES (1, N'NXB Văn Học', N'www.nxbvanhoc.com', N'tonghopvanhoc@vnn.vn', 0, N'')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [Ten], [Website], [Email], [Xoa], [GhiChu]) VALUES (2, N'NXB Thế Giới', N'www.thegioipublishers.vn', N'thegioi@hn.vnn.vn', 0, N'')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [Ten], [Website], [Email], [Xoa], [GhiChu]) VALUES (3, N'NXB Lao Động', N'http://nxblaodong.com.vn/', N'nxblaodong@yahoo.com', 0, N'')
SET IDENTITY_INSERT [dbo].[NhaXuatBan] OFF
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([MaSach], [Ten], [MaTacGia], [MaTheLoai], [NgayXuatBan], [MaNXB], [GiaNhap], [GiaBia], [SoLuong], [AnhBia], [Xoa], [GhiChu]) VALUES (1, N'Chào Mừng Đến Với N.H.K!', 1, 1, CAST(N'2015-08-13 00:00:00.000' AS DateTime), 1, 27200, 34000, 14, NULL, 0, N'')
INSERT [dbo].[Sach] ([MaSach], [Ten], [MaTacGia], [MaTheLoai], [NgayXuatBan], [MaNXB], [GiaNhap], [GiaBia], [SoLuong], [AnhBia], [Xoa], [GhiChu]) VALUES (2, N'Mình Là Cá, Việc Của Mình Là Bơi', 2, 11, CAST(N'2017-08-13 00:00:00.000' AS DateTime), 2, 43200, 54000, 10, NULL, 0, N'')
INSERT [dbo].[Sach] ([MaSach], [Ten], [MaTacGia], [MaTheLoai], [NgayXuatBan], [MaNXB], [GiaNhap], [GiaBia], [SoLuong], [AnhBia], [Xoa], [GhiChu]) VALUES (3, N'Khi Hơi Thở Hóa Thinh Không', 3, 2, CAST(N'2017-07-13 00:00:00.000' AS DateTime), 3, NULL, 0, 0, NULL, 0, N'')
INSERT [dbo].[Sach] ([MaSach], [Ten], [MaTacGia], [MaTheLoai], [NgayXuatBan], [MaNXB], [GiaNhap], [GiaBia], [SoLuong], [AnhBia], [Xoa], [GhiChu]) VALUES (4, N'Nghĩ Đơn Giản, Sống Đơn Thuần', 4, 4, CAST(N'2018-04-13 00:00:00.000' AS DateTime), 2, NULL, 0, 0, NULL, 0, N'')
SET IDENTITY_INSERT [dbo].[Sach] OFF
SET IDENTITY_INSERT [dbo].[TacGia] ON 

INSERT [dbo].[TacGia] ([MaTacGia], [HoTen], [NgaySinh], [GioiTinh], [Xoa], [GhiChu]) VALUES (1, N'Tatsuhiko Takimoto', CAST(N'1978-09-20 00:00:00.000' AS DateTime), 1, 0, N'')
INSERT [dbo].[TacGia] ([MaTacGia], [HoTen], [NgaySinh], [GioiTinh], [Xoa], [GhiChu]) VALUES (2, N'Takeshi Furukawa', CAST(N'2018-12-13 00:00:00.000' AS DateTime), 0, 0, N'')
INSERT [dbo].[TacGia] ([MaTacGia], [HoTen], [NgaySinh], [GioiTinh], [Xoa], [GhiChu]) VALUES (3, N'Paul Kalanithi', CAST(N'1977-04-01 00:00:00.000' AS DateTime), 1, 0, N'')
INSERT [dbo].[TacGia] ([MaTacGia], [HoTen], [NgaySinh], [GioiTinh], [Xoa], [GhiChu]) VALUES (4, N'Tolly Burkan', CAST(N'2018-12-13 00:00:00.000' AS DateTime), 1, 0, N'')
SET IDENTITY_INSERT [dbo].[TacGia] OFF
SET IDENTITY_INSERT [dbo].[TheLoaiSach] ON 

INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [Ten], [Xoa], [GhiChu]) VALUES (1, N'Văn học', 0, N'')
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [Ten], [Xoa], [GhiChu]) VALUES (2, N'Kinh tế', 0, N'')
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [Ten], [Xoa], [GhiChu]) VALUES (3, N'Thiếu nhi', 0, N'')
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [Ten], [Xoa], [GhiChu]) VALUES (4, N'Kỹ năng - Sống đẹp', 0, N'')
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [Ten], [Xoa], [GhiChu]) VALUES (5, N'Giáo Khoa', 0, N'')
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [Ten], [Xoa], [GhiChu]) VALUES (6, N'Từ Điển', 0, N'')
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [Ten], [Xoa], [GhiChu]) VALUES (7, N'Lịch sử', 0, N'')
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [Ten], [Xoa], [GhiChu]) VALUES (8, N'Truyện Tranh', 0, N'')
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [Ten], [Xoa], [GhiChu]) VALUES (9, N'Khoa học - Kỹ thuật', 0, N'')
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [Ten], [Xoa], [GhiChu]) VALUES (10, N'Tôn Giáo - Tâm Linh', 0, N'')
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [Ten], [Xoa], [GhiChu]) VALUES (11, N'Tư Duy - Kỹ Năng Sống', 0, N'')
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [Ten], [Xoa], [GhiChu]) VALUES (12, N'Tự Truyện - Hồi Ký', 0, N'')
SET IDENTITY_INSERT [dbo].[TheLoaiSach] OFF
ALTER TABLE [dbo].[CTHDBanHang]  WITH CHECK ADD  CONSTRAINT [FK_CTHDBanHang_HDBanHang] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HDBanHang] ([MaHD])
GO
ALTER TABLE [dbo].[CTHDBanHang] CHECK CONSTRAINT [FK_CTHDBanHang_HDBanHang]
GO
ALTER TABLE [dbo].[CTHDBanHang]  WITH CHECK ADD  CONSTRAINT [FK_CTHDBanHang_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[CTHDBanHang] CHECK CONSTRAINT [FK_CTHDBanHang_Sach]
GO
ALTER TABLE [dbo].[CTHDNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_CTHDNhapHang_HDNhapHang] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HDNhapHang] ([MaHD])
GO
ALTER TABLE [dbo].[CTHDNhapHang] CHECK CONSTRAINT [FK_CTHDNhapHang_HDNhapHang]
GO
ALTER TABLE [dbo].[CTHDNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_CTHDNhapHang_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[CTHDNhapHang] CHECK CONSTRAINT [FK_CTHDNhapHang_Sach]
GO
ALTER TABLE [dbo].[HDBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HDBanHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HDBanHang] CHECK CONSTRAINT [FK_HDBanHang_KhachHang]
GO
ALTER TABLE [dbo].[HDBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HDBanHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HDBanHang] CHECK CONSTRAINT [FK_HDBanHang_NhanVien]
GO
ALTER TABLE [dbo].[HDNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_HDNhapHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HDNhapHang] CHECK CONSTRAINT [FK_HDNhapHang_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_LoaiNhanVien] FOREIGN KEY([MaLoaiNV])
REFERENCES [dbo].[LoaiNhanVien] ([MaLoaiNV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_LoaiNhanVien]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_NhaXuatBan] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NhaXuatBan] ([MaNXB])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_NhaXuatBan]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TacGia] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TacGia] ([MaTacGia])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TacGia]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TheLoaiSach] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoaiSach] ([MaTheLoai])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TheLoaiSach]
GO
/****** Object:  StoredProcedure [dbo].[SP_CapNhatLoaiNhanVien]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_CapNhatLoaiNhanVien]
@ten nvarchar(30),
@ghichu ntext,
@maloainv int
as
UPDATE [dbo].[LoaiNhanVien]
SET [Ten] = @ten,
    [GhiChu] = @ghichu
 WHERE MaLoaiNV = @maloainv



GO
/****** Object:  StoredProcedure [dbo].[SP_CapNhatNhanVien]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_CapNhatNhanVien]
@maloainv int,
@hoten nvarchar(50),
@ngaysinh datetime,
@gioitinh bit,
@diachi nvarchar(100),
@dienthoai varchar(15),
@email varchar(30),
@ghichu ntext,
@manv int
as
UPDATE NHANVIEN 
SET MALOAINV = @maloainv, 
	HOTEN = @hoten,
    NGAYSINH = @ngaysinh, 
	GIOITINH = @gioitinh,
	DIACHI = @diachi,
    DIENTHOAI = @dienthoai, 
	EMAIL = @email, 
	GHICHU = @ghichu
WHERE MANV = @manv


GO
/****** Object:  StoredProcedure [dbo].[SP_CapNhatSoLuongSach]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_CapNhatSoLuongSach]
@masach int,
@soluongban int
as
update Sach set SoLuong=SoLuong-@soluongban where MaSach=@masach


GO
/****** Object:  StoredProcedure [dbo].[SP_CapNhatTongTien_HDBanHang]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_CapNhatTongTien_HDBanHang]
@tongtien int,
@mahd int
as
update HDBanHang set TongTien=@tongtien where MaHD=@mahd


GO
/****** Object:  StoredProcedure [dbo].[SP_DangNhap]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_DangNhap]
@manv int,
@matkhau char(32)
as
select MaLoaiNV
from NhanVien
where MaNV=@manv and MatKhau=@matkhau and Xoa=0;


GO
/****** Object:  StoredProcedure [dbo].[SP_LayDanhSachLoaiNhanVien]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayDanhSachLoaiNhanVien]
as
SELECT * FROM LOAINHANVIEN WHERE XOA=0


GO
/****** Object:  StoredProcedure [dbo].[SP_LayDanhSachNhanVien]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayDanhSachNhanVien]
as
SELECT N.*, L.TEN TENLOAINV 
FROM NHANVIEN N, LOAINHANVIEN L 
WHERE L.MALOAINV=N.MALOAINV AND N.XOA=0






GO
/****** Object:  StoredProcedure [dbo].[SP_LayDanhSachNXB]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayDanhSachNXB]
 as
 select * from NhaXuatBan where Xoa=0


GO
/****** Object:  StoredProcedure [dbo].[SP_LayDanhSachSACH]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayDanhSachSACH]
 as
 SELECT s.*, t.HoTen TenTacGia, l.Ten TenTheLoai, n.Ten TenNXB 
 FROM [dbo].[Sach] s, dbo.TacGia t, dbo.TheLoaiSach l, dbo.NhaXuatBan n
 WHERE s.Xoa=0 AND s.MaTacGia=t.MaTacGia AND s.MaTheLoai=l.MaTheLoai AND s.MaNXB=n.MaNXB


GO
/****** Object:  StoredProcedure [dbo].[SP_LayDSHDBanHangTheoNgay]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayDSHDBanHangTheoNgay]
@ngaybd datetime, @ngaykt datetime
as
select * from HDBanHang where NgayBan >= @ngaybd and NgayBan <= @ngaykt


GO
/****** Object:  StoredProcedure [dbo].[SP_LayDSSachTheoNXB]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayDSSachTheoNXB]
@manxb int
as
SELECT s.*, t.HoTen TenTacGia, l.Ten TenTheLoai, n.Ten TenNXB 
 FROM [dbo].[Sach] s, dbo.TacGia t, dbo.TheLoaiSach l, dbo.NhaXuatBan n
 WHERE s.Xoa=0 AND s.MaTacGia=t.MaTacGia AND s.MaTheLoai=l.MaTheLoai AND s.MaNXB=n.MaNXB and s.MaNXB=@manxb


GO
/****** Object:  StoredProcedure [dbo].[SP_LayDSSachTheoTheLoai]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayDSSachTheoTheLoai]
@matheloai int
as
SELECT s.*, t.HoTen TenTacGia, l.Ten TenTheLoai, n.Ten TenNXB 
 FROM [dbo].[Sach] s, dbo.TacGia t, dbo.TheLoaiSach l, dbo.NhaXuatBan n
 WHERE s.Xoa=0 AND s.MaTacGia=t.MaTacGia AND s.MaTheLoai=l.MaTheLoai AND s.MaNXB=n.MaNXB and s.MaTheLoai=@matheloai


GO
/****** Object:  StoredProcedure [dbo].[SP_LayDSSachTonKho]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_LayDSSachTonKho]
@soluong int
as
 SELECT s.*, t.HoTen TenTacGia, l.Ten TenTheLoai, n.Ten TenNXB 
 FROM [dbo].[Sach] s, dbo.TacGia t, dbo.TheLoaiSach l, dbo.NhaXuatBan n
 WHERE s.Xoa=0 AND s.MaTacGia=t.MaTacGia AND s.MaTheLoai=l.MaTheLoai AND s.MaNXB=n.MaNXB and SoLuong<=@soluong


GO
/****** Object:  StoredProcedure [dbo].[SP_LayKHTheoMa]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayKHTheoMa]
@makh int
as
select * from KhachHang where MaKH=@makh and Xoa=0


GO
/****** Object:  StoredProcedure [dbo].[SP_LayNhanVienTheoMaNV]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayNhanVienTheoMaNV]
@manv int
as
SELECT N.*, L.TEN TENLOAINV 
FROM NHANVIEN N, LOAINHANVIEN L 
WHERE L.MALOAINV=N.MALOAINV AND N.MaNV=@manv


GO
/****** Object:  StoredProcedure [dbo].[SP_LayNXBTheoMa]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayNXBTheoMa]
@manxb int
as
select * from NhaXuatBan where MaNXB=@manxb


GO
/****** Object:  StoredProcedure [dbo].[SP_LaySachTheoMa]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_LaySachTheoMa]
@masach int
as
SELECT * FROM [dbo].[Sach] where Xoa=0 and MaSach=@masach


GO
/****** Object:  StoredProcedure [dbo].[SP_LaySachTonKhoTheoMa]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_LaySachTonKhoTheoMa]
@masach int
as
SELECT * FROM [dbo].[Sach] where Xoa=0 and MaSach=@masach AND SoLuong > 0


GO
/****** Object:  StoredProcedure [dbo].[SP_LayTacGiaTheoMa]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayTacGiaTheoMa]
@matacgia int
as
select * from TacGia where MaTacGia=@matacgia and Xoa=0


GO
/****** Object:  StoredProcedure [dbo].[SP_LayTenKHTheoMa]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayTenKHTheoMa]
@makh int
as
select HoTen from KhachHang where MaKH=@makh and Xoa=0


GO
/****** Object:  StoredProcedure [dbo].[SP_LayTenSachTheoMa]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayTenSachTheoMa]
@masach int
as
select Ten from Sach where MaSach=@masach and Xoa=0


GO
/****** Object:  StoredProcedure [dbo].[SP_LayTheLoaiTheoMa]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayTheLoaiTheoMa]
@matheloai int
as
select * from TheLoaiSach where MaTheLoai=@matheloai


GO
/****** Object:  StoredProcedure [dbo].[SP_ResetMatKhau]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_ResetMatKhau]
@manv int,
@matkhau char(32)
as
UPDATE NHANVIEN SET MatKhau=@matkhau WHERE MANV=@manv


GO
/****** Object:  StoredProcedure [dbo].[SP_SuaNXB]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_SuaNXB]
@ten nvarchar(256),
@website varchar(50),
@email varchar(50),
@ghichu ntext,
@manxb int
as
UPDATE [dbo].[NhaXuatBan]
SET [Ten]=@ten,
	[Website]=@website,
    [Email]=@email,
    [GhiChu]=@ghichu
WHERE [MaNXB]=@manxb



GO
/****** Object:  StoredProcedure [dbo].[SP_ThemCTHDBanHang]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_ThemCTHDBanHang]
@mahd int, @masach int, @soluong int, @giaban int, @khuyenmai int, @thanhtien int
as
INSERT INTO [dbo].[CTHDBanHang] ([MaHD],[MaSach],[SoLuong],[GiaBan],[KhuyenMai],[ThanhTien])
     VALUES (@mahd,@masach,@soluong,@giaban,@khuyenmai,@thanhtien)


GO
/****** Object:  StoredProcedure [dbo].[SP_ThemHDBanHang]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_ThemHDBanHang]
@ngayban datetime, @manv int, @makh int
as
INSERT INTO [dbo].[HDBanHang] ([NgayBan],[MaNV],[MaKH])
     VALUES (@ngayban, @manv, @makh)


GO
/****** Object:  StoredProcedure [dbo].[SP_ThemLoaiNhanVien]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_ThemLoaiNhanVien]
@ten nvarchar(30),
@ghichu ntext
as
INSERT INTO LOAINHANVIEN (TEN, GHICHU) VALUES (@ten, @ghichu)


GO
/****** Object:  StoredProcedure [dbo].[SP_ThemNhanVien]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_ThemNhanVien]
@matkhau char(32),
@maloainv int,
@hoten nvarchar(50),
@ngaysinh datetime,
@gioitinh bit,
@diachi nvarchar(100),
@dienthoai varchar(15),
@email varchar(30),
@ghichu ntext
as
INSERT INTO NHANVIEN (MATKHAU,MALOAINV,HOTEN,NGAYSINH,GIOITINH,DIACHI,DIENTHOAI,EMAIL,GHICHU)
VALUES (@matkhau,@maloainv,@hoten,@ngaysinh,@gioitinh,@diachi,@dienthoai,@email,@ghichu)


GO
/****** Object:  StoredProcedure [dbo].[SP_ThemNXB]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_ThemNXB]
@ten nvarchar(256),
@website varchar(50),
@email varchar(50),
@ghichu ntext
as
INSERT INTO [dbo].[NhaXuatBan] ([Ten],[Website],[Email],[GhiChu])
VALUES (@ten,@website,@email,@ghichu)


GO
/****** Object:  StoredProcedure [dbo].[SP_XoaLoaiNhanVien]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_XoaLoaiNhanVien]
@maloainv int
as
UPDATE [dbo].[LoaiNhanVien]
SET Xoa = 1 WHERE MaLoaiNV = @maloainv



GO
/****** Object:  StoredProcedure [dbo].[SP_XoaNhanVien]    Script Date: 13/12/2018 4:03:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_XoaNhanVien]
@manv int
as
UPDATE NHANVIEN SET XOA=1 WHERE MANV=@manv


GO
USE [master]
GO
ALTER DATABASE [QLCUAHANGSACH] SET  READ_WRITE 
GO
