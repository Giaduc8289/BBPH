------------------------Kết quả thổi chi tiết-------------
If Object_ID('dbo.Baocaoketquathoichitiet','P') is not null
	Drop Procedure dbo.Baocaoketquathoichitiet;
Go
Create Procedure dbo.Baocaoketquathoichitiet
	@Tungay			Date,
	@Denngay		DATE,
	@Mamay			NVARCHAR(50),
	@Makhach		NVARCHAR(50),
	@Masanpham		Nvarchar(50)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT Ngay, Ca, Mamay, Tenmay, Solenhsx As Lenhsanxuat
		, kq.Mamang As Masanpham, kq.Tenmang As Tensanpham, Makhach, Tenkhach, Macongnhan, Tencongnhan
		--, Sometcap As Dauvaomet, Sokgcap As Dauvaokg
		, Somet As Dauramet, Sokg As Daurakg
		, Nangsuat, Chatluong
	FROM dbo.Ketquathoi kq Left Join dmmang m on kq.Mamang=m.Mamang
	WHERE Ngay BETWEEN @Tungay AND @Denngay 
		AND (Mamay = @Mamay OR @Mamay='')
		AND (Makhach = @Makhach OR @Makhach = '')
		AND (kq.Mamang = @Masanpham OR @Masanpham = '')
	ORDER BY Ngay, Mamay, Ca
	
GO

EXEC Baocaoketquathoichitiet '10/01/2022', '11/30/2022','','',''


--select * from Ketquathoi
--select * from Tknguyenlieuthoi
--select * from dmmang