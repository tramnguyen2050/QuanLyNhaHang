USE [QuanLyATC_HueTam]
GO

CREATE PROC uspTimKiemDanhMucNVL
	@MaNVL NVARCHAR(10) = NULL,
	@TenNVL NVARCHAR(50) = NULL,
	@LoaiNVL NVARCHAR(5) = NULL,
	@QuyCach NVARCHAR(50) = NULL,
	@DonViTinh NVARCHAR(15) = NULL,
	@SoLuongCon FLOAT = NULL,
	@ToiThieuDatLai FLOAT = NULL
AS
BEGIN
	SELECT nvl.ID_NVL, nvl.Ten_NVL, lnvl.Ten_LoaiNVL, nvl.QuyCach, nvl.SoLuongCon, nvl.ToiThieuDatLai, nvl.DonViTinh
	FROM dbo.NGUYENVATLIEU nvl JOIN dbo.LOAI_NVL lnvl ON nvl.ID_LoaiNVL = lnvl.ID_LoaiNVL
	WHERE (nvl.ID_NVL LIKE '%' + @MaNVL + '%')
	OR (nvl.Ten_NVL LIKE '%' + @TenNVL + '%')
	OR (lnvl.Ten_LoaiNVL LIKE '%' + @LoaiNVL + '%')
	OR (nvl.QuyCach LIKE '%' + @QuyCach + '%')
	OR (nvl.DonViTinh LIKE '%' + @DonViTinh + '%')
	OR (nvl.SoLuongCon = @SoLuongCon)
	OR (nvl.ToiThieuDatLai = @ToiThieuDatLai)
END	
GO

DROP PROC dbo.uspTimKiemDanhMucNVL

EXEC dbo.uspTimKiemDanhMucNVL @MaNVL = N'C0', -- nvarchar(10)
    @TenNVL = NULL, -- nvarchar(50)
    @LoaiNVL = NULL, -- nvarchar(5)
    @QuyCach = NULL, -- nvarchar(50)
    @DonViTinh = NULL, -- nvarchar(15)
    @SoLuongCon = NULL, -- float
    @ToiThieuDatLai = NULL -- float


