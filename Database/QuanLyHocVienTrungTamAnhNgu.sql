Use master
Go
Drop Database QuanLyHocVienTrungTamAnhNgu
Go
Create Database QuanLyHocVienTrungTamAnhNgu
Go
Use QuanLyHocVienTrungTamAnhNgu
Go

Set DateFormat DMY

Create Table HOCVIEN
(
	MaHocVien char(10) primary key,
	TenHocVien nvarchar(30) not null,
	NgaySinh date not null,
	GioiTinh nchar(5) not null,
	NgheNgiep nvarchar(50) not null,
	SoDienThoai varchar(20) not null,
	DiaChi nvarchar(100) not null
)

Create Table CAPLOP
(
	MaCapLop char(10) primary key,
	TenCapLop nchar(20) not null
)

Create Table LOAILOP
(
	MaLoaiLop char(10) primary key,
	TenLoaiLop nchar(20) not null,
	NgayHoc date not null,
	GioHoc time not null
)

Create Table KHOAHOC
(
	MaKhoaHoc char(10) primary key,
	NienHoc int not null,	
	HocKy int not null
)

Create Table LOP
(
	MaLop char(10) primary key,
	MaCapLop char(10) foreign key references CAPLOP(MaCapLop),
	MaLoaiLop char(10) foreign key references LOAILOP(MaLoaiLop),
	MaKhoaHoc char(10) foreign key references KHOAHOC(MaKhoaHoc),
	TenLop nchar(20) not null,
	SiSo int not null 
)

Create Table HOSOHOCVIEN
(
	MaHoSo char(10) primary key,
	MaHocVien char(10) foreign key references HOCVIEN(MaHocVien),
	MaLop char(10) foreign key references LOP(MaLop),
	DiemThi float not null,
	XepLoai nvarchar(50) not null
)

Create Table BIENLAI
(
	MaBienLai char(10) primary key,
	HocPhi float not null,
	MienGiam float
)

Create Table DANGKY
(
	MaDangKy char(10) primary key,
	MaKhoaHoc char(10) foreign key references KHOAHOC(MaKhoaHoc),
	MaLop char(10) foreign key references LOP(MaLop),
	MaHocVien char(10) foreign key references HOCVIEN(MaHocVien),
	MaBienLai char(10) foreign key references BIENLAI(MaBienLai)
)

Create Table KYTHI
(
	MaKyThi char(10) primary key,
	MaKhoaHoc char(10) foreign key references KHOAHOC(MaKhoaHoc),
	NgayThi date not null,
	GioThi time not null
)

Create Table DIEMTHI
(
	MaHocVien char(10) foreign key references HOCVIEN(MaHocVien),
	MaKyThi char(10) foreign key references KYTHI(MaKyThi),
	Diem float not null,
	constraint PK_DIEMTHI primary key (MaHocVien,MaKyThi)
)

Create Table BANGCAP
(
	MaBangCap char(10) primary key,
	TenBangCap nvarchar(30) not null
)

Create Table GIAOVIEN
(
	MaGiaoVien char(10) primary key,
	TenGiaoVien nvarchar(30) not null,
	MaBangCap char(10) foreign key references BANGCAP(MaBangCap),
)

Create Table PHANCONG
(
	MaGiaoVien char(10) foreign key references GIAOVIEN(MaGiaoVien),
	MaLop char(10) foreign key references LOP(MaLop),
	constraint PK_PHANCONG primary key (MaGiaoVien,MaLop)
)