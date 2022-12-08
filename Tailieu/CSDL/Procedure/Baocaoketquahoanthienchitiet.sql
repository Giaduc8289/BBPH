------------------------Kết quả hoàn thiện chi tiết-------------
If Object_ID('dbo.Baocaoketquahoanthienchitiet','P') is not null
	Drop Procedure dbo.Baocaoketquahoanthienchitiet;
Go
Create Procedure dbo.Baocaoketquahoanthienchitiet
	@Tungay			Date,
	@Denngay		DATE,
	@Mamay			NVARCHAR(50),
	@Makhach		NVARCHAR(50),
	@Masanpham		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngay, Ca, Mamay, Tenmay, Solenhsx As Lenhsanxuat
		, Masanpham, Tensanpham, Makhach, Tenkhach, Macongnhan, Tencongnhan
		, Dauvaomet, Dauvaokg
		, Ketquatui
		, Nangsuat, Chatluongtui
	FROM dbo.Ketquahoanthien kq Left Join dmhang sp on kq.Masanpham=sp.Masp
	WHERE Ngay BETWEEN @Tungay AND @Denngay 
		AND (Mamay = @Mamay OR @Mamay='')
		AND (Makhach = @Makhach OR @Makhach = '')
		AND (kq.Masanpham = @Masanpham OR @Masanpham = '')
	ORDER BY Ngay, Mamay, Ca
	
GO

EXEC Baocaoketquahoanthienchitiet '10/01/2022', '11/30/2022','','',''

--select * from Ketquahoanthien
