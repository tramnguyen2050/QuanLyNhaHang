USE [QuanLyATC_HueTam]
GO

CREATE PROCEDURE uspXoaMonHoaDon
	@MaHD INT,
	@MaMon NVARCHAR(8)

AS
	DELETE dbo.MON_ORDERS
	WHERE ID_Orders = @MaHD AND ID_Mon = @MaMon
GO