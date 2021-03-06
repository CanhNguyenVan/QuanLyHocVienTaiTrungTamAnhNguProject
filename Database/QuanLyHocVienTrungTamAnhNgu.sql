﻿Use master
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
	MaHocVien nvarchar(10) primary key,
	TenHocVien nvarchar(30) not null,
	NgaySinh date not null,
	GioiTinh nvarchar(5) not null,
	NgheNghiep nvarchar(50) not null,
	SoDienThoai nvarchar(20) not null,
	DiaChi nvarchar(100) not null
)

Create Table CAPLOP
(
	MaCapLop nvarchar(10) primary key,
	TenCapLop nvarchar(20) not null
)

Create Table LOAILOP
(
	MaLoaiLop nvarchar(10) primary key,
	TenLoaiLop nvarchar(20) not null,
	NgayHoc date not null,
	GioHoc time not null
)

Create Table KHOAHOC
(
	MaKhoaHoc nvarchar(10) primary key,
	NienHoc int not null,	
	HocKy int not null
)

Create Table LOP
(
	MaLop nvarchar(10) primary key,
	MaCapLop nvarchar(10) foreign key references CAPLOP(MaCapLop),
	MaLoaiLop nvarchar(10) foreign key references LOAILOP(MaLoaiLop),
	MaKhoaHoc nvarchar(10) foreign key references KHOAHOC(MaKhoaHoc),
	TenLop nvarchar(20) not null,
	SiSo int not null 
)

Create Table HOSOHOCVIEN
(
	MaHoSo nvarchar(10) primary key,
	MaHocVien nvarchar(10) foreign key references HOCVIEN(MaHocVien),
	MaLop nvarchar(10) foreign key references LOP(MaLop),
	DiemThi float not null,
	XepLoai nvarchar(50) not null
)

Create Table BIENLAI
(
	MaBienLai nvarchar(10) primary key,
	HocPhi decimal not null,
	MienGiam decimal
)

Create Table DANGKY
(
	MaDangKy nvarchar(10) primary key,
	MaKhoaHoc nvarchar(10) foreign key references KHOAHOC(MaKhoaHoc),
	MaLop nvarchar(10) foreign key references LOP(MaLop),
	MaHocVien nvarchar(10) foreign key references HOCVIEN(MaHocVien),
	MaBienLai nvarchar(10) foreign key references BIENLAI(MaBienLai)
)

Create Table KYTHI
(
	MaKyThi nvarchar(10) primary key,
	MaKhoaHoc nvarchar(10) foreign key references KHOAHOC(MaKhoaHoc),
	NgayThi date not null,
	GioThi time not null
)

Create Table DIEMTHI
(
	MaHocVien nvarchar(10) foreign key references HOCVIEN(MaHocVien),
	MaKyThi nvarchar(10) foreign key references KYTHI(MaKyThi),
	Diem float not null,
	constraint PK_DIEMTHI primary key (MaHocVien,MaKyThi)
)

Create Table BANGCAP
(
	MaBangCap nvarchar(10) primary key,
	TenBangCap nvarchar(30) not null
)

Create Table GIAOVIEN
(
	MaGiaoVien nvarchar(10) primary key,
	TenGiaoVien nvarchar(30) not null,
	MaBangCap nvarchar(10) foreign key references BANGCAP(MaBangCap),
)

Create Table PHANCONG
(
	MaGiaoVien nvarchar(10) foreign key references GIAOVIEN(MaGiaoVien),
	MaLop nvarchar(10) foreign key references LOP(MaLop),
	constraint PK_PHANCONG primary key (MaGiaoVien,MaLop)
)

Create Table TAIKHOAN
(
	MaTK int primary key,
	TenTK nvarchar(30) not null,
	MatKhau nvarchar(30) not null,
	LoaiTK int
)

GO

--Select All--
---
CREATE PROCEDURE BangCap_SelectAll
AS
BEGIN
	select * from BANGCAP
END
GO

---
CREATE PROCEDURE BienLai_SelectAll
AS
BEGIN
	select * from BIENLAI
END
GO

---
CREATE PROCEDURE CapLop_SelectAll
AS
BEGIN
	select * from CAPLOP
END
GO

---
CREATE PROCEDURE DangKy_SelectAll
AS
BEGIN
	select * from DANGKY
END
GO

---
CREATE PROCEDURE DiemThi_SelectAll
AS
BEGIN
	select * from DIEMTHI
END
GO

