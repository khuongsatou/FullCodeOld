GO
CREATE DATABASE QuanLiCuaHangQuanAo
GO
USE [QuanLiCuaHangQuanAo]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 6/1/2019 8:20:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[NgayLapHD] [datetime] NULL,
	[GiaSP] [float] NULL,
	[SoLuong] [float] NULL,
	[KhuyenMai] [nvarchar](50) NULL,
	[ThanhTien] [float] NULL,
	[Xoa] [bit] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/1/2019 8:20:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NOT NULL,
	[TongTien] [float] NULL,
	[TrangThai] [nvarchar](250) NULL,
	[Xoa] [bit] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 6/1/2019 8:20:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[MaKM] [int] IDENTITY(1,1) NOT NULL,
	[UuDai] [nvarchar](50) NULL,
	[NgayBatDau] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
	[Xoa] [bit] NULL,
 CONSTRAINT [PK_KhuyenMai] PRIMARY KEY CLUSTERED 
(
	[MaKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiNV]    Script Date: 6/1/2019 8:20:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNV](
	[MaLoaiNV] [int] IDENTITY(1,1) NOT NULL,
	[ChucVu] [nvarchar](250) NULL,
	[Xoa] [bit] NULL,
 CONSTRAINT [PK_LoaiNV] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 6/1/2019 8:20:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSP](
	[MaLoaiSP] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiSP] [nvarchar](255) NULL,
	[MoTa] [nvarchar](255) NULL,
	[Xoa] [bit] NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaNSX]    Script Date: 6/1/2019 8:20:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaNSX](
	[MaNSX] [int] IDENTITY(1,1) NOT NULL,
	[TenNSX] [nvarchar](250) NULL,
	[DiaChiNSX] [nvarchar](250) NULL,
	[DienThoaiNSX] [nvarchar](50) NULL,
	[Xoa] [bit] NULL,
 CONSTRAINT [PK_NhaNSX] PRIMARY KEY CLUSTERED 
(
	[MaNSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/1/2019 8:20:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiNV] [int] NULL,
	[TenTaiKhoan] [nvarchar](250) NULL,
	[MatKhau] [nvarchar](250) NULL,
	[HoTen] [nvarchar](250) NULL,
	[Phai] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[NgaySinh] [datetime] NULL,
	[SDT] [nvarchar](10) NULL,
	[CMND] [nvarchar](250) NULL,
	[TrangThai] [nvarchar](50) NULL,
	[Xoa] [bit] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 6/1/2019 8:20:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiSP] [int] NULL,
	[MaKM] [int] NULL,
	[MaNSX] [int] NULL,
	[TenSP] [nvarchar](255) NULL,
	[MoTa] [nvarchar](255) NULL,
	[Size] [nvarchar](50) NULL,
	[Mau] [nvarchar](50) NULL,
	[Hinh] [nvarchar](50) NULL,
	[SLTon] [int] NULL,
	[Gia] [float] NULL,
	[Xoa] [bit] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[V_ChiTietHoaDon_HoaDon]    Script Date: 6/1/2019 8:20:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_ChiTietHoaDon_HoaDon]
AS
SELECT        dbo.HoaDon.MaHD, dbo.HoaDon.TongTien, dbo.ChiTietHoaDon.NgayLapHD
FROM            dbo.ChiTietHoaDon INNER JOIN
                         dbo.HoaDon ON dbo.ChiTietHoaDon.MaHD = dbo.HoaDon.MaHD


