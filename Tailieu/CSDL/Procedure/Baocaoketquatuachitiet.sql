------------------------Kết quả in chi tiết-------------
If Object_ID('dbo.Baocaoketquatuachitiet','P') is not null
	Drop Procedure dbo.Baocaoketquatuachitiet;
Go
Create Procedure dbo.Baocaoketquatuachitiet
	@Tungay			Date,
	@Denngay		DATE,
	@Mamay			NVARCHAR(50),
	@Makhach		NVARCHAR(50),
	@Masanpham		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngay, Ca, Mamay, Tenmay, Lenhtua As Lenhsanxuat
		, Masanpham, Tensanpham, Makhach, Tenkhach, Macongnhan, Tencongnhan
		, SoMetvao As Dauvaomet, SoKgvao As Dauvaokg
		, SoMetra As Dauramet, SoKgra As Daurakg
		, Nangsuat, Chenhlechkg
	FROM dbo.Ketquatua kq Left Join dmhang sp on kq.Masanpham=sp.Masp
	WHERE Ngay BETWEEN @Tungay AND @Denngay 
		AND (Mamay = @Mamay OR @Mamay='')
		AND (Makhach = @Makhach OR @Makhach = '')
		AND (kq.Masanpham = @Masanpham OR @Masanpham = '')
	ORDER BY Ngay, Mamay, Ca
	
GO

EXEC Baocaoketquatuachitiet '10/01/2022', '11/30/2022','','',''