---
CREATE PROCEDURE GiaoVien_SelectAll
AS
BEGIN
	select * from GIAOVIEN
END
GO

---
CREATE PROCEDURE HocVien_SelectAll
AS
BEGIN
	select * from HOCVIEN
END
GO

---
CREATE PROCEDURE HoSoHocVien_SelectAll
AS
BEGIN
	select * from HOSOHOCVIEN
END
GO

---
CREATE PROCEDURE KhoaHoc_SelectAll
AS
BEGIN
	select * from KHOAHOC
END
GO

---
CREATE PROCEDURE KyThi_SelectAll
AS
BEGIN
	select * from KYTHI
END
GO

---
CREATE PROCEDURE LoaiLop_SelectAll
AS
BEGIN
	select * from LOAILOP
END
GO

---
CREATE PROCEDURE Lop_SelectAll
AS
BEGIN
	select * from LOP
END
GO

---
CREATE PROCEDURE PhanCong_SelectAll
AS
BEGIN
	select * from PHANCONG
END
GO

--Select By Id--
---
CREATE PROCEDURE BangCap_SelectById
@MaBangCap nvarchar(10)
AS
BEGIN
	select * from BANGCAP where MaBangCap = @MaBangCap
END
GO

---
CREATE PROCEDURE BienLai_SelectById
@MaBienLai nvarchar(10)
AS
BEGIN
	select * from BIENLAI where MaBienLai = @MaBienLai
END
GO

---
CREATE PROCEDURE CapLop_SelectById
@MaCapLop nvarchar(10)
AS
BEGIN
	select * from CAPLOP where MaCapLop = @MaCapLop
END
GO

---
CREATE PROCEDURE DangKy_SelectById
@MaDangKy nvarchar(10)
AS
BEGIN
	select * from DANGKY where MaDangKy = @MaDangKy
END
GO

---
CREATE PROCEDURE DiemThi_SelectById
@MaHocVien nvarchar(10),
@MaKyThi nvarchar(10)
AS
BEGIN
	select * from DIEMTHI where (MaHocVien = @MaHocVien and MaKyThi = @MaKyThi)
END
GO

---
CREATE PROCEDURE GiaoVien_SelectById
@MaGiaoVien nvarchar(10)
AS
BEGIN
	select * from GIAOVIEN where MaGiaoVien = @MaGiaoVien
END
GO

---
CREATE PROCEDURE HocVien_SelectById
@MaHocVien nvarchar(10)
AS
BEGIN
	select * from HOCVIEN where MaHocVien = @MaHocVien
END
GO

---
CREATE PROCEDURE HoSoHocVien_SelectById
@MaHoSo nvarchar(10)
AS
BEGIN
	select * from HOSOHOCVIEN where MaHoSo = @MaHoSo
END
GO

---
CREATE PROCEDURE KhoaHoc_SelectById
@MaKhoaHoc nvarchar(10)
AS
BEGIN
	select * from KHOAHOC where MaKhoaHoc = @MaKhoaHoc
END
GO

---
CREATE PROCEDURE KyThi_SelectById
@MaKyThi nvarchar(10)
AS
BEGIN
	select * from KYTHI where MaKyThi = @MaKyThi
END
GO

---
CREATE PROCEDURE LoaiLop_SelectById
@MaLoaiLop nvarchar(10)
AS
BEGIN
	select * from LOAILOP where MaLoaiLop = @MaLoaiLop
END
GO

---
CREATE PROCEDURE Lop_SelectById
@MaLop nvarchar(10)
AS
BEGIN
	select * from LOP where MaLop = @MaLop
END
GO

---
CREATE PROCEDURE PhanCong_SelectById
@MaGiaoVien nvarchar(10),
@MaLop nvarchar(10)
AS
BEGIN
	select * from PHANCONG where (MaGiaoVien = @MaGiaoVien and MaLop = @MaLop)
END
GO

--Insert--
---
CREATE PROCEDURE BangCap_Insert
@MaBangCap nvarchar(10),
@TenBangCap nvarchar(30)
AS
BEGIN
	insert into BANGCAP (MaBangCap, TenBangCap)
	values (@MaBangCap, @TenBangCap)
END
GO

---
CREATE PROCEDURE BienLai_Insert
@MaBienLai nvarchar(10),
@HocPhi float,
@MienGiam float
AS
BEGIN
	insert into BIENLAI (MaBienLai, HocPhi, MienGiam)
	values (@MaBienLai, @HocPhi, @MienGiam)
END
GO

