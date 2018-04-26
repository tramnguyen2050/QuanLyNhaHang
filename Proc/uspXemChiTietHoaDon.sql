USE [QuanLyATC_HueTam]
GO

CREATE PROC uspXemChitietHoaDon
	@MaHD INT
AS
	SELECT mo.ID_Mon, mon.Ten_Mon, mo.SoLuong, mo.DonGia, (mo.DonGia * mo.SoLuong) AS ThanhTien  FROM dbo.MON_ORDERS mo JOIN dbo.ORDERS od ON od.ID_Orders = mo.ID_Orders JOIN dbo.MON mon ON mon.ID_Mon = mo.ID_Mon
	WHERE mo.ID_Orders = @MaHD
GO