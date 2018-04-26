USE [QuanLyATC_HueTam]
GO

CREATE PROC uspXoaDanhMucMonAn
	@MaMonAn NVARCHAR(8)
AS
	DELETE dbo.MON
	WHERE ID_Mon = @MaMonAn

EXEC dbo.uspXoaDanhMucMonAn @MaMonAn = N'S08' -- nvarchar(8)

SELECT * FROM dbo.MON