---
CREATE PROCEDURE CapLop_Insert
@MaCapLop nvarchar(10),
@TenCapLop nvarchar(20)
AS
BEGIN
	insert into CAPLOP (MaCapLop, TenCapLop)
	values (@MaCapLop, @TenCapLop)
END
GO

---
CREATE PROCEDURE DangKy_Insert
@MaDangKy nvarchar(10),
@MaKhoaHoc nvarchar(10),
@MaLop nvarchar(10),
@MaHocVien nvarchar(10),
@MaBienLai nvarchar(10)
AS
BEGIN
	insert into DANGKY (MaDangKy, MaKhoaHoc, MaLop, MaHocVien, MaBienLai)
	values (@MaDangKy, @MaKhoaHoc, @MaLop, @MaHocVien, @MaBienLai)
END
GO

---
CREATE PROCEDURE DiemThi_Insert
@MaHocVien nvarchar(10),
@MaKyThi nvarchar(10),
@Diem float
AS
BEGIN
	insert into DIEMTHI (MaHocVien, MaKyThi, Diem)
	values (@MaHocVien, @MaKyThi, @Diem)
END
GO

---
CREATE PROCEDURE GiaoVien_Insert
@MaGiaoVien nvarchar(10),
@TenGiaoVien nvarchar(30),
@MaBangCap nvarchar(10)
AS
BEGIN
	insert into GiaoVien (MaGiaoVien, TenGiaoVien, MaBangCap)
	values (@MaGiaoVien, @TenGiaoVien, @MaBangCap)
END
GO

---
CREATE PROCEDURE HocVien_Insert
@MaHocVien nvarchar(10),
@TenHocVien nvarchar(30),
@NgaySinh date,
@GioiTinh nvarchar(5),
@NgheNghiep nvarchar(50),
@SoDienThoai nvarchar(20),
@DiaChi nvarchar(100)
AS
BEGIN
	insert into HOCVIEN (MaHocVien, TenHocVien, NgaySinh, GioiTinh,NgheNghiep, SoDienThoai, DiaChi)
	values (@MaHocVien, @TenHocVien, @NgaySinh, @GioiTinh,@NgheNghiep, @SoDienThoai, @DiaChi)
END
GO

---
CREATE PROCEDURE HoSoHocVien_Insert
@MaHoSo nvarchar(10),
@MaHocVien nvarchar(10),
@MaLop nvarchar(10),
@DiemThi float,
@XepLoai nvarchar(50)
AS
BEGIN
	insert into HOSOHOCVIEN (MaHoSo, MaHocVien, MaLop, DiemThi, XepLoai)
	values (@MaHoSo, @MaHocVien, @MaLop, @DiemThi, @XepLoai)
END
GO

---
CREATE PROCEDURE KhoaHoc_Insert
@MaKhoaHoc nvarchar(10),
@NienHoc int,
@HocKy int
AS
BEGIN
	insert into KHOAHOC (MaKhoaHoc, NienHoc, HocKy)
	values (@MaKhoaHoc, @NienHoc, @HocKy)
END
GO

---
CREATE PROCEDURE KyThi_Insert
@MaKyThi nvarchar(10),
@MaKhoaHoc nvarchar(10),
@NgayThi date,
@GioThi time(7)
AS
BEGIN
	insert into KYTHI (MaKyThi, MaKhoaHoc, NgayThi, GioThi)
	values (@MaKyThi, @MaKhoaHoc, @NgayThi, @GioThi)
END
GO

---
CREATE PROCEDURE LoaiLop_Insert
@MaLoaiLop nvarchar(10),
@TenLoaiLop nvarchar(20),
@NgayHoc date,
@GioHoc time(7)
AS
BEGIN
	insert into LOAILOP (MaLoaiLop, TenLoaiLop, NgayHoc, GioHoc)
	values (@MaLoaiLop, @TenLoaiLop, @NgayHoc, @GioHoc)
END
GO

---
CREATE PROCEDURE Lop_Insert
@MaLop nvarchar(10),
@MaCapLop nvarchar(10),
@MaLoaiLop nvarchar(10),
@MaKhoaHoc nvarchar(10),
@TenLop nvarchar(20),
@SiSo int
AS 
BEGIN
	insert into LOP (MaLop, MaCapLop, MaLoaiLop, MaKhoaHoc, TenLop, SiSo)
	values (@MaLop, @MaCapLop, @MaLoaiLop, @MaKhoaHoc, @TenLop, @SiSo)
END
GO

