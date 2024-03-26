create database QUANLYSV
go

use QUANLYSV
go 

create table TAIKHOAN(
	TenDangNhap nvarchar(20) primary key,
	MatKhau nvarchar(20),
	VaiTro nvarchar(20)
)
 

create table KHOA(
	MaKhoa nvarchar(20) primary key,
	TenKhoa nvarchar(100)
)
create table NGANH(
	MaNganh nvarchar(20) primary key,
	TenNganh nvarchar(100),
	MaKhoa nvarchar(20),
constraint NganhThuocKhoa foreign key(MaKhoa) references KHOA(MaKhoa) on delete set null on update cascade
)


create table VIPHAM(
	MaVP nvarchar(10) primary key,
	NoiDung nvarchar(100)
)


create table GIANGVIEN(
	MaGV nvarchar(20) primary key,
	HoTenGV nvarchar(100),
	MaKhoa nvarchar(20),
	constraint TaiKhoanGV foreign key(MaGV) references TAIKHOAN(TenDangNhap) on delete cascade,
	constraint GVThuocKhoa foreign key(MaKhoa) references KHOA(MaKhoa)
)

create table QUANLY(
	MaQL nvarchar(20) primary key,
	TenNQL nvarchar(100)
	constraint TaiKhoanQL foreign key(MaQL) references TAIKHOAN(TenDangNhap) on delete cascade
)



create table CTDAOTAO(
	MaCTDT nvarchar(20) primary key,
	TenCTDT nvarchar(50),
	HinhThucDT nvarchar(50),
	NgonNguDT nvarchar(50),
	TrinhDoDaoTao nvarchar(50)
)

create table LOP(
	MaLop nvarchar(20) primary key,
	TenLop nvarchar(50),
	MaNganh nvarchar(20),
	MaCTDT nvarchar(20),
	constraint LopThuocNganh foreign key(MaNganh) references NGANH(MaNganh) on delete set null on update cascade,
	constraint LopThuocCTDT foreign key(MaCTDT) references CTDAOTAO(MaCTDT) on delete set null on update cascade
)

create table SINHVIEN(
	MaSV nvarchar(20) primary key,
	HoTenSV nvarchar(100),
	GioiTinh nvarchar(3),
	NgaySinh date, 
	MaLop nvarchar(20),
	TinhTrangVP nvarchar(10),
	constraint SVThuocLop foreign key(MaLop) references LOP(MaLop) on delete set null on update cascade,
	constraint SVViPham foreign key(TinhTrangVP) references VIPHAM(MaVP) on update cascade,
	constraint TaiKhoanSV foreign key(MaSV) references TAIKHOAN(TenDangNhap) on delete cascade
)


create table MONHOC(
	MaMH nvarchar(20) primary key,
	TenMH nvarchar(100),
	SoTinChi int
)

create table MONHOC_DAOTAO(
	MaMHDT nvarchar(20) primary key,
	MaMH nvarchar(20),
	MaCTDT nvarchar(20),
	MaNganh nvarchar(20),
	constraint CuaMonHoc foreign key(MaMH) references MONHOC(MaMH) on delete cascade,
	constraint CuaCTDT foreign key(MaCTDT) references CTDAOTAO(MaCTDT) on delete cascade,
	constraint CuaNganh foreign key(MaNganh) references Nganh(MaNganh) on delete cascade)

create table LOPHOC(
	MaLopHoc nvarchar(20) primary key,
	MaMHDT nvarchar(20),
	MaGV nvarchar(20),
	GioiHan int,
	TenPhong nvarchar(20),
	Thu nvarchar(20),
	TietBatDau int,
	TietKetThuc int,
	ThoiGianBatDau date,
	ThoiGianKetThuc date,
	HocKy nvarchar(5),
	Nam int,
	constraint CoMonHoc foreign key(MaMHDT) references MONHOC_DAOTAO(MaMHDT) on delete cascade,
	constraint CuaGiangVien foreign key(MaGV) references GIANGVIEN(MaGV) on delete set null
)

create table DANGKY(
	MaSV nvarchar(20),
	MaLopHoc nvarchar(20),
	primary key(MaSV,MaLopHoc),
	constraint CuaSinhVien foreign key(MaSV) references SINHVIEN(MaSV) on delete cascade,
	constraint CuaLopHoc foreign key(MaLopHoc) references LOPHOC(MaLopHoc) on delete cascade
)
go


--VIEW
--View 1: Danh sách sinh viên không bị cấm đăng ký
create view View_DanhSachDKMH 
as
select sv.MaSV, sv.HoTenSV, sk.TenNganh, sv.TinhTrangVP from SINHVIEN sv, (select lop.MaLop, ng.TenNganh FROM LOP lop inner join NGANH ng on lop.MaNganh = ng.MaNganh) sk 
		WHERE sv.MaLop = sk.MaLop and sv.TinhTrangVP is null;
go
-- Thực hiện: select * from View_DanhSachDKMH
-- Xóa view: drop view View_DanhSachDKMH


--View 2: Danh sách sinh viên bị cấm đăng ký
create view View_DanhSachCamDKMH 
as
select sv.MaSV, sv.HoTenSV, sk.TenNganh, sv.TinhTrangVP from SINHVIEN sv, (select lop.MaLop, ng.TenNganh FROM LOP lop inner join NGANH ng on lop.MaNganh = ng.MaNganh) sk 
		WHERE sv.MaLop = sk.MaLop and sv.TinhTrangVP is not null;
go
-- Thực hiện: select * from View_DanhSachCamDKMH
-- Xóa view: drop view View_DanhSachCamDKMH

--View 3: Tổng số chỉ của sinh viên
create view View_TongSoChi(HocKy, Nam, MaSV, TenSV, TongSoChi) 
as
select tc.HocKy, tc.Nam, tc.MaSV, sv.HoTenSV, sum(tc.SoTinChi) from SINHVIEN sv,
(select lh.HocKy, lh.Nam, dk.MaSV, mh.MaMH, mh.SoTinChi from LOPHOC lh, DANGKY dk, MONHOC mh, MONHOC_DAOTAO mhdt where dk.MaLopHoc = lh.MaLopHoc and lh.MaMHDT = mhdt.MaMHDT and mhdt.MaMH = mh.MaMH) tc
where sv.MaSV = tc.MaSV
group by tc.HocKy, tc.Nam, tc.MaSV, sv.HoTenSV
go

--select * from View_TongSoChi
--drop view 

--View 4: Danh sách môn học đào tạo
create view View_DanhSachMHDT
as select mhdt.MaMHDT, mh.TenMH, mh.SoTinChi, ctdt.TenCTDT, ctdt.NgonNguDT, ng.TenNganh from MONHOC_DAOTAO mhdt, NGANH ng, CTDAOTAO ctdt, MONHOC mh 
	where mhdt.MaMH = mh.MaMH and mhdt.MaCTDT = ctdt.MaCTDT and mhdt.MaNganh = ng.MaNganh
go

--select * from View_DanhSachMHDT

--View 5: Số lượng sinh viên của lớp học
create view View_SoLuongSVLop(MaLopHoc, SoLuong)
as 
select lh.MaLopHoc, COUNT(MaSv) from DANGKY dk FULL OUTER JOIN LOPHOC lh on dk.MaLopHoc=lh.MaLopHoc group by lh.MaLopHoc
go

--select * from View_SoLuongSVLop
--drop view View_SoLuongSVLop


/*Trigger*/
--Trigger 1: Không cho phép đăng ký vượt quá giới hạn của lớp
create trigger Trigger_SoLuongSVLop on DANGKY after insert 
as declare @newsl int, @gh int
select @newsl = sl.SoLuong, @gh = lh.GioiHan
from inserted ne, View_SoLuongSVLop sl, LOPHOC lh where lh.MaLopHoc = ne.MaLopHoc and ne.MaLopHoc = sl.MaLopHoc
if (@newsl > @gh)
begin
	print(N'Không thể thêm');
	rollback;
end
go

--Trigger 2: Không cho phép sinh viên có vi phạm đăng ký môn học
create trigger Trigger_ThemTKB on DANGKY after Insert
as declare @tinhtrang nvarchar(100)
select @tinhtrang = sv.TinhTrangVP
from inserted ne, SINHVIEN sv where ne.MaSV=sv.MaSV
if (@tinhtrang != 'NULL')
begin
	print(N'Không thể đăng ký');
	rollback;
end
go

--Trigger 3: Không cho một phòng tại 1 thời điểm có nhiều lớp học
create trigger Trigger_Phong on LOPHOC after Insert, update
as 
	declare @newtenphong nvarchar(20), @newthu nvarchar(20), @newtbd int, @newtkt int, @dem int, @newnam int, @newki nvarchar(5)
	select @newtenphong=ne.TenPhong, @newthu=ne.Thu, @newtbd=ne.TietBatDau, @newtkt=ne.TietKetThuc, @newnam = ne.Nam, @newki =ne.HocKy
	from inserted ne
	select @dem = count(*) from LOPHOC where Nam = @newnam and @newki = HocKy and TenPhong = @newtenphong and Thu = @newthu and ((TietBatDau <= @newtbd and TietKetThuc >= @newtbd)
																					or (TietBatDau <= @newtkt and TietKetThuc >= @newtkt))
	if(@dem > 1)
	begin
		print(N'Lớp bị trùng')
		rollback;
	end
go


