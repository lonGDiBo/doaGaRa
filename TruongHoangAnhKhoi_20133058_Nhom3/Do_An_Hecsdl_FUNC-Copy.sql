USE QLSuaChuaXe3

GO
---Thêm, xóa, sửa, xuất bảng NHÂN VIÊN
-----Xuât thông tin
CREATE FUNCTION XUAT_NV() RETURNS table
as
RETURN (SELECT * FROM VIEW_NV)
GO
-----thêm
CREATE proc THEM_NV
@nguoiid CHAR(6),
@hoten nvarchar(30),
@diachi nvarchar(30),
@dienthoai CHAR(11),
@ngaysinh date,
@cccd CHAR(11),
@gioitinnh bit,
@macv CHAR(6),
@luong int
AS
	INSERT INTO dbo.TT_NGUOI(NguoiID,Hoten,DiaChi,DienThoai,NgaySinh,CCCD,GioiTinh)
	VALUES(@nguoiid, @hoten, @diachi, @dienthoai,@ngaysinh,@cccd,@gioitinnh)
	INSERT INTO dbo.NHANVIEN(NV_NguoiID,MaCV,Luong)
	VALUES(@nguoiid,@macv,@luong)
GO
-----sửa
CREATE PROC SUA_NV
@nguoiid CHAR(6),
@hoten nvarchar(30),
@diachi nvarchar(30),
@dienthoai CHAR(11),
@ngaysinh date,
@cccd CHAR(11),
@gioitinh bit,
@macv CHAR(6),
@luong INT
AS
	UPDATE dbo.TT_NGUOI
	SET Hoten=@hoten,DiaChi=@diachi,DienThoai=@dienthoai,NgaySinh=@ngaysinh,CCCD=@cccd,GioiTinh=@gioitinh 
	WHERE NguoiID = @nguoiid;
	UPDATE dbo.NHANVIEN
	SET Luong=@luong
	WHERE NV_NguoiID=@nguoiid;
GO
-----XÓA
CREATE PROC XOA_NV
@nguoiid CHAR(6)
as
	DELETE FROM dbo.TT_NGUOI WHERE @nguoiid = NguoiID;
GO
---Thêm, xóa, sửa, xuất bảng KHÁCH HÀNG
-----XUẤT
CREATE FUNCTION XUAT_KH() RETURNS table
as
RETURN (SELECT * FROM VIEW_KH)

GO
-----THÊM
CREATE PROC THEM_KH 
@nguoiid CHAR(6),
@hoten nvarchar(30),
@diachi nvarchar(30),
@dienthoai CHAR(11),
@ngaysinh date,
@cccd CHAR(11),
@gioitinh bit
AS
BEGIN
INSERT INTO TT_NGUOI VALUES (@nguoiid,@hoten,@diachi,@dienthoai,@ngaysinh,@cccd,@gioitinh)
INSERT INTO KHACHHANG VALUES(@nguoiid)
END

GO
----- SỬA
CREATE PROC SUA_KH
@nguoiid CHAR(6),
@hoten nvarchar(30),
@diachi nvarchar(30),
@dienthoai CHAR(11),
@ngaysinh date,
@cccd CHAR(11),
@gioitinh bit
AS
BEGIN
	UPDATE TT_NGUOI
	SET HoTen=@hoten,DiaChi=@DiaChi,DienThoai=@dienthoai,NgaySinh=@ngaysinh,CCCD=@cccd,GioiTinh=@gioitinh
	WHERE NguoiID=@nguoiid
END

GO
----- Xóa
CREATE PROC XOA_KH
@nguoiid CHAR(6)
AS
DELETE 
FROM TT_Nguoi
WHERE NguoiID=@nguoiid
GO
---Thêm, xóa, sửa, xuất bảng VẬT LIỆU
CREATE FUNCTION XUAT_VL() RETURNS table
as
RETURN (SELECT * FROM VATLIEU)

GO
-----THÊM
CREATE PROC THEM_VL 
@mavl CHAR(6),
@tenvl nvarchar(20),
@soluong int 
AS
BEGIN
INSERT INTO VATLIEU VALUES (@mavl,@tenvl,@soluong)
END