---
CREATE PROCEDURE PhanCong_Insert
@MaGiaoVien nvarchar(10),
@MaLop nvarchar(10)
AS 
BEGIN
	insert into PHANCONG (MaGiaoVien, MaLop)
	values (@MaGiaoVien, @MaLop)
END
GO

--Update--
---
CREATE PROCEDURE BangCap_Update
@MaBangCap nvarchar(10),
@TenBangCap nvarchar(30)
AS
BEGIN
	update BANGCAP
	set
		TenBangCap = @TenBangCap
	where MaBangCap = @MaBangCap
END
GO

---
CREATE PROCEDURE BienLai_Update
@MaBienLai nvarchar(10),
@HocPhi float,
@MienGiam float
AS
BEGIN
	update BIENLAI
	set
		HocPhi = @HocPhi,
		MienGiam = @MienGiam
	where MaBienLai = @MaBienLai
END
GO

---
CREATE PROCEDURE CapLop_Update
@MaCapLop nvarchar(10),
@TenCapLop nvarchar(20)
AS
BEGIN
	update CAPLOP
	set
		TenCapLop = @TenCapLop
	where MaCapLop = @MaCapLop
END
GO

---
CREATE PROCEDURE DangKy_Update
@MaDangKy nvarchar(10),
@MaKhoaHoc nvarchar(10),
@MaLop nvarchar(10),
@MaHocVien nvarchar(10),
@MaBienLai nvarchar(10)
AS
BEGIN
	update DANGKY
	set
		MaKhoaHoc = @MaKhoaHoc,
		MaLop = @MaLop,
		MaHocVien = @MaHocVien,
		MaBienLai = @MaBienLai
	where MaDangKy = @MaDangKy
END
GO

---
CREATE PROCEDURE DiemThi_Update
@MaHocVien nvarchar(10),
@MaKyThi nvarchar(10),
@Diem float
AS
BEGIN
	update DIEMTHI
	set
		Diem = @Diem
	where (MaHocVien = @MaHocVien and MaKyThi = @MaKyThi)
END
GO

---
CREATE PROCEDURE GiaoVien_Update
@MaGiaoVien nvarchar(10),
@TenGiaoVien nvarchar(30),
@MaBangCap nvarchar(10)
AS
BEGIN
	update GIAOVIEN
	set
		TenGiaoVien = @TenGiaoVien,
		MaBangCap = @MaBangCap
	where MaGiaoVien = @MaGiaoVien
END
GO

---
CREATE PROCEDURE HocVien_Update
@MaHocVien nvarchar(10),
@TenHocVien nvarchar(30),
@NgaySinh date,
@GioiTinh nvarchar(5),
@NgheNghiep nvarchar(50),
@SoDienThoai nvarchar(20),
@DiaChi nvarchar(100)
AS
BEGIN
	update HOCVIEN
	set
		TenHocVien = @TenHocVien,
		NgaySinh = @NgaySinh,
		GioiTinh = @GioiTinh,
		NgheNghiep = @NgheNghiep,
		SoDienThoai = @SoDienThoai,
		DiaChi = @DiaChi
	where MaHocVien = @MaHocVien
END
GO

---
CREATE PROCEDURE HoSoHocVien_Update
@MaHoSo nvarchar(10),
@MaHocVien nvarchar(10),
@MaLop nvarchar(10),
@DiemThi float,
@XepLoai nvarchar(50)
AS
BEGIN
	update HOSOHOCVIEN
	set
		MaHocVien = @MaHocVien,
		MaLop = @MaLop,
		DiemThi = @DiemThi,
		XepLoai = @XepLoai
	where MaHoSo = @MaHoSo
END
GO

---
CREATE PROCEDURE KhoaHoc_Update
@MaKhoaHoc nvarchar(10),
@NienHoc int,
@HocKy int
AS
BEGIN
	update KHOAHOC
	set
		MaKhoaHoc = @MaKhoaHoc,
		NienHoc = @NienHoc,
		HocKy = HocKy
	where MaKhoaHoc = @MaKhoaHoc
END
GO

---
CREATE PROCEDURE KyThi_Update
@MaKyThi nvarchar(10),
@MaKhoaHoc nvarchar(10),
@NgayThi date,
@GioThi time(7)
AS
BEGIN
	update KYTHI
	set
		MaKhoaHoc = @MaKhoaHoc,
		NgayThi = @NgayThi,
		GioThi = @GioThi
	where MaKyThi = @MaKyThi
END
GO