--Trigger 4: Không cho một lớp học tại 1 thời điểm có nhiều giáo viên dạy
create trigger Trigger_Trung_GV on LOPHOC for Insert, update
as 
	declare @newmgv nvarchar(20), @newthu nvarchar(20), @newtbd int, @newtkt int, @dem int, @newnam int, @newki nvarchar(5)
	select @newmgv=ne.MaGV, @newthu=ne.Thu, @newtbd=ne.TietBatDau, @newtkt=ne.TietKetThuc, @newnam = ne.Nam, @newki =ne.HocKy
	from inserted ne
	select @dem = count(*) from LOPHOC where Nam = @newnam and @newki = HocKy and MaGV = @newmgv and Thu = @newthu and ((TietBatDau <= @newtbd and TietKetThuc >= @newtbd)
																					or (TietBatDau <= @newtkt and TietKetThuc >= @newtkt))
	if(@dem > 1)
	begin
		print(N'Giáo viên bị trùng')
		rollback;
	end
go

--Trigger 5: Không cho phép trùng môn học đào tạo
create trigger Trigger_TrungMHDT on MONHOC_DAOTAO after insert, update
as
	declare @newid nvarchar(20), @newmamh nvarchar(20), @newmactdt nvarchar(20), @newmanganh nvarchar(20), @dem int
	select @newid = ne.MaMHDT, @newmamh = ne.MaMH, @newmactdt = ne.MaCTDT, @newmanganh = ne.MaNganh
	from inserted ne

	select @dem = count(*) from MONHOC_DAOTAO where MaMH = @newmamh and MaCTDT = @newmactdt and MaNganh = @newmanganh
	if(@dem>1)
	begin
		print(@dem)
		print(@newid)
		print(N'Môn học đào tạo bị trùng')
		rollback;
	end
go

--Trigger 6: Không cho phép sinh viên đăng kí một môn nhiều lớp
create trigger Trigger_CamDangKyMotMonNhieuLop on DANGKY after insert, update
as
	declare @newSV nvarchar(20), @newMaLP nvarchar(20), @newMaMHDT nvarchar(20), @dem int
	select @newSV = ne.MaSV, @newMaLP = ne.MaLopHoc
	from inserted ne

	select @newMaMHDT = LOPHOC.MaMHDT from LOPHOC where LOPHOC.MaLopHoc = @newMaLP

	select @dem = count(*) from DANGKY inner join LOPHOC on DANGKY.MaLopHoc = LOPHOC.MaLopHoc
				where @newSV = DANGKY.MaSV and @newMaMHDT = LOPHOC.MaMHDT
	if(@dem >1)
	begin
		print('Khong duoc dang ky mot mon nhieu lop')
		rollback;
	end
go



/*Thủ tục không có tham số*/

--Thủ tục 1: Lấy danh sách tài khoản
CREATE PROC NonP_DSTaiKhoan
AS
	SELECT * FROM TAIKHOAN
go
--Thực hiện: Exec NonP_DSTaiKhoan

--Thủ tục 2: Lấy danh sách sinh viên được đăng ký môn học
CREATE PROC NonP_DanhSachDKMH
AS 
	SELECT * FROM View_DanhSachDKMH 
go
--Thực hiện: Exec NonP_DanhSachDKMH

--Thủ tục 3: Lấy danh sách sinh viên không được đăng ký môn học
CREATE PROC NonP_DanhSachCamDKMH
AS
	SELECT * FROM View_DanhSachCamDKMH
go
-- Thực hiện: Exec NonP_DanhSachCamDKMH

--Thủ tục 4: Lấy danh sách cụ thể các môn học đào tạo
CREATE PROC NonP_DanhSachMHDT
AS
	SELECT * FROM View_DanhSachMHDT
go
--Thực hiện: exec NonP_DanhSachMHDT

--Thủ tục 5: Lấy danh sách các lớp 
CREATE PROC NonP_DanhSachLop
AS
	SELECT lop.MaLop, lop.TenLop, nganh.TenNganh, ctdt.TenCTDT FROM LOP lop, CTDAOTAO ctdt, NGANH nganh WHERE lop.MaNganh = nganh.MaNganh and ctdt.MaCTDT = lop.MaCTDT
go
--Thực hiện: Exec NonP_DanhSachLop

--Thủ tục 6: Lấy danh sách chương trình đào tạo
CREATE PROC NonP_DanhSachCTDT
AS
	SELECT * FROM CTDAOTAO
go
-- Thực hiện: Exec NonP_DanhSachCTDT

--Thủ tục 7: Danh sách các môn học
CREATE PROC NonP_DanhSachMonHoc
AS
	SELECT * FROM MONHOC
go
--Thực hiện: Exec NonP_DanhSachMonHoc

--Thủ tục 8: Danh sách giảng viên
CREATE PROC NonP_DanhSachGV 
AS
	SELECT gv.MaGV, gv.HoTenGV, khoa.TenKhoa FROM GIANGVIEN gv, KHOA khoa where khoa.MaKhoa = gv.MaKhoa
go
--Thực hiện: Exec NonP_DanhSachGV
--Xóa hàm: drop proc Nonp_DanhSachGV

--Thủ tục 9: Danh sách lớp học
CREATE PROC NonP_DanhSachLopHoc
AS
	SELECT * FROM LOPHOC
go
--Thực hiện: Exec NonP_DanhSachLopHoc
--drop proc NonP_DanhSachLopHoc


--Thủ tục 10: Tìm kiếm lớp học
CREATE PROC HasP_TimKiemLop @malop nvarchar(20)
AS
	SELECT * FROM LOPHOC where LOPHOC.MaLopHoc = @malop
go
--Thực hiện: exec HasP_TimKiemLop 'LLCT120314_01'
--drop proc HasP_TimKiemLop

--Thủ tục 11: Môn học đã đăng ký
CREATE PROC HasP_MHDaDK @mssv nvarchar(20)
AS 
	Select DISTINCT mh.MaMH, mh.TenMH, mh.SoTinChi FROM MONHOC mh, SINHVIEN sv, LOP lop, MONHOC_DAOTAO mhdt, NGANH nganh, DangKy dk, LOPHOC lh
					WHERE dk.MaSV = @mssv and dk.MaLopHoc = lh.MaLopHoc and  mhdt.MaMHDT = lh.MaMHDT and mhdt.MaMH = mh.MaMH 
go
--Thực hiện: exec HasP_MHDaDK '21110767'
--drop proc HasP_MHDaDK


/*Thủ tục có trả về*/
--Thủ tục 12: Xem thông tin của sinh viên
CREATE PROC Re_ThongTinSV @mssv nvarchar(20) = NULL 
AS 
BEGIN
	IF @mssv is NULL
	BEGIN
		PRINT N'Xin nhập lại mã số sinh viên!'
		RETURN
	END
	SELECT * FROM SINHVIEN
	WHERE @mssv = MaSV
END
go
--exec Re_ThongTinSV '20132202'
--exec Re_ThongTinSV 

--Thủ tục 13: Thêm một lớp
create proc Re_ThemLop @MaLop nvarchar(20), @TenLop nvarchar(50), @MaNganh nvarchar(20), @MaCTDT nvarchar(20)
as
	begin tran
	if(@MaLop is null or @TenLop is null or @MaNganh is null or @MaCTDT is null)
	begin 
		raiserror(N'Các trường không được để trống', 16, 1)
		rollback
		return
	end 
	insert into LOP values(@MaLop, @TenLop, @MaNganh, @MaCTDT)
	if(@@ERROR<>0)
	begin
		raiserror('error', 16, 1)
		rollback
		return
	end
	commit tran
go
--Thực hiện: exec Re_ThemLop '201104A', N'Công nghệ thông tin A', '103', 'CTDT1'
--drop proc Re_ThemLop

--Thủ tục 14: Xóa lớp
create proc Re_XoaLop @MaLop nvarchar(20)
as
Begin TRANSACTION
	IF (@MaLop is null)
	BEGIN
		RAISERROR('Không được để trống',16,1)
		ROLLBACK
		RETURN
	END
	delete from LOP where LOP.MaLop = @MaLop
	IF(@@ERROR <> 0)
	BEGIN
		RAISERROR('Error!', 16, 1)
		ROLLBACK
		RETURN
	END
COMMIT TRANSACTION
go
--Thực hiện: exec Re_XoaLop '201104A'
--drop proc Re_XoaLop

--Thủ tục 15: Thêm sinh viên
create proc Re_ThemSinhVien @TenDangNhap nvarchar(20), @MatKhau nvarchar(20), @HoTenSV nvarchar(100), @GioiTinh nvarchar(3), @NgaySinh date, @MaLop nvarchar(20)
as
	begin tran
	if(@TenDangNhap is null or @MatKhau is null or @HoTenSV is null or @GioiTinh is null or @NgaySinh is null or @MaLop is null)
	begin
		raiserror(N'Các trường không được để trống', 16, 1)
		rollback
		return
	end
	insert into TAIKHOAN values(@TenDangNhap, @MatKhau, N'Sinh Viên')
	insert into SINHVIEN values(@TenDangNhap, @HoTenSV, @GioiTinh, @NgaySinh, @MaLop, null)
	if(@@ERROR<>0)
	begin
		raiserror('error', 16, 1)
		rollback
		return
	end
	commit tran
go
--Thực hiện: exec Re_ThemSinhVien '18125107', '123456', N'Huỳnh Thanh Tâm', N'Nam', '2000-10-28', '181251B'
--delete SinhVien where MaSV='18125107'
--delete TAIKHOAN where TenDangNhap ='18125107'
--drop proc Re_ThemSinhVien

