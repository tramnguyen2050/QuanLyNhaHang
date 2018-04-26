USE [QuanLyATC_HueTam]
GO

CREATE PROC uspTimKiemDanhMucMonAn
	@MaMonAn NVARCHAR(8),
	@TenMonAn NVARCHAR(50),
	@LoaiMon NVARCHAR(5),
	@DonGia INT,
	@QuyCach NVARCHAR(50),
	@MonKemTheo NVARCHAR(50),
	@NuocCham NVARCHAR(50)
AS
BEGIN
	SELECT ID_Mon, Ten_Mon, lm.Ten_LoaiMon, DonGia, mon.QuyCach, mon.MonKemTheo, NuocCham
	FROM dbo.MON mon JOIN dbo.LOAI_MON lm ON mon.ID_LoaiMon = lm.ID_LoaiMon
	WHERE --mon.NuocCham IS NOT NULL
		-- ((mon.ID_Mon LIKE '%' + ISNULL(@MaMonAn, mon.ID_Mon) + '%') OR @MaMonAn IS NULL)
		--AND ((mon.Ten_Mon LIKE '%' + ISNULL(@TenMonAn, mon.Ten_Mon) + '%') OR @TenMonAn IS NULL)
		--AND ((lm.Ten_LoaiMon LIKE '%' + ISNULL(@LoaiMon, lm.Ten_LoaiMon) + '%') OR @LoaiMon IS NULL)
		--AND (mon.DonGia = @DonGia OR @DonGia IS NULL)
		--AND  ((mon.QuyCach LIKE '%' + ISNULL(@QuyCach, mon.QuyCach) + '%') OR @QuyCach IS NULL)
		--AND ((mon.MonKemTheo LIKE '%' + ISNULL(@MonKemTheo, mon.MonKemTheo) + '%') OR @MonKemTheo IS NULL)
		--AND ((mon.NuocCham LIKE '%' + ISNULL(@NuocCham, mon.NuocCham) + '%') OR @NuocCham IS NULL)

		mon.ID_Mon LIKE '%' + @MaMonAn + '%'
		OR mon.Ten_Mon LIKE '%' + @TenMonAn + '%'
		OR lm.Ten_LoaiMon LIKE '%' + @LoaiMon + '%'
		OR mon.DonGia = @DonGia
		OR QuyCach LIKE '%' + @QuyCach + '%'
		OR mon.MonKemTheo LIKE '%' + @MonKemTheo + '%'
		OR mon.NuocCham LIKE '%' + @NuocCham + '%'
END

DROP PROC dbo.uspTimKiemDanhMucMonAn

EXEC dbo.uspTimKiemDanhMucMonAn @MaMonAn = N'C0', -- nvarchar(8)
    @TenMonAn = NULL, -- nvarchar(50)
    @LoaiMon = NULL, -- nvarchar(5)
    @DonGia = NULL, -- int
    @QuyCach = NULL, -- nvarchar(50)
    @MonKemTheo = NULL, -- nvarchar(50)
    @NuocCham = NULL -- nvarchar(50)

SELECT * FROM dbo.MON
