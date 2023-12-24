USE [master]
GO
/****** Object:  Database [QL_SieuThi]    Script Date: 11-12-2023 9:43:33 PM ******/
CREATE DATABASE [QL_SieuThi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_SieuThi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.VNDT\MSSQL\DATA\QL_SieuThi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QL_SieuThi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.VNDT\MSSQL\DATA\QL_SieuThi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QL_SieuThi] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_SieuThi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_SieuThi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_SieuThi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_SieuThi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_SieuThi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_SieuThi] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_SieuThi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_SieuThi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_SieuThi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_SieuThi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_SieuThi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_SieuThi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_SieuThi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_SieuThi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_SieuThi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_SieuThi] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_SieuThi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_SieuThi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_SieuThi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_SieuThi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_SieuThi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_SieuThi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_SieuThi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_SieuThi] SET RECOVERY FULL 
GO
ALTER DATABASE [QL_SieuThi] SET  MULTI_USER 
GO
ALTER DATABASE [QL_SieuThi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_SieuThi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_SieuThi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_SieuThi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QL_SieuThi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QL_SieuThi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QL_SieuThi', N'ON'
GO
ALTER DATABASE [QL_SieuThi] SET QUERY_STORE = OFF
GO
USE [QL_SieuThi]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_PhieuBan] [int] NULL,
	[MaSanPham] [int] NULL,
	[Gia] [float] NULL,
	[SoLuong] [int] NULL,
	[GiaTriKhuyenMai] [int] NULL,
	[TongCong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietKhuyenMai]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietKhuyenMai](
	[MaKhuyenMai] [int] NOT NULL,
	[MaSanPham] [int] NOT NULL,
	[GiaTriKhuyenMai] [int] NULL,
 CONSTRAINT [fk_ChiTietKhuyenMai] PRIMARY KEY CLUSTERED 
(
	[MaKhuyenMai] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieuNhap] [int] NOT NULL,
	[MaSanPham] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[Gia] [float] NULL,
	[TongCong] [float] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [pk_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DM_ManHinh]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_ManHinh](
	[MaManHinh] [varchar](5) NOT NULL,
	[TenManHinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_DMManHinh] PRIMARY KEY CLUSTERED 
(
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [varchar](50) NULL,
	[MatKhau] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[MaKhuyenMai] [int] IDENTITY(1,1) NOT NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
	[NoiDung] [nvarchar](511) NULL,
	[GiaTriKhuyenMai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhuyenMai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[MoTa] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhanCungCap] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaCungCap] [nvarchar](100) NULL,
	[SoDienThoai] [numeric](10, 0) NULL,
	[Email] [varchar](50) NULL,
	[DiaChi] [nvarchar](511) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [varchar](50) NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](511) NULL,
	[SoDienThoai] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[LuongCoBan] [float] NULL,
	[HinhAnh] [varchar](100) NULL,
	[LoaiNhanVien] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [bit] NULL,
	[NgayVaoLam] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuBanHang]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuBanHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NgayMua] [date] NULL,
	[MaNhanVien] [int] NULL,
	[MaKhachHang] [int] NULL,
	[TongTien] [float] NULL,
	[GiamGia] [float] NULL,
	[TienPhaiTra] [float] NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapHang]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapHang](
	[MaPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[NgayNhap] [datetime] NULL,
	[MaNhaCungCap] [int] NULL,
	[MaNhanVien] [int] NULL,
	[TrangThai] [bit] NULL,
	[GiaTri] [float] NULL,
	[QL_PheDuyet] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QL_NguoiDungNhomNguoiDung]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_NguoiDungNhomNguoiDung](
	[TenDangNhap] [varchar](50) NOT NULL,
	[MaNhomNguoiDung] [varchar](5) NOT NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_QLNguoiDungNhomNguoiDung] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC,
	[MaNhomNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QL_NhomNguoiDung]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_NhomNguoiDung](
	[MaNhom] [varchar](5) NOT NULL,
	[TenNhom] [nvarchar](30) NULL,
	[GhiChu] [nvarchar](250) NULL,
 CONSTRAINT [PK_QLNhomNguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QL_PhanQuyen]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_PhanQuyen](
	[MaNhomNguoiDung] [varchar](5) NOT NULL,
	[MaManHinh] [varchar](5) NOT NULL,
	[CoQuyen] [bit] NULL,
 CONSTRAINT [PK_QLPhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaNhomNguoiDung] ASC,
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [int] IDENTITY(1,1) NOT NULL,
	[MaLoai] [int] NULL,
	[TenSanPham] [nvarchar](50) NULL,
	[HinhAnh] [varchar](512) NULL,
	[Gia] [float] NULL,
	[SoLuongTon] [int] NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[MoTa] [nvarchar](511) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NULL,
	[LoaiTaiKhoan] [nvarchar](10) NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinChamCong]    Script Date: 11-12-2023 9:43:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinChamCong](
	[MaNhanVien] [int] NULL,
	[SoNgayLamViec] [int] NULL,
	[LuongCoBan] [float] NULL,
	[Thang] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Thang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON 

INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (1, 1, 2, 2500, 1, 0, 2500)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (2, 2, 1, 2500, 1, 0, 2500)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (3, 2, 2, 2500, 2, 0, 5000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (4, 2, 6, 12000, 3, 0, 36000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (5, 3, 6, 12000, 3, 0, 36000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (6, 4, 3, 12000, 1, 0, 12000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (7, 4, 3, 12000, 1, 0, 12000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (8, 4, 3, 12000, 1, 0, 12000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (9, 5, 4, 5000, 1, 0, 5000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (10, 6, 1, 2500, 1, 0, 2500)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (11, 7, 2, 2500, 1, 0, 2500)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (12, 8, 6, 12000, 1, 0, 12000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (13, 9, 2, 2500, 1, 0, 2500)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (14, 11, 2, 2500, 4, 15, 32725)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (15, 11, 3, 12000, 3, 15, 30600)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (16, 12, 6, 12000, 3, 0, 36000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (17, 12, 2, 2500, 2, 15, 4250)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (18, 13, 6, 12000, 1, 0, 12000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (19, 14, 1, 2500, 200, 0, 500000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (20, 14, 6, 12000, 47, 0, 576000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (21, 15, 3, 12000, 2, 0, 24000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (22, 17, 1, 2500, 4, 20, 8000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (23, 17, 3, 12000, 1, 15, 10200)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (24, 20, 15, 15000, 4, 0, 60000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (25, 20, 4, 5000, 3, 0, 15000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (26, 21, 1, 2500, 1, 20, 2000)
INSERT [dbo].[ChiTietHoaDon] ([ID], [ID_PhieuBan], [MaSanPham], [Gia], [SoLuong], [GiaTriKhuyenMai], [TongCong]) VALUES (27, 21, 9, 168000, 1, 15, 142800)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF
GO
INSERT [dbo].[ChiTietKhuyenMai] ([MaKhuyenMai], [MaSanPham], [GiaTriKhuyenMai]) VALUES (1, 2, 15)
INSERT [dbo].[ChiTietKhuyenMai] ([MaKhuyenMai], [MaSanPham], [GiaTriKhuyenMai]) VALUES (1, 3, 15)
INSERT [dbo].[ChiTietKhuyenMai] ([MaKhuyenMai], [MaSanPham], [GiaTriKhuyenMai]) VALUES (1, 7, 15)
INSERT [dbo].[ChiTietKhuyenMai] ([MaKhuyenMai], [MaSanPham], [GiaTriKhuyenMai]) VALUES (1, 9, 15)
INSERT [dbo].[ChiTietKhuyenMai] ([MaKhuyenMai], [MaSanPham], [GiaTriKhuyenMai]) VALUES (2, 1, 20)
GO
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (1, 1, 200, 2.5, 500, 0)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (1, 4, 50, 5000, 250000, 0)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (1, 6, 50, 12000, 600000, 0)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (5, 4, 50, 5000, 250000, 0)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (5, 5, 20, 6000, 120000, 0)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (6, 3, 100, 12000, 1200000, 0)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (11, 3, 1, 12000, 12000, 1)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (11, 7, 100, 250000, 25000000, 1)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (13, 1, 50, 10000, 500000, 1)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (13, 3, 100, 10000, 1000000, 1)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (14, 10, 10, 3000, 30000, 1)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (17, 7, 10, 150000, 1500000, 1)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (17, 8, 10, 160000, 1600000, 1)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (17, 9, 15, 156000, 2340000, 1)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (18, 14, 100, 196000, 19600000, 1)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (18, 15, 100, 256000, 25600000, 1)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (19, 5, 1, 150000, 150000, 1)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia], [TongCong], [TrangThai]) VALUES (19, 6, 100, 12000, 1200000, 1)
GO
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH001', N'PhanQuyenFrm')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH002', N'BanHangFrm')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH003', N'NhapHangFrm')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH004', N'QLSanPhamFrm')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH005', N'QLNhanVien')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH006', N'ThongKeFrm')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH007', N'TrangCaNhanFrm')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH008', N'KhachHangFrm')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH009', N'NhanVienFrm')
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai], [MatKhau]) VALUES (1, N'Nguyễn Thị Ngọc Phượng', 0, N'TP.HCM', N'0912345678', N'123')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai], [MatKhau]) VALUES (2, N'Khách vãng lai', 1, N'TP.HCM', N'0912345654', N'123')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai], [MatKhau]) VALUES (8, N'NGUYỄN THỊ C', 0, N'Tiền Giang', N'0912345679', N'0912345679')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai], [MatKhau]) VALUES (22, N'A LONG', 1, N'Long A', N'0912345677', N'0912345677')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[KhuyenMai] ON 

INSERT [dbo].[KhuyenMai] ([MaKhuyenMai], [NgayBatDau], [NgayKetThuc], [NoiDung], [GiaTriKhuyenMai]) VALUES (1, CAST(N'2023-11-29' AS Date), CAST(N'2023-12-15' AS Date), N'Khuyen mai 1', 15)
INSERT [dbo].[KhuyenMai] ([MaKhuyenMai], [NgayBatDau], [NgayKetThuc], [NoiDung], [GiaTriKhuyenMai]) VALUES (2, CAST(N'2023-11-30' AS Date), CAST(N'2023-12-30' AS Date), N'Khuyen mai 2', 20)
SET IDENTITY_INSERT [dbo].[KhuyenMai] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiSanPham] ON 

INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (1, N'Thực phẩm', N'Hàng hóa liên quan đến thực phẩm')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (2, N'Đồ gia dụng', N'Đồ dùng trong gia đình')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (3, N'Thời trang', N'Quần áo, giày dép, phụ kiện thời trang')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (4, N'Điện tử', N'Thiết bị điện tử, điện gia dụng')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (5, N'Sức khỏe và làm đẹp', N'Sản phẩm chăm sóc sức khỏe, làm đẹp')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (6, N'Đồ chơi', N'Đồ chơi, đồ dùng cho trẻ em')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (7, N'Thể thao', N'Đồ dùng và thiết bị thể thao')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (8, N'Xe cộ', N'Xe hơi, xe máy, ph? tùng, đ? chơi xe')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (9, N'Văn phòng phẩm', N'Sản phẩm văn phòng, đồ dùng học tập')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (10, N'Đồ uống', N'Rượu, bia, đồ uống giải khát')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (11, N'Điện thoại', N'Điện thoại di động')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (12, N'Máy tính bảng', N'Máy tính bảng')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (13, N'Laptop', N'Máy tính xách tay')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (14, N'Máy ảnh', N'Máy ảnh kỹ thuật số')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (15, N'Máy quay phim', N'Máy quay phim')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (16, N'Âm thanh', N'Thiết bị âm thanh')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (17, N'Điện gia dụng nhỏ', N'Đồ dùng nhà bếp, máy hút bụi, máy giặt, tủ lạnh')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (18, N'Điện gia dụng lớn', N'Tivi, máy lạnh, máy giặt công nghiệp')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (19, N'Phụ kiện điện thoại', N'Ốp lưng, bao da, dán màn hình')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (20, N'Phụ kiện máy tính bảng', N'Ốp lưng, bao da, bút cảm ứng')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (21, N'Phụ kiện laptop', N'Túi đựng, chuột, bàn di chuột')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (22, N'Phụ kiện máy ảnh', N'Thẻ nhớ, pin, sạc, ống kính')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (23, N'Phụ kiện âm thanh', N'Tai nghe, loa')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (24, N'Sữa tắm', N'Sữa tắm, xà phòng, gel tắm')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (25, N'Dầu gội', N'Dầu gội, dầu xả, serum tóc')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (26, N'Chăm sóc da', N'Kem dưỡng da, sữa rửa mặt, tẩy trang')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (27, N'Chăm sóc tóc', N'Dầu dưỡng tóc, mặt nạ tóc, sáp vuốt tóc')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (28, N'Trang điểm', N'Kem nền, phấn phủ, son môi')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (29, N'Thực phẩm tươi sống', N'Rau củ, thịt, cá')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (30, N'Thực phẩm đông lạnh', N'Thực phẩm đóng gói, thực phẩm đông lạnh')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (31, N'Thực phẩm khô', N'Hạt, trái cây khô, bánh kẹo')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (32, N'Đồ ăn nhanh', N'Bánh mì, pizza, hamburger')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (33, N'Thực phẩm chay', N'Thực phẩm không có thành phần động vật')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (34, N'Đồ chơi trẻ em', N'Đồ chơi cho trẻ em')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (35, N'Đồ chơi điện tử', N'Máy chơi game, máy điều khiển từ xa')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (36, N'Đồ chơi giáo dục', N'Đồ chơi giúp trẻ phát triển trí tuệ')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (37, N'Đồ chơi vận động', N'Đồ chơi giúp trẻ rèn luyện thể chất')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (38, N'Đồ chơi xếp hình', N'Đồ chơi giúp trẻ phát triển trí não')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (39, N'Bóng đá', N'Bóng đá, giày bóng đá, áo đấu bóng đá')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (40, N'Bóng rổ', N'Bóng rổ, giày bóng rổ, áo đấu bóng rổ')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (41, N'Bóng chuyền', N'Bóng chuyền, giày bóng chuyền, áo đấu bóng chuyền')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (42, N'Yoga', N'Tạ, băng đô, quần áo yoga')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (43, N'Đi bộ', N'Giày thể thao, quần áo thể thao')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (44, N'Thể dục dụng cụ', N'Dụng cụ tập thể hình')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (45, N'Xe đạp', N'Xe đạp thể thao, xe đạp địa hình')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (46, N'Xe máy', N'Xe máy, phụ tùng xe máy')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (47, N'Xe hơi', N'Xe hơi, phụ tùng xe hơi')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (48, N'Rượu vang', N'Rượu vang đỏ, rượu vang trắng')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (49, N'Rượu bia', N'Rượu bia, nước ngọt, nước giải khát')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (50, N'Nước ép', N'Nước ép trái cây, nước ép rau củ')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (51, N'Bột giặt', N'Sản phẩm thiết yếu hằng ngày')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (52, N'Thuc an nhanh', N'thuc an nhanh')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (53, N'Loai 1', N'loai 1')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai], [MoTa]) VALUES (54, N'Sữa tươi', N'Sữa tươi')
SET IDENTITY_INSERT [dbo].[LoaiSanPham] OFF
GO
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON 