--Thủ tục 16: Cập nhật sinh viên
create proc Re_CapNhatSinhVien @TenDangNhap nvarchar(20), @HoTenSV nvarchar(100)=null, @GioiTinh nvarchar(3)=null, @NgaySinh date=null, @MaLop nvarchar(20)=null, @Tinhtrang nvarchar(10)=null
as
begin tran
	begin
		declare @oldHoTenSV nvarchar(100), @oldGioiTinh nvarchar(3), @oldNgaySinh date, @oldMaLop nvarchar(20), @oldTinhtrang nvarchar(10)
		select @oldHoTenSV=HoTenSV, @oldGioiTinh=GioiTinh, @oldNgaySinh=NgaySinh, @oldMaLop=MaLop, @oldTinhtrang=TinhTrangVP from SINHVIEN where @TenDangNhap=MaSV
		if @HoTenSV IS NULL
			set @HoTenSV=@oldHoTenSV
		if @GioiTinh IS NULL
			set @GioiTinh=@oldGioiTinh
		if @NgaySinh IS NULL
			set @NgaySinh=@oldNgaySinh
		if @MaLop IS NULL
			set @MaLop=@oldMaLop
		if @Tinhtrang IS NULL
			set @Tinhtrang=@oldTinhtrang
		update dbo.SINHVIEN set HoTenSV=@HoTenSV, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, MaLop=@MaLop, TinhTrangVP=@Tinhtrang where @TenDangNhap=MaSV
	end
	if(@@ERROR<>0)
	begin
		raiserror('error', 16, 1)
		rollback
		return
	end
	commit tran
go
--Thực hiện: exec Re_CapNhatSinhVien '20132202', null, N'Nữ', null, null, null
--drop proc Re_CapNhatSinhVien

--Thủ tục 17: Xóa sinh viên
create proc Re_XoaSinhVien @mssv nvarchar(20)
as
	begin tran
	delete SINHVIEN where SINHVIEN.MaSV = @mssv
	delete TAIKHOAN where TAIKHOAN.TenDangNhap = @mssv
	if(@@ERROR<>0)
	begin
		raiserror('error', 16, 1)
		rollback
		return
	end
	commit tran
go
--Thực hiện: exec Re_XoaSinhVien '18125107'
--dreop proc Re_XoaSinhVien

--Thủ tục 18: Thêm giảng viên
create proc Re_ThemGiangVien @TenDangNhap nvarchar(20), @MatKhau varchar(20), @HoTenGV nvarchar(100), @MaKhoa nvarchar(20)
as
	begin tran
	if(@TenDangNhap is null or @MatKhau is null or @HoTenGV is null or @MaKhoa is null)
	begin
		raiserror(N'Các trường không được để trống', 16, 1)
		rollback
		return
	end
	insert into TAIKHOAN values(@TenDangNhap, @MatKhau, N'Giảng Viên')
	insert into GIANGVIEN values(@TenDangNhap, @HoTenGV, @MaKhoa)
	if(@@ERROR<>0)
	begin
		raiserror('error', 16, 1)
		rollback
		return
	end
	commit tran
go
--Thực hiện: exec Re_ThemGiangVien '1918', '123456', N'Trần Trung Thảo', '20'
--drop proc Re_ThemGiangVien


--Thủ tục 19: Xóa giảng viên
create proc Re_XoaGiangVien @magv nvarchar(20)
as
	begin tran
	delete GIANGVIEN where GIANGVIEN.MaGV = @magv
	delete TAIKHOAN where TAIKHOAN.TenDangNhap = @magv
	if(@@ERROR<>0)
	begin
		raiserror('error', 16, 1)
		rollback
		return
	end
	commit tran
go
--Thực hiện: exec Re_XoaGiangVien '1111'
--drop proc Re_XoaGiangVien

--Thủ tục 20: Thêm Ngành
create proc Re_ThemNganh @MaNganh nvarchar(20), @TenNganh nvarchar(50), @MaKhoa nvarchar(20)
as
Begin TRANSACTION
	IF (@MaNganh is null or @TenNganh is null or @MaKhoa is null )
	BEGIN
		RAISERROR(N'Không được để trống',16,1)
		ROLLBACK
		RETURN
	END
	insert into NGANH values(@MaNganh, @TenNganh, @MaKhoa)
	IF(@@ERROR <> 0)
	BEGIN
		RAISERROR('Error!', 16, 1)
		ROLLBACK
		RETURN
	END
COMMIT TRANSACTION
go
--Thực hiện: exec Re_ThemNganh '458', 'Trí tuệ nhân tạo', '19'
--drop proc Re_ThemNganh

--Thủ tục 21: Xóa ngành
create proc Re_XoaNganh @MaNganh nvarchar(20)
as
Begin TRANSACTION
	IF (@MaNganh is null)
	BEGIN
		RAISERROR(N'Không được để trống',16,1)
		ROLLBACK
		RETURN
	END
	delete from NGANH where NGANH.MaNganh = @MaNganh
	IF(@@ERROR <> 0)
	BEGIN
		RAISERROR('Error!', 16, 1)
		ROLLBACK
		RETURN
	END
COMMIT TRANSACTION
go
--Thực hiện: exec Re_XoaNganh '458'
--drop proc Re_XoaNganh

--Thủ tục 22: Thêm Khoa
create proc Re_ThemKhoa @MaKhoa nvarchar(20), @TenKhoa nvarchar(50)
as
Begin TRANSACTION
	IF (@MaKhoa is null or @TenKhoa is null )
	BEGIN
		RAISERROR(N'Không được để trống',16,1)
		ROLLBACK
		RETURN
	END
	insert into KHOA values(@MaKhoa, @TenKhoa)
	IF(@@ERROR <> 0)
	BEGIN
		RAISERROR('Error!', 16, 1)
		ROLLBACK
		RETURN
	END
COMMIT TRANSACTION
go
--Thực hiện: exec Re_ThemKhoa '22', 'An toàn thông tin'
--drop proc Re_ThemKhoa

--Thủ tục 23: Xóa khoa
create proc Re_XoaKhoa @MaKhoa nvarchar(20)
as
Begin TRANSACTION
	IF (@MaKhoa is null)
	BEGIN
		RAISERROR(N'Không được để trống',16,1)
		ROLLBACK
		RETURN
	END
	delete from KHOA where KHOA.MaKhoa = @MaKhoa
	IF(@@ERROR <> 0)
	BEGIN
		RAISERROR('Error!', 16, 1)
		ROLLBACK
		RETURN
	END
COMMIT TRANSACTION
go
--Thực hiện: exec Re_XoaKhoa '22'
--drop proc Re_XoaKhoa

--Thủ tục 24: Thêm lớp học
create proc Re_ThemLopHoc @MaLopHoc nvarchar(20), @MaMHDT nvarchar(20), @MaGV nvarchar(20), @GioiHan int, @Phong nvarchar(20), @Thu nvarchar(20), @TietBatDau int, @TietKetThuc int, @ThoiGianBatDau date, @ThoiGianKetThuc date, @HocKy nvarchar(20), @Nam int
as
	Begin TRANSACTION
	IF (@MaLopHoc is null or @MaMHDT is null or @MaGV  is null or @GioiHan is null or @Phong is null or @Thu is null or @TietBatDau is null or @TietKetThuc is null or @ThoiGianBatDau is null or @HocKy is null or @Nam is null )
	BEGIN
		RAISERROR(N'Không được để trống',16,1)
		ROLLBACK
		RETURN
	END

	insert into LOPHOC values(@MaLopHoc, @MaMHDT, @MaGV, @GioiHan, @Phong, @Thu, @TietBatDau, @TietKetThuc, @ThoiGianBatDau, @ThoiGianKetThuc, @HocKy, @Nam)
	IF(@@ERROR <> 0)
	BEGIN
		RAISERROR('Error!', 16, 1)
		ROLLBACK
		RETURN
	END
COMMIT TRANSACTION
go
--Thực hiện: exec Re_ThemLopHoc '1113', 'MHDT009', '1951', '60', 'A111', 'Thu 7', 5, 6, '2022-06-01', '2022-12-01', '1', '2022' 
--drop proc Re_ThemLopHoc

--Thủ tục 25: Xóa Lớp học
create proc Re_XoaLopHoc @MaLopHoc nvarchar(20)
as
BEGIN TRANSACTION
	IF (@MaLopHoc is null )
	BEGIN
		RAISERROR('Không được để trống',16,1)
		ROLLBACK
		RETURN
	END
	delete from LOPHOC where LOPHOC.MaLopHoc = @MaLopHoc
	IF(@@ERROR <> 0)
	BEGIN
		RAISERROR('Error!', 16, 1)
		ROLLBACK
		RETURN
	END
COMMIT TRANSACTION
go
--Thực hiện: exec Re_XoaLopHoc '1111'
--drop proc Re_XoaLopHoc

--Thủ tục 26: thêm môn học
create proc Re_ThemMonHoc @MaMH nvarchar(20), @TenMH nvarchar(20), @SoTinChi int
as
	Begin TRANSACTION
	IF (@MaMH is null or @TenMH is null or @SoTinChi  is null)
	BEGIN
		RAISERROR(N'Không được để trống',16,1)
		ROLLBACK
		RETURN
	END

	insert into MONHOC values(@MaMH, @TenMH, @SoTinChi)
	IF(@@ERROR <> 0)
	BEGIN
		RAISERROR('Error!', 16, 1)
		ROLLBACK
		RETURN
	END
COMMIT TRANSACTION
go
--Thực hiện: exec Re_ThemMonHoc 'AAAAA5555', N'Học Máy', '3'
--drop proc Re_ThemMonHoc

