USE [QuanLyATC_HueTam]
GO

CREATE PROC uspSuaNVL
	@MaNVL NVARCHAR(10),
	@TenNVL NVARCHAR(50),
	@MaLoaiNVL NVARCHAR(5),
	@QuyCach NVARCHAR(50),
	@DonViTinh NVARCHAR(15),
	@SoLuongCon FLOAT,
	@ToiThieuDatLai FLOAT
AS
BEGIN
    UPDATE dbo.NGUYENVATLIEU
	SET Ten_NVL = @TenNVL, ID_LoaiNVL = @MaLoaiNVL, QuyCach = @QuyCach, DonViTinh = @DonViTinh, SoLuongCon = @SoLuongCon, ToiThieuDatLai = @ToiThieuDatLai
	WHERE ID_NVL = @MaNVL
END
GO

DROP PROC uspSuaNVL

EXEC dbo.uspSuaNVL @MaNVL = N'C01', -- nvarchar(10)
    @TenNVL = N'', -- nvarchar(50)
    @MaLoaiNVL = N'LNVL1', -- nvarchar(5)
    @QuyCach = N'', -- nvarchar(50)
    @DonViTinh = N'', -- nvarchar(15)
    @SoLuongCon = 0.0, -- float
    @ToiThieuDatLai = 0.0 -- float
SELECT * FROM dbo.NGUYENVATLIEU

SELECT * FROM dbo.LOAI_NVL