---
CREATE PROCEDURE LoaiLop_Update
@MaLoaiLop nvarchar(10),
@TenLoaiLop nvarchar(20),
@NgayHoc date,
@GioHoc time(7)
AS
BEGIN
	update LOAILOP
	set
		TenLoaiLop = @TenLoaiLop,
		NgayHoc = @NgayHoc,
		GioHoc = @GioHoc
	where MaLoaiLop = @MaLoaiLop
END
GO

---
CREATE PROCEDURE Lop_Update
@MaLop nvarchar(10),
@MaCapLop nvarchar(10),
@MaLoaiLop nvarchar(10),
@MaKhoaHoc nvarchar(10),
@TenLop nvarchar(20),
@SiSo int
AS 
BEGIN
	update LOP
	set
		MaCapLop = @MaCapLop,
		MaLoaiLop = @MaLoaiLop,
		MaKhoaHoc = @MaKhoaHoc,
		TenLop = @TenLop,
		SiSo = @SiSo
	where MaLop = @MaLop
END
GO

---
CREATE PROCEDURE PhanCong_Update
@MaGiaoVien nvarchar(10),
@MaLop nvarchar(10)
AS 
BEGIN
	update PHANCONG
	set
		MaGiaoVien = @MaGiaoVien,
		MaLop = @MaLop
END
GO

--Delete--
---
CREATE PROCEDURE BangCap_Delete
@MaBangCap nvarchar(10)
AS
BEGIN
	delete from BANGCAP where MaBangCap = @MaBangCap
END
GO

---
CREATE PROCEDURE BienLai_Delete
@MaBienLai nvarchar(10)
AS
BEGIN
	delete from BIENLAI where MaBienLai = @MaBienLai
END
GO

---
CREATE PROCEDURE CapLop_Delete
@MaCapLop nvarchar(10)
AS
BEGIN
	delete from CAPLOP where MaCapLop = @MaCapLop
END
GO

---
CREATE PROCEDURE DangKy_Delete
@MaDangKy nvarchar(10)
AS
BEGIN
	delete from DANGKY where MaDangKy = @MaDangKy
END
GO

---
CREATE PROCEDURE DiemThi_Delete
@MaHocVien nvarchar(10),
@MaKyThi nvarchar(10)
AS
BEGIN
	delete from DIEMTHI where (MaHocVien = @MaHocVien and MaKyThi = @MaKyThi)
END
GO

---
CREATE PROCEDURE GiaoVien_Delete
@MaGiaoVien nvarchar(10)
AS
BEGIN
	delete from GIAOVIEN where MaGiaoVien = @MaGiaoVien
END
GO

---
CREATE PROCEDURE HocVien_Delete
@MaHocVien nvarchar(10)
AS
BEGIN
	delete from HOCVIEN where MaHocVien = @MaHocVien
END
GO

---
CREATE PROCEDURE HoSoHocVien_Delete
@MaHoSo nvarchar(10)
AS
BEGIN
	delete from HOSOHOCVIEN where MaHoSo = @MaHoSo
END
GO

---
CREATE PROCEDURE KhoaHoc_Delete
@MaKhoaHoc nvarchar(10)
AS
BEGIN
	delete from KHOAHOC where MaKhoaHoc = @MaKhoaHoc
END
GO

---
CREATE PROCEDURE KyThi_Delete
@MaKyThi nvarchar(10)
AS
BEGIN
	delete from KYTHI where MaKyThi = @MaKyThi
END
GO

---
CREATE PROCEDURE LoaiLop_Delete
@MaLoaiLop nvarchar(10)
AS
BEGIN
	delete from LOAILOP where MaLoaiLop = @MaLoaiLop
END
GO

---
CREATE PROCEDURE Lop_Delete
@MaLop nvarchar(10)
AS
BEGIN
	delete from LOP where MaLop = @MaLop
END
GO

---
CREATE PROCEDURE PhanCong_Delete
@MaGiaoVien nvarchar(10),
@MaLop nvarchar(10)
AS
BEGIN
	delete from PHANCONG where (MaGiaoVien = @MaGiaoVien and MaLop = @MaLop)
END
GO

CREATE PROCEDURE TaiKhoan_Delete
@MaTK int
AS

SET NOCOUNT ON

DELETE FROM TAIKHOAN
WHERE
	MaTK = @MaTK

Go

CREATE PROCEDURE TaiKhoan_Insert
	@MaTK int, @TenTK nvarchar(30), @MatKhau nvarchar(30), @LoaiTK int
AS

SET NOCOUNT ON