--Thủ tục 27: Xóa Môn Học
create proc Re_XoaMonHoc @MaMH nvarchar(20)
as
BEGIN TRANSACTION
	IF (@MaMH is null )
	BEGIN
		RAISERROR('Không được để trống',16,1)
		ROLLBACK
		RETURN
	END
	delete from MONHOC where MONHOC.MaMH = @MaMH
	IF(@@ERROR <> 0)
	BEGIN
		RAISERROR('Error!', 16, 1)
		ROLLBACK
		RETURN
	END
COMMIT TRANSACTION
go
--Thực hiện: exec Re_XoaMonHoc 'AAAAA5555'
--drop proc Re_XoaMonHoc

--Thủ tục 28: Thêm môn học- đào tạo
create proc Re_ThemMHDT @MaMHDT nvarchar(20), @MaMH nvarchar(20), @MaCTDT nvarchar(20), @MaNganh nvarchar(20)
as
	Begin TRANSACTION
	IF (@MaMHDT is null or @MaMH is null or @MaCTDT is null or @MaNganh is null)
	BEGIN
		RAISERROR(N'Không được để trống',16,1)
		ROLLBACK
		RETURN
	END

	insert into MONHOC_DAOTAO values(@MaMHDT , @MaMH , @MaCTDT , @MaNganh)
	IF(@@ERROR <> 0)
	BEGIN
		RAISERROR('Error!', 16, 1)
		ROLLBACK
		RETURN
	END
COMMIT TRANSACTION
go
--exec Re_ThemMHDT 'MHDT102', 'TAPO330407', 'CTDT4', '457'
--drop proc Re_ThemMHDT

--Thủ tục 29: Xóa môn học - đào tạo
create proc Re_XoaMHDT @MaMHDT nvarchar(20)
as
BEGIN TRANSACTION
	IF (@MaMHDT is null )
	BEGIN
		RAISERROR('Không được để trống',16,1)
		ROLLBACK
		RETURN
	END
	delete from MONHOC_DAOTAO where MONHOC_DAOTAO.MaMHDT = @MaMHDT
	IF(@@ERROR <> 0)
	BEGIN
		RAISERROR('Error!', 16, 1)
		ROLLBACK
		RETURN
	END
COMMIT TRANSACTION
go
--exec Re_XoaMHDT 'MHDT102'
--drop proc Re_XoaMHDT

--Thủ tục 30: Đăng ký lớp học
create proc Re_DangKyLH @MaLopHoc nvarchar(20), @MaSV nvarchar(20)
as
	Begin TRANSACTION
	IF (@MaLopHoc is null or @MaSV is null )
	BEGIN
		RAISERROR(N'Không được để trống',16,1)
		ROLLBACK
		RETURN
	END

	insert into DANGKY values(@MaSV , @MaLopHoc)
	IF(@@ERROR <> 0)
	BEGIN
		RAISERROR('Error!', 16, 1)
		ROLLBACK
		RETURN
	END
COMMIT TRANSACTION
go
--exec Re_DangKyLH 'TLAW332209_01', '20151426'
--drop proc Re_DangKyLH

create proc Re_XoaDangKyLH @MaLopHoc nvarchar(20), @MaSV nvarchar(20)
as
	begin TRANSACTION
	IF (@MaLopHoc is null or @MaSV is null )
	BEGIN
		RAISERROR(N'Không được để trống',16,1)
		ROLLBACK
		RETURN
	END

	delete from DANGKY where DANGKY.MaSV = @MaSV and DANGKY.MaLopHoc = @MaLopHoc
	IF(@@ERROR <> 0)
	BEGIN
		RAISERROR('Error!', 16, 1)
		ROLLBACK
		RETURN
	END
COMMIT TRANSACTION
go
--exec Re_XoaDangKyLH 'LLCT120314_01', '21110767'
--drop proc Re_XoaDangKyLH

create proc Re_DoiMatKhau @MatKhau nvarchar(20), @TenDangNhap nvarchar(20)
as
begin TRANSACTION
	IF (@MatKhau is null or @TenDangNhap is null )
	BEGIN
		RAISERROR(N'Không được để trống',16,1)
		ROLLBACK
		RETURN
	END

	update TAIKHOAN set MatKhau = @MatKhau where TenDangNhap = @TenDangNhap
	IF(@@ERROR <> 0)
	BEGIN
		RAISERROR('Error!', 16, 1)
		ROLLBACK
		RETURN
	END
COMMIT TRANSACTION
go

--exec Re_DoiMatKhau '111111', '17124068'
--drop proc Re_DoiMatKhau

/*Hàm trả về một giá trị*/

--Hàm 31: Tổng sinh viên của khoa
CREATE FUNCTION RNO_TongSVKhoa(@khoa nvarchar(100)) RETURNS int
AS
BEGIN
	DECLARE @sl int
	SELECT @sl = COUNT(*)
	FROM SINHVIEN sv, KHOA khoa, LOP lop, NGANH nganh
	WHERE sv.MaLop = lop.MaLop and lop.MaNganh = nganh.MaNganh and nganh.MaKhoa = khoa.MaKhoa and (khoa.TenKhoa Like '%'+@khoa+'%' or @khoa = khoa.MaKhoa)
	RETURN @sl
END
go
--select dbo.RNO_TongSVKhoa('19')
--select dbo.RNO_TongSVKhoa(N'khoa công nghệ thông tin')
--drop function RNO_TongSVKhoa

--Hàm 32: Tổng sinh viên của khoa
CREATE FUNCTION RNO_TongSVNganh(@nganh nvarchar(100)) RETURNS int
AS
BEGIN
	DECLARE @sl int
	SELECT @sl = COUNT(*)
	FROM SINHVIEN sv, LOP lop, NGANH nganh
	WHERE sv.MaLop = lop.MaLop and lop.MaNganh = nganh.MaNganh  and (nganh.TenNganh Like '%'+@nganh+'%' or @nganh = nganh.MaNganh)
	RETURN @sl
END
go
--select dbo.RNO_TongSVNganh('19')
--select dbo.RNO_TongSVNganh(N'khoa công nghệ thông tin')
--drop function RNO_TongSVNganh

--Hàm 33: Tổng sinh viên của lớp học
CREATE FUNCTION RNO_TongSVLopHoc(@malh nvarchar(20)) RETURNS int
AS
BEGIN
	DECLARE @sl int
	SELECT @sl = COUNT(*)
	FROM LOPHOC lh, DANGKY dk
	WHERE lh.MaLopHoc = dk.MaLopHoc and lh.MaLopHoc = @malh
	RETURN @sl
END
go
--select dbo.RNO_TongSVLopHoc('DBSY230184_02')


/*Hàm trả về một bảng có một câu lệnh*/

--Hàm 34: Đăng nhập
CREATE FUNCTION RTO_DangNhap(@mssv nvarchar(20), @matkhau nvarchar(20)) RETURNS table
AS
	RETURN (SELECT * FROM TAIKHOAN tk WHERE tk.TenDangNhap = @mssv and tk.MatKhau = @matkhau)
go
--Thực hiện: select * from dbo.RTO_DangNhap('20132202', '123456')
--Xóa hàm:	 drop function RTO_DangNhap

--Hàm 35: Lấy thông tin của sinh viên
CREATE FUNCTION RTO_ThongTinSV (@mssv nvarchar(20)) RETURNS table
AS 
	RETURN (SELECT sv.MaSV, sv.HoTenSV, sv.GioiTinh, sv.NgaySinh FROM SINHVIEN sv WHERE @mssv = sv.MaSV)
go
-- Thực hiện: select * from dbo.RTO_ThongTinSV ('20132202')
-- Xóa hàm:  drop function RTO_ThongTinSV


--Hàm 36: Hàm lấy thông tin của quản lý
CREATE FUNCTION RTO_ThongTinQL (@ms nvarchar(20)) RETURNS table
AS 
	RETURN (SELECT * FROM QUANLY WHERE @ms = QUANLY.MaQL)
go
-- Thực hiện: select * from dbo.RTO_ThongTinQL ('120000')
-- Xóa hàm:  drop function RTO_ThongTinQL

--Hàm 37: Hàm lấy thông tin sinh viên của lớp
CREATE FUNCTION RTO_ThongTinSVLop (@ms nvarchar(20)) RETURNS table
AS 
	RETURN (SELECT sv.MaSV, sv.HoTenSV, sv.GioiTinh, sv.NgaySinh FROM SINHVIEN sv WHERE @ms = sv.MaLop)
go
-- Thực hiện: select * from dbo.RTO_ThongTinSVLop('201106A')
-- Xóa hàm:  drop function RTO_ThongTinSVLop

--Hàm 38: Hàm lấy thông tin giảng viên
CREATE FUNCTION RTO_ThongTinGV (@magv nvarchar(20)) RETURNS table
AS
	RETURN (SELECT gv.MaGV, gv.HoTenGV, khoa.TenKhoa FROM GIANGVIEN gv, KHOA khoa where khoa.MaKhoa = gv.MaKhoa and gv.MaGV = @magv)
go
--Thực hiện: select * from dbo.RTO_ThongTinGV('1951')
--Xóa hàm: drop function RTO_ThongTinGV

--Hàm 39: Danh sách khoa
CREATE FUNCTION RTO_DanhSachKhoa() RETURNS table
AS
	RETURN (SELECT * FROM KHOA)
go
--Thực hiện: select * from dbo.RTO_DanhSachKhoa()
--drop function RTO_DanhSachKhoa

--Hàm 40: Tìm kiếm khoa
CREATE FUNCTION RTO_TimKiemKhoa(@makhoa nvarchar(20)) RETURNS table
AS
	RETURN (SELECT * FROM KHOA WHERE KHOA.MaKhoa = @makhoa)
