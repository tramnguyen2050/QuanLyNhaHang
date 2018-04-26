USE [QuanLyATC_HueTam]
GO

CREATE PROC uspXemDanhMucMonAn
	--@MaMon NVARCHAR(8),
	--@TenMon NVARCHAR(50),
	--@LoaiMon NVARCHAR(5),
	--@DonGia INT,
	--@QuyCach NVARCHAR(50),
	--@MonKemTheo NVARCHAR(50),
	--@NuocCham NVARCHAR(50)
AS
	SELECT ID_Mon, Ten_Mon, lm.Ten_LoaiMon, DonGia, NuocCham
	FROM dbo.MON mon JOIN dbo.LOAI_MON lm ON mon.ID_LoaiMon = lm.ID_LoaiMon
	WHERE mon.NuocCham IS NOT NULL

EXEC dbo.uspXemDanhMucMonAn

DROP PROC dbo.uspXemDanhMucMonAn
