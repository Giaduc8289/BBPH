------------------------K?t qu? ghép chi ti?t-------------
If Object_ID('dbo.Baocaoketquaghepchitiet','P') is not null
	Drop Procedure dbo.Baocaoketquaghepchitiet;
Go
Create Procedure dbo.Baocaoketquaghepchitiet
	@Tungay			Date,
	@Denngay		DATE,
	@Mamay			NVARCHAR(50),
	@Makhach		NVARCHAR(50),
	@Masanpham		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngay, Ca, Mamay, Tenmay, Lenhghep As Lenhsanxuat
		, Masanpham, Tensanpham, Makhach, Tenkhach, Macongnhan, Tencongnhan
		, Dauratua, kq.Solopghep
		, ManginMet, ManginKg, MangcapMet, MangcapKg
		, ThucteMet As Dauramet, ThucteKg As Daurakg
		, Nangsuat
	FROM dbo.Ketquaghep kq Left Join dmhang sp on kq.Masanpham=sp.Masp
	WHERE Ngay BETWEEN @Tungay AND @Denngay 
		AND (Mamay = @Mamay OR @Mamay='')
		AND (Makhach = @Makhach OR @Makhach = '')
		AND (kq.Masanpham = @Masanpham OR @Masanpham = '')
	ORDER BY Ngay, Mamay, Ca
	
GO

EXEC Baocaoketquaghepchitiet '10/01/2022', '11/30/2022','','',''