go
--Thực hiện: select * from dbo.RTO_TimKiemKhoa(14)
--drop function RTO_TimKiemKhoa

--Hàm 41: Danh sách ngành
CREATE FUNCTION RTO_DanhSachNganh() RETURNS table
AS
	RETURN (SELECT NGANH.MaNganh, NGANH.TenNganh, KHOA.TenKhoa FROM NGANH, KHOA WHERE KHOA.MaKhoa = NGANH.MaKhoa)
go
--Thực hiện: select * from dbo.RTO_DanhSachNganh()
--drop function RTO_DanhSachNganh

--Hàm 42: Tìm kiếm ngành
CREATE FUNCTION RTO_TimKiemNganh(@manganh nvarchar(20)) RETURNS table
AS
	RETURN (SELECT NGANH.MaNganh, NGANH.TenNganh, KHOA.TenKhoa FROM NGANH, KHOA WHERE KHOA.MaKhoa = NGANH.MaKhoa and NGANH.MaNganh=@manganh)
go
--Thực hiện: select * from dbo.RTO_TimKiemNganh(260)
--drop function RTO_TimKiemNganh



--Hàm 43: Tìm kiếm môn học
CREATE FUNCTION RTO_TimKiemMonHoc(@mamh nvarchar(20)) RETURNS table
AS
	RETURN (SELECT * FROM MONHOC WHERE MaMH = @mamh)
go
--Thực hiện: select * from dbo.RTO_TimKiemMonHoc('ECON240206')
--drop function RTO_TimKiemMonHoc

--Hàm 44: Tìm kiếm môn học đào tạo
CREATE FUNCTION RTO_TimKiemMHDT(@mamhdt nvarchar(20)) RETURNS table
AS
	RETURN (SELECT * FROM View_DanhSachMHDT WHERE MaMHDT = @mamhdt)
go
--Thực hiện: select * from dbo.RTO_TimKiemMHDT('MHDT002')
--drop function RTO_TimKiemMHDT

--Hàm 45: danh sách sinh viên của lớp học 
CREATE function RTO_DanhSachSVLopHoc(@malh nvarchar(20)) returns table 
AS 
	RETURN (SELECT sv.MaSV, sv.HoTenSV, sv.GioiTinh, sv.NgaySinh, sv.MaLop FROM SINHVIEN sv, DANGKY dk WHERE @malh = dk.MaLopHoc and dk.MaSV = sv.MaSV)
go

--select * from dbo.RTO_DanhSachSVLopHoc('DBSY230184_02')
--drop function dbo.RTO_DanhSachSVLopHoc 

/*Hàm trả về một bảng có nhiều câu lệnh*/
--Hàm 46: Danh sách các học phần trong chương trình đào tạo của sinh viên
CREATE FUNCTION RTM_HocPhanCTDTSV (@mssv nvarchar(20)) RETURNS @table table(MaMH nvarchar(20), TenMH nvarchar(100), SoTinChi int) 
AS 
BEGIN 
	INSERT @table SELECT DISTINCT mh.MaMH, mh.TenMH, mh.SoTinChi FROM MONHOC mh, SINHVIEN sv, LOP lop, MONHOC_DAOTAO mhdt, NGANH nganh
					WHERE sv.MaSV = @mssv and sv.MaLop = lop.MaLop and (lop.MaNganh = mhdt.MaNganh or mhdt.MaNganh = '009' or mhdt.MaNganh = '008')
							and lop.MaCTDT = mhdt.MaCTDT and mhdt.MaMH = mh.MaMH
	RETURN 
END
go

--select * from dbo.RTM_HocPhanCTDTSV ('20151426')
--drop function RTM_HocPhanCTDTSV 

--Hàm 47: Hàm lấy thông tin của giảng viên
CREATE FUNCTION RTM_ThongTinGV (@ms nvarchar(20)) RETURNS @table table(MaGV nvarchar(20), TenGV nvarchar(100), TenKhoa nvarchar(100))
AS 
BEGIN
	INSERT @table SELECT DISTINCT gv.MaGV, gv.HoTenGV, kh.MaKhoa FROM GIANGVIEN gv, KHOA kh WHERE kh.MaKhoa = gv.MaKhoa
	RETURN
END
go
--select * from dbo.RTM_ThongTinGV('1951')
--drop function RTM_ThongTinGV

--Hàm 48: Đăng ký lớp
CREATE FUNCTION RTM_TimKiemLHDK (@mamh nvarchar(20), @masv nvarchar(20)) RETURNS @table table(MaLopHoc nvarchar(20), TenGV nvarchar(100), GioiHan int, TenPhong nvarchar(20), Thu nvarchar(20), TietBatDau int, TietKetThuc int, ThoiGianBatDau date, ThoiGianKetThuc date)
AS 
BEGIN
	insert @table select lh.MaLopHoc, gv.HoTenGV, lh.GioiHan, lh.TenPhong, lh.Thu, lh.TietBatDau, lh.TietKetThuc, lh.ThoiGianBatDau, lh.ThoiGianKetThuc
			from LOPHOC lh, GIANGVIEN gv, (select MONHOC_DAOTAO.MaMHDT, MONHOC_DAOTAO.MaMH, MONHOC.TenMH, MONHOC_DAOTAO.MaCTDT from MONHOC_DAOTAO inner join MONHOC on MONHOC_DAOTAO.MaMH = MONHOC.MaMH) mh, SINHVIEN sv, LOP lop
			where mh.MaMH = @mamh  and mh.MaMHDT = lh.MaMHDT and gv.MaGV=lh.MaGV and @masv = sv.MaSV and lop.MaCTDT = mh.MaCTDT and sv.MaLop = lop.MaLop
	return
END
go
--select * from dbo.RTM_TimKiemLHDK ('TLAW332209', '20151426')
--drop function RTM_TimKiemLHDK

--Hàm 49: Hàm trả về danh sách sinh viên của khoa
CREATE FUNCTION RTM_DSSVKhoa(@khoa nvarchar(100)) 
RETURNS @table table (MaSV nvarchar(20),HoTenSV nvarchar(30),GioiTinh nvarchar(3),NgaySinh date,MaLop nvarchar(20),TinhTrangVP nvarchar(10))
AS
BEGIN
	insert @table SELECT sv.MaSV, sv.HoTenSV, sv.GioiTinh, sv.NgaySinh, sv.MaLop, sv.TinhTrangVP
	FROM SINHVIEN sv, KHOA khoa, LOP lop, NGANH nganh
	WHERE sv.MaLop = lop.MaLop and lop.MaNganh = nganh.MaNganh and nganh.MaKhoa = khoa.MaKhoa and ( khoa.TenKhoa Like '%'+@khoa+'%' or @khoa = khoa.MaKhoa)
	RETURN
END
go
--select * from dbo.RTM_DSSVKhoa('19')
--select * from dbo.RTM_DSSVKhoa(N'công nghệ ')
--drop function DS_SV_Khoa

--Hàm 50: Hàm trả về danh sách sinh viên của ngành
CREATE FUNCTION RTM_DSSVNganh(@nganh nvarchar(100)) 
RETURNS @table table (MaSV nvarchar(20),HoTenSV nvarchar(30),GioiTinh nvarchar(3),NgaySinh date,MaLop nvarchar(20),TinhTrangVP nvarchar(10))
AS
BEGIN
	insert @table SELECT sv.MaSV, sv.HoTenSV, sv.GioiTinh, sv.NgaySinh, sv.MaLop, sv.TinhTrangVP
	FROM SINHVIEN sv, LOP lop, NGANH nganh
	WHERE sv.MaLop = lop.MaLop and lop.MaNganh = nganh.MaNganh and ( nganh.TenNganh Like '%'+@nganh+'%' or @nganh = nganh.MaNganh)
	RETURN
END
go
--select * from dbo.RTM_DSSVKhoa('19')
--select * from dbo.RTM_DSSVKhoa(N'công nghệ ')
--drop function DS_SV_Khoa

--Hàm 51: Tìm kiếm lớp học
create function RTM_TimKiemLopHocTheoMon (@MonHoc nvarchar(100))
returns @table table (MaLopHoc nvarchar(20), TenGV nvarchar(100), GioiHan int, TenPhong nvarchar(20), Thu nvarchar(20), TietBatDau int, TietKetThuc int, ThoiGianBatDau date, ThoiGianKetThuc date)
as
begin
	insert @table select lh.MaLopHoc, gv.HoTenGV, lh.GioiHan, lh.TenPhong, lh.Thu, lh.TietBatDau, lh.TietKetThuc, lh.ThoiGianBatDau, lh.ThoiGianKetThuc
			from LOPHOC lh, GIANGVIEN gv, (select MONHOC_DAOTAO.MaMHDT, MONHOC_DAOTAO.MaMH, MONHOC.TenMH from MONHOC_DAOTAO inner join MONHOC on MONHOC_DAOTAO.MaMH = MONHOC.MaMH) mh
			where (mh.MaMH = @MonHoc or mh.TenMH Like '%'+@MonHoc+'%' ) and mh.MaMHDT = lh.MaMHDT and gv.MaGV=lh.MaGV
	return
end
go
--select * from dbo.RTM_TimKiemLopHocTheoMon(N'Giáo dục thể chất 3')
--drop function RTM_TimKiemLopHocTheoMon