INSERT INTO TAIKHOAN
VALUES (@MaTK, @TenTK, @MatKhau, @LoaiTK)

Go

CREATE PROCEDURE TaiKhoan_SelectLastMaTK
AS

SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ COMMITTED

SELECT TOP 1 MaTK
FROM	TAIKHOAN
ORDER BY 
	MaTK DESC

Go

CREATE PROCEDURE TaiKhoan_SelectAll
AS

SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
BEGIN
SELECT  *
FROM
	TAIKHOAN
END

Go

CREATE PROCEDURE TaiKhoan_Update
	@MaTK int, @TenTK nvarchar(30), @MatKhau nvarchar(30), @LoaiTK int
AS

SET NOCOUNT ON

UPDATE TAIKHOAN SET
	
	TenTK = @TenTK,
	MatKhau=@MatKhau,
	LoaiTK=@LoaiTK
WHERE
	MaTK = @MaTK

Go

CREATE PROCEDURE TraCuuHocVienTheoMa
	@MaHocVien nvarchar(10)
AS
BEGIN
	SELECT a.MaHocVien, TenHocVien, NgaySinh, GioiTinh, TenLop, TenLoaiLop, TenCapLop, DiemThi, XepLoai
	FROM HOSOHOCVIEN a, LOP, HOCVIEN, LOAILOP, CAPLOP
	WHERE a.MaHocVien = @MaHocVien AND A.MaHocVien = HOCVIEN.MaHocVien AND A.MaLop = LOP.MaLop
	AND LOP.MaCapLop = CAPLOP.MaCapLop AND LOP.MaLoaiLop = LOAILOP.MaLoaiLop
END
GO

CREATE PROCEDURE TraCuuHocVien
AS
BEGIN
	SELECT a.MaHocVien, TenHocVien, NgaySinh, GioiTinh, TenLop, TenLoaiLop, TenCapLop, DiemThi, XepLoai
	FROM HOSOHOCVIEN a, LOP, HOCVIEN, LOAILOP, CAPLOP
	WHERE A.MaHocVien = HOCVIEN.MaHocVien AND A.MaLop = LOP.MaLop
	AND LOP.MaCapLop = CAPLOP.MaCapLop AND LOP.MaLoaiLop = LOAILOP.MaLoaiLop
END
GO

CREATE PROCEDURE TraCuuLop
AS
BEGIN
	SELECT MaLop, TenLop, TenLoaiLop, TenCapLop, NgayHoc, GioHoc, SiSo
	FROM LOP, LOAILOP, CAPLOP
	WHERE LOP.MaCapLop = CAPLOP.MaCapLop AND LOAILOP.MaLoaiLop = LOP.MaLoaiLop 
END
GO

CREATE PROCEDURE TraCuuLopTheoMa
	@MaLop nvarchar(10)
AS
BEGIN
	SELECT MaLop, TenLop, TenLoaiLop, TenCapLop, NgayHoc, GioHoc, SiSo
	FROM LOP, LOAILOP, CAPLOP
	WHERE LOP.MaLop = @MaLop AND LOP.MaCapLop = CAPLOP.MaCapLop AND LOAILOP.MaLoaiLop = LOP.MaLoaiLop 
END
GO

CREATE PROCEDURE TraCuuTKB
AS
BEGIN
	SELECT LOP.MaLop, TenLop, TenLoaiLop, TenCapLop, NgayHoc, GioHoc, GIAOVIEN.TenGiaoVien
	FROM LOP, LOAILOP, CAPLOP, GIAOVIEN, PHANCONG
	WHERE LOP.MaLop = PHANCONG.MaLop and GIAOVIEN.MaGiaoVien = PHANCONG.MaGiaoVien and 
	LOP.MaCapLop = CAPLOP.MaCapLop and LOP.MaLoaiLop = LOAILOP.MaLoaiLop
END
GO

CREATE PROCEDURE TraCuuTKBTheoMa
	@MaLop nvarchar(10)
AS
BEGIN
	SELECT LOP.MaLop, TenLop, TenLoaiLop, TenCapLop, NgayHoc, GioHoc, GIAOVIEN.TenGiaoVien
	FROM LOP, LOAILOP, CAPLOP, GIAOVIEN, PHANCONG
	WHERE LOP.MaLop = PHANCONG.MaLop and GIAOVIEN.MaGiaoVien = PHANCONG.MaGiaoVien and 
	LOP.MaCapLop = CAPLOP.MaCapLop and LOP.MaLoaiLop = LOAILOP.MaLoaiLop and LOP.MaLop = @MaLop