GO
/****** Object:  View [dbo].[V_ChiTietHoaDon_SanPham]    Script Date: 6/1/2019 8:20:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_ChiTietHoaDon_SanPham]
AS
SELECT        dbo.SanPham.TenSP, dbo.SanPham.MoTa, dbo.SanPham.Size, dbo.SanPham.Mau, dbo.ChiTietHoaDon.MaHD, dbo.ChiTietHoaDon.MaSP, 
                         dbo.ChiTietHoaDon.SoLuong, dbo.ChiTietHoaDon.KhuyenMai, dbo.ChiTietHoaDon.ThanhTien, dbo.SanPham.Gia
FROM            dbo.ChiTietHoaDon INNER JOIN
                         dbo.SanPham ON dbo.ChiTietHoaDon.MaSP = dbo.SanPham.MaSP


GO
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (1, 2, CAST(0x0000AA540105E67C AS DateTime), 50000, 1, N'10%', 45000, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (2, 2, CAST(0x0000AA54010A17EC AS DateTime), 50000, 2, N'10%', 90000, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (2, 3, CAST(0x0000AA54010A17EC AS DateTime), 20000, 1, N'10%', 18000, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (2, 4, CAST(0x0000AA54010A17EC AS DateTime), 40000, 1, N'10%', 36000, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (3, 5, CAST(0x0000AA54010FEE10 AS DateTime), 27283, 1, N'10%', 24554.7, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (4, 2, CAST(0x0000AA5700EE3860 AS DateTime), 50000, 3, N'1', 148500, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (5, 2, CAST(0x0000AA5700EF1258 AS DateTime), 50000, 1, N'1', 49500, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (5, 3, CAST(0x0000AA5700EF1258 AS DateTime), 20000, 1, N'1', 19800, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (5, 4, CAST(0x0000AA5700EF1258 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (6, 2, CAST(0x0000AA5700F3924C AS DateTime), 50000, 1, N'1', 49500, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (7, 1, CAST(0x0000AA59015E77EC AS DateTime), 40000, 2, N'1', 79200, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (8, 1, CAST(0x0000AA590164BC38 AS DateTime), 40000, 2, N'1', 79200, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (9, 1, CAST(0x0000AA5A009A1424 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (9, 3, CAST(0x0000AA5A009A1424 AS DateTime), 20000, 1, N'1', 19800, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (9, 4, CAST(0x0000AA5A009A1424 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (10, 1, CAST(0x0000AA5A009F4C14 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (11, 4, CAST(0x0000AA5A00FCFA80 AS DateTime), 40000, 5, N'1', 198000, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (12, 3, CAST(0x0000AA5A0107CCD0 AS DateTime), 20000, 1, N'1', 19800, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (12, 4, CAST(0x0000AA5A0107CCD0 AS DateTime), 40000, 5, N'1', 198000, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (15, 1, CAST(0x0000AA5B00DB60F0 AS DateTime), 40000, 2, N'1', 79200, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (15, 3, CAST(0x0000AA5B00DB60F0 AS DateTime), 20000, 1, N'1', 19800, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (15, 4, CAST(0x0000AA5B00DB60F0 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (16, 1, CAST(0x0000AA5B00DF7640 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (17, 1, CAST(0x0000AA5B00000000 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (18, 1, CAST(0x0000AA5B00000000 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (19, 1, CAST(0x0000AA5B00000000 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (19, 3, CAST(0x0000AA5B00000000 AS DateTime), 20000, 2, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (19, 4, CAST(0x0000AA5B00000000 AS DateTime), 40000, 2, N'1', 79200, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (20, 1, CAST(0x0000AA5B00000000 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (21, 1, CAST(0x0000AA5B00000000 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (21, 3, CAST(0x0000AA5B00000000 AS DateTime), 20000, 1, N'1', 19800, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (21, 5, CAST(0x0000AA5B00000000 AS DateTime), 10000, 1, N'1', 9900, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (21, 6, CAST(0x0000AA5B00000000 AS DateTime), 50000, 1, N'1', 49500, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (22, 10, CAST(0x0000AA5B00000000 AS DateTime), 394832, 1, N'1', 390883.7, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (23, 1, CAST(0x0000AA5B00000000 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (24, 1, CAST(0x0000AA5B00000000 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (24, 3, CAST(0x0000AA5B00000000 AS DateTime), 20000, 1, N'1', 19800, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (24, 4, CAST(0x0000AA5B00000000 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (24, 5, CAST(0x0000AA5B00000000 AS DateTime), 10000, 1, N'1', 9900, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (25, 1, CAST(0x0000AA5B00000000 AS DateTime), 40000, 3, N'1', 118800, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (26, 3, CAST(0x0000AA5B00000000 AS DateTime), 20000, 4, N'1', 79200, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (27, 5, CAST(0x0000AA5B00000000 AS DateTime), 10000, 4, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (28, 7, CAST(0x0000AA5B00000000 AS DateTime), 500000, 2, N'1', 990000, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (28, 8, CAST(0x0000AA5B00000000 AS DateTime), 60000, 1, N'20', 48000, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (29, 7, CAST(0x0000AA5B00000000 AS DateTime), 500000, 1, N'1', 495000, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (29, 8, CAST(0x0000AA5B00000000 AS DateTime), 60000, 1, N'20', 48000, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (30, 7, CAST(0x0000AA5B00000000 AS DateTime), 500000, 2, N'1', 990000, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (31, 1, CAST(0x0000AA5B00000000 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (32, 1, CAST(0x0000AA5B00000000 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (32, 10, CAST(0x0000AA5B00000000 AS DateTime), 394832, 5, N'1', 1954419, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (33, 1, CAST(0x0000AA5B00000000 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (34, 3, CAST(0x0000AA5B00000000 AS DateTime), 20000, 1, N'1', 19800, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (35, 3, CAST(0x0000AA5B00000000 AS DateTime), 20000, 1, N'1', 19800, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (36, 4, CAST(0x0000AA5B00000000 AS DateTime), 40000, 1, N'1', 39600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (37, 5, CAST(0x0000AA5B00000000 AS DateTime), 10000, 1, N'1', 9900, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (38, 13, CAST(0x0000AA5B00000000 AS DateTime), 2932920, 1, N'100', 0, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (39, 13, CAST(0x0000AA5B00000000 AS DateTime), 2932920, 1, N'100', 0, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (40, 5, CAST(0x0000AA5C00000000 AS DateTime), 10000, 1, N'11', 8900, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (41, 5, CAST(0x0000AA5C00000000 AS DateTime), 10000, 1, N'11', 8900, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (42, 3, CAST(0x0000AA5D00000000 AS DateTime), 20000, 1, N'11', 17800, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (42, 4, CAST(0x0000AA5D00000000 AS DateTime), 40000, 1, N'11', 35600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (43, 4, CAST(0x0000AA5D00000000 AS DateTime), 40000, 1, N'11', 35600, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (44, 3, CAST(0x0000AA5D00000000 AS DateTime), 20000, 1, N'11', 17800, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (44, 8, CAST(0x0000AA5D00000000 AS DateTime), 60000, 1, N'20', 48000, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (45, 1, CAST(0x0000AA5F00000000 AS DateTime), 40000, 1, N'10', 36000, 0)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [NgayLapHD], [GiaSP], [SoLuong], [KhuyenMai], [ThanhTien], [Xoa]) VALUES (45, 3, CAST(0x0000AA5F00000000 AS DateTime), 20000, 1, N'11', 17800, 0)
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (1, 6, 45000, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (2, 6, 144000, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (3, 6, 24554.7, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (4, 6, 148500, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (5, 6, 108900, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (6, 6, 49500, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (7, 6, 79200, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (8, 6, 79200, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (9, 6, 99000, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (10, 6, 39600, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (11, 6, 198000, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (12, 6, 217800, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (15, 6, 138600, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (16, 6, 39600, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (17, 6, 39600, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (18, 6, 39600, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (19, 6, 158400, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (20, 6, 39600, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (21, 6, 118800, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (22, 6, 390883.7, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (23, 6, 39600, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (24, 6, 108900, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (25, 6, 118800, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (26, 6, 79200, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (27, 6, 39600, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (28, 6, 1038000, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (29, 6, 543000, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (30, 6, 990000, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (31, 9, 39600, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (32, 6, 1994019, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (33, 6, 39600, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (34, 6, 19800, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (35, 6, 19800, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (36, 6, 39600, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (37, 6, 9900, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (38, 6, 0, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (39, 6, 0, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (40, 6, 8900, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (41, 6, 8900, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (42, 6, 53400, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (43, 6, 35600, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (44, 6, 65800, N'Xong', 0)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [TongTien], [TrangThai], [Xoa]) VALUES (45, 6, 53800, N'Xong', 0)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
SET IDENTITY_INSERT [dbo].[KhuyenMai] ON 

INSERT [dbo].[KhuyenMai] ([MaKM], [UuDai], [NgayBatDau], [NgayKetThuc], [Xoa]) VALUES (1, N'11', CAST(0x0000AA4C00000000 AS DateTime), CAST(0x0000AA5B00000000 AS DateTime), 0)
INSERT [dbo].[KhuyenMai] ([MaKM], [UuDai], [NgayBatDau], [NgayKetThuc], [Xoa]) VALUES (2, N'10', CAST(0x0000AA4E00000000 AS DateTime), CAST(0x0000AA5E00000000 AS DateTime), 0)
INSERT [dbo].[KhuyenMai] ([MaKM], [UuDai], [NgayBatDau], [NgayKetThuc], [Xoa]) VALUES (3, N'20', CAST(0x0000AA4E00000000 AS DateTime), CAST(0x0000AA5900000000 AS DateTime), 0)
INSERT [dbo].[KhuyenMai] ([MaKM], [UuDai], [NgayBatDau], [NgayKetThuc], [Xoa]) VALUES (4, N'30', CAST(0x0000AA4E00000000 AS DateTime), CAST(0x0000AA5300000000 AS DateTime), 1)
INSERT [dbo].[KhuyenMai] ([MaKM], [UuDai], [NgayBatDau], [NgayKetThuc], [Xoa]) VALUES (5, N'40', CAST(0x0000AA4E00000000 AS DateTime), CAST(0x0000AA5300000000 AS DateTime), 0)
INSERT [dbo].[KhuyenMai] ([MaKM], [UuDai], [NgayBatDau], [NgayKetThuc], [Xoa]) VALUES (6, N'45', CAST(0x0000AA4E00000000 AS DateTime), CAST(0x0000AA5300000000 AS DateTime), 0)
INSERT [dbo].[KhuyenMai] ([MaKM], [UuDai], [NgayBatDau], [NgayKetThuc], [Xoa]) VALUES (7, N'50', CAST(0x0000AA4E00000000 AS DateTime), CAST(0x0000AA5300000000 AS DateTime), 0)
INSERT [dbo].[KhuyenMai] ([MaKM], [UuDai], [NgayBatDau], [NgayKetThuc], [Xoa]) VALUES (8, N'60', CAST(0x0000AA4F00000000 AS DateTime), CAST(0x0000AA5300000000 AS DateTime), 0)
INSERT [dbo].[KhuyenMai] ([MaKM], [UuDai], [NgayBatDau], [NgayKetThuc], [Xoa]) VALUES (9, N'70', CAST(0x0000AA4E00000000 AS DateTime), CAST(0x0000AA5300000000 AS DateTime), 0)
INSERT [dbo].[KhuyenMai] ([MaKM], [UuDai], [NgayBatDau], [NgayKetThuc], [Xoa]) VALUES (10, N'80', CAST(0x0000AA4E00000000 AS DateTime), CAST(0x0000AA5300000000 AS DateTime), 0)
INSERT [dbo].[KhuyenMai] ([MaKM], [UuDai], [NgayBatDau], [NgayKetThuc], [Xoa]) VALUES (11, N'100', CAST(0x0000AA4E00000000 AS DateTime), CAST(0x0000AA5300000000 AS DateTime), 1)
INSERT [dbo].[KhuyenMai] ([MaKM], [UuDai], [NgayBatDau], [NgayKetThuc], [Xoa]) VALUES (12, N'90', CAST(0x0000AA4E00000000 AS DateTime), CAST(0x0000AA5300000000 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[KhuyenMai] OFF
SET IDENTITY_INSERT [dbo].[LoaiNV] ON 

INSERT [dbo].[LoaiNV] ([MaLoaiNV], [ChucVu], [Xoa]) VALUES (1, N'Chủ Shop', 0)
INSERT [dbo].[LoaiNV] ([MaLoaiNV], [ChucVu], [Xoa]) VALUES (2, N'Nhân Viên ', 0)
SET IDENTITY_INSERT [dbo].[LoaiNV] OFF
SET IDENTITY_INSERT [dbo].[LoaiSP] ON 

INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP], [MoTa], [Xoa]) VALUES (1, N'Áo', N'Áo Nữ ABC XYZ', 0)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP], [MoTa], [Xoa]) VALUES (2, N'Quần', N'Quần 2 Ống', 0)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP], [MoTa], [Xoa]) VALUES (3, N'Giày', N'Giày Đôi', 1)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP], [MoTa], [Xoa]) VALUES (4, N'Tất', N'Vớ Ý Mà', 1)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP], [MoTa], [Xoa]) VALUES (5, N'Áo', N'sdjks', 1)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP], [MoTa], [Xoa]) VALUES (6, N'Áo', N'ádsa', 1)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP], [MoTa], [Xoa]) VALUES (7, N'Áo', N'uuuw', 1)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP], [MoTa], [Xoa]) VALUES (8, N'Giày', N'thể thao', 0)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP], [MoTa], [Xoa]) VALUES (9, N'Giày', N'232', 1)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP], [MoTa], [Xoa]) VALUES (10, N'Dép', N'abc', 0)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP], [MoTa], [Xoa]) VALUES (11, N'Kệ Nó Đi', N'1', 1)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP], [MoTa], [Xoa]) VALUES (12, N'áo', N'jaja', 1)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP], [MoTa], [Xoa]) VALUES (13, N'quần', N'haha', 1)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP], [MoTa], [Xoa]) VALUES (14, N'fudgkf', N'3reukhlieq', 0)
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP], [MoTa], [Xoa]) VALUES (15, N'quần', N'392', 0)
SET IDENTITY_INSERT [dbo].[LoaiSP] OFF
SET IDENTITY_INSERT [dbo].[NhaNSX] ON 

INSERT [dbo].[NhaNSX] ([MaNSX], [TenNSX], [DiaChiNSX], [DienThoaiNSX], [Xoa]) VALUES (1, N'Đạt', N'Cầu Nhà Ma', N'0306171362', 0)
INSERT [dbo].[NhaNSX] ([MaNSX], [TenNSX], [DiaChiNSX], [DienThoaiNSX], [Xoa]) VALUES (2, N'Hoài', N'XXXX', N'0303003332', 0)
INSERT [dbo].[NhaNSX] ([MaNSX], [TenNSX], [DiaChiNSX], [DienThoaiNSX], [Xoa]) VALUES (3, N'Khương', N'XXXXX', N'0356543232', 0)
INSERT [dbo].[NhaNSX] ([MaNSX], [TenNSX], [DiaChiNSX], [DienThoaiNSX], [Xoa]) VALUES (4, N'không', N'um', N'2693828639', 0)
INSERT [dbo].[NhaNSX] ([MaNSX], [TenNSX], [DiaChiNSX], [DienThoaiNSX], [Xoa]) VALUES (5, N'1234', N'1234', N'1234', 1)
SET IDENTITY_INSERT [dbo].[NhaNSX] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [MaLoaiNV], [TenTaiKhoan], [MatKhau], [HoTen], [Phai], [DiaChi], [NgaySinh], [SDT], [CMND], [TrangThai], [Xoa]) VALUES (4, 1, N'admin', N'c4ca4238a0b923820dcc509a6f75849b', N'Nguyễn Văn Khương', N'Nam', N'XXXXX', CAST(0x0000AA3900000000 AS DateTime), N'035475844', N'0343746378', N'Còn Làm', 0)
INSERT [dbo].[NhanVien] ([MaNV], [MaLoaiNV], [TenTaiKhoan], [MatKhau], [HoTen], [Phai], [DiaChi], [NgaySinh], [SDT], [CMND], [TrangThai], [Xoa]) VALUES (5, 2, N'nv', N'c4ca4238a0b923820dcc509a6f75849b', N'Liêu Trần Hiếu Hoài', N'Nữ', N'XXXX', CAST(0x00008E1A00000000 AS DateTime), N'0409483092', N'2382739239', N'Còn Làm', 0)
INSERT [dbo].[NhanVien] ([MaNV], [MaLoaiNV], [TenTaiKhoan], [MatKhau], [HoTen], [Phai], [DiaChi], [NgaySinh], [SDT], [CMND], [TrangThai], [Xoa]) VALUES (6, 2, N'nv1', N'c4ca4238a0b923820dcc509a6f75849b', N'Đạt Sừng', N'Nam', N'XXXXXX', CAST(0x00008DC600000000 AS DateTime), N'0349232232', N'2355675432', N'Còn Làm', 0)
INSERT [dbo].[NhanVien] ([MaNV], [MaLoaiNV], [TenTaiKhoan], [MatKhau], [HoTen], [Phai], [DiaChi], [NgaySinh], [SDT], [CMND], [TrangThai], [Xoa]) VALUES (7, 2, N'nv2', N'1', N'Đạt 2', N'Nam', N'Việt', CAST(0x00008DC600000000 AS DateTime), N'282', N'2392', N'Còn Làm', 1)
INSERT [dbo].[NhanVien] ([MaNV], [MaLoaiNV], [TenTaiKhoan], [MatKhau], [HoTen], [Phai], [DiaChi], [NgaySinh], [SDT], [CMND], [TrangThai], [Xoa]) VALUES (8, 2, N'nv2', N'c4ca4238a0b923820dcc509a6f75849b', N'Khương', N'Nam', N'Ha', CAST(0x00008DC600000000 AS DateTime), N'14399834', N'3483943', N'Còn Làm', 0)
INSERT [dbo].[NhanVien] ([MaNV], [MaLoaiNV], [TenTaiKhoan], [MatKhau], [HoTen], [Phai], [DiaChi], [NgaySinh], [SDT], [CMND], [TrangThai], [Xoa]) VALUES (9, 1, N'nv4', N'c4ca4238a0b923820dcc509a6f75849b', N'Khuong ABCXYZ', N'Nam', N'3292', CAST(0x00008DC600000000 AS DateTime), N'283292', N'23556754322', N'Còn Làm', 0)
INSERT [dbo].[NhanVien] ([MaNV], [MaLoaiNV], [TenTaiKhoan], [MatKhau], [HoTen], [Phai], [DiaChi], [NgaySinh], [SDT], [CMND], [TrangThai], [Xoa]) VALUES (10, NULL, NULL, NULL, N'1', N'Nam', N'1', CAST(0x00008DC600000000 AS DateTime), N'035475844', N'0354758448', N'Còn Làm', 1)
INSERT [dbo].[NhanVien] ([MaNV], [MaLoaiNV], [TenTaiKhoan], [MatKhau], [HoTen], [Phai], [DiaChi], [NgaySinh], [SDT], [CMND], [TrangThai], [Xoa]) VALUES (11, NULL, NULL, NULL, N'3223', N'Nam', N'2392', CAST(0x00008DC600000000 AS DateTime), N'Còn Làm', N'Còn Làm', N'Còn Làm', 1)
INSERT [dbo].[NhanVien] ([MaNV], [MaLoaiNV], [TenTaiKhoan], [MatKhau], [HoTen], [Phai], [DiaChi], [NgaySinh], [SDT], [CMND], [TrangThai], [Xoa]) VALUES (12, NULL, N'nv6', N'c4ca4238a0b923820dcc509a6f75849b', N'abc', N'Nam', N'fdj', CAST(0x00008DC600000000 AS DateTime), N'2742982', N'28472982982', N'Nghĩ Làm', 0)
INSERT [dbo].[NhanVien] ([MaNV], [MaLoaiNV], [TenTaiKhoan], [MatKhau], [HoTen], [Phai], [DiaChi], [NgaySinh], [SDT], [CMND], [TrangThai], [Xoa]) VALUES (13, NULL, N'nv7', N'c4ca4238a0b923820dcc509a6f75849b', N'khương', N'Nữ', N'1', CAST(0x00008DC600000000 AS DateTime), N'1123', N'111', N'Nghĩ Làm', 0)
INSERT [dbo].[NhanVien] ([MaNV], [MaLoaiNV], [TenTaiKhoan], [MatKhau], [HoTen], [Phai], [DiaChi], [NgaySinh], [SDT], [CMND], [TrangThai], [Xoa]) VALUES (14, 1, N'nv8', N'202cb962ac59075b964b07152d234b70', N'uweu', N'Nam', N'jidkjsh', CAST(0x00008DC600000000 AS DateTime), N'2938729111', N'23972391122', N'Còn Làm', 0)
INSERT [dbo].[NhanVien] ([MaNV], [MaLoaiNV], [TenTaiKhoan], [MatKhau], [HoTen], [Phai], [DiaChi], [NgaySinh], [SDT], [CMND], [TrangThai], [Xoa]) VALUES (15, NULL, N'nv9', NULL, N'Khương', N'Nam', N'có chứ', CAST(0x00008DC600000000 AS DateTime), N'1821982192', N'280729837292', N'Còn Làm', 1)
INSERT [dbo].[NhanVien] ([MaNV], [MaLoaiNV], [TenTaiKhoan], [MatKhau], [HoTen], [Phai], [DiaChi], [NgaySinh], [SDT], [CMND], [TrangThai], [Xoa]) VALUES (16, NULL, N'nv9', NULL, N'hoai', N'Nam', N'cccc', CAST(0x00008DC600000000 AS DateTime), N'12345', N'11111111', N'Nghĩ Làm', 1)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (1, 1, 2, 2, N'Áo Nữ', N'abcxyz', N'XL', N'Trắng', N'\E1YO4z_simg_b5529c_250x250_maxb.jpg', 2, 40000, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (2, 1, 2, 1, N'Áo', N'abc', N'XL', N'Trắng', N'\2MCeWG_simg_b5529c_250x250_maxb.jpg', 1, 50000, 1)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (3, 1, 1, 1, N'Áo Dài Tay', N'abc', N'L', N'Trắng', N'\7umU3v_simg_b5529c_250x250_maxb.jpg', 8, 20000, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (4, 1, 1, 1, N'Giày V', N'VL', N'XL', N'Xanh', N'\7umU3v_simg_b5529c_250x250_maxb.jpg', 2, 40000, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (5, 1, 1, 1, N'Áo Trắng1', N'Không Cánh', N'XXL', N'Trắng', N'\jzT1pW_simg_b5529c_250x250_maxb.jpg', 5, 10000, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (6, 2, 1, 3, N'Quần', N'Quần Gì Cũng Được', N'XL', N'Đen', N'\GaLTFB_simg_b5529c_250x250_maxb.jpg', 3, 50000, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (7, 2, 1, 1, N'Giày', N'Giầy Nữ 2 Lai', N'L', N'Trắng', N'\utyudz_simg_b5529c_250x250_maxb.jpg', 2, 500000, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (8, 2, 3, 2, N'Tất', N'Tất FULL POR', N'XL', N'Chấm Bi', N'\Os1ZPV_simg_b5529c_250x250_maxb.jpg', 1, 60000, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (9, 1, 1, 1, N'alfd', N'Aos', N'XL', N'Trắng', N'\6bC3TW_simg_b5529c_250x250_maxb.jpg', 3, 47983, 1)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (10, 10, 1, 1, N'Khổ Trang', N'Toàn Đầu Người', N'XL', N'Trắng', N'\7wZgmJ_simg_b5529c_250x250_maxb.jpg', 1, 394832, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (11, 1, 1, 1, N'Á F', N'Wa', N'XL', N'Trắng', N'\E24hzc_simg_b5529c_250x250_maxb.jpg', 3, 123, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (12, 1, 1, 1, N'CF', N'23', N'XL', N'Trắng', N'\pKXpMd_simg_b5529c_250x250_maxb.jpg', 3, 2, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (13, 1, 10, 1, N'Gái Xinh Này', N'ưlejwo', N'XL', N'Trắng', N'\N2fTyV_simg_b5529c_250x250_maxb.jpg', 6, 2932920, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (14, 1, 1, 1, N'A Na ta', N'2398209', N'XL', N'Trắng', N'\pKXpMd_simg_b5529c_250x250_maxb.jpg', 8, 0, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (15, 1, 3, 3, N'Áo Cặp', N'UMM', N'XL', N'Trắng', N'\MAQUIA-WHEN-THE-PROMISED-FLOWER-BLOOMS-1.jpg', 0, 50000, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (16, 1, 1, 1, N'Cosplay', N'keypress', N'XL', N'Trắng', N'\kC9Nwt2.jpg', 20, 8, 1)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (19, 1, 1, 1, N'fjdil', N'èiui', N'XL', N'Đen', N'\kC9Nwt2.jpg', 3, 3, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (20, 1, 1, 1, N'dfuh', N'dflfo', N'XL', N'Đen', N'\kenja-no-mago-cover-1554799428.jpg', 3, 300000, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (22, 1, 1, 1, N'quần', N'dài', N'XL', N'Trắng', N'\kenja-no-mago-cover-1554799428.jpg', 5, 1000, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (23, 1, 1, 1, N'djgsug', N'dshsiuk', N'XL', N'Trắng', N'\2CeU7F_simg_b5529c_250x250_maxb.jpg', 29, 292, 0)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (24, 1, 1, 1, N'váy', N'đen', N'XL', N'Trắng', N'\2CeU7F_simg_b5529c_250x250_maxb.jpg', 5, 100000, 1)
INSERT [dbo].[SanPham] ([MaSP], [MaLoaiSP], [MaKM], [MaNSX], [TenSP], [MoTa], [Size], [Mau], [Hinh], [SLTon], [Gia], [Xoa]) VALUES (25, 1, 1, 1, N'áo dài', N'trắng', N'XL', N'Trắng', N'\2CeU7F_simg_b5529c_250x250_maxb.jpg', 5, 100000, 1)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  CONSTRAINT [DF_ChiTietHoaDon_Xoa_1]  DEFAULT ((0)) FOR [Xoa]
GO
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [DF_HoaDon_Xoa]  DEFAULT ((0)) FOR [Xoa]
GO
ALTER TABLE [dbo].[KhuyenMai] ADD  CONSTRAINT [DF_KhuyenMai_Xoa]  DEFAULT ((0)) FOR [Xoa]
GO
ALTER TABLE [dbo].[LoaiNV] ADD  CONSTRAINT [DF_LoaiNV_Xoa]  DEFAULT ((0)) FOR [Xoa]
GO
ALTER TABLE [dbo].[LoaiSP] ADD  CONSTRAINT [DF_LoaiSP_Xoa]  DEFAULT ((0)) FOR [Xoa]
GO
ALTER TABLE [dbo].[NhaNSX] ADD  CONSTRAINT [DF_NhaNSX_Xoa]  DEFAULT ((0)) FOR [Xoa]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_NhanVien_Xoa]  DEFAULT ((0)) FOR [Xoa]
GO
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [DF_SanPham_Xoa]  DEFAULT ((0)) FOR [Xoa]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_LoaiNV] FOREIGN KEY([MaLoaiNV])
REFERENCES [dbo].[LoaiNV] ([MaLoaiNV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_LoaiNV]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_KhuyenMai] FOREIGN KEY([MaKM])
REFERENCES [dbo].[KhuyenMai] ([MaKM])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_KhuyenMai]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSP] FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSP] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSP]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_NhaNSX] FOREIGN KEY([MaNSX])
REFERENCES [dbo].[NhaNSX] ([MaNSX])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_NhaNSX]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ChiTietHoaDon"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "HoaDon"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 135
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_ChiTietHoaDon_HoaDon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_ChiTietHoaDon_HoaDon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ChiTietHoaDon"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "SanPham"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 135
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 8
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_ChiTietHoaDon_SanPham'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_ChiTietHoaDon_SanPham'
GO
