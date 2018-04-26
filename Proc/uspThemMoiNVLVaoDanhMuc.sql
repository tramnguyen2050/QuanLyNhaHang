USE [QuanLyATC_HueTam]
GO

CREATE PROC uspThemMoiNVLVaoDanhMuc
	@MaNVL NVARCHAR(10),
	@TenNVL NVARCHAR(50),
	@LoaiNVL NVARCHAR(5),
	@QuyCach NVARCHAR(50),
	@DonViTinh NVARCHAR(15),
	@SoLuongCon FLOAT,
	@ToiThieuDatLai FLOAT
AS
BEGIN
    INSERT INTO dbo.NGUYENVATLIEU
            ( ID_NVL ,
              Ten_NVL ,
              ID_LoaiNVL ,
              QuyCach ,
              DonViTinh ,
              SoLuongCon ,
              ToiThieuDatLai)
    VALUES  ( @MaNVL , -- ID_NVL - nvarchar(10)
              @TenNVL , -- Ten_NVL - nvarchar(50)
              @LoaiNVL , -- ID_LoaiNVL - nvarchar(5)
              @QuyCach , -- QuyCach - nvarchar(50)
              @DonViTinh , -- DonViTinh - nvarchar(15)
              @SoLuongCon , -- SoLuongCon - float
              @ToiThieuDatLai  -- ToiThieuDatLai - float
            )
END

DROP PROC uspThemMoiNVLVaoDanhMuc

EXEC dbo.uspThemMoiNVLVaoDanhMuc @MaNVL = N'C01', -- nvarchar(10)
    @TenNVL = N'Củ hủ dừa', -- nvarchar(50)
    @LoaiNVL = N'LNVL2', -- nvarchar(5)
    @QuyCach = N'Củ 2kg', -- nvarchar(50)
    @DonViTinh = N'kg', -- nvarchar(15)
    @SoLuongCon = 3.0, -- float
    @TouThieuDatLai = 1.0 -- float

SELECT * FROM dbo.NGUYENVATLIEU
