USE [QLHS]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 05/14/2019 16:45:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [int] NOT NULL,
	[TenLop] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Lop] ([MaLop], [TenLop]) VALUES (1, N'CDTH17')
INSERT [dbo].[Lop] ([MaLop], [TenLop]) VALUES (2, N'CDTH18')
/****** Object:  Table [dbo].[SinhVien]    Script Date: 05/14/2019 16:45:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [int] NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[MaLop] [int] NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [DiaChi], [NgaySinh], [MaLop]) VALUES (1, N'Khương', N'LL', CAST(0x00008DB000000000 AS DateTime), 1)
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [DiaChi], [NgaySinh], [MaLop]) VALUES (2, N'Khương1', N'LL', CAST(0x00008DB000000000 AS DateTime), 2)
/****** Object:  ForeignKey [FK_SinhVien_Lop]    Script Date: 05/14/2019 16:45:19 ******/
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop]
GO
