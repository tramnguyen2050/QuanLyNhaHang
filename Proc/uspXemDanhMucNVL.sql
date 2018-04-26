USE [QuanLyATC_HueTam]
GO

CREATE PROC uspXemDanhMucNVL
	--@MaNVL NVARCHAR(10),
	--@TenNVL NVARCHAR(50),
	--@LoaiNVL NVARCHAR(5),
	--@QuyCach NVARCHAR(50),
	--@DonViTinh NVARCHAR(15),
	--@SoLuongTrongKho FLOAT,
	--@ToiThieuDatLai FLOAT
AS
	SELECT ID_NVL, Ten_NVL,lnvl.Ten_LoaiNVL, QuyCach, SoLuongCon, ToiThieuDatLai, DonViTinh
	FROM dbo.NGUYENVATLIEU nvl JOIN dbo.LOAI_NVL lnvl ON nvl.ID_LoaiNVL = lnvl.ID_LoaiNVL

EXEC dbo.uspXemDanhMucNVL

DROP PROC dbo.uspXemDanhMucNVL

