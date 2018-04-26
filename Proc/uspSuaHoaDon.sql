USE [QuanLyATC_HueTam]
GO

CREATE PROC uspSuaHoaDon
	@MaHoaDon INT,
	@MaKH INT,
	@MaNV INT,
	@NgayGioDat DATETIME,
	@BanSo NVARCHAR(3)
AS
	UPDATE dbo.ORDERS
	SET ID_KH = @MaKH, ID_NV = @MaNV, NgayGioDat = @NgayGioDat, BanSo = @BanSo
	WHERE ID_Orders = @MaHoaDon
GO