END
GO

---
CREATE PROCEDURE BaoCao_Lop
AS
BEGIN
	select LOP.MaLop, LOP.TenLop, LOP.SiSo, A.DaDangKy
	from LOP, (select HOSOHOCVIEN.MaLop, Count(HOSOHOCVIEN.MaLop) DaDangKy
				from HOSOHOCVIEN
				group by HOSOHOCVIEN.MaLop) A
	where LOP.MaLop = A.MaLop
END
GO

--
CREATE PROCEDURE BaoCao_HocVien
AS
BEGIN
	select h.MaHocVien, s.TenHocVien, l.TenLop , h.DiemThi, h.XepLoai
	from HOSOHOCVIEN h, HOCVIEN s, LOP l
	where h.MaHocVien = s.MaHocVien and h.MaLop = l.MaLop
END
GO

--
Create Procedure BaoCao_DoanhThu
As
Begin
Select k.NienHoc, k.HocKy, (sum(b.HocPhi)-SUM(b.MienGiam))as DoanhThu
	From DANGKY d, BIENLAI b, KHOAHOC k
	Where d.MaBienLai=b.MaBienLai and d.MaKhoaHoc = k.MaKhoaHoc
	Group by k.HocKy, k.NienHoc
End

Go

--
Create Procedure SelectAllNienHoc
AS
Begin
	Select distinct NienHoc
	From KHOAHOC
End

Go
insert into BANGCAP (MaBangCap, TenBangCap) values ('BC1', N'Thạc Sĩ')
insert into BANGCAP (MaBangCap, TenBangCap) values ('BC2', N'Tiến Sĩ')
insert into BANGCAP (MaBangCap, TenBangCap) values ('BC3', N'Cử Nhân')

---
insert into BIENLAI (MaBienLai, HocPhi, MienGiam) values ('BL1', 400000, 50000)
insert into BIENLAI (MaBienLai, HocPhi, MienGiam) values ('BL2', 500000, 0)
insert into BIENLAI (MaBienLai, HocPhi, MienGiam) values ('BL3', 600000, 100000)

---
insert into CAPLOP (MaCapLop, TenCapLop) values ('CL1', N'Cấp 1')
insert into CAPLOP (MaCapLop, TenCapLop) values ('CL2', N'Cấp 2')
insert into CAPLOP (MaCapLop, TenCapLop) values ('CL3', N'Cấp 3')

---
insert into KHOAHOC (MaKhoaHoc, NienHoc, HocKy) values ('KH1', 2014, 3)
insert into KHOAHOC (MaKhoaHoc, NienHoc, HocKy) values ('KH2', 2014, 4)
insert into KHOAHOC (MaKhoaHoc, NienHoc, HocKy) values ('KH3', 2015, 1)
insert into KHOAHOC (MaKhoaHoc, NienHoc, HocKy) values ('KH4', 2015, 2)
insert into KHOAHOC (MaKhoaHoc, NienHoc, HocKy) values ('KH5', 2015, 3)

---
insert into HOCVIEN(MaHocVien, TenHocVien, NgaySinh, GioiTinh, NgheNghiep , SoDienThoai, DiaChi) values ('HV1', N'Nguyễn Văn A', '14/2/1994', N'Nam',N'Sinh viên', '0987654321', N'Thủ Đức')
insert into HOCVIEN(MaHocVien, TenHocVien, NgaySinh, GioiTinh, NgheNghiep , SoDienThoai, DiaChi) values ('HV2', N'Phan Thị B', '15/3/1997', N'Nữ',N'Học Sinh', '01678954321', N'Quận 1')
insert into HOCVIEN(MaHocVien, TenHocVien, NgaySinh, GioiTinh, NgheNghiep , SoDienThoai, DiaChi) values ('HV3', N'Trần Thanh C', '2/1/1989', N'Nam',N'CNVC', '0988888888', N'Quận Bình Tân')
insert into HOCVIEN(MaHocVien, TenHocVien, NgaySinh, GioiTinh, NgheNghiep , SoDienThoai, DiaChi) values ('HV4', N'Lung Thị Linh', '7/6/1993', N'Nữ',N'Sinh viên', '0987654321', N'Quận 9')

