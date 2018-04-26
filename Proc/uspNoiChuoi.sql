USE [QuanLyATC_HueTam]
GO

CREATE PROC uspNoiChuoi 
	@MaNV INT
AS
BEGIN
	DECLARE @a NVARCHAR(100), @b NVARCHAR(100), @kc NVARCHAR(3) = ' '

	SELECT @a = Ho_NV FROM dbo.NHANVIEN WHERE ID_NV = @MaNV
	SELECT @b = Ten_NV FROM dbo.NHANVIEN WHERE ID_NV = @MaNV

	SELECT CONCAT(@a, @kc, @b)
END

DROP PROC uspNoiChuoi

EXEC dbo.uspNoiChuoi @MaNV = 2 -- int

SELECT * FROM dbo.NHANVIEN