--Hàm 52: Thời Khóa Biểu của Sinh Viên
create or alter function RTM_XemTKB (@MaSV nvarchar(20))
returns @table table (MaLopHoc nvarchar(20), Thu nvarchar(20), TietBatDau int, TietKetThuc int, TenPhong nvarchar(20), TenMH nvarchar(100), HoTenGV nvarchar(100))
as
begin
	insert @table select LOPHOC.MaLopHoc, LOPHOC.Thu, LOPHOC.TietBatDau, LOPHOC.TietKetThuc, LOPHOC.TenPhong, MONHOC.TenMH, GIANGVIEN.HoTenGV
			from DANGKY, LOPHOC, MONHOC, GIANGVIEN, MONHOC_DAOTAO
			where DANGKY.MaSV = @MaSV and DANGKY.MaLopHoc = LOPHOC.MaLopHoc and LOPHOC.MaMHDT = MONHOC_DAOTAO.MaMHDT and MONHOC_DAOTAO.MaMH = MONHOC.MaMH and LOPHOC.MaGV = GIANGVIEN.MaGV
	return
end
go
--select * from dbo.RTM_XemTKB('21110767')
--drop function RTM_XemTKB

--Hàm 53: Thời Khóa Biểu của GiangVien
create function RTM_XemTKBGV (@MaGV nvarchar(20))
returns @table table (Thu nvarchar(20), TietBatDau int, TietKetThuc int, TenPhong nvarchar(20), TenMH nvarchar(100))
as
begin
	insert @table select LOPHOC.Thu, LOPHOC.TietBatDau, LOPHOC.TietKetThuc, LOPHOC.TenPhong, MONHOC.TenMH
			from LOPHOC, MONHOC, GIANGVIEN, MONHOC_DAOTAO
			where GIANGVIEN.MaGV = @MaGV and LOPHOC.MaMHDT = MONHOC_DAOTAO.MaMHDT and MONHOC_DAOTAO.MaMH = MONHOC.MaMH and LOPHOC.MaGV = GIANGVIEN.MaGV
	return
end
go
--select * from dbo.RTM_XemTKBGV('5151')
--drop function RTM_XemTKBGV

--Hàm 54: Chi Tiết của GiangVien
create function RTM_ChiTietLHGV (@MaGV nvarchar(20))
returns @table table (MaLopHoc nvarchar(20),TenMH nvarchar(100), TenPhong nvarchar(20), Thu nvarchar(20), TietBatDau int, TietKetThuc int, soluong int)
as
begin
	insert @table select LOPHOC.MaLopHoc,MONHOC.TenMH, LOPHOC.TenPhong, LOPHOC.Thu, LOPHOC.TietBatDau, LOPHOC.TietKetThuc, viewsl.SoLuong
			from LOPHOC, MONHOC, GIANGVIEN, MONHOC_DAOTAO, View_SoLuongSVLop viewsl
			where GIANGVIEN.MaGV = @MaGV and LOPHOC.MaMHDT = MONHOC_DAOTAO.MaMHDT and MONHOC_DAOTAO.MaMH = MONHOC.MaMH and LOPHOC.MaGV = GIANGVIEN.MaGV and viewsl.MaLopHoc = LOPHOC.MaLopHoc
	return
end
go
--select * from dbo.RTM_ChiTietLHGV('5151')
--drop function RTM_ChiTietLHGV

--Phân quyền người dùng
create login [sinhvien] with password='sinhvien'
go

create user [sinhvien] for login [sinhvien]
go

grant exec on dbo.Re_DangKyLH to [sinhvien]
grant exec on dbo.Re_XoaDangKyLH to [sinhvien]
grant exec on dbo.Re_DoiMatKhau to [sinhvien]
grant select on dbo.RTM_HocPhanCTDTSV to [sinhvien]
grant select on dbo.RTO_ThongTinSV to [sinhvien]
grant select on dbo.RTM_TimKiemLopHocTheoMon to [sinhvien]
grant select on dbo.RTM_XemTKB to [sinhvien]
grant select on dbo.RTM_TimKiemLHDK to [sinhvien]
go


create login [giangvien] with password='giangvien'
go

create user [giangvien] for login [giangvien]
go

grant select on dbo.RTM_XemTKBGV to [giangvien]
grant select on dbo.RTM_ChiTietLHGV to [giangvien]
grant exec on dbo.RNO_TongSVLopHoc to [giangvien]
grant exec on dbo.Re_DoiMatKhau to [giangvien]
grant select on dbo.RTO_DanhSachSVLopHoc to [giangvien]
grant select on dbo.RTO_ThongTinGV to [giangvien]
go

--Nhập dữ liệu
insert into KHOA(MaKhoa, TenKhoa) values
('29', N'Khoa Công nghệ may & Thời trang'),
('35', N'Khoa Xây dựng & Cơ học ứng dụng'),
('32', N'Khoa kinh tế'),
('15', N'Khoa Cơ khí động lực'),
('26', N'Khoa Thời trang và Du lịch'),
('19', N'Khoa công nghệ thông tin'),
('25', N'Khoa cơ khí chế tạo máy'),
('34', N'Khoa in và truyền thông'),
('14', N'Khoa Công nghệ hóa học & Thực phẩm'),
('21', N'Khoa điện điện tử'),
('49', N'Khoa Lý luận Chính trị'),
('37', N'Khoa Khoa học ứng dụng'),
('20', N'Khoa Ngoại ngữ'),
('30', N'Khoa Truyền Thông & Báo Chí'),
('33', N'Khoa Môi Trường'),
('45', N'Khoa đào tạo cử nhân'),
('40', N'Khoa Ngữ Văn'),
('28', N'Khoa Văn hóa & Nghệ thuật '),
('36', N'Khoa điện ảnh'),
('72', N'Khoa giáo dục thể chất và quốc phòng')

go
insert into NGANH(MaNganh, TenNganh, MaKhoa) values
('321', N'Logistics & Quản lý Chuỗi cung ứng', '32'),
('251', N'Kế toán ', '32'),
('260', N'Thương mại điện tử', '32'),
('360', N'Kinh doanh quốc tế', '32'),
('240', N'Quản lý công nghiệp', '32'),
('560', N'Thiết kế đồ họa', '34'),
('443', N'Cơ khí', '15'),
('290', N'Kỹ thuật y sinh', '21'),
('390', N'Hệ thống nhúng & IOT', '21'),
('103', N'Công Nghệ thông tin', '19'),
('104', N'Kỹ thuật dữ liệu', '19'),
('456', N'Công nghệ Kỹ thuật môi trường', '14'),
('123', N'Công nghệ thực phẩm', '14'),
('789', N'Công nghệ Kỹ thuật Hóa học', '14'),
('457', N'Công nghệ kỹ thuật ô tô', '15'),
('009', N'Nhóm môn học chính trị', '49'),
('008', N'Nhóm môn học thể chất', '72'),
('072', N'Nhóm môn học khoa học ứng dụng', '37')

go

insert into CTDAOTAO(MaCTDT, TenCTDT, HinhThucDT, NgonNguDT, TrinhDoDaoTao) values
('CTDT1', N'Đại trà', N'Chính Quy', N'Tiếng Việt', N'Đại học'),
('CTDT2', N'CLC', N'Chính Quy', N'Tiếng Việt', N'Đại học'),
('CTDT3', N'CLC', N'Chính Quy', N'Tiếng Anh', N'Đại học'),
('CTDT4', N'CLC', N'Chính Quy', N'Tiếng Nhật', N'Đại học')
go


insert into LOP(MaLop, TenLop, MaNganh, MaCTDT) values
('201321C', N'Logistics và Quản lý Chuỗi cung ứng C', '321', 'CTDT1'),
('181251B', N'Kế toán B', '251', 'CTDT1'),
('211263A', N'Thương mại điện tử A', '260', 'CTDT2'),
('201457B', N'Công nghệ kỹ thuật ô tô B', '457', 'CTDT1'),
('201443C', N'Cơ khí C', '443', 'CTDT1'),
('211107A', N'Công nghệ thông tin A', '103', 'CTDT1'),
('211462C', N'Kinh doanh quốc tế', '360', 'CTDT1'),
('181560B', N'Thiết kế đồ họa B', '560', 'CTDT1'),
('201321B', N'Logistics và quản lí chuỗi cung ứng B', '321', 'CTDT1'),
('201241B', N'Quản lí công nghiệp B', '240', 'CTDT1'),
('201290B', N'Kỹ thuật y sinh B', '290', 'CTDT3'),
('201390B', N'Hệ thống nhúng & IOT B', '390', 'CTDT1'),
('201106C', N'Công Nghệ thông tin C', '103', 'CTDT1'),
('201106A', N'Công Nghệ thông tin A', '103', 'CTDT2'),
('201106B', N'Công Nghệ thông tin B', '103', 'CTDT1'),
('201321A', N'Logistics và quản lí chuỗi cung ứng A', '321', 'CTDT4')

go
insert into VIPHAM(MaVP,NoiDung) values
('12000', N'Sinh viên chưa nộp học phí kỳ trước'),
('12001', N'Đánh nhau trong trường'),
('12002', N'Vi phạm quy chế kiểm tra, thi học kỳ'),
('12003', N'Đem điện thoại vào phòng thi'),
('12004', N'Vi phạm các quy định về an toàn giao thông và các vi phạm khác theo quy định'),
('12005', N'Vi phạm quy định về đóng bảo hiểm y tế'),
('12006', N'Vi phạm thực hiện đạo đức tác phong trong trường'),
('12007', N'Đánh nhau trong trường'),
('12008', N'say rượu bia khi đến lớp'),
('12009', N'Hút thuốc lá trong giờ học, nơi học,nơi cấm hút thuốc'),
('12010', N'Chơi cờ bạc'),
('12011', N'Đưa người lạ vào trường, KTX gây ảnh hưởng xấu đến an ninh, trật tự trong nhà trường'),
('12012', N'Vi phạm sinh hoạt đầu khóa, cuối khóa, đầu năm học'),
('12013', N'Vi phạm nội quy Nội trú Ký túc xá'),
('12014', N'Mất trật tự, làm việc riêng trong giờ học'),
('12015', N'Trễ hạn báo cáo đề tài nghiên cứu khoa học'),
('12016', N'Bị cấm thi'),
('12017', N'Nghỉ học quá số lần cho phép'),
('12018', N'Bỏ thi'),
('12019', N'Học hộ, nhờ người khác học hộ')

