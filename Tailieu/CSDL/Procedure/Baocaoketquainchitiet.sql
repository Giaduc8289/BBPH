------------------------Kết quả in chi tiết-------------
If Object_ID('dbo.Baocaoketquainchitiet','P') is not null
	Drop Procedure dbo.Baocaoketquainchitiet;
Go
Create Procedure dbo.Baocaoketquainchitiet
	@Tungay			Date,
	@Denngay		DATE,
	@Mamay			NVARCHAR(50),
	@Makhach		NVARCHAR(50),
	@Masanpham		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngay, Ca, Mamay, Tenmay, Lenhin As Lenhsanxuat, SometLSX
		, Masanpham, Tensanpham, Macongnhan, Tencongnhan
		, Sometcap As Dauvaomet, Sokgcap As Dauvaokg
		, Thuctein As Dauramet, Sokgin As Daurakg
		, Nangsuat, Tylesaihong
	FROM dbo.Ketquain kq Left Join dmhang sp on kq.Masanpham=sp.Masp
	WHERE Ngay BETWEEN @Tungay AND @Denngay 
		AND (Mamay = @Mamay OR @Mamay='')
		AND (Makhach = @Makhach OR @Makhach = '')
		AND (kq.Masanpham = @Masanpham OR @Masanpham = '')
	ORDER BY Ngay, Mamay, Ca
	
GO

EXEC Baocaoketquainchitiet '10/01/2022', '11/30/2022','','',''


