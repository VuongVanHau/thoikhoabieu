USE [master]
GO
/****** Object:  Database [XepThoiKhoaBieu]    Script Date: 2017-12-15 1:02:24 CH ******/
CREATE DATABASE [XepThoiKhoaBieu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'XepThoiKhoaBieu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\XepThoiKhoaBieu.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'XepThoiKhoaBieu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\XepThoiKhoaBieu_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [XepThoiKhoaBieu] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [XepThoiKhoaBieu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [XepThoiKhoaBieu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET ARITHABORT OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET  MULTI_USER 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [XepThoiKhoaBieu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [XepThoiKhoaBieu] SET DELAYED_DURABILITY = DISABLED 
GO
USE [XepThoiKhoaBieu]
GO
/****** Object:  User [thanhvien]    Script Date: 2017-12-15 1:02:25 CH ******/
CREATE USER [thanhvien] FOR LOGIN [thanhvien] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [AdTKB]    Script Date: 2017-12-15 1:02:25 CH ******/
CREATE USER [AdTKB] FOR LOGIN [AdTKB] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [AdTKB]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [AdTKB]
GO
ALTER ROLE [db_datareader] ADD MEMBER [AdTKB]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [AdTKB]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 2017-12-15 1:02:25 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[MaBan] [int] NOT NULL,
	[TenBan] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BoMon]    Script Date: 2017-12-15 1:02:25 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoMon](
	[MaBM] [int] NOT NULL,
	[TenBM] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChuNhiem]    Script Date: 2017-12-15 1:02:25 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuNhiem](
	[STT] [int] NOT NULL,
	[MaLop] [int] NOT NULL,
	[MaGV] [int] NOT NULL,
 CONSTRAINT [PK_ChuNhiem] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 2017-12-15 1:02:25 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGV] [int] NOT NULL,
	[TenGV] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[SDT] [varchar](20) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[MaBM] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 2017-12-15 1:02:25 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [int] NOT NULL,
	[TenLop] [nvarchar](10) NULL,
	[SoHocSinh] [int] NULL,
	[MaBan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 2017-12-15 1:02:25 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [int] NOT NULL,
	[TenMH] [nvarchar](50) NULL,
	[MaBM] [int] NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongHoc]    Script Date: 2017-12-15 1:02:25 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongHoc](
	[MaPH] [int] NOT NULL,
	[TenPH] [nvarchar](50) NULL,
	[DungLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tiet]    Script Date: 2017-12-15 1:02:25 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tiet](
	[STT] [int] NOT NULL,
	[Tiet] [int] NULL,
	[Thu] [int] NULL,
	[Time] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tiet] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThoiKhoaBieu]    Script Date: 2017-12-15 1:02:25 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThoiKhoaBieu](
	[MaPH] [int] NOT NULL,
	[MaMH] [int] NOT NULL,
	[MaLop] [int] NOT NULL,
	[MaGV] [int] NOT NULL,
	[MaTiet] [int] NOT NULL,
 CONSTRAINT [PK_ThoiKhoaBieu] PRIMARY KEY CLUSTERED 
(
	[MaPH] ASC,
	[MaMH] ASC,
	[MaLop] ASC,
	[MaGV] ASC,
	[MaTiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Ban] ([MaBan], [TenBan]) VALUES (1, N'A')
INSERT [dbo].[Ban] ([MaBan], [TenBan]) VALUES (2, N'B')
INSERT [dbo].[BoMon] ([MaBM], [TenBM]) VALUES (1, N'Hóa Học')
INSERT [dbo].[BoMon] ([MaBM], [TenBM]) VALUES (2, N'Lý-Công Nghệ')
INSERT [dbo].[BoMon] ([MaBM], [TenBM]) VALUES (3, N'Ngữ Văn')
INSERT [dbo].[BoMon] ([MaBM], [TenBM]) VALUES (4, N'Ngoại Ngữ')
INSERT [dbo].[BoMon] ([MaBM], [TenBM]) VALUES (5, N'Sử-GDCD')
INSERT [dbo].[BoMon] ([MaBM], [TenBM]) VALUES (6, N'Sinh-Công Nghệ')
INSERT [dbo].[BoMon] ([MaBM], [TenBM]) VALUES (7, N'Toán Học')
INSERT [dbo].[BoMon] ([MaBM], [TenBM]) VALUES (8, N'Thể Dục-ANQP')
INSERT [dbo].[BoMon] ([MaBM], [TenBM]) VALUES (9, N'Địa Lý')
INSERT [dbo].[BoMon] ([MaBM], [TenBM]) VALUES (10, N'Tin Học')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (1, N'Trần Thị Chung', N'Nữ', N'3558054', N'Tổ trưởng bộ môn', N'ttchung.thpt.ngt@phuyen.edu.vn', 1)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (2, N'Lê Thị Như Quỳnh', N'Nữ', N'3558054', N'Tổ phó bộ môn', N'ltnquynh.thpt.ngt@phuyen.edu.vn', 1)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (3, N'Phạm Đình Tiềm', N'Nam', N'3558054', N'Giáo viên', N'pdtiem.thpt.ngt@phuyen.edu.vn', 1)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (4, N'Trần Thị Thúy', N'Nữ', N'3558054', N'Giáo viên', N'ttthuy.thpt.ngt@phuyen.edu.vn', 1)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (5, N'Nguyễn Thị Thanh Tú', N'Nữ', N'3558054', N'Cán bộ Đoàn', N'ntttu.thpt.ngt@phuyen.edu.vn', 1)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (6, N'Lê Thị Hạnh Ngân', N'Nữ', N'3558054', N'Giáo viên', N'lthngan.thpt.ngt@phuyen.edu.vn', 1)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (7, N'Nguyễn Trọng Thế', N'Nam', N'3558054', N'Tổ trưởng bộ môn', N'ntthe.thpt.ngt@phuyen.edu.vn', 2)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (8, N'Nguyễn Đình Trĩ', N'Nam', N'3558054', N'Tổ phó bộ môn', N'ndtri.thpt.ngt@phuyen.edu.vn', 2)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (9, N'Trương Duy Tuấn', N'Nam', N'3558054', N'Thanh Tra nhân dân', N'tduytuan.thpt.ngt@phuyen.edu.vn', 2)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (10, N'Lê Lý', N'Nam', N'3558054', N'Giáo viên', N'lly.thpt.ngt@phuyen.edu.vn', 2)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (11, N'Phạm Ngọc Thanh Lan', N'Nữ', N'3558054', N'Giáo viên', N'pntlan.thpt.ngt@phuyen.edu.vn', 2)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (12, N'Võ Ngọc Huy', N'Nam', N'3558054', N'GIáo viên', N'vnhuy.thpt.ngt@phuyen.edu.vn', 2)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (13, N'Ngô Thị Tiên', N'Nữ', N'3558054', N'Giáo viên', N'nttien.thpt.ngt@phuyen.edu.vn', 2)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (14, N'Lương Thị Vương', N'Nữ', N'3558054', N'Giáo viên', N'ltvuong.thpt.ngt@phuyen.edu.vn', 2)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (15, N'Cao Thị Mỹ Hằng', N'Nữ', N'3558054', N'Giáo viên', N'ctmhang.thpt.ngt@phuyen.edu.vn', 2)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (16, N'Nguyễn Thị Thanh Tuyền', N'Nữ', N'3558054', N'Giáo viên', N'ntttuyen.thpt.ngt@phuyen.edu.vn', 2)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (17, N'Thái Thị Mỹ Hảo', N'Nữ', N'3558054', N'Tổ trưởng bộ môn', N'ttmhao.thpt.ngt@phuyen.edu.vn', 3)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (18, N'Đinh Thị Huệ', N'Nữ', N'3558054', N'Tổ phó bộ môn', N'dthue.thpt.ngt@phuyen.edu.vn', 3)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (19, N'Trần Kim Trúc', N'Nam', N'3558054', N'Giáo viên', N'tktruc.thpt.ngt@phuyen.edu.vn', 3)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (20, N'Huỳnh Thị Thu Thảo', N'Nữ', N'3558054', N'Giáo viên', N'httthao.thpt.ngt@phuyen.edu.vn', 3)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (21, N'Nguyễn Thị Hằng', N'Nữ', N'3558054', N'Giáo viên', N'nthang.thpt.ngt@phuyen.edu.vn', 3)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (22, N'Nguyễn Thị Hiền', N'Nữ', N'3558054', N'Giáo viên', N'nthien.thpt.ngt@phuyen.edu.vn', 3)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (23, N'Trần Thị Bích Hồng', N'Nữ', N'3558054', N'Giáo viên', N'ttbhong.thpt.ngt@phuyen.edu.vn', 3)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (24, N'Nguyễn Thị Lan', N'Nữ', N'3558054', N'Giáo viên', N'ntlan.thpt.ngt@phuyen.edu.vn', 3)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (25, N'Lê Hoài Phương', N'Nữ', N'3558054', N'Giáo viên', N'lhphuong.thpt.ngt@phuyen.edu.vn', 3)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (26, N'Lê Thị Luận', N'Nữ', N'3558054', N'Giáo viên', N'ltluan.thpt.ngt@phuyen.edu.vn', 3)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (27, N'Phạm Anh Tuấn', N'Nam', N'3558054', N'Cán bộ Đoàn', N'patuan.thpt.ngt@phuyen.edu.vn', 3)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (28, N'Trần Lê Thùy Linh', N'Nữ', N'3558054', N'Giáo viên', N'tltlinh.thpt.ngt@phuyen.edu.vn', 3)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (29, N'Lê Thị Thanh Bích', N'Nữ', N'3558054', N'Tổ trưởng bộ môn', N'lttbich.thpt.ngt@phuyen.edu.vn', 4)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (30, N'Đặng Như Thục', N'Nữ', N'3558054', N'Tổ phó bộ môn', N'dnthuc.thpt.ngt@phuyen.edu.vn', 4)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (31, N'Huỳnh Thị Lệ My', N'Nữ', N'3558054', N'Hiệu phó', N'htlmy.thpt.ngt@phuyen.edu.vn', 4)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (32, N'Phạm Thị Bích Thùy', N'Nữ', N'3558054', N'Giáo viên', N'ptbthuy.thpt.ngt@phuyen.edu.vn', 4)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (33, N'Dương Thị Thanh Tuyền', N'Nữ', N'3558054', N'Giáo viên', N'dtttuyen.thpt.ngt@phuyen.edu.vn', 4)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (34, N'Hồ Thị Trúc Giang', N'Nữ', N'3558054', N'Giáo viên', N'httgiang.thpt.ngt@phuyen.edu.vn', 4)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (35, N'Mang Thị Thu Hà', N'Nữ', N'3558054', N'Giáo viên', N'mttha.thpt.ngt@phuyen.edu.vn', 4)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (36, N'Nguyễn Thị Thanh Tịnh', N'Nữ', N'3558054', N'Giáo viên', N'	ntttinh.thpt.ngt@phuyen.edu.vn', 4)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (37, N'Lương Thị Ngọc Thỏa', N'Nữ', N'3558054', N'Giáo viên', N'ltnthoa.thpt.ngt@phuyen.edu.vn', 4)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (38, N'Trần Hạnh Nguyên', N'Nữ', N'3558054', N'Giáo viên', N'thnguyen.thpt.ngt@phuyen.edu.vn', 4)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (39, N'Lê Ngọc Anh Tuệ', N'Nam', N'3558054', N'Giáo viên', N'lnatue.thpt.ngt@phuyen.edu.vn', 4)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (40, N'Bùi Thị Minh Trang', N'Nữ', N'3558054', N'Giáo viên', N'btmtrang.thpt.ngt@phuyen.edu.vn', 4)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (41, N'Nguyễn Thị Hương Thùy', N'Nữ', N'3558054', N'Giáo viên', N'nththuy.thpt.ngt@phuyen.edu.vn', 4)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (42, N'Mai Tấn Điện', N'Nam', N'3558054', N'Hiệu phó', N'mtdien.thpt.ngt@phuyen.edu.vn', 5)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (43, N'Lâm Thị Hương', N'Nữ', N'3558054', N'Hiệu phó', N'lthuong.thpt.ngt@phuyen.edu.vn', 5)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (44, N'Nguyễn Thị Thu Giang', N'Nữ', N'3558054', N'Giáo viên', N'nttgiang.thpt.ngt@phuyen.edu.vn', 5)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (45, N'Nguyễn Ngọc Hùng', N'Nam', N'3558054', N'Tổ phó bộ môn', N'nnhung.thpt.ngt@phuyen.edu.vn', 5)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (46, N'Nguyễn Thị Mai Lan', N'Nữ', N'3558054', N'Giáo viên', N'ntmlan.thpt.ngt@phuyen.edu.vn', 5)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (47, N'Phạm Thị Mai', N'Nữ', N'3558054', N'Giáo viên', N'ptmai.thpt.ngt@phuyen.edu.vn', 5)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (48, N'Trương Thị Ngọc Thạnh', N'Nữ', N'3558054', N'Giáo viên', N'ttnthanh.thpt.ngt@phuyen.edu.vn', 5)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (49, N'Phan Thị Mỹ Tho', N'Nữ', N'3558054', N'Giáo viên', N'ptmtho.thpt.ngt@phuyen.edu.vn', 5)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (50, N'Võ Thị Ánh Thúy', N'Nữ', N'3558054', N'Giáo viên', N'vtathuy.thpt.ngt@phuyen.edu.vn', 5)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (51, N'Võ Thị Bích Vương', N'Nữ', N'3558054', N'Tổ trưởng bộ môn', N'vtbvuong.thpt.ngt@phuyen.edu.vn', 6)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (52, N'Phạm Thị Như Nguyệt', N'Nữ', N'3558054', N'Tổ phó bộ môn', N'ptnnguyet.thpt.ngt@phuyen.edu.vn', 6)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (53, N'Huỳnh Thị Trà My', N'Nữ', N'3558054', N'Giáo viên', N'huynhtramy.thpt.ngt@phuyen.edu.vn', 6)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (54, N'Huỳnh Lê Bảo Trâm', N'Nữ', N'3558054', N'Giáo viên', N'hlbtram.thpt.ngt@phuyen.edu.vn', 6)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (55, N'Nguyễn Thị Thanh Thúy', N'Nữ', N'3558054', N'Giáo viên', N'nttthuy.thpt.ngt@phuyen.edu.vn', 6)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (56, N'Nguyễn Thị Thanh Trúc', N'Nữ', N'3558054', N'Giáo viên', N'nttthuy.thpt.ngt@phuyen.edu.vn', 6)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (57, N'Nguyễn Tú', N'Nam', N'3558054', N'Tổ trưởng bộ môn', N'ntu.thpt.ngt@phuyen.edu.vn', 7)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (58, N'Lê Trung Thành', N'Nam', N'3558054', N'Tổ phó bộ môn', N'ltthanh.thpt.ngt@phuyen.edu.vn', 7)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (59, N'Huỳnh Văn Khánh', N'Nam', N'3558054', N'Hiệu trưởng', N'hvkhanh.thpt.ngt@phuyen.edu.vn', 7)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (60, N'Lê Thành Lợi', N'Nam', N'3558054', N'Giáo viên', N'ltloi.thpt.ngt@phuyen.edu.vn', 7)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (61, N'Ngô Minh Quang', N'Nam', N'3558054', N'Giáo viên', N'nmquang.thpt.ngt@phuyen.edu.vn', 7)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (62, N'Nguyễn Minh Sơn', N'Nam', N'3558054', N'Giáo viên', N'nminhson.thpt.ngt@phuyen.edu.vn', 7)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (63, N'Nguyễn Văn Thành', N'Nam', N'3558054', N'Giáo viên', N'nvthanh.thpt.ngt@phuyen.edu.vn', 7)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (64, N'Đặng Quang Vũ', N'Nam', N'3558054', N'Giáo viên', N'dqvu.thpt.ngt@phuyen.edu.vn', 7)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (65, N'Nguyễn Thị Hồng Hạnh', N'Nữ', N'3558054', N'Giáo viên', N'nthhanh.thpt.ngt@phuyen.edu.vn', 7)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (66, N'Huỳnh Việt Tân', N'Nam', N'3558054', N'Giáo viên', N'hvtan.thpt.ngt@phuyen.edu.vn', 7)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (67, N'Lê Thị Hồng Vân', N'Nữ', N'3558054', N'Giáo viên', N'lthvan.thpt.ngt@phuyen.edu.vn', 7)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (68, N'Trương Trí', N'Nam', N'3558054', N'Giáo viên', N'ttri.thpt.ngt@phuyen.edu.vn', 7)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (69, N'Trần Lê Thanh Nhàn', N'Nữ', N'3558054', N'Giáo viên', N'tltnhan.thpt.ngt@phuyen.edu.vn', 7)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (70, N'Lê Thị Hạnh Nguyên', N'Nữ', N'3558054', N'Giáo viên', N'lthnguyen.thpt.ngt@phuyen.edu.vn', 7)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (71, N'Nguyễn Thị Thùy Linh', N'Nữ', N'3558054', N'Giáo viên', N'nttlinh.thpt.ngt@phuyen.edu.vn', 7)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (72, N'Trần Ngọc Hải', N'Nam', N'3558054', N'Tổ trưởng bộ môn', N'tnhai.thpt.ngt@phuyen.edu.vn', 8)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (73, N'Phan Thái Châu', N'Nam', N'3558054', N'Tổ phó bộ môn', N'ptchau.thpt.ngt@phuyen.edu.vn', 8)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (74, N'Trần Yên Tịnh', N'Nam', N'3558054', N'Giáo viên', N'tytinh.thpt.ngt@phuyen.edu.vn', 8)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (75, N'Lê Thanh Tùng', N'Nam', N'3558054', N'Giáo viên', N'lttung.thpt.ngt@phuyen.edu.vn', 8)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (76, N'Trần Mạnh Hùng', N'Nam', N'3558054', N'Giáo viên', N'tmanhhung.thpt.ngt@phuyen.edu.vn', 8)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (77, N'Nguyễn Thị Ngọc Huệ', N'Nữ', N'3558054', N'Giáo viên', N'ntnhue.thpt.ngt@phuyen.edu.vn', 8)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (78, N'Phạm Thị Thanh Điệp', N'Nữ', N'3558054', N'Tổ trưởng bộ môn', N'pttdiep.thpt.ngt@phuyen.edu.vn', 9)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (79, N'Phạm Thị Hải Anh', N'Nữ', N'3558054', N'Tổ phó bộ môn', N'pthanh.thpt.ngt@phuyen.edu.vn', 9)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (80, N'Lê Văn Nam', N'Nam', N'3558054', N'Giáo viên', N'lvnam.thpt.ngt@phuyen.edu.vn', 9)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (81, N'Lê Thị Trang', N'Nữ', N'3558054', N'Giáo viên', N'lttrang.thpt.ngt@phuyen.edu.vn', 9)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (82, N'Võ Thị Phượng', N'Nữ', N'3558054', N'Tổ trưởng bộ môn', N'vtphuong.thpt.ngt@phuyen.edu.vn', 10)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (83, N'Phan Hồ Kim Quyên', N'Nữ', N'3558054', N'Tổ phó bộ môn', N'phkquyen.thpt.ngt@phuyen.edu.vn', 10)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (84, N'Bùi Thị Tường Uyên', N'Nữ', N'3558054', N'Giáo viên', N'bttuyen.thpt.ngt@phuyen.edu.vn', 10)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (85, N'Huỳnh Thị Tuyết Liên', N'Nữ', N'3558054', N'Giáo viên', N'httlien.thpt.ngt@phuyen.edu.vn', 10)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [GioiTinh], [SDT], [ChucVu], [Email], [MaBM]) VALUES (86, N'Võ Anh Duy', N'Nam', N'3558054', N'Cán bộ Đoàn', N'vaduy.thpt.ngt@phuyen.edu.vn', 10)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (1, N'10A1', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (2, N'10A2', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (3, N'10A3', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (4, N'10A4', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (5, N'10A5', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (6, N'10A6', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (7, N'10B1', 45, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (8, N'10B2', 45, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (9, N'10B3', 45, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (10, N'10B4', 45, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (11, N'10B5', 45, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (12, N'11A1', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (13, N'11A2', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (14, N'11A3', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (15, N'11A4', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (16, N'11A5', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (17, N'11A6', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (18, N'11B1', 45, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (19, N'11B2', 45, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (20, N'11B3', 45, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (21, N'11B4', 45, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (22, N'12A1', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (23, N'12A2', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (24, N'12A3', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (25, N'12A4', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (26, N'12A5', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (27, N'12A6', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (28, N'12A7', 45, 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (29, N'12B1', 45, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (30, N'12B2', 45, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (31, N'12B3', 45, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (32, N'12B4', 45, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (33, N'12B5', 45, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (34, N'12B6', 45, 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoHocSinh], [MaBan]) VALUES (35, N'12B7', 45, 2)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [MaBM]) VALUES (1, N'Toán Học', 7)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [MaBM]) VALUES (2, N'Vật Lý', 2)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [MaBM]) VALUES (3, N'Hóa Học', 1)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [MaBM]) VALUES (4, N'Sinh Học', 6)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [MaBM]) VALUES (5, N'Ngữ Văn', 3)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [MaBM]) VALUES (6, N'Anh Văn', 4)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [MaBM]) VALUES (7, N'Lịch Sử', 5)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [MaBM]) VALUES (8, N'Địa Lý', 9)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [MaBM]) VALUES (9, N'Công nghệ', 2)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [MaBM]) VALUES (10, N'Công Dân', 5)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [MaBM]) VALUES (11, N'Tin Học', 10)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [MaBM]) VALUES (12, N'Thể dục', 8)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [MaBM]) VALUES (13, N'Quốc phòng', 8)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (1, N'P1', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (2, N'P2', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (3, N'P3', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (4, N'P4', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (5, N'P5', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (6, N'P6', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (7, N'P7', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (8, N'P8', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (9, N'P9', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (10, N'P10', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (11, N'P11', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (12, N'P12', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (13, N'P13', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (14, N'P14', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (15, N'P15', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (16, N'P16', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (17, N'P17', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (18, N'P18', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (19, N'P19', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (20, N'P20', 50)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (21, N'Sân bóng', 1000)
INSERT [dbo].[PhongHoc] ([MaPH], [TenPH], [DungLuong]) VALUES (22, N'Phòng Giáo Án Điện Tử', 100)
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (1, 1, 2, N'7h00-7h45')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (2, 2, 2, N'7h50-8h35')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (3, 3, 2, N'8h50-9h35')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (4, 4, 2, N'9h-40-10h25')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (5, 5, 2, N'10h30-11h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (6, 6, 2, N'12h30-13h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (7, 7, 2, N'13h20-14h05')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (8, 8, 2, N'14h20-15h25')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (9, 9, 2, N'15h30-16h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (10, 10, 2, N'16h20-17h05')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (11, 1, 3, N'7h00-7h45')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (12, 2, 3, N'7h50-8h35')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (13, 3, 3, N'8h50-9h35')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (14, 4, 3, N'9h-40-10h25')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (15, 5, 3, N'10h30-11h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (16, 6, 3, N'12h30-13h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (17, 7, 3, N'13h20-14h05')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (18, 8, 3, N'14h20-15h25')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (19, 9, 3, N'15h30-16h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (20, 10, 3, N'16h20-17h05')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (21, 1, 4, N'7h00-7h45')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (22, 2, 4, N'7h50-8h35')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (23, 3, 4, N'8h50-9h35')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (24, 4, 4, N'9h-40-10h25')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (25, 5, 4, N'10h30-11h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (26, 6, 4, N'12h30-13h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (27, 7, 4, N'13h20-14h05')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (28, 8, 4, N'14h20-15h25')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (29, 9, 4, N'15h30-16h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (30, 10, 4, N'16h20-17h05')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (31, 1, 5, N'7h00-7h45')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (32, 2, 5, N'7h50-8h35')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (33, 3, 5, N'8h50-9h35')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (34, 4, 5, N'9h-40-10h25')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (35, 5, 5, N'10h30-11h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (36, 6, 5, N'12h30-13h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (37, 7, 5, N'13h20-14h05')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (38, 8, 5, N'14h20-15h25')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (39, 9, 5, N'15h30-16h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (40, 10, 5, N'16h20-17h05')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (41, 1, 6, N'7h00-7h45')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (42, 2, 6, N'7h50-8h35')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (43, 3, 6, N'8h50-9h35')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (44, 4, 6, N'9h-40-10h25')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (45, 5, 6, N'10h30-11h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (46, 6, 6, N'12h30-13h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (47, 7, 6, N'13h20-14h05')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (48, 8, 6, N'14h20-15h25')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (49, 9, 6, N'15h30-16h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (50, 10, 6, N'16h20-17h05')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (51, 1, 7, N'7h00-7h45')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (52, 2, 7, N'7h50-8h35')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (53, 3, 7, N'8h50-9h35')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (54, 4, 7, N'9h-40-10h25')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (55, 5, 7, N'10h30-11h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (56, 6, 7, N'12h30-13h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (57, 7, 7, N'13h20-14h05')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (58, 8, 7, N'14h20-15h25')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (59, 9, 7, N'15h30-16h15')
INSERT [dbo].[Tiet] ([STT], [Tiet], [Thu], [Time]) VALUES (60, 10, 7, N'16h20-17h05')
ALTER TABLE [dbo].[ChuNhiem]  WITH CHECK ADD  CONSTRAINT [FK_ChuNhiem_GiaoVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[ChuNhiem] CHECK CONSTRAINT [FK_ChuNhiem_GiaoVien]
GO
ALTER TABLE [dbo].[ChuNhiem]  WITH CHECK ADD  CONSTRAINT [FK_ChuNhiem_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[ChuNhiem] CHECK CONSTRAINT [FK_ChuNhiem_Lop]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD FOREIGN KEY([MaBM])
REFERENCES [dbo].[BoMon] ([MaBM])
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[Ban] ([MaBan])
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_MonHoc_BoMon] FOREIGN KEY([MaBM])
REFERENCES [dbo].[BoMon] ([MaBM])
GO
ALTER TABLE [dbo].[MonHoc] CHECK CONSTRAINT [FK_MonHoc_BoMon]
GO
ALTER TABLE [dbo].[ThoiKhoaBieu]  WITH CHECK ADD  CONSTRAINT [FK_ThoiKhoaBieu_GiaoVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[ThoiKhoaBieu] CHECK CONSTRAINT [FK_ThoiKhoaBieu_GiaoVien]
GO
ALTER TABLE [dbo].[ThoiKhoaBieu]  WITH CHECK ADD  CONSTRAINT [FK_ThoiKhoaBieu_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[ThoiKhoaBieu] CHECK CONSTRAINT [FK_ThoiKhoaBieu_Lop]
GO
ALTER TABLE [dbo].[ThoiKhoaBieu]  WITH CHECK ADD  CONSTRAINT [FK_ThoiKhoaBieu_MonHoc] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[ThoiKhoaBieu] CHECK CONSTRAINT [FK_ThoiKhoaBieu_MonHoc]
GO
ALTER TABLE [dbo].[ThoiKhoaBieu]  WITH CHECK ADD  CONSTRAINT [FK_ThoiKhoaBieu_PhongHoc] FOREIGN KEY([MaPH])
REFERENCES [dbo].[PhongHoc] ([MaPH])
GO
ALTER TABLE [dbo].[ThoiKhoaBieu] CHECK CONSTRAINT [FK_ThoiKhoaBieu_PhongHoc]
GO
ALTER TABLE [dbo].[ThoiKhoaBieu]  WITH CHECK ADD  CONSTRAINT [FK_ThoiKhoaBieu_Tiet] FOREIGN KEY([MaTiet])
REFERENCES [dbo].[Tiet] ([STT])
GO
ALTER TABLE [dbo].[ThoiKhoaBieu] CHECK CONSTRAINT [FK_ThoiKhoaBieu_Tiet]
GO
USE [master]
GO
ALTER DATABASE [XepThoiKhoaBieu] SET  READ_WRITE 
GO