---
insert into GiaoVien (MaGiaoVien, TenGiaoVien, MaBangCap) values ('GV1', N'Nguyễn Văn Cảnh', 'BC2')
insert into GiaoVien (MaGiaoVien, TenGiaoVien, MaBangCap) values ('GV2', N'Nguyễn Sỹ Mạnh Cường', 'BC1')
insert into GiaoVien (MaGiaoVien, TenGiaoVien, MaBangCap) values ('GV3', N'Lê Tuấn Anh', 'BC3')

---
insert into LOAILOP (MaLoaiLop, TenLoaiLop, NgayHoc, GioHoc) values ('LL1', N'Tổng quát', '20/6/2015', '7:30')
insert into LOAILOP (MaLoaiLop, TenLoaiLop, NgayHoc, GioHoc) values ('LL2', N'Giao tiếp', '25/6/2015', '9:30')
insert into LOAILOP (MaLoaiLop, TenLoaiLop, NgayHoc, GioHoc) values ('LL3', N'IELTS', '1/7/2015', '13:30')

---
insert into LOP (MaLop, MaCapLop, MaLoaiLop, MaKhoaHoc, TenLop, SiSo) values ('L1', 'CL2', 'LL1', 'KH4', N'Lớp 1', 50)
insert into LOP (MaLop, MaCapLop, MaLoaiLop, MaKhoaHoc, TenLop, SiSo) values ('L2', 'CL1', 'LL3', 'KH2', N'Lớp 2', 45)
insert into LOP (MaLop, MaCapLop, MaLoaiLop, MaKhoaHoc, TenLop, SiSo) values ('L3', 'CL3', 'LL2', 'KH1', N'Lớp 3', 55)

---
insert into PHANCONG (MaGiaoVien, MaLop) values ('GV1', 'L2')
insert into PHANCONG (MaGiaoVien, MaLop) values ('GV2', 'L3')
insert into PHANCONG (MaGiaoVien, MaLop) values ('GV3', 'L1')

---
insert into KYTHI (MaKyThi, MaKhoaHoc, NgayThi, GioThi) values ('KT1', 'KH1', '3/10/2015', '7:30')
insert into KYTHI (MaKyThi, MaKhoaHoc, NgayThi, GioThi) values ('KT2', 'KH2', '6/10/2015', '7:30')
insert into KYTHI (MaKyThi, MaKhoaHoc, NgayThi, GioThi) values ('KT3', 'KH3', '9/10/2015', '7:30')

---
insert into DANGKY (MaDangKy, MaKhoaHoc, MaLop, MaHocVien, MaBienLai) values ('DK1', 'KH1', 'L1', 'HV1', 'BL1')
insert into DANGKY (MaDangKy, MaKhoaHoc, MaLop, MaHocVien, MaBienLai) values ('DK2', 'KH3', 'L2', 'HV3', 'BL3')
insert into DANGKY (MaDangKy, MaKhoaHoc, MaLop, MaHocVien, MaBienLai) values ('DK3', 'KH2', 'L1', 'HV4', 'BL2')
insert into DANGKY (MaDangKy, MaKhoaHoc, MaLop, MaHocVien, MaBienLai) values ('DK4', 'KH2', 'L3', 'HV2', 'BL2')

---
insert into DIEMTHI (MaHocVien, MaKyThi, Diem) values ('HV1', 'KT1', 8.5)
insert into DIEMTHI (MaHocVien, MaKyThi, Diem) values ('HV2', 'KT2', 6)
insert into DIEMTHI (MaHocVien, MaKyThi, Diem) values ('HV3', 'KT3', 7.5)
insert into DIEMTHI (MaHocVien, MaKyThi, Diem) values ('HV4', 'KT2', 9)

---
insert into HOSOHOCVIEN (MaHoSo, MaHocVien, MaLop, DiemThi, XepLoai) values ('HS1', 'HV1', 'L1', 8.5, N'Khá')
insert into HOSOHOCVIEN (MaHoSo, MaHocVien, MaLop, DiemThi, XepLoai) values ('HS2', 'HV2', 'L3', 6, N'Trung bình')
insert into HOSOHOCVIEN (MaHoSo, MaHocVien, MaLop, DiemThi, XepLoai) values ('HS3', 'HV3', 'L2', 7.5, N'Khá')
insert into HOSOHOCVIEN (MaHoSo, MaHocVien, MaLop, DiemThi, XepLoai) values ('HS4', 'HV4', 'L1', 9, N'Giỏi')

insert into TAIKHOAN values(1,'Admin','123456',1)
insert into TAIKHOAN values(2,'NhanVien','123456',2)
insert into TAIKHOAN values(3,'GiaoVien','123456',3)