INSERT [dbo].[NhaCungCap] ([MaNhanCungCap], [TenNhaCungCap], [SoDienThoai], [Email], [DiaChi]) VALUES (1, N'Nhà cung cấp bánh mì heo quay chả lụa', CAST(984123456 AS Numeric(10, 0)), N'ncc01@gmail.com', N'1 lê trọng tấn,tân phú, thành phố Hồ Chí Minh')
INSERT [dbo].[NhaCungCap] ([MaNhanCungCap], [TenNhaCungCap], [SoDienThoai], [Email], [DiaChi]) VALUES (2, N'Nhà cung cấp trà sữa 1', CAST(984123456 AS Numeric(10, 0)), N'ncc01@gmail.com', N'1 lê trọng tấn,tân phú, thành phố Hồ Chí Minh')
INSERT [dbo].[NhaCungCap] ([MaNhanCungCap], [TenNhaCungCap], [SoDienThoai], [Email], [DiaChi]) VALUES (3, N'Nhà cung cấp nước ngọt', CAST(984123456 AS Numeric(10, 0)), N'ncc01@gmail.com', N'1 lê trọng tấn,tân phú, thành phố Hồ Chí Minh')
INSERT [dbo].[NhaCungCap] ([MaNhanCungCap], [TenNhaCungCap], [SoDienThoai], [Email], [DiaChi]) VALUES (4, N'Nhà cung cấp 1', CAST(984123456 AS Numeric(10, 0)), N'ncc1@gmail.com', N'TP.HCM')
INSERT [dbo].[NhaCungCap] ([MaNhanCungCap], [TenNhaCungCap], [SoDienThoai], [Email], [DiaChi]) VALUES (5, N'Nhà cung cấp 2', CAST(984098765 AS Numeric(10, 0)), N'ncc2@gmail.com', N'TP.HCM')
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNhanVien], [TenDangNhap], [TenNhanVien], [DiaChi], [SoDienThoai], [Email], [LuongCoBan], [HinhAnh], [LoaiNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam]) VALUES (1, N'VoNguyenDuyTan', N'Võ Nguyễn Duy Tân', N'Tiền Giang', N'0984123456', N'nv01@gmail.com', 4000000, N'lisa.jpg', N'MN001', CAST(N'2002-02-08' AS Date), 1, CAST(N'2023-11-20' AS Date))
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenDangNhap], [TenNhanVien], [DiaChi], [SoDienThoai], [Email], [LuongCoBan], [HinhAnh], [LoaiNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam]) VALUES (2, N'ngocphuong', N'Nguyễn Thị Ngọc Phượng', N'Quảng Ngãi', N'0984123457', N'nv02@gmail.com', 4600000, N'h1.png', N'MN004', CAST(N'2002-02-10' AS Date), 0, NULL)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenDangNhap], [TenNhanVien], [DiaChi], [SoDienThoai], [Email], [LuongCoBan], [HinhAnh], [LoaiNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam]) VALUES (6, N'sa', N'Nguyễn Văn A', N'Quảng Ngãi', N'0984123458', N'nv03@gmail.com', 4600000, N'h1.png', N'MN001', CAST(N'2002-02-13' AS Date), 1, NULL)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenDangNhap], [TenNhanVien], [DiaChi], [SoDienThoai], [Email], [LuongCoBan], [HinhAnh], [LoaiNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam]) VALUES (7, N'BH01', N'Trần Văn Thắng', N'Quảng Ngãi', N'0984123459', N'nv04@gmail.com', 4600000, N'h1.png', N'MN002', CAST(N'2002-02-15' AS Date), 1, NULL)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenDangNhap], [TenNhanVien], [DiaChi], [SoDienThoai], [Email], [LuongCoBan], [HinhAnh], [LoaiNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam]) VALUES (8, N'ThuKho1', N'Nhan vien 1', N'Quảng Ngãi', N'0984123400', N'nv05@gmail.com', 4600000, N'h1.png', N'MN003', CAST(N'2002-02-15' AS Date), 1, NULL)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenDangNhap], [TenNhanVien], [DiaChi], [SoDienThoai], [Email], [LuongCoBan], [HinhAnh], [LoaiNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam]) VALUES (11, N'NhanVien2', N'Nhan vien 2', N'TP.HCM', N'0984111111', N'nhanvien2@gmail.com', 3400000, N'default.png', N'MN005', CAST(N'2009-10-27' AS Date), 1, NULL)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuBanHang] ON 

INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (1, NULL, 1, 1, 2500, 0, 0, 1)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (2, NULL, 1, 1, 43500, 0, 0, 1)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (3, NULL, 1, 1, 36000, 0, 0, 1)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (4, NULL, 1, 1, 12000, 0, 0, 1)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (5, CAST(N'2023-11-23' AS Date), 1, 1, 5000, 0, 0, 1)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (6, CAST(N'2023-11-23' AS Date), 1, 1, 2500, 0, 0, 1)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (7, CAST(N'2023-11-23' AS Date), 1, 1, 2500, 0, 0, 1)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (8, CAST(N'2023-11-23' AS Date), 1, 1, 12000, 0, 12000, 0)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (9, CAST(N'2023-11-23' AS Date), 1, 1, 2500, 0, 2500, 1)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (11, CAST(N'2023-11-30' AS Date), 7, 2, 32725, 0, 32725, 1)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (12, CAST(N'2023-11-30' AS Date), 7, 2, 40250, 0, 40250, 1)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (13, CAST(N'2023-11-30' AS Date), 7, 2, 12000, 0, 12000, 1)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (14, CAST(N'2023-11-30' AS Date), 7, 2, 1076000, 0, 1076000, 1)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (15, CAST(N'2023-11-30' AS Date), 7, 2, 24000, 0, 24000, 1)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (16, CAST(N'2023-11-30' AS Date), 7, 2, 0, 0, 0, 0)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (17, CAST(N'2023-11-30' AS Date), 7, 2, 18200, 0, 18200, 1)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (20, CAST(N'2023-12-07' AS Date), 1, 2, 75000, 0, 75000, 1)
INSERT [dbo].[PhieuBanHang] ([ID], [NgayMua], [MaNhanVien], [MaKhachHang], [TongTien], [GiamGia], [TienPhaiTra], [TrangThai]) VALUES (21, CAST(N'2023-12-10' AS Date), 7, 2, 144800, 0, 144800, 1)
SET IDENTITY_INSERT [dbo].[PhieuBanHang] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuNhapHang] ON 

INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TrangThai], [GiaTri], [QL_PheDuyet]) VALUES (1, CAST(N'2023-06-01T16:13:02.787' AS DateTime), 2, 1, 0, 0, 1)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TrangThai], [GiaTri], [QL_PheDuyet]) VALUES (5, CAST(N'2023-06-01T22:35:02.150' AS DateTime), 1, 1, 0, 0, 1)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TrangThai], [GiaTri], [QL_PheDuyet]) VALUES (6, CAST(N'2017-06-02T07:16:45.480' AS DateTime), 3, 1, 0, 0, 0)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TrangThai], [GiaTri], [QL_PheDuyet]) VALUES (11, CAST(N'2023-11-29T20:23:05.770' AS DateTime), 4, 1, 1, 0, 1)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TrangThai], [GiaTri], [QL_PheDuyet]) VALUES (13, CAST(N'2023-11-29T22:21:56.857' AS DateTime), 5, 1, 1, 0, 1)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TrangThai], [GiaTri], [QL_PheDuyet]) VALUES (14, CAST(N'2023-11-30T13:36:44.853' AS DateTime), 3, 6, 1, 0, 1)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TrangThai], [GiaTri], [QL_PheDuyet]) VALUES (17, CAST(N'2023-12-04T15:50:42.483' AS DateTime), 3, 11, 1, 5440000, 1)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TrangThai], [GiaTri], [QL_PheDuyet]) VALUES (18, CAST(N'2023-12-07T09:09:54.483' AS DateTime), 3, 6, 1, 45200000, 1)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TrangThai], [GiaTri], [QL_PheDuyet]) VALUES (19, CAST(N'2023-12-07T12:53:37.140' AS DateTime), 3, 11, 1, 1350000, 1)
SET IDENTITY_INSERT [dbo].[PhieuNhapHang] OFF
GO
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'BH01', N'MN002', N'')
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'ngocphuong', N'MN004', N'')
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'NhanVien2', N'MN003', N'')
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'NhanVien2', N'MN004', N'')
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'sa', N'MN001', N'')
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'ThuKho1', N'MN003', N'')
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'VoNguyenDuyTan', N'MN001', N'')
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'VoNguyenDuyTan', N'MN004', N'')
GO
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'MN001', N'Admin', N'Người quản trị')
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'MN002', N'Nhân viên bán hàng', N'')
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'MN003', N'Thủ kho', N'')
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'MN004', N'Quản lý', N'')
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'MN005', N'Kế toán', N'')
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'MN006', N'NoneAuthor', N'')
GO
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN001', N'MH001', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN001', N'MH002', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN001', N'MH003', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN001', N'MH004', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN001', N'MH005', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN001', N'MH006', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN001', N'MH007', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN001', N'MH008', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN001', N'MH009', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN002', N'MH001', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN002', N'MH002', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN002', N'MH003', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN002', N'MH004', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN002', N'MH005', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN002', N'MH006', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN002', N'MH007', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN002', N'MH008', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN002', N'MH009', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN003', N'MH001', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN003', N'MH002', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN003', N'MH003', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN003', N'MH004', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN003', N'MH005', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN003', N'MH006', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN003', N'MH007', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN003', N'MH008', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN003', N'MH009', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN004', N'MH001', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN004', N'MH002', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN004', N'MH003', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN004', N'MH004', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN004', N'MH005', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN004', N'MH006', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN004', N'MH007', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN004', N'MH008', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN004', N'MH009', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN005', N'MH001', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN005', N'MH002', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN005', N'MH003', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN005', N'MH004', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN005', N'MH005', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN005', N'MH006', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN005', N'MH007', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN005', N'MH008', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN005', N'MH009', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN006', N'MH001', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN006', N'MH002', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN006', N'MH003', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN006', N'MH004', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN006', N'MH005', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN006', N'MH006', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN006', N'MH007', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN006', N'MH008', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'MN006', N'MH009', 0)
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSanPham], [MaLoai], [TenSanPham], [HinhAnh], [Gia], [SoLuongTon], [DonViTinh], [MoTa]) VALUES (1, 32, N'Bánh mì sandwich', N'https://res.cloudinary.com/dozsz2dqi/image/upload/v1701284213/QL_SieuThi/ndfesir2e73nbojyystp.jpg', 2500, 0, N'Cái', N'Bánh mì sandwich thịt gà')
INSERT [dbo].[SanPham] ([MaSanPham], [MaLoai], [TenSanPham], [HinhAnh], [Gia], [SoLuongTon], [DonViTinh], [MoTa]) VALUES (2, 32, N'Bánh mì thịt', N'https://res.cloudinary.com/dozsz2dqi/image/upload/v1701284213/QL_SieuThi/rawq2tyo5p7joa8iahdc.jpg', 2500, 144, N'Cái', N'Bánh mì sandwich thịt heo')
INSERT [dbo].[SanPham] ([MaSanPham], [MaLoai], [TenSanPham], [HinhAnh], [Gia], [SoLuongTon], [DonViTinh], [MoTa]) VALUES (3, 10, N'Pesi', N'https://res.cloudinary.com/dozsz2dqi/image/upload/v1701284214/QL_SieuThi/fh4zcf8vlxku82yaugc8.jpg', 12000, 104, N'Chai', N'Giải khát khi báo cáo')
INSERT [dbo].[SanPham] ([MaSanPham], [MaLoai], [TenSanPham], [HinhAnh], [Gia], [SoLuongTon], [DonViTinh], [MoTa]) VALUES (4, 1, N'Mì gói hảo hảo', N'https://res.cloudinary.com/dozsz2dqi/image/upload/v1701284214/QL_SieuThi/rgc7dwy2s1eigxecxwnk.jpg', 5000, 2, N'Gói', N'Mì gối cứu đối ngày cuối tháng')
INSERT [dbo].[SanPham] ([MaSanPham], [MaLoai], [TenSanPham], [HinhAnh], [Gia], [SoLuongTon], [DonViTinh], [MoTa]) VALUES (5, 1, N'Mì gói lẩu thái', N'https://res.cloudinary.com/dozsz2dqi/image/upload/v1701284213/QL_SieuThi/n19di9wohin4b1a9vwlv.jpg', 6000, 21, N'Gói', N'Mì gói cứu đói mỗi thứ bảy')
INSERT [dbo].[SanPham] ([MaSanPham], [MaLoai], [TenSanPham], [HinhAnh], [Gia], [SoLuongTon], [DonViTinh], [MoTa]) VALUES (6, 1, N'Mì gói Omachi', N'https://res.cloudinary.com/dozsz2dqi/image/upload/v1701284214/QL_SieuThi/pdl7t3svk6hwxrldw6mt.jpg', 12000, 100, N'Gói', N'Mì gói đầu tháng sang sáng tí')
INSERT [dbo].[SanPham] ([MaSanPham], [MaLoai], [TenSanPham], [HinhAnh], [Gia], [SoLuongTon], [DonViTinh], [MoTa]) VALUES (7, 2, N'Nước xả vải', N'https://res.cloudinary.com/dozsz2dqi/image/upload/v1701321865/QL_SieuThi/twnqbs0zyxnamcatpxkd.jpg', 25000, 10, N'Gói', N'Nuoc xa vai khong thom')
INSERT [dbo].[SanPham] ([MaSanPham], [MaLoai], [TenSanPham], [HinhAnh], [Gia], [SoLuongTon], [DonViTinh], [MoTa]) VALUES (8, 25, N'Downy', N'https://res.cloudinary.com/dozsz2dqi/image/upload/v1701289070/QL_SieuThi/vqlgwx1wkxhid53wqcz3.png', 15000, 10, N'Gói', N'Nuoc giat donwy')
INSERT [dbo].[SanPham] ([MaSanPham], [MaLoai], [TenSanPham], [HinhAnh], [Gia], [SoLuongTon], [DonViTinh], [MoTa]) VALUES (9, 51, N'Nước giặt Ariel', N'https://res.cloudinary.com/dozsz2dqi/image/upload/v1701291231/QL_SieuThi/l9r4rxan2scvp8xdf8za.png', 168000, 14, N'Gói', N'Nuoc giat ariel')
INSERT [dbo].[SanPham] ([MaSanPham], [MaLoai], [TenSanPham], [HinhAnh], [Gia], [SoLuongTon], [DonViTinh], [MoTa]) VALUES (10, 53, N'Mì goi hao hao', N'https://res.cloudinary.com/dozsz2dqi/image/upload/v1701326163/QL_SieuThi/k58t171alaggrnmzevq0.png', 10, 10, N'Gói', N'mo ta')
INSERT [dbo].[SanPham] ([MaSanPham], [MaLoai], [TenSanPham], [HinhAnh], [Gia], [SoLuongTon], [DonViTinh], [MoTa]) VALUES (14, 54, N'Sữa tươi cô gái Hà Lan', N'https://res.cloudinary.com/dozsz2dqi/image/upload/v1701853579/QL_SieuThi/sonx9akwmnavgkmmdac2.jpg', 15000, 100, N'Thùng', N'Sữa tươi cô gái Hà Lan')
INSERT [dbo].[SanPham] ([MaSanPham], [MaLoai], [TenSanPham], [HinhAnh], [Gia], [SoLuongTon], [DonViTinh], [MoTa]) VALUES (15, 54, N'Milo', N'https://res.cloudinary.com/dozsz2dqi/image/upload/v1701914978/QL_SieuThi/aq60ysdwhxu1h37clsap.jpg', 15000, 255996, N'Thùng', N'Milo')
INSERT [dbo].[SanPham] ([MaSanPham], [MaLoai], [TenSanPham], [HinhAnh], [Gia], [SoLuongTon], [DonViTinh], [MoTa]) VALUES (16, 54, N'Vinamilk', N'https://res.cloudinary.com/dozsz2dqi/image/upload/v1701287859/QL_SieuThi/opebdjy24xgqhlyfruol.png', 10000, 0, N'Thùng', N'Vinamilk')
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [LoaiTaiKhoan], [TrangThai]) VALUES (N'BH01', N'123', N'MN002', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [LoaiTaiKhoan], [TrangThai]) VALUES (N'ngocphuong', N'456', N'MN002', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [LoaiTaiKhoan], [TrangThai]) VALUES (N'NhanVien2', N'123', N'MN003', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [LoaiTaiKhoan], [TrangThai]) VALUES (N'sa', N'123', N'MN001', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [LoaiTaiKhoan], [TrangThai]) VALUES (N'ThuKho1', N'123', N'MN003', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [LoaiTaiKhoan], [TrangThai]) VALUES (N'VoNguyenDuyTan', N'123', N'MN001', 1)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [SDT_unique]    Script Date: 11-12-2023 9:43:34 PM ******/
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [SDT_unique] UNIQUE NONCLUSTERED 
(
	[SoDienThoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KhuyenMai] ADD  DEFAULT (getdate()) FOR [NgayBatDau]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ((1)) FOR [GioiTinh]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT (getdate()) FOR [NgayVaoLam]
GO
ALTER TABLE [dbo].[PhieuBanHang] ADD  DEFAULT (getdate()) FOR [NgayMua]
GO
ALTER TABLE [dbo].[PhieuBanHang] ADD  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[ThongTinChamCong] ADD  DEFAULT (getdate()) FOR [Thang]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [fk_ChiTietHoaDon_PhieuBanHang] FOREIGN KEY([ID_PhieuBan])
REFERENCES [dbo].[PhieuBanHang] ([ID])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [fk_ChiTietHoaDon_PhieuBanHang]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [fk_ChiTietHoaDon_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [fk_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[ChiTietKhuyenMai]  WITH CHECK ADD  CONSTRAINT [fk_ChiTietKhuyenMai_KhuyenMai] FOREIGN KEY([MaKhuyenMai])
REFERENCES [dbo].[KhuyenMai] ([MaKhuyenMai])
GO
ALTER TABLE [dbo].[ChiTietKhuyenMai] CHECK CONSTRAINT [fk_ChiTietKhuyenMai_KhuyenMai]
GO
ALTER TABLE [dbo].[ChiTietKhuyenMai]  WITH CHECK ADD  CONSTRAINT [fk_ChiTietKhuyenMai_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietKhuyenMai] CHECK CONSTRAINT [fk_ChiTietKhuyenMai_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_ChiTietPhieuNhap_PhieuNhapHang] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhapHang] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [fk_ChiTietPhieuNhap_PhieuNhapHang]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_ChiTietPhieuNhap_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [fk_ChiTietPhieuNhap_SanPham]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [fk_NhanVien_TaiKhoan] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [fk_NhanVien_TaiKhoan]
GO
ALTER TABLE [dbo].[PhieuBanHang]  WITH CHECK ADD  CONSTRAINT [fk_PhieuBanHang_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PhieuBanHang] CHECK CONSTRAINT [fk_PhieuBanHang_KhachHang]
GO
ALTER TABLE [dbo].[PhieuBanHang]  WITH CHECK ADD  CONSTRAINT [fk_PhieuBanHang_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuBanHang] CHECK CONSTRAINT [fk_PhieuBanHang_NhanVien]
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD  CONSTRAINT [fk_PhieuNhapHang_NhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhanCungCap])
GO
ALTER TABLE [dbo].[PhieuNhapHang] CHECK CONSTRAINT [fk_PhieuNhapHang_NhaCungCap]
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD  CONSTRAINT [fk_PhieuNhaphang_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhapHang] CHECK CONSTRAINT [fk_PhieuNhaphang_NhanVien]
GO
ALTER TABLE [dbo].[QL_NguoiDungNhomNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_QLNguoiDungNhomNguoiDung_QLNhomNguoiDung] FOREIGN KEY([MaNhomNguoiDung])
REFERENCES [dbo].[QL_NhomNguoiDung] ([MaNhom])
GO
ALTER TABLE [dbo].[QL_NguoiDungNhomNguoiDung] CHECK CONSTRAINT [FK_QLNguoiDungNhomNguoiDung_QLNhomNguoiDung]
GO
ALTER TABLE [dbo].[QL_NguoiDungNhomNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_QLNguoiDungNhomNguoiDung_TaiKhoan] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[QL_NguoiDungNhomNguoiDung] CHECK CONSTRAINT [FK_QLNguoiDungNhomNguoiDung_TaiKhoan]
GO
ALTER TABLE [dbo].[QL_PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_QLPhanQuyen_DMManHinh] FOREIGN KEY([MaManHinh])
REFERENCES [dbo].[DM_ManHinh] ([MaManHinh])
GO
ALTER TABLE [dbo].[QL_PhanQuyen] CHECK CONSTRAINT [FK_QLPhanQuyen_DMManHinh]
GO
ALTER TABLE [dbo].[QL_PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_QLPhanQuyen_QL_NhomNguoiDung] FOREIGN KEY([MaNhomNguoiDung])
REFERENCES [dbo].[QL_NhomNguoiDung] ([MaNhom])
GO
ALTER TABLE [dbo].[QL_PhanQuyen] CHECK CONSTRAINT [FK_QLPhanQuyen_QL_NhomNguoiDung]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [fk_SanPham_LoaiSanPham] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiSanPham] ([MaLoai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [fk_SanPham_LoaiSanPham]
GO
ALTER TABLE [dbo].[ThongTinChamCong]  WITH CHECK ADD  CONSTRAINT [fk_ThongTinChamCong_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[ThongTinChamCong] CHECK CONSTRAINT [fk_ThongTinChamCong_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [QL_SieuThi] SET  READ_WRITE 
GO
