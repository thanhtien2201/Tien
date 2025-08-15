-- 1. Tạo Database
CREATE DATABASE qlxmshop;
GO

-- 2. Sử dụng Database
USE qlxmshop;
GO

-- 3. Tạo bảng
CREATE TABLE BaoHanh (
    MaBH CHAR(20) NOT NULL PRIMARY KEY,
    MaXe INT NOT NULL,
    TenKH NVARCHAR(100),
    Xe NVARCHAR(20),
    SoKhung INT,
    SoMay INT,
    ThoigianBH CHAR(20)
);
GO

CREATE TABLE Hoa_Don_Thanh_Toan (
    MaNCC CHAR(50) NOT NULL,
    MaNV CHAR(30) NOT NULL,
    MaHD CHAR(50) NOT NULL,
    ThanhTien INT,
    Soluong INT,
    NgayLap DATETIME,
    PRIMARY KEY (MaNCC, MaNV)
);
GO

CREATE TABLE HoaDon_Ban_Xe (
    MaXe INT NOT NULL,
    MaKH CHAR(20) NOT NULL,
    MaNV CHAR(30) NOT NULL,
    MaHD CHAR(50) NOT NULL,
    MauSac NVARCHAR(50),
    DonGia INT,
    NgayLap DATE,
    SoKhung INT,
    SoMay INT,
    PRIMARY KEY (MaXe, MaKH, MaNV)
);
GO

CREATE TABLE KhachHang (
    MaKH CHAR(20) NOT NULL PRIMARY KEY,
    HoTenKh NVARCHAR(100),
    DiaChiKH NVARCHAR(50),
    SDT INT,
    SoCMT INT
);
GO

CREATE TABLE Login (
    UserName CHAR(20),
    PassWord CHAR(20)
);
GO

CREATE TABLE Model_Xe (
    MaDX CHAR(20) NOT NULL PRIMARY KEY,
    MaNCC CHAR(50) NOT NULL,
    TenDX NVARCHAR(50),
    NamSX INT,
    MauDX NVARCHAR(20),
    Soluong INT,
    Gia INT
);
GO

CREATE TABLE Nha_Cung_Cap (
    MaNCC CHAR(50) NOT NULL PRIMARY KEY,
    TenNCC NVARCHAR(50),
    Diachi NVARCHAR(100),
    SDT INT,
    Email CHAR(100)
);
GO

CREATE TABLE Nhan_Vien (
    MaNV CHAR(30) NOT NULL PRIMARY KEY,
    HotenNV NVARCHAR(100),
    SoCMT INT,
    Diachi NVARCHAR(100),
    ChuyenMon NVARCHAR(20),
    Luong INT
);
GO

CREATE TABLE Phieu_Nhap_Hang (
    MaDX CHAR(20) NOT NULL,
    MaNV CHAR(30) NOT NULL,
    MaNCC CHAR(50) NOT NULL,
    MaPhieuNhap CHAR(20) NOT NULL PRIMARY KEY,
    Soluong INT,
    DonGia INT,
    NgayLap CHAR(20),
    TongTien INT
);
GO

CREATE TABLE Xe (
    MaXe INT NOT NULL PRIMARY KEY,
    MaDX CHAR(20) NOT NULL,
    MaNV CHAR(30) NOT NULL,
    MaKH CHAR(20) NOT NULL,
    TenXe NCHAR(20),
    SoKhung INT NOT NULL UNIQUE,
    SoMay INT NOT NULL UNIQUE,
    Mau NVARCHAR(20),
    Gia INT
);
GO

-- 4. Tạo View
GO
CREATE VIEW RPBanXe AS
SELECT 
    Xe.MaXe, Model_Xe.TenDX, Xe.SoKhung, Xe.SoMay, HoaDon_Ban_Xe.MaHD, 
    Xe.MaKH, Model_Xe.NamSX, HoaDon_Ban_Xe.DonGia, HoaDon_Ban_Xe.NgayLap, 
    HoaDon_Ban_Xe.MauSac
FROM HoaDon_Ban_Xe
JOIN Xe ON HoaDon_Ban_Xe.MaXe = Xe.MaXe
CROSS JOIN Model_Xe;
GO

CREATE VIEW v_PhieuNhap AS
SELECT 
    Phieu_Nhap_Hang.MaDX, Phieu_Nhap_Hang.MaNV, Nha_Cung_Cap.TenNCC, 
    Phieu_Nhap_Hang.MaPhieuNhap, Phieu_Nhap_Hang.Soluong
FROM Phieu_Nhap_Hang
JOIN Nha_Cung_Cap ON Phieu_Nhap_Hang.MaNCC = Nha_Cung_Cap.MaNCC;
GO

-- 5. Tạo Index
CREATE INDEX ThuocBH_FK ON BaoHanh(MaXe);
CREATE INDEX Hoa_Don_Thanh_Toan_FK ON Hoa_Don_Thanh_Toan(MaNCC);
CREATE INDEX Hoa_Don_Thanh_Toan2_FK ON Hoa_Don_Thanh_Toan(MaNV);
CREATE INDEX HoaDon_Ban_Xe_FK ON HoaDon_Ban_Xe(MaXe);
CREATE INDEX HoaDon_Ban_Xe2_FK ON HoaDon_Ban_Xe(MaKH);
CREATE INDEX HoaDon_Ban_Xe3_FK ON HoaDon_Ban_Xe(MaNV);
CREATE INDEX ThuocNCCX_FK ON Model_Xe(MaNCC);
CREATE INDEX Phieu_Nhap_Hang_FK ON Phieu_Nhap_Hang(MaDX);
CREATE INDEX Phieu_Nhap_Hang2_FK ON Phieu_Nhap_Hang(MaNV);
CREATE INDEX Phieu_Nhap_Hang3_FK ON Phieu_Nhap_Hang(MaNCC);
CREATE INDEX Ban_FK ON Xe(MaNV);
CREATE INDEX Mua_FK ON Xe(MaKH);
CREATE INDEX Thuoc_FK ON Xe(MaDX);
GO