GO
----- SỬA
CREATE PROC SUA_VL
@mavl CHAR(6),
@tenvl nvarchar(20),
@soluong int 
AS
BEGIN
	UPDATE VATLIEU
	SET TenVL=@tenvl,SoLuong=@soluong
	WHERE MaVL=@mavl
END

GO
----- Xóa
CREATE PROC XOA_VL
@mavl CHAR(6)
AS
DELETE 
FROM VATLIEU
WHERE MaVL=@mavl
GO
---Thêm, xóa, sửa, xuất bảng NHÀ CUNG CẤP
-----XUẤT
CREATE FUNCTION XUAT_NCC() RETURNS table
as
RETURN (SELECT * FROM NHACUNGCAP)
GO
-----THÊM
CREATE PROC THEM_NCC
@manhacc CHAR(6),
@tennhacc nvarchar(30),
@dienthoai CHAR(11),
@diachi nvarchar(30)
AS
BEGIN
INSERT INTO NHACUNGCAP VALUES (@manhacc,@tennhacc,@dienthoai,@diachi)
END

GO
----- SỬA
CREATE PROC SUA_NCC
@manhacc CHAR(6),
@tennhacc nvarchar(30),
@dienthoai CHAR(11),
@diachi nvarchar(30)
AS
BEGIN
	UPDATE NHACUNGCAP
	SET TenNhaCC=@tennhacc,DienThoai=@dienthoai,DiaChi=@diachi
	WHERE MaNhaCC=@manhacc
END

GO
----- Xóa
CREATE PROC XOA_NCC
@manhacc CHAR(6)
AS
DELETE 
FROM NHACUNGCAP
WHERE MaNhaCC=@manhacc
GO
---Thêm, xóa, sửa, xuất bảng CONGVIEC
CREATE FUNCTION XUAT_CVIEC() RETURNS table
as
RETURN (SELECT * FROM CONGVIEC)

GO
-----THÊM
CREATE PROC THEM_CVIEC
@macv CHAR(6),
@noidungcv nvarchar(40),
@tiencong int,
@vatlieu char(6)
AS
BEGIN
INSERT INTO CONGVIEC VALUES (@macv,@noidungcv,@tiencong,@vatlieu)
END

GO
----- SỬA
CREATE PROC SUA_CViec
@macv CHAR(6),
@noidungcv nvarchar(40),
@tiencong int,
@vatlieu char(6)
AS
BEGIN
	UPDATE CONGVIEC
	SET NoiDungCV=@noidungcv,TienCong=@tiencong,VatLieu=@vatlieu
	WHERE MaCViec=@macv
END

GO
----- Xóa
CREATE PROC XOA_CViec
@macv CHAR(6)
AS
DELETE 
FROM DBO.CONGVIEC
WHERE MaCViec=@macv
GO
---Thêm xóa sửa xuất bảng chức vụ
-----Xuất chuc vu
CREATE FUNCTION XUAT_CHUCVU() RETURNS table
as
RETURN (SELECT * FROM CHUCVU)
GO
-----Them chuc vu
CREATE proc THEM_CHUCVU
@macv char(6),
@tencv nvarchar(20)
AS
INSERT INTO dbo.CHUCVU
VALUES(@macv,@tencv)
GO
--exec THEM_CHUCVU '1','nongdan'
------Xoa chuc vu
CREATE PROC XOA_CHUCVU
@macv CHAR(6)
as
DELETE FROM dbo.CHUCVU WHERE @macv = MaCV;
GO
---exec XOA_CHUCVU '1'
----Sua chuc vu
create proc SUA_CHUCVU
@macv char(6),
@tencv nvarchar(20)
as
update dbo.CHUCVU
set TenCV = @tencv
where @macv = MaCV
go
---Thêm xóa sửa bảng USERS
-----Thêm
CREATE PROC THEM_USER
@Username CHAR(20),
@Pass CHAR(20),
@Chucvu NVARCHAR(30)
AS
BEGIN
	INSERT INTO USERS
	VALUES(@Username,@Pass,@Chucvu)
END
GO
-----Sửa
CREATE PROC SUA_USERS
@Username CHAR(20),
@Pass CHAR(20),
@Chucvu NVARCHAR(30)
AS
BEGIN
	UPDATE USERS
	SET Username=@Username, Pass=@Pass, Chucvu=@Chucvu
	WHERE Username=@Username