go
insert into TAIKHOAN(TenDangNhap, MatKhau, VaiTro) values
('20132202', '123456', N'Sinh Viên'),
('18125106', '123456', N'Sinh Viên'),
('21126327', '123456', N'Sinh Viên'),
('17124068', '123456', N'Sinh Viên'),
('20145707', '123456', N'Sinh Viên'),
('20144333', '123456', N'Sinh Viên'),
('19121001', '123456', N'Sinh Viên'),
('21110767', '123456', N'Sinh Viên'),
('21146201', '123456', N'Sinh Viên'),
('18156069', '123456', N'Sinh Viên'),
('20132084', '123456', N'Sinh Viên'),
('20146418', '123456', N'Sinh Viên'),
('20124361', '123456', N'Sinh Viên'),
('20151426', '123456', N'Sinh Viên'),
('20129049', '123456', N'Sinh Viên'),
('20151109', '123456', N'Sinh Viên'),
('20139062', '123456', N'Sinh Viên'),
('20142383', '123456', N'Sinh Viên'),
('20110625', '123456', N'Sinh Viên'),
('20132082', '123456', N'Sinh Viên'),

('1951', '123456', N'Giảng Viên'),
('5615', '123456', N'Giảng Viên'),
('1916', '123456', N'Giảng Viên'),
('8954', '123456', N'Giảng Viên'),
('4455', '123456', N'Giảng Viên'),
('1611', '123456', N'Giảng Viên'),
('5151', '123456', N'Giảng Viên'),
('4812', '123456', N'Giảng Viên'),
('2551', '123456', N'Giảng Viên'),
('1591', '123456', N'Giảng Viên'),
('9495', '123456', N'Giảng Viên'),
('6516', '123456', N'Giảng Viên'),
('1917', '123456', N'Giảng Viên'),
('1651', '123456', N'Giảng Viên'),
('1585', '123456', N'Giảng Viên'),
('8447', '123456', N'Giảng Viên'),
('4181', '123456', N'Giảng Viên'),
('9852', '123456', N'Giảng Viên'),
('5452', '123456', N'Giảng Viên'),

('120000', '123456', N'QUẢN LÝ'),
('120001', '123456', N'QUẢN LÝ'),
('120002', '123456', N'QUẢN LÝ'),
('120003', '123456', N'QUẢN LÝ'),
('120004', '123456', N'QUẢN LÝ')
go


go
insert into SINHVIEN(MaSV, HoTenSV, GioiTinh, NgaySinh, MaLop, TinhTrangVP) values
('20132202', N'Phạm Hồng Hiếu', N'Nam', '2002-06-01', '201321C' , null),
('18125106', N'Huỳnh Thanh Tâm', N'Nam', '2000-10-28', '181251B' , null),
('21126327', N'Nguyễn Thiên Hân', N'Nữ', '2003-09-07', '211263A' , null),
('17124068', N'Trương Thị Khánh Linh', N'Nữ', '1999-07-10', '201106A' , null),
('20145707', N'Nguyễn Vũ Phương Nam', N'Nam', '2002-06-05', '201457B' , null),
('20144333', N'Nguyễn Hoàng Linh', N'Nữ', '2002-12-12', '201443C' , null),
('19121001', N'Nguyễn Thùy Trúc Quyên', N'Nữ', '2001-03-04', '201106A' , null),
('21110767', N'Lý Huy Hoàng', N'Nam', '2003-09-27', '211107A' , null),
('21146201', N'Đỗ Tấn Phát', N'Nam', '2003-09-07', '211107A' , null),
('18156069', N'Võ Thị Hồng Nhung', N'Nữ', '2000-02-06', '181560B' , null),
('20132084', N'Trần Thanh Sơn', N'Nam', '2002-06-01', '201321B' , null),
('20146418', N'Bùi Hữu Thạch', N'Nam', '2002-06-01', '201106A' , null),
('20124361', N'Nguyễn Thị Thúy Hằng', N'Nữ', '2002-10-16', '201241B' , null),
('20151426', N'Nguyễn Xuân Trưởng', N'Nam', '2002-05-19', '201106B' , null),
('20129049', N'Nguyễn Thị Thu Hiền', N'Nữ', '2002-04-03', '201290B' , null),
('20151109', N'Nguyễn Quốc Trình', N'Nam', '2002-08-05', '201106A' , null),
('20139062', N'Nguyễn Trí Ban', N'Nam', '2002-01-01', '201390B' , null),
('20142383', N'Trịnh Minh Nhựt', N'Nam', '2002-04-01', '201106B' , null),
('20110625', N'Nguyễn Ngọc Duy', N'Nam', '2002-09-01', '201106C' , null),
('20132082', N'Trần Cẩm Nhung', N'Nữ', '2002-02-24', '201321C' , null)

go
insert into GIANGVIEN(MaGV, HoTenGV, MaKhoa) values
('1951', N'Nguyễn Thị Thanh Hà', '29'),
('5615', N'Vũ Thị Tuyết Mai', '35'),
('1916', N'Nguyễn Nguyên Đương', '32'),
('8954', N'Đào Quốc Hưng', '15'),
('4455', N'Vũ Bảo Duy', '26'),
('1611', N'Đinh Công Hiếu', '19'),
('5151', N'Phan Dương Hoàng Kha', '25'),
('4812', N'Lê Phương Linh', '34'),
('2551', N'Nguyễn Phan Quỳnh Như', '14'),
('1591', N'Nguyễn Thu Sang', '21'),
('9495', N'Phạm Thị Minh Tâm', '49'),
('6516', N'Võ Minh Nghĩa', '37'),
('1917', N'Trần Trung Thảo', '20'),
('1651', N'Nguyễn Thị Thanh Thảo', '30'),
('1585', N'Đặng Nhật Hạ', '33'),
('8447', N'Bùi Văn Quy', '45'),
('4181', N'Đỗ Thị Hà', '40'),
('9852', N'Nguyễn Thúc Thùy Tiên', '28'),
('5452', N'Hồ Văn Qúy', '36')

go
insert into QUANLY(MaQL, TenNQL) values
('120000', N'Đỗ Tuấn Anh'),
('120001', N'Huỳnh Phương Anh'),
('120002', N'Lê Thị Ngọc Ánh'),
('120003', N'Võ Ngọc Quỳnh Châu'),
('120004', N'Đỗ Trung Chính')


go

insert into MONHOC(MaMH, TenMH, SoTinChi) values
('LLCT120314', N'Tư tưởng Hồ Chí Minh', 2),
('LLCT120205', N'Kinh tế chính trị Mác - Lênin', 2),
('DBSY230184', N'Cơ sở dữ liệu', 3),
('LLCT220514', N'Lịch sử Đảng CSVN', 2),
('PHED130715', N'Giáo dục thể chất 3', 3),
('LLCT120405', N'Chủ nghĩa xã hội khoa học', 2),
('PHED110513', N'Giáo dục thể chất 1', 1),
('PHED110613', N'Giáo dục thể chất 2', 1),
('MAOP230706', N'Nguyên lí kế toán', 3),
('ECON240206', N'Tin học ứng dụng', 3),
('PRAC230407', N'Sức bền vật liệu', 3),
('TLAW332209', N'Thương mại điện tử',3),
('FUMA230806', N'Phân tích dữ liệu', 2),
('ETHE221506', N'Tín hiệu thống kê', 3),
('PSBU220408', N'Toán cao cấp 2', 3),
('PRSK320705', N'Thí nghiệm vật lí 1', 1),
('BCUL320506', N'Tâm lí học', 2),
('PRAN321106', N'Xác xuất thống kê ứng dụng', 3),
('APCM230307', N'Máy điện đo lường', 2),
('TAPO330407', N'Điện tử cơ bản', 3)
go

