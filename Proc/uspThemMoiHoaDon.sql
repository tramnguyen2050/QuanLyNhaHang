USE [QuanLyATC_HueTam]
GO

CREATE PROC uspThemMoiHoaDon
	@MaKhachhang INT,
	@MaNhanVien INT,
	@NgayGioDat DATETIME,
	@BanSo NVARCHAR(3)
AS
BEGIN
	INSERT INTO dbo.ORDERS
	        ( ID_KH, ID_NV, NgayGioDat, BanSo )
	VALUES  ( @MaKhachhang, -- ID_KH - int
	          @MaNhanVien, -- ID_NV - int
	          @NgayGioDat, -- NgayGioDat - datetime
	          @BanSo  -- BanSo - nvarchar(3)
	          )
END

DROP PROC uspThemMoiHoaDon

EXEC dbo.uspThemMoiHoaDon @MaKhachhang = 1, -- int
    @MaNhanVien = 2, -- int
    @NgayGioDat = 0, -- int
    @BanSo = N'' -- nvarchar(3)


SELECT * FROM dbo.ORDERS

SELECT * FROM dbo.NHANVIEN