END

GO
-----Xác minh
CREATE FUNCTION XACMINH_USERS(@username CHAR(20), @pass CHAR(20)) RETURNS int
AS
	BEGIN
		DECLARE @result int
		IF EXISTS(SELECT 1 FROM USERS WHERE Username=@username AND Pass = @pass)
			BEGIN
				SELECT @result=0
				return @result
			END
		ELSE IF EXISTS(SELECT 1 FROM USERS WHERE Username=@username)
			BEGIN
				SELECT @result=1
				return @result
			END
		SELECT @result=2
		RETURN @result
	END
GO
---Chỉnh sửa hợp đồng
-----Thêm
CREATE PROC THEM_HDONG
@SoHD CHAR(15),
@KH_NguoiID CHAR(6),
@SoXe CHAR(10),
@NgayGiaoDuKien DATE
AS
INSERT INTO HOPDONG VALUES(@SoHD,DEFAULT,@KH_NguoiID,@SoXe,DEFAULT,@NgayGiaoDuKien,'')
GO
-----Xóa 
CREATE PROC XOA_HDONG
@SoHD CHAR(15)
AS
	DELETE
	FROM HOPDONG
	WHERE SoHD=@SoHD

GO
-----Tìm kiếm
CREATE FUNCTION TIMKIEM_HDONG(@SoHD CHAR(15)) RETURNS table
as
RETURN (SELECT *
	FROM HOPDONG
	WHERE SoHD = @SoHD)
GO
---Chỉnh sửa Chi tiết hợp đồng
-----Tìm kiếm
CREATE FUNCTION TIMKIEM_CHITIET_HD(@SoHD CHAR(15)) RETURNS table
as
RETURN (SELECT * FROM CHITIET_HD WHERE SoHD=@SoHD)
GO
-----Thêm
CREATE PROC THEM_CHITIET_HD
@SoHD CHAR(15),
@MaCV CHAR(6),
@MaNV CHAR(6),
@TriGiaCV INT
AS
	BEGIN
		SELECT @TriGiaCV=TienCong FROM CONGVIEC WHERE MaCViec=@MaCV
		INSERT INTO CHITIET_HD VALUES(@SoHD,@MaCV,@TriGiaCV,@MaNV)
	END
GO
-----XÓA 
CREATE PROC XOA_CHITIET_HD(@SoHD CHAR(15),@MaCV CHAR(6))
AS
	DELETE
	FROM CHITIET_HD
	WHERE SoHD=@SoHD AND MaCV=@MaCV
GO
---Chỉnh sửa nhập kho
-----Xuất
CREATE FUNCTION XUAT_NHAPKHO() RETURNS table
as
RETURN (SELECT * FROM NHAPKHO)
-----Thêm
GO 
CREATE PROC THEM_NHAPKHO
@MaVL CHAR(6),
@MaNhaCC CHAR(6),
@SoLuong INT,
@GiaTri INT,
@MaNV CHAR(6)
AS
	BEGIN
		INSERT INTO NHAPKHO VALUES(@MaVL,@MaNhaCC,@SoLuong,@GiaTri,DEFAULT,@MaNV)
	END
GO
-----Xóa
CREATE PROC XOA_NHAPKHO
@ngaydautien date,
@ngaycuoicung date
AS
DELETE 
FROM NHAPKHO
WHERE NgayNhap>= @ngaydautien AND NgayNhap<=@ngaycuoicung
GO
---Tính toán doanh thu 
CREATE FUNCTION DOANHTHU(@ngaydautien date,@ngaycuoicung date) RETURNS INT 
AS
	BEGIN
		DECLARE @doanhthu int
		SELECT @doanhthu=sum(TriGiaHD) FROM HOPDONG_BACKUP WHERE NgayNghiemThu>=@ngaydautien AND NgayNghiemThu<=@ngaycuoicung
		return @doanhthu 
	END
GO 
---Xóa doanh thu 
CREATE PROC XOA_DOANHTHU
@ngaydautien date,
@ngaycuoicung date
AS
	DELETE 
	FROM HOPDONG_BACKUP
	WHERE NgayNghiemThu>= @ngaydautien AND NgayNghiemThu<=@ngaycuoicung