insert into MONHOC_DAOTAO(MaMHDT, MaMH, MaCTDT, MaNganh) values
('MHDT001', 'LLCT120314', 'CTDT1', '009'),
('MHDT002', 'LLCT120205', 'CTDT1', '009'),
('MHDT003', 'LLCT120205', 'CTDT2', '009'),
('MHDT004', 'LLCT120205', 'CTDT3', '009'),
('MHDT005', 'DBSY230184', 'CTDT1', '103'),
('MHDT006', 'DBSY230184', 'CTDT2', '103'),
('MHDT007', 'LLCT220514', 'CTDT1', '009'),
('MHDT008', 'LLCT220514', 'CTDT2', '009'),
('MHDT009', 'LLCT220514', 'CTDT3', '009'),
('MHDT010', 'LLCT220514', 'CTDT4', '009'),
('MHDT011', 'LLCT120314', 'CTDT2', '009'),
('MHDT012', 'LLCT120314', 'CTDT3', '009'),
('MHDT013', 'LLCT120314', 'CTDT4', '009'),
('MHDT014', 'LLCT120205', 'CTDT4', '009'),
('MHDT015', 'DBSY230184', 'CTDT3', '103'),
('MHDT021', 'PHED110613', 'CTDT1', '008'),
('MHDT022', 'PHED110613', 'CTDT2', '008'),
('MHDT023', 'PHED110613', 'CTDT3', '008'),
('MHDT024', 'PHED110613', 'CTDT4', '008'),
('MHDT025', 'PHED130715', 'CTDT1', '008'),
('MHDT026', 'PHED130715', 'CTDT2', '008'),
('MHDT027', 'PHED130715', 'CTDT3', '008'),
('MHDT028', 'PHED130715', 'CTDT4', '008'),
('MHDT029', 'LLCT120405', 'CTDT1', '009'),
('MHDT030', 'LLCT120405', 'CTDT2', '009'),
('MHDT031', 'LLCT120405', 'CTDT3', '009'),
('MHDT032', 'LLCT120405', 'CTDT4', '009'),
('MHDT033', 'DBSY230184', 'CTDT1', '260'),
('MHDT034', 'DBSY230184', 'CTDT2', '260'),
('MHDT036', 'DBSY230184', 'CTDT4', '260'),
('MHDT045', 'MAOP230706', 'CTDT1', '260'),
('MHDT046', 'MAOP230706', 'CTDT2', '260'),
('MHDT047', 'MAOP230706', 'CTDT3', '260'),
('MHDT048', 'MAOP230706', 'CTDT4', '260'),
('MHDT056', 'MAOP230706', 'CTDT4', '240'),
('MHDT057', 'ECON240206', 'CTDT1', '251'),
('MHDT058', 'ECON240206', 'CTDT2', '251'),
('MHDT059', 'ECON240206', 'CTDT3', '251'),
('MHDT060', 'ECON240206', 'CTDT4', '251'),
('MHDT065', 'PRAC230407', 'CTDT1', '390'),
('MHDT066', 'PRAC230407', 'CTDT2', '390'),
('MHDT067', 'PRAC230407', 'CTDT3', '390'),
('MHDT068', 'PRAC230407', 'CTDT4', '390'),
('MHDT069', 'TLAW332209', 'CTDT1', '103'),
('MHDT070', 'TLAW332209', 'CTDT2', '103'),
('MHDT071', 'TLAW332209', 'CTDT3', '103'),
('MHDT072', 'TLAW332209', 'CTDT4', '103'),
('MHDT073', 'FUMA230806', 'CTDT1', '104'),
('MHDT074', 'FUMA230806', 'CTDT2', '104'),
('MHDT075', 'FUMA230806', 'CTDT3', '104'),
('MHDT076', 'FUMA230806', 'CTDT4', '104'),
('MHDT077', 'ETHE221506', 'CTDT1', '457'),
('MHDT078', 'ETHE221506', 'CTDT2', '457'),
('MHDT079', 'ETHE221506', 'CTDT3', '457'),
('MHDT080', 'ETHE221506', 'CTDT4', '457'),
('MHDT081', 'PSBU220408', 'CTDT1', '072'),
('MHDT082', 'PSBU220408', 'CTDT2', '072'),
('MHDT083', 'PSBU220408', 'CTDT3', '072'),
('MHDT084', 'PSBU220408', 'CTDT4', '072'),
('MHDT085', 'PRSK320705', 'CTDT1', '072'),
('MHDT086', 'PRSK320705', 'CTDT2', '072'),
('MHDT087', 'PRSK320705', 'CTDT3', '072'),
('MHDT088', 'PRSK320705', 'CTDT4', '072'),
('MHDT089', 'BCUL320506', 'CTDT1', '072'),
('MHDT090', 'BCUL320506', 'CTDT2', '072'),
('MHDT091', 'BCUL320506', 'CTDT3', '072'),
('MHDT092', 'BCUL320506', 'CTDT4', '072'),
('MHDT093', 'PRAN321106', 'CTDT1', '072'),
('MHDT094', 'PRAN321106', 'CTDT2', '072'),
('MHDT095', 'PRAN321106', 'CTDT3', '072'),
('MHDT096', 'PRAN321106', 'CTDT4', '072'),
('MHDT097', 'APCM230307', 'CTDT1', '457'),
('MHDT098', 'TAPO330407', 'CTDT1', '457'),
('MHDT099', 'TAPO330407', 'CTDT2', '457'),
('MHDT100', 'TAPO330407', 'CTDT3', '457'),
('MHDT101', 'TAPO330407', 'CTDT4', '457')

go

insert into LOPHOC(MaLopHoc, MaMHDT, MaGV, GioiHan, TenPhong, Thu, TietBatDau, TietKetThuc, ThoiGianBatDau, ThoiGianKetThuc, HocKy, Nam) values
('LLCT120314_01', 'MHDT001', '1951', 60, N'A111', N'Thứ 3', 1, 3, '2022-06-01', '2022-12-01', '1', '2022'),
('LLCT120314_02', 'MHDT001', '5615', 75, N'A111', N'Thứ 4', 1, 3, '2022-06-01', '2022-12-01', '1', '2022'),
('LLCT120205_01', 'MHDT002', '1916', 80, N'A113', N'Thứ 2', 1, 3, '2022-06-01', '2022-12-01', '1', '2022'),
('LLCT120205_02', 'MHDT003', '8954', 65, N'A114', N'Thứ 5', 1, 3, '2022-06-01', '2022-12-01', '1', '2022'),
('DBSY230184_02', 'MHDT015', '4455', 60, N'A116', N'Thứ 7', 1, 3, '2022-06-01', '2022-12-01', '1', '2022'),
('LLCT220514_01', 'MHDT009', '1611', 75, N'A117', N'Thứ 2', 4, 6, '2022-06-01', '2022-12-01', '1', '2022'),
('LLCT220514_02', 'MHDT008', '5151', 80, N'B111', N'Thứ 3', 4, 6, '2022-06-01', '2022-12-01', '1', '2022'),
('LLCT120405_01', 'MHDT031', '9495', 60, N'B113', N'Thứ 6', 4, 8, '2022-06-01', '2022-12-01', '1', '2022'),
('LLCT120405_02', 'MHDT032', '6516', 60, N'B114', N'Thứ 7', 4, 5, '2022-06-01', '2022-12-01', '1', '2022'),
('PHED110513_01', 'MHDT025', '1917', 60, N'B115', N'Thứ 3', 4, 7, '2022-06-01', '2022-12-01', '1', '2022'),
('PHED110513_02', 'MHDT025', '1651', 60, N'C111', N'Thứ 4', 7, 10, '2022-06-01', '2022-12-01', '1', '2022'),
('PHED110613_03', 'MHDT026', '1585', 60, N'C112', N'Thứ 2', 7, 10, '2022-06-01', '2022-12-01', '1', '2022'),
('PHED110613_04', 'MHDT027', '8447', 60, N'C113', N'Thứ 3', 7, 11, '2022-06-01', '2022-12-01', '1', '2022'),
('MAOP230706_01', 'MHDT045', '4181', 60, N'C114', N'Thứ 6', 9, 13, '2022-06-01', '2022-12-01', '1', '2022'),
('ECON240206_01', 'MHDT057', '5452', 60, N'D111', N'Thứ 2', 1, 3, '2022-06-01', '2022-12-01', '1', '2022'),
('PRAC230407_01', 'MHDT065', '2551', 60, N'D112', N'Thứ 3', 1, 3, '2022-06-01', '2022-12-01', '1', '2022'),
('TLAW332209_01', 'MHDT069', '9495', 60, N'D113', N'Thứ 6', 1, 3, '2022-06-01', '2022-12-01', '1', '2022'),
('FUMA230806_01', 'MHDT076', '8447', 60, N'D114', N'Thứ 2', 7, 10, '2022-06-01', '2022-12-01', '1', '2022'),
('ETHE221506_01', 'MHDT079', '5615', 60, N'A111', N'Thứ 6', 1, 3,'2022-06-01', '2022-12-01', '1', '2022'),
('PSBU220408_01', 'MHDT082', '9852', 60, N'B111', N'Thứ 7', 1, 3, '2022-06-01', '2022-12-01', '1', '2022'),
('PRSK320705_01', 'MHDT085', '5151', 60, N'C111', N'Thứ 3', 1, 3, '2022-06-01', '2022-12-01', '1', '2022'),
('BCUL320506_01', 'MHDT089', '6516', 60, N'D111', N'Thứ 4', 4, 8, '2022-06-01', '2022-12-01', '1', '2022'),
('PRAN321106_01', 'MHDT094', '1951', 60, N'A111', N'Thứ 3', 4, 7, '2022-06-01', '2022-12-01', '1', '2022'),
('APCM230307_01', 'MHDT097', '4181', 60, N'B111', N'Thứ 7', 7, 10, '2022-06-01', '2022-12-01', '1', '2022'),
('TAPO330407_01', 'MHDT098', '1951', 60, N'C111', N'Thứ 4', 11, 14, '2022-06-01', '2022-12-01', '1', '2022')

go
insert into DANGKY(MaSV, MaLopHoc) values
('20132202', 'LLCT120314_01'),
('18125106', 'TAPO330407_01'),
('21126327', 'APCM230307_01'),
('20145707', 'ETHE221506_01'),
('20144333', 'ECON240206_01'),
('19121001', 'MAOP230706_01'),
('21110767', 'DBSY230184_02'),
('21146201', 'BCUL320506_01'),
('18156069', 'PSBU220408_01'),
('20132084', 'LLCT120314_01'),
('21146201', 'DBSY230184_02'),
('21110767', 'PHED110513_01')
